using Hranoteka.Data;

namespace Hranoteka.Controls;

public partial class RecipeTemplate1Control : UserControl
{
    public RecipeTemplate1Control()
    {
        InitializeComponent();

        btnAddIngredientToList.Click += btnAddIngredientToList_Click;
        btnLoadImage.Click += btnLoadImage_Click;
    }

    private void BtnLoadImage_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
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
        get { return txtDescription.Text; }
        set { txtDescription.Text = value; }
    }

    public decimal Kcal
    {
        get { return nudKcal.Value; }
        set { nudKcal.Value = value; }
    }

    public string ImagePath
    {
        get { return picImage.ImageLocation; }
        set { picImage.ImageLocation = value; }
    }

    public List<string> Ingredients
    {
        get
        {
            var ingredients = new List<string>();
            foreach (var item in lstIngredients.Items)
            {
                ingredients.Add(item.ToString());
            }
            return ingredients;
        }
        set
        {
            lstIngredients.Items.Clear();
            if (value != null)
            {
                foreach (var ingredient in value)
                {
                    lstIngredients.Items.Add(ingredient);
                }
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

    public List<Unit> Units
    {
        set
        {
            cmbUnit.DataSource = null;
            cmbUnit.DataSource = value;
            cmbUnit.DisplayMember = nameof(Data.Unit.Name);
            cmbUnit.ValueMember = nameof(Data.Unit.UnitId);
        }
    }

    public event EventHandler LoadImageEvent;

    private void btnLoadImage_Click(object sender, EventArgs e)
    {
        LoadImageEvent?.Invoke(this, EventArgs.Empty);
    }

    private void btnAddIngredientToList_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtIngredientName.Text) || nudAmount.Value <= 0)
        {
            MessageBox.Show("Da bi dodali namirnicu, namirnica treba imati naziv i količinu..", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lstIngredients.Items.Add($"{txtIngredientName.Text} - {nudAmount.Value} {cmbUnit.Text}");
        txtIngredientName.Text = "";
    }

}
