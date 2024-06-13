using Hranoteka.Data;
using Hranoteka.Utils;
using System.Windows.Forms;

namespace Hranoteka.Views;

public partial class EditRecipeForm : Form, IEditRecipeForm
{
    public event EventHandler SaveRecipeEvent;
    public event EventHandler<RecipeEventArgs> LoadImageEvent;

    public EditRecipeForm()
    {
        InitializeComponent();

        btnSaveRecipe.Click += (s, e) => SaveRecipeEvent?.Invoke(s, e);
        recipeTemplate1.LoadImageEvent += (s, e) => LoadImageEvent?.Invoke(this, new RecipeEventArgs(recipeId));
        recipeTemplate2.LoadImageEvent += (s, e) => LoadImageEvent?.Invoke(this, new RecipeEventArgs(recipeId));
        this.FormClosing += EditRecipeForm_FormClosing;
    }

    private void EditRecipeForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
    }

    public string Title
    {
        get
        {
            return lblEditRecipeTitle.Text;
        }
        set
        {
            lblEditRecipeTitle.Text = value;
        }
    }

    private int recipeId;
    public int RecipeId
    {
        get
        {
            return recipeId;
        }
        set
        {
            recipeId = value;
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.RecipeId = value;
                recipeTemplate2.RecipeId = 0;
            }
            else
            {
                recipeTemplate2.RecipeId = value;
                recipeTemplate1.RecipeId = 0;
            }
        }
    }

    public string RecipeName
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.RecipeName : recipeTemplate2.RecipeName;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.RecipeName = value;
                recipeTemplate2.RecipeName = null;
            }
            else
            {
                recipeTemplate2.RecipeName = value;
                recipeTemplate1.RecipeName = null;
            }
        }
    }

    public int CategoryId
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.SelectedCategoryId : recipeTemplate2.SelectedCategoryId;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.SelectedCategoryId = value;
                recipeTemplate2.SelectedCategoryId = 0;
            }
            else
            {
                recipeTemplate2.SelectedCategoryId = value;
                recipeTemplate1.SelectedCategoryId = 0;
            }
        }
    }

    public Category Category
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.SelectedCategory : recipeTemplate2.SelectedCategory;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.SelectedCategory = value;
                recipeTemplate2.SelectedCategory = null;
            }
            else
            {
                recipeTemplate2.SelectedCategory = value;
                recipeTemplate1.SelectedCategory = null;
            }
        }
    }

    public string Alergens
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.Alergens : recipeTemplate2.Alergens;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.Alergens = value;
                recipeTemplate2.Alergens = null;
            }
            else
            {
                recipeTemplate2.Alergens = value;
                recipeTemplate1.Alergens = null;
            }
        }
    }

    public decimal Kcal
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.Kcal : recipeTemplate2.Kcal;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.Kcal = value;
                recipeTemplate2.Kcal = 0m;
            }
            else
            {
                recipeTemplate2.Kcal = value;
                recipeTemplate1.Kcal = 0m;
            }
        }
    }

    public string Description
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.Description : recipeTemplate2.Description;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.Description = value;
                recipeTemplate2.Description = null;
            }
            else
            {
                recipeTemplate2.Description = value;
                recipeTemplate1.Description = null;
            }
        }
    }

    public List<Ingredient> Ingredients
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.Ingredients : recipeTemplate2.Ingredients;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.Ingredients = value;
                recipeTemplate2.Ingredients = null;
            }
            else
            {
                recipeTemplate2.Ingredients = value;
                recipeTemplate1.Ingredients = null;
            }
        }
    }

    public string ImagePath
    {
        get
        {
            return tabs.SelectedTab == tabPageTemplate1 ? recipeTemplate1.ImagePath : recipeTemplate2.ImagePath;
        }
        set
        {
            if (tabs.SelectedTab == tabPageTemplate1)
            {
                recipeTemplate1.ImagePath = value;
                recipeTemplate2.ImagePath = null;
            }
            else
            {
                recipeTemplate2.ImagePath = value;
                recipeTemplate1.ImagePath = null;
            }
        }
    }

    public List<Category> Categories
    {
        set
        {
            recipeTemplate1.Categories = value;
            recipeTemplate2.Categories = value;
        }
    }

    public List<Unit> Units
    {
        set
        {
            recipeTemplate1.Units = value;
        }
    }

    public void SetDetailsPageForEditing()
    {
        ResetFields();

        Title = "Izmjena recepta";

        tabs.TabPages.Clear();
        tabPageTemplate2.Text = "Izmjena";
        tabs.TabPages.Add(tabPageTemplate2);
        tabs.SelectedTab = tabPageTemplate2;
    }

    public void SetDetailsPageForAdding()
    {
        ResetFields();

        Title = "Novi recept";

        tabs.TabPages.Clear();
        tabPageTemplate1.Text = "Predložak 1";
        tabs.TabPages.Add(tabPageTemplate1);
        tabPageTemplate2.Text = "Predložak 2";
        tabs.TabPages.Add(tabPageTemplate2);
        tabs.SelectedTab = tabPageTemplate1;
    }

    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void ResetFields()
    {
        recipeId = 0;

        lblEditRecipeTitle.Text = "";

        recipeTemplate1.RecipeName = "";
        recipeTemplate2.RecipeName = "";

        recipeTemplate1.SelectedCategoryId = 0;
        recipeTemplate2.SelectedCategoryId = 0;

        recipeTemplate1.SelectedCategory = null;
        recipeTemplate2.SelectedCategory = null;

        recipeTemplate1.Ingredients = null;
        recipeTemplate2.Ingredients = null;

        recipeTemplate1.Alergens = "";
        recipeTemplate2.Alergens = "";

        recipeTemplate1.Kcal = 0m;
        recipeTemplate2.Kcal = 0m;

        recipeTemplate1.Description = "";
        recipeTemplate2.Description = "";

        recipeTemplate1.ImagePath = "";
        recipeTemplate2.ImagePath = "";
    }
}
