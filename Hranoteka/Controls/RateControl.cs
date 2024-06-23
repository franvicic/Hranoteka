namespace Hranoteka.Controls;

public partial class RateControl : UserControl
{
    public RateControl()
    {
        InitializeComponent();

        btnSaveCommentAndRate.Click += btnSaveCommentAndRate_Click;
    }

    public int Rating
    {
        get
        {
            if (rad1.Checked) return 1;
            if (rad2.Checked) return 2;
            if (rad3.Checked) return 3;
            if (rad4.Checked) return 4;
            if (rad5.Checked) return 5;
            return 0; 
        }
        set
        {
            switch (value)
            {
                case 1:
                    rad1.Checked = true;
                    break;
                case 2:
                    rad2.Checked = true;
                    break;
                case 3:
                    rad3.Checked = true;
                    break;
                case 4:
                    rad4.Checked = true;
                    break;
                case 5:
                    rad5.Checked = true;
                    break;
                default:
                    rad1.Checked = false;
                    rad2.Checked = false;
                    rad3.Checked = false;
                    rad4.Checked = false;
                    rad5.Checked = false;
                    break;
            }
        }
    }

    public string Comment
    {
        get { return txtComment.Text; }
        set { txtComment.Text = value; }
    }

    // Događaj za spremanje ocjene i komentara
    public event EventHandler SaveCommentAndRateEvent;

    private void btnSaveCommentAndRate_Click(object sender, EventArgs e)
    {
        SaveCommentAndRateEvent?.Invoke(this, EventArgs.Empty);
    }


}
