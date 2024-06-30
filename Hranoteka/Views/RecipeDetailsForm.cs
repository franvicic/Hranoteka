using Hranoteka.Data;
using Hranoteka.Utils;

namespace Hranoteka.Views;

public partial class RecipeDetailsForm : Form, IRecipeDetailsForm
{
    public event EventHandler<RecipeEventArgs> RateRecipeEvent;
    public event EventHandler<RecipeEventArgs> EditRecipeEvent;

    public RecipeDetailsForm()
    {
        InitializeComponent();

        btnEditMyRecipe.Click += (s, e) => EditRecipeEvent?.Invoke(this, new RecipeEventArgs(recipeId));
        rate.SaveCommentAndRateEvent += (s, e) => RateRecipeEvent?.Invoke(this, new RecipeEventArgs(recipeId));
        this.FormClosing += RecipeDetailsForm_FormClosing;
    }

    private void RecipeDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
    }

    private int recipeId;
    public int RecipeId
    {
        get { return recipeId; }
        set { recipeId = value; }
    }
    public string RecipeTitle
    {
        get { return lblTitle.Text; }
        set { lblTitle.Text = value; }
    }

    public Category Category
    {
        get { return lblCategory.Tag as Category; }
        set 
        { 
            lblCategory.Tag = value;
            lblCategory.Text = value.Name; 
        }
    }

    public string TotalCalories
    {
        get { return txtTotalCalories.Text; }
        set { txtTotalCalories.Text = value; }
    }

    public string TotalRating
    {
        get { return txtRating.Text; }
        set { txtRating.Text = value; }
    }

    public string ImagePath
    {
        get { return picRecipe.ImageLocation; }
        set 
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", value ?? "");
            if (File.Exists(imagePath))
            {
                picRecipe.ImageLocation = imagePath;
            }
            else
            {
                picRecipe.Image = Properties.Resources.undefined_recipe;
            }
        }
    }

    public string Description
    {
        get { return recipeDetails.Description; }
        set { recipeDetails.Description = value; }
    }

    public string Ingredients
    {
        get { return recipeDetails.Ingredients; }
        set { recipeDetails.Ingredients = value; }
    }

    public string Alergens
    {
        get { return recipeDetails.Alergens; }
        set { recipeDetails.Alergens = value; }
    }

    public int CurrentUserRating
    {
        get { return rate.Rating; }
        set { rate.Rating = value; }
    }

    public string CurrentUserComment
    {
        get { return rate.Comment; }
        set { rate.Comment = value; }
    }

    public void DisplayComments(List<Comment> comments)
    {
        commentsList.SetComments(comments);
    }


    public void SetEditButtonVisibility(bool isVisible)
    {
        btnEditMyRecipe.Visible = isVisible;
    }

    public void SetRateTabPageVisibility(bool isVisible)
    {
        if (isVisible)
        {
            if (!tabDetails.Contains(tabPageRate))
            {
                tabDetails.TabPages.Add(tabPageRate);
            }
        }
        else
        {
            if (tabDetails.Contains(tabPageRate))
            {
                tabDetails.TabPages.Remove(tabPageRate);
            }
        }
    }


    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }


}
