namespace Hranoteka.Controls;

public partial class RecipesListItemControl : UserControl
{
    private int _id;

    public RecipesListItemControl()
    {
        InitializeComponent();
        btnOpenRecipe.Click += btnOpenRecipe_Click;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Title
    {
        get => lblTitle.Text;
        set => lblTitle.Text = value;
    }

    //public string Description
    //{
    //    get => lblDescription.Text;
    //    set => lblDescription.Text = value;
    //}

    public string Author
    {
        get => lblAuthor.Text;
        set => lblAuthor.Text = value;
    }

    public string ImagePath
    {
        get => picRecipe.ImageLocation;
        set => picRecipe.ImageLocation = value;
    }


    public event EventHandler LoadDetailsEvent;

    private void btnOpenRecipe_Click(object sender, EventArgs e)
    {
        LoadDetailsEvent?.Invoke(this, EventArgs.Empty);
    }
}
