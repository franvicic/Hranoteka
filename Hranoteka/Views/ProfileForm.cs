namespace Hranoteka.Views;

public partial class ProfileForm : Form, IProfileForm
{
    public event EventHandler SaveProfileEvent;
    public event EventHandler ChangePasswordEvent;
    public event EventHandler ChangeImageEvent;

    public ProfileForm()
    {
        InitializeComponent();

        btnSaveProfile.Click += (s, e) => SaveProfileEvent?.Invoke(s, e);
        btnChangePassword.Click += (s, e) => ChangePasswordEvent?.Invoke(s, e);
        btnChangePicture.Click += (s, e) => ChangeImageEvent?.Invoke(s, e);
        this.FormClosing += ProfileForm_FormClosing;
    }

    private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
    }

    public string Username
    {
        get { return txtUsername.Text; }
        set { txtUsername.Text = value; }
    }

    public string FirstName
    {
        get { return txtFirstName.Text; }
        set { txtFirstName.Text = value; }
    }

    public string LastName
    {
        get { return txtLastName.Text; }
        set { txtLastName.Text = value; }
    }

    public string Country
    {
        get { return txtCountry.Text; }
        set { txtCountry.Text = value; }
    }

    public string CurrentPassword
    {
        get { return txtCurrentPassword.Text; }
    }

    public string NewPassword
    {
        get { return txtNewPassword.Text; }
    }

    public string NewPasswordRepeat
    {
        get { return txtNewPasswordRepeat.Text; }
    }

    public string ProfileImagePath
    {
        get { return picProfile.ImageLocation; }
        set
        {
            if (value != null)
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", value);
                if (File.Exists(imagePath))
                {
                    picProfile.ImageLocation = imagePath;
                }
                else
                {
                    picProfile.Image = Properties.Resources.profile;
                }
            }
            else
            {
                picProfile.Image = Properties.Resources.profile;
            }
        }
    }

    public DialogResult ShowOpenFileDialog()
    {
        using (var openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SelectedFilePath = openFileDialog.FileName;
            }
            return result;
        }
    }

    public string SelectedFilePath { get; private set; }

    public void ResetPasswords()
    {
        txtCurrentPassword.Text = string.Empty;
        txtNewPassword.Text = string.Empty;
        txtNewPasswordRepeat.Text = string.Empty;
    }

    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public FileInfo CreateFileInfo(string fileName)
    {
        return new FileInfo(fileName);
    }
}
