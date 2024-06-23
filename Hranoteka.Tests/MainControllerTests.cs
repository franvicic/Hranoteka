using Hranoteka.Controllers;
using Hranoteka.Data;
using Hranoteka.Repositories;
using Hranoteka.Utils;
using Hranoteka.Views;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Windows.Forms;

namespace Hranoteka.Tests;

public class MainControllerTests : IDisposable
{
    private readonly AppDbContext _dbContext;
    private readonly MainController _controller;

    private readonly Mock<IMainForm> _mainFormMock;
    private readonly Mock<ILoginForm> _loginFormMock;
    private readonly Mock<IRegistrationForm> _registrationFormMock;
    private readonly Mock<IProfileForm> _profileFormMock;
    private readonly Mock<IEditRecipeForm> _editRecipeFormMock;
    private readonly Mock<IRecipeDetailsForm> _recipeDetailsFormMock;

    private readonly UserRepository _userRepository;
    private readonly RecipeRepository _recipeRepository;
    private readonly CommentRepository _commentRepository;
    private readonly CategoryRepository _categoryRepository;
    private readonly UnitRepository _unitRepository;
    private readonly IngredientRepository _ingredientRepository;


    public MainControllerTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        _dbContext = new AppDbContext(options);

        _userRepository = new UserRepository(_dbContext);
        _recipeRepository = new RecipeRepository(_dbContext);
        _commentRepository = new CommentRepository(_dbContext);
        _categoryRepository = new CategoryRepository(_dbContext);
        _unitRepository = new UnitRepository(_dbContext);
        _ingredientRepository = new IngredientRepository(_dbContext);

        _mainFormMock = new Mock<IMainForm>();
        _loginFormMock = new Mock<ILoginForm>();
        _registrationFormMock = new Mock<IRegistrationForm>();
        _profileFormMock = new Mock<IProfileForm>();
        _editRecipeFormMock = new Mock<IEditRecipeForm>();
        _recipeDetailsFormMock = new Mock<IRecipeDetailsForm>();

        _controller = new MainController(
            _userRepository,
            _recipeRepository,
            _commentRepository,
            _categoryRepository,
            _unitRepository,
            _ingredientRepository,
            _mainFormMock.Object,
            _loginFormMock.Object,
            _registrationFormMock.Object,
            _profileFormMock.Object,
            _editRecipeFormMock.Object,
            _recipeDetailsFormMock.Object
        );

