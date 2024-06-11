namespace Hranoteka.Controls;

public partial class RecipeDetailsControl : UserControl
{
    public RecipeDetailsControl()
    {
        InitializeComponent();
    }

    public string Description
    {
        get { return txtDescription.Text; }
        set { txtDescription.Text = value; }
    }

    public string Ingredients
    {
        get { return txtIngredients.Text; }
        set { txtIngredients.Text = value; }
    }

    public string Alergens
    {
        get { return txtAlergens.Text; }
        set { txtAlergens.Text = value; }
    }
}
