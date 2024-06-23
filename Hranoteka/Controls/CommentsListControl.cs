using Hranoteka.Data;

namespace Hranoteka.Controls;

public partial class CommentsListControl : UserControl
{
    public CommentsListControl()
    {
        InitializeComponent();
    }

    private int currentCommentsTop = 5;
    public void AddComment(Comment comment)
    {
        var commentItem = new CommentsListItemControl
        {
            Comment = comment.Text,
            Rating = comment.Rating.ToString(),
            Username = comment.Author.Username
        };
        commentItem.Top = currentCommentsTop;
        commentItem.Left = 5;
        commentItem.Width = pnlContent.Width - 10;
        pnlContent.Controls.Add(commentItem);
        currentCommentsTop += commentItem.Height + 5;
        //
        pnlContent.Height = currentCommentsTop + 5;
    }

    public void SetComments(List<Comment> comments)
    {
        pnlContent.Controls.Clear();
        currentCommentsTop = 5;
        pnlBase.Width = Width;
        pnlContent.Width = pnlBase.Width - 50;
        pnlContent.Height = currentCommentsTop + 5;
        foreach (var comment in comments)
        {
            AddComment(comment);
        }
    }
}
