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
            Username = comment.Author
        };
        commentItem.Top = currentCommentsTop;
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
        pnlContent.Width = pnlBase.Width - 70;
        foreach (var comment in comments)
        {
            AddComment(comment);
        }
    }
}
