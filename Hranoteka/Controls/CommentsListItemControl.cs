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

    private void CommentsListItemControl_SizeChanged(object sender, EventArgs e)
    {
        //lblComment.Width = this.Width - 210;
        //label23.Left = this.Width - 200;
        //label21.Left = this.Width - 200;
        //lblRate.Left = this.Width - 200;
        //lblUsername.Left = this.Width - 200;
    }
}
