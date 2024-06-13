using Hranoteka.Controls;
using Hranoteka.Data;
using Hranoteka.Utils;

namespace Hranoteka.Views;

public partial class MainForm : Form, IMainForm
{
    public string SearchText => txtRecipesSearch.Text;
    public bool CurrentRecipesOnly => chkMyRecipes.Checked;

    public event EventHandler AddNewRecipeEvent;
    //public event EventHandler MyRecipesEvent;
    public event EventHandler SearchRecipesEvent;
    public event EventHandler LoadProfileEvent;
    public event EventHandler LoadRecipeDetailsEvent;
    public event EventHandler<RecipeEventArgs> RecipeLoadDetailsEvent;

    public MainForm()
    {
        InitializeComponent();

        btnAddNewRecipe.Click += (s, e) => AddNewRecipeEvent?.Invoke(s, e);
        //chkMyRecipes.Click += (s, e) => MyRecipesEvent?.Invoke(s, e);
        btnSearchRecipes.Click += (s, e) => SearchRecipesEvent?.Invoke(s, e);
        btnShowMyProfile.Click += (s, e) => LoadProfileEvent?.Invoke(s, e); 
    }

    public void PopulateUserData(User user)
    {
        lblTitle.Text = $"Bok, {user.Username}!";

        if (!string.IsNullOrWhiteSpace(user.ProfileImagePath))
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", user.ProfileImagePath);
            if (File.Exists(imagePath))
            {
                picProfile.ImageLocation = imagePath;
            }
            else
            {
                picProfile.Image = Properties.Resources.profile;
            }
        }
        else
        {
            picProfile.Image = Properties.Resources.profile;
        }
    }

    public void DisplayRecipes(List<Recipe> recipes)
    {
        UnregisterLoadDetailsEvents();
        pnlContent.Controls.Clear();
        int currentTop = 5;
        pnlContent.Width = pnlBase.Width - 70;
        pnlContent.Height = currentTop + 5;
        foreach (var recipe in recipes)
        {
            var recipeControl = new RecipesListItemControl
            {
                Id = recipe.RecipeId,
                Title = recipe.Name,
                //Description = recipe.Description,
                Author = recipe.Author.Username,
                ImagePath = recipe.RecipeImagePath
            };
            recipeControl.LoadDetailsEvent += RecipeLoadDetailsEventHandler;
            recipeControl.Top = currentTop;
            recipeControl.Width = pnlContent.Width - 10;

            pnlContent.Controls.Add(recipeControl);

            currentTop += recipeControl.Height + 5;
            //
            pnlContent.Height = currentTop + 5;
        }
    }

    private void UnregisterLoadDetailsEvents()
    {
        foreach (Control control in pnlContent.Controls)
        {
            if (control is RecipesListItemControl recipeControl)
            {
                recipeControl.LoadDetailsEvent -= RecipeLoadDetailsEventHandler;
            }
        }
    }

    private void RecipeLoadDetailsEventHandler(object sender, EventArgs e)
    {
        if (sender is RecipesListItemControl recipeControl)
        {
            RecipeLoadDetailsEvent?.Invoke(this, new RecipeEventArgs(recipeControl.Id));
        }
    }

    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }


}
