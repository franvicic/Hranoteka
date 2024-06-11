namespace Hranoteka.Controls;

public partial class CommentsListItemControl : UserControl
{
    public CommentsListItemControl()
    {
        InitializeComponent();
    }

    // Property za komentar
    public string Comment
    {
        get { return lblComment.Text; }
        set { lblComment.Text = value; }
    }

    // Property za ocjenu
    public string Rating
    {
        get { return lblRate.Text; }
        set { lblRate.Text = value; }
    }

    // Property za korisničko ime
    public string Username
    {
        get { return lblUsername.Text; }
        set { lblUsername.Text = value; }
    }
}
