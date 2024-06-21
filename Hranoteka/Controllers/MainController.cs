using Hranoteka.Data;
using Hranoteka.Repositories;
using Hranoteka.Utils;
using Hranoteka.Views;
using NUlid;

namespace Hranoteka.Controllers;

public class MainController
{
    private readonly RecipeRepository _recipeRepository;
    private readonly UserRepository _userRepository;
    private readonly CommentRepository _commentRepository;
    private readonly CategoryRepository _categoryRepository;
    private readonly UnitRepository _unitRepository;
    private readonly IngredientRepository _ingredientRepository;

    private readonly ILoginForm _loginForm;
    private readonly IMainForm _mainForm;
    private readonly IRegistrationForm _registrationForm;
    private readonly IProfileForm _profileForm;
    private readonly IEditRecipeForm _editRecipeForm;
    private readonly IRecipeDetailsForm _recipeDetailsForm;

    public User CurrentUser = null;
    public AppStates AppState = AppStates.Undefined;

    public MainController(UserRepository userRepository, RecipeRepository recipeRepository,
        CommentRepository commentRepository, CategoryRepository categoryRepository,
        UnitRepository unitRepository, IngredientRepository ingredientRepository,
        IMainForm mainForm, ILoginForm loginForm, IRegistrationForm registrationForm,
        IProfileForm profileForm, IEditRecipeForm editRecipeForm, IRecipeDetailsForm recipeDetailsForm)
    {
        _userRepository = userRepository;
        _recipeRepository = recipeRepository;
        _commentRepository = commentRepository;
        _categoryRepository = categoryRepository;
        _unitRepository = unitRepository;
        _ingredientRepository = ingredientRepository;

        _mainForm = mainForm;
        _loginForm = loginForm;
        _registrationForm = registrationForm;
        _profileForm = profileForm;
        _editRecipeForm = editRecipeForm;
        _recipeDetailsForm = recipeDetailsForm;

        // events
        _loginForm.LoginEvent += OnLogin;
        _loginForm.GoToRegistrationEvent += OnGoToRegistration;
        _registrationForm.RegisterEvent += OnRegister;
        _registrationForm.LoginEvent += OnGoToLogin;
        _mainForm.AddNewRecipeEvent += OnAddNewRecipe;
        //_mainForm.MyRecipesEvent += OnMyRecipes;
        _mainForm.SearchRecipesEvent += OnSearchRecipes;
        _mainForm.LoadProfileEvent += OnLoadProfile;
        _mainForm.RecipeLoadDetailsEvent += OnLoadRecipeDetails;
        _profileForm.SaveProfileEvent += OnSaveProfile;
        _profileForm.ChangePasswordEvent += OnChangePassword;
        _profileForm.ChangeImageEvent += OnChangeProfilePicture;
        _editRecipeForm.SaveRecipeEvent += OnSaveRecipe;
        _editRecipeForm.LoadImageEvent += OnLoadRecipeImage;
        _recipeDetailsForm.EditRecipeEvent += OnEditRecipe;
        _recipeDetailsForm.RateRecipeEvent += OnRateRecipe;

        AppState = AppStates.Login;
    }

    public void OnLogin(object sender, EventArgs e)
    {
        CurrentUser = _userRepository.ValidateUser(_loginForm.Username, _loginForm.Password);
        if (CurrentUser != null)
        {
            AppState = AppStates.Main;
            _mainForm.PopulateUserData(CurrentUser);
            _loginForm.Close();
        }
        else
        {
            _loginForm.ShowErrorMessage("Neispravno korisničko ime ili šifra.");
        }
    }

    public void OnGoToRegistration(object sender, EventArgs e)
    {
        AppState = AppStates.Registration;
        _loginForm.Close();
    }

    public void OnGoToLogin(object sender, EventArgs e)
    {
        AppState = AppStates.Login;
        _registrationForm.Close();
    }

