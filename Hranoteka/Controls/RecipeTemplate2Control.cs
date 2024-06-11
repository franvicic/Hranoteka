using Hranoteka.Data;

namespace Hranoteka.Controls;

public partial class RecipeTemplate2Control : UserControl
{
    public event EventHandler LoadImageEvent;

    public RecipeTemplate2Control()
    {
        InitializeComponent();
    }

    public string RecipeName
    {
        get { return txtRecipeName.Text; }
        set { txtRecipeName.Text = value; }
    }

    public string SelectedCategory
    {
        get { return cmbCategory.SelectedText; }
        set { cmbCategory.SelectedText = value; }
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

    public List<string> Ingredients
    {
        get
        {
            return txtIngredients.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }
        set
        {
            txtIngredients.Text = value == null? null : string.Join(Environment.NewLine, value);
        }
    }

    public string ImagePath
    {
        get { return picImage.ImageLocation; }
        set { picImage.ImageLocation = value; }
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
