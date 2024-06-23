using Hranoteka.Data;

namespace Hranoteka.Controls;

public partial class RecipeTemplate2Control : UserControl
{
    public event EventHandler LoadImageEvent;

    public RecipeTemplate2Control()
    {
        InitializeComponent();
        btnLoadImage.Click += btnLoadImage_Click;
    }

    private int recipeId;
    public int RecipeId
    {
        get { return recipeId; }
        set { recipeId = value; }
    }

    public string RecipeName
    {
        get { return txtRecipeName.Text; }
        set { txtRecipeName.Text = value; }
    }

    public Category SelectedCategory
    {
        get { return cmbCategory.SelectedItem as Category; }
        set { cmbCategory.SelectedItem = value; }
    }

    public int SelectedCategoryId
    {
        get { return (int)cmbCategory.SelectedValue; }
        set { cmbCategory.SelectedValue = value; }
    }

    public string Alergens
    {
        get { return txtAlergens.Text; }
        set { txtAlergens.Text = value; }
    }

    public string Description
    {
        get { return txtPreparation.Text; }
        set { txtPreparation.Text = value; }
    }

    public decimal Kcal
    {
        get { return nudKcal.Value; }
        set { nudKcal.Value = value; }
    }

    public List<Ingredient> Ingredients
    {
        get
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            var list = txtIngredients.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .ToList();
            foreach ( var item in list)
            {
                ingredients.Add(new Ingredient { RecipeId = recipeId, Description = item });
            }
            return ingredients;
        }
        set
        {
            txtIngredients.Text = value == null 
                ? null 
                : string.Join(Environment.NewLine, value.Select(x => x.Description).ToList());
        }
    }

    public string ImagePath
    {
        get { return picImage.ImageLocation; }
        set
        {
            if (value != null)
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", value);
                if (File.Exists(imagePath))
                {
                    picImage.ImageLocation = imagePath;
                }
                else
                {
                    picImage.Image = Properties.Resources.undefined_recipe;
                }
            }
            else
            {
                picImage.Image = Properties.Resources.undefined_recipe;
            }
        }
    }

    public List<Category> Categories
    {
        set
        {
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = value;
            cmbCategory.DisplayMember = nameof(Data.Category.Name);
            cmbCategory.ValueMember = nameof(Data.Category.CategoryId);
        }
    }


    private void btnLoadImage_Click(object sender, EventArgs e)
    {
        LoadImageEvent?.Invoke(this, EventArgs.Empty);
    }
}