    public void OnRegister(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_registrationForm.Username) ||
            string.IsNullOrWhiteSpace(_registrationForm.Password) ||
            string.IsNullOrWhiteSpace(_registrationForm.FirstName) ||
            string.IsNullOrWhiteSpace(_registrationForm.LastName) ||
            string.IsNullOrWhiteSpace(_registrationForm.Country))
        {
            _registrationForm.ShowErrorMessage("Morate popuniti sva polja.");
            return;
        }
        if (_registrationForm.Password != _registrationForm.RepeatPassword)
        {
            _registrationForm.ShowErrorMessage("Šifre se ne poklapaju.");
            return;
        }
        if (!_registrationForm.AcceptTerms)
        {
            _registrationForm.ShowErrorMessage("Morate prihvatiti uvjete korištenja.");
            return;
        }

        if (_userRepository.GetUserByUsername(_registrationForm.Username) != null)
        {
            _registrationForm.ShowErrorMessage("Korisnik s tim imenom već postoji.");
            return;
        }

        var user = new User
        {
            Username = _registrationForm.Username,
            Password = _registrationForm.Password,
            FirstName = _registrationForm.FirstName,
            LastName = _registrationForm.LastName,
            Country = _registrationForm.Country
        };

        if (_userRepository.AddUser(user))
        {
            CurrentUser = user;
            AppState = AppStates.Main;
            _mainForm.PopulateUserData(CurrentUser);
            _registrationForm.Close();
        }
        else
        {
            _registrationForm.ShowErrorMessage("Došlo je do greške prilikom registracije.");
        }
    }

    public void OnAddNewRecipe(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_editRecipeForm)) return;

        _editRecipeForm.SetDetailsPageForAdding();

        _editRecipeForm.Categories = _categoryRepository.GetAllCategories();
        _editRecipeForm.Units = _unitRepository.GetAllUnits();

        _editRecipeForm.ShowDialog();
    }

    public void OnSearchRecipes(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_mainForm)) return;

        string searchText = _mainForm.SearchText;
        int? userId = _mainForm.CurrentRecipesOnly ? CurrentUser.UserId : null;

        var recipes = _recipeRepository.SearchRecipes(searchText, userId);

        _mainForm.DisplayRecipes(recipes);
    }

    public void OnLoadProfile(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_profileForm)) return;

        _profileForm.ResetPasswords();
        _profileForm.Username = CurrentUser.Username;
        _profileForm.FirstName = CurrentUser.FirstName;
        _profileForm.LastName = CurrentUser.LastName;
        _profileForm.Country = CurrentUser.Country;
        _profileForm.ProfileImagePath = CurrentUser.ProfileImagePath;

        _profileForm.ShowDialog();
    }

    public void OnSaveProfile(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_profileForm)) return;

        string username = _profileForm.Username;
        string firstName = _profileForm.FirstName;
        string lastName = _profileForm.LastName;
        string country = _profileForm.Country;
        string imagePath = _profileForm.ProfileImagePath;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(firstName) ||
            string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(country))
        {
            _profileForm.ShowErrorMessage("Sva polja moraju biti popunjena.");
            return;
        }

        CurrentUser.Username = username;
        CurrentUser.FirstName = firstName;
        CurrentUser.LastName = lastName;
        CurrentUser.Country = country;
        CurrentUser.ProfileImagePath = imagePath;

        if (_userRepository.UpdateUser(CurrentUser.UserId, CurrentUser))
        {
            _profileForm.ShowMessage("Profil uspješno spremljen.");
            _profileForm.Close();
        }
        else
        {
            _profileForm.ShowErrorMessage("Došlo je do greške prilikom spremanja podataka.");
        }
    }

    public void OnChangePassword(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_profileForm)) return;

        string currentPassword = _profileForm.CurrentPassword;
        string newPassword = _profileForm.NewPassword;
        string newPasswordRepeat = _profileForm.NewPasswordRepeat;

        if (newPassword != newPasswordRepeat)
        {
            _profileForm.ShowErrorMessage("Nova šifra se ne poklapa.");
            return;
        }
        if (CurrentUser.Password == newPassword)
        {
            _profileForm.ShowErrorMessage("Nova i trenutna šifra su iste.");
            return;
        }
        if (CurrentUser.Password != currentPassword)
        {
            _profileForm.ShowErrorMessage("Trenutna šifra nije ispravna.");
            return;
        }

        CurrentUser.Password = newPassword;
        if (_userRepository.UpdateUser(CurrentUser.UserId, CurrentUser))
        {
            _profileForm.ShowMessage("Šifra uspješno promijenjena.");
            _profileForm.Close();
        }
        else
        {
            _profileForm.ShowErrorMessage("Šifra nije uspješno izmijenjena.");
        }
    }

    public void OnChangeProfilePicture(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_profileForm)) return;

        if (_profileForm.ShowOpenFileDialog() == DialogResult.OK)
        {
            string imagePath = _profileForm.SelectedFilePath;
            var imageFile = _profileForm.CreateFileInfo(imagePath);
            if (imageFile != null && imageFile.Exists)
            {
                string prefix = Ulid.NewUlid().ToString();
                string newFileName = $"{prefix}_{imageFile.Name}";
                string newImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", newFileName);
                File.Copy(imagePath, newImagePath);

                CurrentUser.ProfileImagePath = newFileName;
                if (_userRepository.UpdateUser(CurrentUser.UserId, CurrentUser))
                {
                    _profileForm.ProfileImagePath = newFileName;
                    _mainForm.PopulateUserData(CurrentUser);
                }
                else
                {
                    _profileForm.ProfileImagePath = null;
                    _profileForm.ShowErrorMessage("Greška pri promjeni slike.");
                }
            }
            else
            {
                _profileForm.ProfileImagePath = null;
                _profileForm.ShowErrorMessage("Greška pri promjeni slike.");

            }
        }
    }

    public void OnSaveRecipe(object sender, EventArgs e)
    {
        if (!UserIsLoggedIn(_editRecipeForm)) return;

        int recipeId = _editRecipeForm.RecipeId;
        string recipeName = _editRecipeForm.RecipeName;
        int categoryId = _editRecipeForm.CategoryId;
        Category category = _editRecipeForm.Category;
        string alergens = _editRecipeForm.Alergens;
        decimal kcal = _editRecipeForm.Kcal;
        string description = _editRecipeForm.Description;
        List<Ingredient> ingredients = _editRecipeForm.Ingredients;
        string imagePath = _editRecipeForm.ImagePath;
        if (!string.IsNullOrWhiteSpace(imagePath))
        {
            var imageFile = _editRecipeForm.CreateFileInfo(imagePath);
            if (imageFile != null && imageFile.Exists)
            {
                imagePath = imageFile.Name;
            }
            else
            {
                imagePath = null;
            }
        }

        if (string.IsNullOrWhiteSpace(recipeName) || categoryId <= 0 || kcal <= 0
            || string.IsNullOrWhiteSpace(description) || !ingredients.Any())
        {
            _editRecipeForm.ShowErrorMessage("Sva polja moraju biti popunjena.");
            return;
        }

        var recipe = new Recipe
        {
            RecipeId = recipeId,
            Name = recipeName,
            Category = category,
            CategoryId = categoryId,
            Alergens = alergens,
            Kcal = kcal,
            Description = description,
            Ingredients = ingredients,
            RecipeImagePath = imagePath,
            UserId = CurrentUser.UserId,
            Author = CurrentUser
        };

        bool success;
        if (recipe.RecipeId > 0)
        {
            success = _recipeRepository.UpdateRecipe(recipe.RecipeId, recipe);
        }
        else
        {
            success = _recipeRepository.AddRecipe(recipe);
        }

        if (success)
        {
            _editRecipeForm.ShowMessage("Recept uspješno spremljen.");
            _editRecipeForm.Close();
            OnSearchRecipes(null, null);
        }
        else
        {
            _editRecipeForm.ShowErrorMessage("Recept nije uspješno spremljen.");
        }
    }

    public void OnLoadRecipeImage(object sender, RecipeEventArgs e)
    {
        if (!UserIsLoggedIn(_editRecipeForm)) return;

        if (_editRecipeForm.ShowOpenFileDialog() == DialogResult.OK)
        {
            string imagePath = _editRecipeForm.SelectedFilePath;
            var imageFile = _editRecipeForm.CreateFileInfo(imagePath);
            if (imageFile != null && imageFile.Exists)
            {
                string prefix = Ulid.NewUlid().ToString();
                string newFileName = $"{prefix}_{imageFile.Name}";
                string newImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", newFileName);
                File.Copy(imagePath, newImagePath);

                _editRecipeForm.ImagePath = newFileName;
            }
            else
            {
                _editRecipeForm.ImagePath = null;
                _editRecipeForm.ShowErrorMessage("Greška pri promjeni slike.");
            }
        }
    }

    public void OnLoadRecipeDetails(object sender, RecipeEventArgs e)
    {
        if (!UserIsLoggedIn(_recipeDetailsForm)) return;

        int recipeId = e.RecipeId;
        var recipe = _recipeRepository.GetRecipeById(recipeId);
        if (recipe == null)
        {
            _recipeDetailsForm.ShowErrorMessage("Recept nije pronađen.");
            return;
        }

        _recipeDetailsForm.RecipeId = recipe.RecipeId;
        _recipeDetailsForm.RecipeTitle = recipe.Name;
        _recipeDetailsForm.Category = recipe.Category;
        _recipeDetailsForm.TotalCalories = recipe.Kcal.ToString();
        _recipeDetailsForm.TotalRating = recipe.Rating.ToString();
        _recipeDetailsForm.ImagePath = recipe.RecipeImagePath;
        _recipeDetailsForm.Description = recipe.Description;
        _recipeDetailsForm.Ingredients = string.Join(Environment.NewLine,
            recipe.Ingredients.Select(i => i.Description).ToList());
        _recipeDetailsForm.Alergens = recipe.Alergens;


        // prikaz svih komentara
        var comments = _commentRepository.GetCommentsByRecipeId(recipeId);
        _recipeDetailsForm.DisplayComments(comments);

        // popunimo ocjenu trenutnog korisnika (ako postoji)
        var currentUserComment = _commentRepository.GetUserCommentForRecipe(recipeId, CurrentUser.UserId);
        if (currentUserComment != null)
        {
            _recipeDetailsForm.CurrentUserComment = currentUserComment.Text;
            _recipeDetailsForm.CurrentUserRating = currentUserComment.Rating;
        }
        else
        {
            _recipeDetailsForm.CurrentUserComment = "";
            _recipeDetailsForm.CurrentUserRating = -1;
        }

        // pokaži/skrij gumb za editiranje i tab za ocjenjivanje ovisno o tome radi li se o autoru recepta ili ne
        bool isAuthor = recipe.UserId == CurrentUser.UserId;
        _recipeDetailsForm.SetEditButtonVisibility(isAuthor);
        _recipeDetailsForm.SetRateTabPageVisibility(!isAuthor);

        _recipeDetailsForm.ShowDialog();
    }

    public void OnEditRecipe(object sender, RecipeEventArgs e)
    {
        if (!UserIsLoggedIn(_editRecipeForm)) return;

        _editRecipeForm.SetDetailsPageForEditing();

        _editRecipeForm.Categories = _categoryRepository.GetAllCategories();
        _editRecipeForm.Units = _unitRepository.GetAllUnits();

        var recipe = _recipeRepository.GetRecipeById(e.RecipeId);
        if (recipe != null)
        {
            var ingredients = _ingredientRepository.GetIngredientsForRecipe(recipe.RecipeId);
            _editRecipeForm.RecipeId = recipe.RecipeId;
            _editRecipeForm.RecipeName = recipe.Name;
            _editRecipeForm.CategoryId = recipe.CategoryId;
            _editRecipeForm.Category = recipe.Category;
            _editRecipeForm.Alergens = recipe.Alergens;
            _editRecipeForm.Description = recipe.Description;
            _editRecipeForm.Ingredients = ingredients;
            _editRecipeForm.ImagePath = recipe.RecipeImagePath;
            _editRecipeForm.Kcal = recipe.Kcal;

            _recipeDetailsForm.Close();
            _editRecipeForm.ShowDialog();
        }
        else
        {
            _recipeDetailsForm.ShowErrorMessage("Recept ne postoji u sustavu.");
        }
    }

    public void OnRateRecipe(object sender, RecipeEventArgs e)
    {
        if (!UserIsLoggedIn(_recipeDetailsForm)) return;

        Comment newComment = new Comment
        {
            RecipeId = e.RecipeId,
            UserId = CurrentUser.UserId,
            Rating = _recipeDetailsForm.CurrentUserRating,
            Text = _recipeDetailsForm.CurrentUserComment
        };
        if (_commentRepository.AddComment(newComment))
        {
            _recipeDetailsForm.ShowMessage("Komentar je uspješno spremljen.");

            // refresh svih komentara
            var comments = _commentRepository.GetCommentsByRecipeId(e.RecipeId);
            _recipeDetailsForm.DisplayComments(comments);
            // refresh totala ratinga
            _recipeDetailsForm.TotalRating = _recipeRepository.RecalculateRatingForRecipe(e.RecipeId).ToString("#,##0.0");
        }
        else
        {
            _recipeDetailsForm.ShowErrorMessage("Recept ne postoji u sustavu.");
        }
    }

    public virtual FileInfo CreateFileInfo(string fileName)
    {
        return new FileInfo(fileName);
    }

    private bool UserIsLoggedIn(IForm form)
    {
        if (CurrentUser == null)
        {
            form.ShowErrorMessage("Niste prijavljeni.");

            return false;
        }
        return true;
    }


}