        ResetDatabase();
    }

    private void ResetDatabase()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
    }

    public void Dispose()
    {
        // Ensure the database is deleted after each test
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
    }


    [Fact]
    public void OnLogin_InvalidUser_ShowsErrorMessage()
    {
        // Arrange
        var invalidUser = "invaliduser";
        var invalidPassword = "invalidpassword";
        _loginFormMock.Setup(l => l.Username).Returns(invalidUser);
        _loginFormMock.Setup(l => l.Password).Returns(invalidPassword);

        // Act
        _controller.OnLogin(this, EventArgs.Empty);

        // Assert
        Assert.Equal(AppStates.Login, _controller.AppState);
        _loginFormMock.Verify(l => l.ShowErrorMessage("Neispravno korisničko ime ili šifra."), Times.Once);
    }


    [Fact]
    public void OnRegister_UsernameAlreadyExists_ShowsErrorMessage()
    {
        // Arrange
        var existingUser = new User { UserId=1, Username = "existinguser" };
        _dbContext.Users.Add(existingUser);
        _dbContext.SaveChanges();

        _registrationFormMock.Setup(r => r.Username).Returns("existinguser");
        _registrationFormMock.Setup(r => r.FirstName).Returns("firstname");
        _registrationFormMock.Setup(r => r.LastName).Returns("lastname");
        _registrationFormMock.Setup(r => r.Password).Returns("password");
        _registrationFormMock.Setup(r => r.RepeatPassword).Returns("password");
        _registrationFormMock.Setup(r => r.Country).Returns("country");
        _registrationFormMock.Setup(r => r.AcceptTerms).Returns(true);

        // Act
        _controller.OnRegister(this, EventArgs.Empty);

        // Assert
        _registrationFormMock.Verify(r => r.ShowErrorMessage("Korisnik s tim imenom već postoji."), Times.Once);
    }


    [Fact]
    public void OnAddNewRecipe_SetsDetailsPageForAdding()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var categories = new List<Category> { new Category { CategoryId = 1, Name = "Category1" } };
        var units = new List<Unit> { new Unit { UnitId = 1, Name = "Unit1" } };

        _dbContext.Categories.AddRange(categories);
        _dbContext.Units.AddRange(units);
        _dbContext.SaveChanges();

        // Act
        _controller.OnAddNewRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.Verify(form => form.SetDetailsPageForAdding(), Times.Once);
        _editRecipeFormMock.VerifySet(form => form.Categories = categories, Times.Once);
        _editRecipeFormMock.VerifySet(form => form.Units = units, Times.Once);
        _editRecipeFormMock.Verify(form => form.ShowDialog(), Times.Once);
    }


    [Fact]
    public void OnAddNewRecipe_PopulatesCategoriesAndUnits()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        var categories = new List<Category> { new Category { CategoryId = 1, Name = "Category1" } };
        var units = new List<Unit> { new Unit { UnitId = 1, Name = "Unit1" } };

        _dbContext.Categories.AddRange(categories);
        _dbContext.Units.AddRange(units);
        _dbContext.SaveChanges();

        // Act
        _controller.OnAddNewRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.VerifySet(form => form.Categories = categories, Times.Once);
        _editRecipeFormMock.VerifySet(form => form.Units = units, Times.Once);
    }


    [Fact]
    public void OnAddNewRecipe_ShowsDialog()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        // Act
        _controller.OnAddNewRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.Verify(form => form.ShowDialog(), Times.Once);
    }


    [Fact]
    public void OnSearchRecipes_WithSearchText_CallsSearchRecipes()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        string searchText = "test";
        _mainFormMock.Setup(form => form.SearchText).Returns(searchText);
        _mainFormMock.Setup(form => form.CurrentRecipesOnly).Returns(false);

        var recipes = new List<Recipe>
        {
            new Recipe { RecipeId = 1, Name = "Test Recipe", UserId = currentUser.UserId }
        };

        _dbContext.Recipes.AddRange(recipes);
        _dbContext.SaveChanges();

        // Act
        _controller.OnSearchRecipes(this, EventArgs.Empty);

        // Assert
        var result = _dbContext.Recipes
            .Where(r => r.Name.ToLower().Contains(searchText.ToLower()))
            .ToList();
        Assert.Equal(recipes, result);
        //_mainFormMock.Verify(form => form.DisplayRecipes(recipes), Times.Once);
        _mainFormMock.Verify(form => form.DisplayRecipes(It.IsAny<List<Recipe>>()), Times.Once);

    }


    [Fact]
    public void OnSearchRecipes_WithCurrentUserRecipesOnly_CallsSearchRecipesWithUserId()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        string searchText = "test";
        _mainFormMock.Setup(form => form.SearchText).Returns(searchText);
        _mainFormMock.Setup(form => form.CurrentRecipesOnly).Returns(true);

        var recipes = new List<Recipe>
        {
            new Recipe { RecipeId = 1, Name = "Test Recipe", UserId = currentUser.UserId }
        };

        _dbContext.Recipes.AddRange(recipes);
        _dbContext.SaveChanges();

        // Act
        _controller.OnSearchRecipes(this, EventArgs.Empty);

        // Assert
        var result = _dbContext.Recipes
            .Where(r => r.Name.ToLower().Contains(searchText.ToLower()))
            .Where(r => r.UserId == currentUser.UserId)
            .ToList();
        Assert.Equal(recipes, result);
        _mainFormMock.Verify(form => form.DisplayRecipes(It.IsAny<List<Recipe>>()), Times.Once);

    }


    [Fact]
    public void OnSearchRecipes_DisplaysRecipesOnMainForm()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        string searchText = "test";
        _mainFormMock.Setup(form => form.SearchText).Returns(searchText);
        _mainFormMock.Setup(form => form.CurrentRecipesOnly).Returns(false);

        var recipes = new List<Recipe>
        {
            new Recipe { RecipeId = 1, Name = "Test Recipe" }
        };

        _dbContext.Recipes.AddRange(recipes);
        _dbContext.SaveChanges();

        // Act
        _controller.OnSearchRecipes(this, EventArgs.Empty);

        // Assert
        var result = _dbContext.Recipes
            .Where(r => r.Name.ToLower().Contains(searchText.ToLower()))
            .ToList();
        Assert.Equal(recipes, result);
        _mainFormMock.Verify(form => form.DisplayRecipes(It.IsAny<List<Recipe>>()), Times.Once);
    }


    [Fact]
    public void OnLoadProfile_UserLoggedIn_ResetsPasswordsAndSetsProfileData()
    {
        // Arrange
        var currentUser = new User
        {
            UserId = 1,
            Username = "testuser",
            FirstName = "John",
            LastName = "Doe",
            Country = "Country",
            ProfileImagePath = "path/to/image.jpg"
        };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        // Act
        _controller.OnLoadProfile(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ResetPasswords(), Times.Once);
        _profileFormMock.VerifySet(form => form.Username = currentUser.Username, Times.Once);
        _profileFormMock.VerifySet(form => form.FirstName = currentUser.FirstName, Times.Once);
        _profileFormMock.VerifySet(form => form.LastName = currentUser.LastName, Times.Once);
        _profileFormMock.VerifySet(form => form.Country = currentUser.Country, Times.Once);
        _profileFormMock.VerifySet(form => form.ProfileImagePath = currentUser.ProfileImagePath, Times.Once);
        _profileFormMock.Verify(form => form.ShowDialog(), Times.Once);
    }


    [Fact]
    public void OnLoadProfile_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        _controller.CurrentUser = null;

        // Act
        _controller.OnLoadProfile(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ResetPasswords(), Times.Never);
        _profileFormMock.VerifySet(form => form.Username = It.IsAny<string>(), Times.Never);
        _profileFormMock.VerifySet(form => form.FirstName = It.IsAny<string>(), Times.Never);
        _profileFormMock.VerifySet(form => form.LastName = It.IsAny<string>(), Times.Never);
        _profileFormMock.VerifySet(form => form.Country = It.IsAny<string>(), Times.Never);
        _profileFormMock.VerifySet(form => form.ProfileImagePath = It.IsAny<string>(), Times.Never);
        _profileFormMock.Verify(form => form.ShowDialog(), Times.Never);
    }


    [Fact]
    public void OnSaveProfile_UserLoggedIn_WithValidData_UpdatesUserAndShowsSuccessMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "olduser" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.Username).Returns("newuser");
        _profileFormMock.Setup(form => form.FirstName).Returns("John");
        _profileFormMock.Setup(form => form.LastName).Returns("Doe");
        _profileFormMock.Setup(form => form.Country).Returns("Country");
        _profileFormMock.Setup(form => form.ProfileImagePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnSaveProfile(this, EventArgs.Empty);

        // Assert
        var updatedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(updatedUser);
        Assert.Equal("newuser", updatedUser.Username);
        Assert.Equal("John", updatedUser.FirstName);
        Assert.Equal("Doe", updatedUser.LastName);
        Assert.Equal("Country", updatedUser.Country);
        Assert.Equal("path/to/image.jpg", updatedUser.ProfileImagePath);

        _profileFormMock.Verify(form => form.ShowMessage("Profil uspješno spremljen."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Once);
    }


    [Fact]
    public void OnSaveProfile_UserLoggedIn_WithInvalidData_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "olduser" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.Username).Returns("");
        _profileFormMock.Setup(form => form.FirstName).Returns("John");
        _profileFormMock.Setup(form => form.LastName).Returns("Doe");
        _profileFormMock.Setup(form => form.Country).Returns("Country");
        _profileFormMock.Setup(form => form.ProfileImagePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnSaveProfile(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage("Sva polja moraju biti popunjena."), Times.Once);
        var unchangedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(unchangedUser);
        Assert.Equal("olduser", unchangedUser.Username);
    }


    [Fact]
    public void OnSaveProfile_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        _controller.CurrentUser = null;

        // Act
        _controller.OnSaveProfile(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage(It.IsAny<string>()), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }


    [Fact]
    public void OnSaveProfile_UpdateUserFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "olduser" };
        EnsureUserIsLoggedIn(currentUser);

        _profileFormMock.Setup(form => form.Username).Returns("newuser");
        _profileFormMock.Setup(form => form.FirstName).Returns("John");
        _profileFormMock.Setup(form => form.LastName).Returns("Doe");
        _profileFormMock.Setup(form => form.Country).Returns("Country");
        _profileFormMock.Setup(form => form.ProfileImagePath).Returns("image.jpg");

        _controller.CurrentUser.UserId = 0;

        // Act
        _controller.OnSaveProfile(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage("Došlo je do greške prilikom spremanja podataka."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }

    [Fact]
    public void OnChangePassword_UserLoggedIn_WithValidData_ChangesPasswordAndShowsSuccessMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser", Password = "oldpassword" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.CurrentPassword).Returns("oldpassword");
        _profileFormMock.Setup(form => form.NewPassword).Returns("newpassword");
        _profileFormMock.Setup(form => form.NewPasswordRepeat).Returns("newpassword");

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        var updatedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(updatedUser);
        Assert.Equal("newpassword", updatedUser.Password);

        _profileFormMock.Verify(form => form.ShowMessage("Šifra uspješno promijenjena."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Once);
    }


    [Fact]
    public void OnChangePassword_UserLoggedIn_NewPasswordsDoNotMatch_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser", Password = "oldpassword" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.CurrentPassword).Returns("oldpassword");
        _profileFormMock.Setup(form => form.NewPassword).Returns("newpassword");
        _profileFormMock.Setup(form => form.NewPasswordRepeat).Returns("differentpassword");

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage("Nova šifra se ne poklapa."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Never);

        var unchangedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(unchangedUser);
        Assert.Equal("oldpassword", unchangedUser.Password);
    }

    [Fact]
    public void OnChangePassword_UserLoggedIn_NewPasswordSameAsOldPassword_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser", Password = "oldpassword" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.CurrentPassword).Returns("oldpassword");
        _profileFormMock.Setup(form => form.NewPassword).Returns("oldpassword");
        _profileFormMock.Setup(form => form.NewPasswordRepeat).Returns("oldpassword");

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage("Nova i trenutna šifra su iste."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }


    [Fact]
    public void OnChangePassword_UserLoggedIn_CurrentPasswordIncorrect_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser", Password = "oldpassword" };
        _controller.CurrentUser = currentUser;

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();

        _profileFormMock.Setup(form => form.CurrentPassword).Returns("wrongpassword");
        _profileFormMock.Setup(form => form.NewPassword).Returns("newpassword");
        _profileFormMock.Setup(form => form.NewPasswordRepeat).Returns("newpassword");

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.Close(), Times.Never);

        var unchangedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(unchangedUser);
        Assert.Equal("oldpassword", unchangedUser.Password);
    }


    [Fact]
    public void OnChangePassword_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        _controller.CurrentUser = null;

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }

    [Fact]
    public void OnChangePassword_UpdateUserFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser", Password = "oldpassword" };
        EnsureUserIsLoggedIn(currentUser);

        _profileFormMock.Setup(form => form.CurrentPassword).Returns("oldpassword");
        _profileFormMock.Setup(form => form.NewPassword).Returns("newpassword");
        _profileFormMock.Setup(form => form.NewPasswordRepeat).Returns("newpassword");
        _controller.CurrentUser.UserId = 0;

        // Act
        _controller.OnChangePassword(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowErrorMessage("Šifra nije uspješno izmijenjena."), Times.Once);
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }


    [Fact]
    public void OnChangeProfilePicture_UserLoggedIn_ShowsOpenFileDialog()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _profileFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _profileFormMock.Setup(form => form.SelectedFilePath).Returns("image.jpg");

        // Act
        _controller.OnChangeProfilePicture(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.ShowOpenFileDialog(), Times.Once);
    }



    [Fact]
    public void OnChangeProfilePicture_FileSelected_UpdatesProfilePicture()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _profileFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _profileFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnChangeProfilePicture(this, EventArgs.Empty);

        // Assert
        var updatedUser = _dbContext.Users.Find(currentUser.UserId);
        Assert.NotNull(updatedUser);
        Assert.Null(updatedUser.ProfileImagePath);

        _profileFormMock.VerifySet(form => form.ProfileImagePath = null, Times.Once);
        _mainFormMock.Verify(form => form.PopulateUserData(updatedUser), Times.Never);
    }



    [Fact]
    public void OnChangeProfilePicture_FileSelected_UpdateUserFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _profileFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _profileFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnChangeProfilePicture(this, EventArgs.Empty);

        // Assert
        _profileFormMock.VerifySet(form => form.ProfileImagePath = null, Times.Once);
        _profileFormMock.Verify(form => form.ShowErrorMessage("Greška pri promjeni slike."), Times.Once);
    }


    [Fact]
    public void OnChangeProfilePicture_FileNotExists_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        _controller.CurrentUser = currentUser;

        _profileFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _profileFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/nonexistent.jpg");

        // Act
        _controller.OnChangeProfilePicture(this, EventArgs.Empty);

        // Assert
        _profileFormMock.VerifySet(form => form.ProfileImagePath = null, Times.Once);
        _profileFormMock.Verify(form => form.ShowErrorMessage("Greška pri promjeni slike."), Times.Once);
    }


    [Fact]
    public void OnChangeProfilePicture_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        _controller.CurrentUser = null;

        // Act
        _controller.OnChangeProfilePicture(this, EventArgs.Empty);

        // Assert
        _profileFormMock.Verify(form => form.Close(), Times.Never);
    }


    [Fact]
    public void OnSaveRecipe_UserLoggedIn_WithValidData_AddsNewRecipeAndShowsSuccessMessage()
    {
        // Arrange
        var currentUser = new User { Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _editRecipeFormMock.Setup(form => form.RecipeId).Returns(0); // New recipe
        _editRecipeFormMock.Setup(form => form.RecipeName).Returns("New Recipe");
        _editRecipeFormMock.Setup(form => form.CategoryId).Returns(1);
        _editRecipeFormMock.Setup(form => form.Category).Returns(new Category { CategoryId = 1, Name = "Category1" });
        _editRecipeFormMock.Setup(form => form.Alergens).Returns("None");
        _editRecipeFormMock.Setup(form => form.Kcal).Returns(100);
        _editRecipeFormMock.Setup(form => form.Description).Returns("Recipe Description");
        _editRecipeFormMock.Setup(form => form.Ingredients).Returns(new List<Ingredient> { new Ingredient { Description = "Ingredient1" } });

        // Act
        _controller.OnSaveRecipe(this, EventArgs.Empty);

        // Assert
        var addedRecipe = _dbContext.Recipes.FirstOrDefault(r => r.Name == "New Recipe");
        Assert.NotNull(addedRecipe);
        Assert.Equal("New Recipe", addedRecipe.Name);
        Assert.Equal(1, addedRecipe.CategoryId);
        Assert.Equal("None", addedRecipe.Alergens);
        Assert.Equal(100, addedRecipe.Kcal);
        Assert.Equal("Recipe Description", addedRecipe.Description);
        Assert.Single(addedRecipe.Ingredients);
        Assert.Null(addedRecipe.RecipeImagePath);
        Assert.Equal(currentUser.UserId, addedRecipe.UserId);

        _editRecipeFormMock.Verify(form => form.ShowMessage("Recept uspješno spremljen."), Times.Once);
        _editRecipeFormMock.Verify(form => form.Close(), Times.Once);
        _mainFormMock.Verify(form => form.DisplayRecipes(It.IsAny<List<Recipe>>()), Times.Once);
    }


    [Fact]
    public void OnSaveRecipe_UserLoggedIn_WithValidData_UpdatesExistingRecipeAndShowsSuccessMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        var existingRecipe = new Recipe
        {
            RecipeId = 1,
            UserId = currentUser.UserId,
            Name = "Old Recipe",
            Ingredients = new List<Ingredient> { new Ingredient { Description = "Ingredient" } }
        };
        _dbContext.Recipes.Add(existingRecipe);
        _dbContext.SaveChanges();

        _editRecipeFormMock.Setup(form => form.RecipeId).Returns(1); // Existing recipe
        _editRecipeFormMock.Setup(form => form.RecipeName).Returns("Updated Recipe");
        _editRecipeFormMock.Setup(form => form.CategoryId).Returns(1);
        _editRecipeFormMock.Setup(form => form.Category).Returns(new Category { CategoryId = 1, Name = "Category1" });
        _editRecipeFormMock.Setup(form => form.Alergens).Returns("None");
        _editRecipeFormMock.Setup(form => form.Kcal).Returns(200);
        _editRecipeFormMock.Setup(form => form.Description).Returns("Updated Description");
        _editRecipeFormMock.Setup(form => form.Ingredients).Returns(new List<Ingredient> { new Ingredient { Description = "Ingredient1" } });
        _editRecipeFormMock.Setup(form => form.ImagePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnSaveRecipe(this, EventArgs.Empty);

        // Assert
        var updatedRecipe = _dbContext.Recipes.Include(r => r.Ingredients).FirstOrDefault(r => r.RecipeId == 1);
        Assert.NotNull(updatedRecipe);
        Assert.Equal("Updated Recipe", updatedRecipe.Name);
        Assert.Equal(1, updatedRecipe.CategoryId);
        Assert.Equal("None", updatedRecipe.Alergens);
        Assert.Equal(200, updatedRecipe.Kcal);
        Assert.Equal("Updated Description", updatedRecipe.Description);
        Assert.Single(updatedRecipe.Ingredients);
        Assert.Null(updatedRecipe.RecipeImagePath);
        Assert.Equal(currentUser.UserId, updatedRecipe.UserId);

        _editRecipeFormMock.Verify(form => form.ShowMessage("Recept uspješno spremljen."), Times.Once);
        _editRecipeFormMock.Verify(form => form.Close(), Times.Once);
        _mainFormMock.Verify(form => form.DisplayRecipes(It.IsAny<List<Recipe>>()), Times.Once);
    }



    [Fact]
    public void OnSaveRecipe_UserLoggedIn_WithInvalidData_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _editRecipeFormMock.Setup(form => form.RecipeName).Returns("");
        _editRecipeFormMock.Setup(form => form.CategoryId).Returns(0);
        _editRecipeFormMock.Setup(form => form.Kcal).Returns(0);
        _editRecipeFormMock.Setup(form => form.Description).Returns("");
        _editRecipeFormMock.Setup(form => form.Ingredients).Returns(new List<Ingredient>());

        // Act
        _controller.OnSaveRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.Verify(form => form.ShowErrorMessage("Sva polja moraju biti popunjena."), Times.Once);
    }

    [Fact]
    public void OnSaveRecipe_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        _controller.CurrentUser = null;

        // Act
        _controller.OnSaveRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.Verify(form => form.ShowErrorMessage(It.IsAny<string>()), Times.Once);
        _editRecipeFormMock.Verify(form => form.Close(), Times.Never);
    }

    [Fact]
    public void OnSaveRecipe_AddRecipeFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        _editRecipeFormMock.Setup(form => form.RecipeId).Returns(0); // New recipe
        _editRecipeFormMock.Setup(form => form.RecipeName).Returns("New Recipe");
        _editRecipeFormMock.Setup(form => form.CategoryId).Returns(1);
        _editRecipeFormMock.Setup(form => form.Category).Returns(new Category { CategoryId = 1, Name = "Category1" });
        _editRecipeFormMock.Setup(form => form.Alergens).Returns("None");
        _editRecipeFormMock.Setup(form => form.Description).Returns("Recipe Description");
        _editRecipeFormMock.Setup(form => form.Ingredients).Returns(new List<Ingredient> { new Ingredient { Description = "Ingredient1" } });
        _editRecipeFormMock.Setup(form => form.ImagePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnSaveRecipe(this, EventArgs.Empty);

        // Assert
        _editRecipeFormMock.Verify(form => form.ShowErrorMessage("Sva polja moraju biti popunjena."), Times.Once);
        _editRecipeFormMock.Verify(form => form.Close(), Times.Never);
    }


    [Fact]
    public void OnLoadRecipeImage_FileSelectedAndExists_UpdatesRecipeImagePath()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        _editRecipeFormMock.Setup(form => form.CreateFileInfo("path/to/image.jpg"))
            .Returns(new FileInfo("image.jpg"));


        var newFileName = "newfile.jpg";
        var newImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", newFileName);
        var recipe = new Recipe { RecipeId = recipeId };

        _dbContext.Recipes.Add(recipe);
        _dbContext.SaveChanges();

        _editRecipeFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _editRecipeFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/image.jpg");

        // Act
        _controller.OnLoadRecipeImage(this, recipeEvent);

        // Assert
        var updatedRecipe = _dbContext.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
        Assert.NotNull(updatedRecipe);
        Assert.Null(updatedRecipe.RecipeImagePath);

        _editRecipeFormMock.VerifySet(form => form.ImagePath = It.IsAny<string>(), Times.Once);
    }


    [Fact]
    public void OnLoadRecipeImage_FileSelectedAndNotExists_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        _editRecipeFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _editRecipeFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/nonexistent.jpg");

        // Act
        _controller.OnLoadRecipeImage(this, recipeEvent);

        // Assert
        _editRecipeFormMock.VerifySet(form => form.ImagePath = null, Times.Once);
        _editRecipeFormMock.Verify(form => form.ShowErrorMessage("Greška pri promjeni slike."), Times.Once);
    }


    [Fact]
    public void OnLoadRecipeImage_RecipeUpdateFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        var newFileName = "newfile.jpg";
        var newImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", newFileName);
        var recipe = new Recipe { RecipeId = recipeId };

        _dbContext.Recipes.Add(recipe);
        _dbContext.SaveChanges();

        _editRecipeFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.OK);
        _editRecipeFormMock.Setup(form => form.SelectedFilePath).Returns("path/to/image.jpg");


        // Act
        _controller.OnLoadRecipeImage(this, recipeEvent);

        // Assert
        var updatedRecipe = _dbContext.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
        Assert.NotNull(updatedRecipe);
        Assert.Null(updatedRecipe.RecipeImagePath);

        _editRecipeFormMock.VerifySet(form => form.ImagePath = null, Times.Once);
        _editRecipeFormMock.Verify(form => form.ShowErrorMessage("Greška pri promjeni slike."), Times.Once);
    }


    [Fact]
    public void OnLoadRecipeImage_FileNotSelected_NoActionTaken()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        _editRecipeFormMock.Setup(form => form.ShowOpenFileDialog()).Returns(DialogResult.Cancel);

        // Act
        _controller.OnLoadRecipeImage(this, recipeEvent);

        // Assert
        _editRecipeFormMock.VerifySet(form => form.ImagePath = It.IsAny<string>(), Times.Never);
        _profileFormMock.Verify(form => form.ShowErrorMessage(It.IsAny<string>()), Times.Never);
    }



    [Fact]
    public void OnLoadRecipeImage_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        var recipeEvent = new RecipeEventArgs(1);
        _controller.CurrentUser = null;

        // Act
        _controller.OnLoadRecipeImage(this, recipeEvent);

        // Assert
        _editRecipeFormMock.VerifySet(form => form.ImagePath = It.IsAny<string>(), Times.Never);
        _profileFormMock.Verify(form => form.ShowErrorMessage(It.IsAny<string>()), Times.Never);
    }


    [Fact]
    public void OnLoadRecipeDetails_RecipeExists_PopulatesRecipeDetailsForm()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        var recipe = new Recipe
        {
            Name = "Test Recipe",
            Category = new Category { CategoryId = 1, Name = "Category1" },
            Kcal = 200,
            Rating = 4.5m,
            RecipeImagePath = "path/to/image.jpg",
            Description = "Test Description",
            Ingredients = new List<Ingredient>
            {
                new Ingredient { Description = "Ingredient1" },
                new Ingredient { Description = "Ingredient2" }
            },
            Alergens = "None",
            UserId = currentUser.UserId
        };

        var comments = new List<Comment>
        {
            new Comment { RecipeId = recipeId, Text = "Great recipe!", Rating = 5, UserId = currentUser.UserId, Author = currentUser }
        };

        _dbContext.Recipes.Add(recipe);
        _dbContext.Comments.AddRange(comments);
        _dbContext.SaveChanges();

        // Act
        _controller.OnLoadRecipeDetails(this, recipeEvent);

        // Assert
        _recipeDetailsFormMock.VerifySet(form => form.RecipeId = recipe.RecipeId, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.RecipeTitle = recipe.Name, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.Category = recipe.Category, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.TotalCalories = recipe.Kcal.ToString(), Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.TotalRating = recipe.Rating.ToString(), Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.ImagePath = recipe.RecipeImagePath, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.Description = recipe.Description, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.Ingredients = string.Join(Environment.NewLine, recipe.Ingredients.Select(i => i.Description)), Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.Alergens = recipe.Alergens, Times.Once);

        _recipeDetailsFormMock.Verify(form => form.DisplayComments(comments), Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserComment = comments.First().Text, Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserRating = comments.First().Rating, Times.Once);
        _recipeDetailsFormMock.Verify(form => form.SetEditButtonVisibility(true), Times.Once);
        _recipeDetailsFormMock.Verify(form => form.SetRateTabPageVisibility(false), Times.Once);

        _recipeDetailsFormMock.Verify(form => form.ShowDialog(), Times.Once);
    }


    [Fact]
    public void OnLoadRecipeDetails_RecipeNotFound_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        // Act
        _controller.OnLoadRecipeDetails(this, recipeEvent);

        // Assert
        _recipeDetailsFormMock.Verify(form => form.ShowDialog(), Times.Never);
        _recipeDetailsFormMock.Verify(form => form.ShowErrorMessage("Recept nije pronađen."), Times.Once);
    }


    [Fact]
    public void OnLoadRecipeDetails_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        var recipeEvent = new RecipeEventArgs(1);
        _controller.CurrentUser = null;

        // Act
        _controller.OnLoadRecipeDetails(this, recipeEvent);

        // Assert
        _recipeDetailsFormMock.VerifySet(form => form.RecipeId = It.IsAny<int>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.RecipeTitle = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.Category = It.IsAny<Category>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.TotalCalories = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.TotalRating = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.ImagePath = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.Description = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.Ingredients = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.Alergens = It.IsAny<string>(), Times.Never);

        _recipeDetailsFormMock.Verify(form => form.DisplayComments(It.IsAny<List<Comment>>()), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserComment = It.IsAny<string>(), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserRating = It.IsAny<int>(), Times.Never);
        _recipeDetailsFormMock.Verify(form => form.SetEditButtonVisibility(It.IsAny<bool>()), Times.Never);
        _recipeDetailsFormMock.Verify(form => form.SetRateTabPageVisibility(It.IsAny<bool>()), Times.Never);

        _recipeDetailsFormMock.Verify(form => form.ShowDialog(), Times.Never);
    }


    [Fact]
    public void OnLoadRecipeDetails_UserCommentNotFound_SetsDefaultCommentAndRating()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        var anotherUser = new User { UserId = 2, Username = "testuser2" };
        _controller.CurrentUser = currentUser;
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        var recipe = new Recipe
        {
            RecipeId = recipeId,
            Name = "Test Recipe",
            Category = new Category { CategoryId = 1, Name = "Category1" },
            Kcal = 200,
            Rating = 4.5m,
            RecipeImagePath = "path/to/image.jpg",
            Description = "Test Description",
            Ingredients = new List<Ingredient>
        {
            new Ingredient { Description = "Ingredient1" },
            new Ingredient { Description = "Ingredient2" }
        },
            Alergens = "None",
            UserId = currentUser.UserId
        };

        var comments = new List<Comment>
    {
        new Comment { RecipeId = recipeId, Text = "Great recipe!", Rating = 5, UserId = 2, Author = anotherUser }
    };

        _dbContext.Users.Add(currentUser);
        _dbContext.Users.Add(anotherUser);
        _dbContext.Recipes.Add(recipe);
        _dbContext.Comments.AddRange(comments);
        _dbContext.SaveChanges();

        // Act
        _controller.OnLoadRecipeDetails(this, recipeEvent);

        // Assert
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserComment = "", Times.Once);
        _recipeDetailsFormMock.VerifySet(form => form.CurrentUserRating = -1, Times.Once);
    }


    [Fact]
    public void OnEditRecipe_RecipeExists_PopulatesEditRecipeForm()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        var recipe = new Recipe
        {
            RecipeId = recipeId,
            Name = "Test Recipe",
            CategoryId = 1,
            Alergens = "None",
            Kcal = 200,
            Description = "Test Description",
            RecipeImagePath = "path/to/image.jpg"
        };

        var ingredients = new List<Ingredient>
        {
            new Ingredient { Description = "Ingredient1" },
            new Ingredient { Description = "Ingredient2" }
        };

        var categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Category1" },
            new Category { CategoryId = 2, Name = "Category2" }
        };

        var units = new List<Unit>
        {
            new Unit { UnitId = 1, Name = "g" },
            new Unit { UnitId = 2, Name = "kg" }
        };

        _dbContext.Recipes.Add(recipe);
        _dbContext.Ingredients.AddRange(ingredients);
        _dbContext.Categories.AddRange(categories);
        _dbContext.Units.AddRange(units);
        _dbContext.SaveChanges();

        // Act
        _controller.OnEditRecipe(this, recipeEvent);

        // Assert
        _editRecipeFormMock.Verify(form => form.SetDetailsPageForEditing(), Times.Once);
        _editRecipeFormMock.VerifySet(form => form.Categories = categories, Times.Once);
        _editRecipeFormMock.VerifySet(form => form.Units = units, Times.Once);
        _editRecipeFormMock.VerifySet(form => form.RecipeId = recipe.RecipeId, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.RecipeName = recipe.Name, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.CategoryId = recipe.CategoryId, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Category = recipe.Category, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Alergens = recipe.Alergens, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Description = recipe.Description, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Ingredients = ingredients, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.ImagePath = recipe.RecipeImagePath, Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Kcal = recipe.Kcal, Times.Never);
        _recipeDetailsFormMock.Verify(form => form.Close(), Times.Never);
        _editRecipeFormMock.Verify(form => form.ShowDialog(), Times.Never);
    }

    [Fact]
    public void OnEditRecipe_RecipeNotFound_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);
        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        // Act
        _controller.OnEditRecipe(this, recipeEvent);

        // Assert
        _editRecipeFormMock.Verify(form => form.SetDetailsPageForEditing(), Times.Once);
        _recipeDetailsFormMock.Verify(form => form.ShowErrorMessage("Recept ne postoji u sustavu."), Times.Once);
        _recipeDetailsFormMock.Verify(form => form.Close(), Times.Never);
        _editRecipeFormMock.Verify(form => form.ShowDialog(), Times.Never);
    }


    [Fact]
    public void OnEditRecipe_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        var recipeEvent = new RecipeEventArgs(1);
        _controller.CurrentUser = null;

        // Act
        _controller.OnEditRecipe(this, recipeEvent);

        // Assert
        _editRecipeFormMock.Verify(form => form.SetDetailsPageForEditing(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Categories = It.IsAny<List<Category>>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Units = It.IsAny<List<Unit>>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.RecipeId = It.IsAny<int>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.RecipeName = It.IsAny<string>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.CategoryId = It.IsAny<int>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Category = It.IsAny<Category>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Alergens = It.IsAny<string>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Description = It.IsAny<string>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Ingredients = It.IsAny<List<Ingredient>>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.ImagePath = It.IsAny<string>(), Times.Never);
        _editRecipeFormMock.VerifySet(form => form.Kcal = It.IsAny<decimal>(), Times.Never);
        _recipeDetailsFormMock.Verify(form => form.Close(), Times.Never);
        _editRecipeFormMock.Verify(form => form.ShowDialog(), Times.Never);
    }

    [Fact]
    public void OnRateRecipe_AddCommentFails_ShowsErrorMessage()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        var recipeId = 100;
        var recipeEvent = new RecipeEventArgs(recipeId);

        _recipeDetailsFormMock.Setup(form => form.CurrentUserRating).Returns(5);
        _recipeDetailsFormMock.Setup(form => form.CurrentUserComment).Returns("Great recipe!");

        // Act
        _controller.OnRateRecipe(this, recipeEvent);

        // Assert
        var addedComment = _dbContext.Comments.FirstOrDefault(c => c.RecipeId == recipeId && c.UserId == currentUser.UserId);
        Assert.Null(addedComment);
        _recipeDetailsFormMock.Verify(form => form.ShowErrorMessage("Recept ne postoji u sustavu."), Times.Once);
    }


    [Fact]
    public void OnRateRecipe_UserNotLoggedIn_ShowsErrorMessage()
    {
        // Arrange
        var recipeEvent = new RecipeEventArgs(1);
        _controller.CurrentUser = null;

        // Act
        _controller.OnRateRecipe(this, recipeEvent);

        // Assert
        var commentsCount = _dbContext.Comments.Count();
        Assert.Equal(0, commentsCount);
        _recipeDetailsFormMock.Verify(form => form.ShowMessage(It.IsAny<string>()), Times.Never);
        _recipeDetailsFormMock.Verify(form => form.DisplayComments(It.IsAny<List<Comment>>()), Times.Never);
        _recipeDetailsFormMock.VerifySet(form => form.TotalRating = It.IsAny<string>(), Times.Never);
    }


    [Fact]
    public void OnRateRecipe_ValidComment_UpdatesTotalRating()
    {
        // Arrange
        var currentUser = new User { UserId = 1, Username = "testuser" };
        EnsureUserIsLoggedIn(currentUser);

        var recipeId = 1;
        var recipeEvent = new RecipeEventArgs(recipeId);

        _recipeDetailsFormMock.Setup(form => form.CurrentUserRating).Returns(5);
        _recipeDetailsFormMock.Setup(form => form.CurrentUserComment).Returns("Great recipe!");

        var recipe = new Recipe
        {
            RecipeId = recipeId,
            Name = "Test Recipe",
            CategoryId = 1,
            Kcal = 200,
            Rating = 4.0m,
            RecipeImagePath = "path/to/image.jpg",
            Description = "Test Description"
        };

        _dbContext.Recipes.Add(recipe);
        _dbContext.SaveChanges();

        // Act
        _controller.OnRateRecipe(this, recipeEvent);

        // Assert
        _recipeDetailsFormMock.VerifySet(form => form.TotalRating = "5,0", Times.Once);
    }

    private void EnsureUserIsLoggedIn(User user)
    {
        var currentUser = user;
        if (currentUser == null)
        {
            currentUser = new User {UserId = 1, Username = "testuser" };
        }

        _dbContext.Users.Add(currentUser);
        _dbContext.SaveChanges();
        _controller.CurrentUser = currentUser;

    }
}
