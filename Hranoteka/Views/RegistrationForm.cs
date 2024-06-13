namespace Hranoteka.Views;

public partial class RegistrationForm : Form, IRegistrationForm
{
    public RegistrationForm()
    {
        InitializeComponent();
        btnRegister.Click += (s, e) => RegisterEvent?.Invoke(s, e);
        lnkLogin.Click += (s, e) => LoginEvent?.Invoke(s, e);
    }

    public string Username => txtUsername.Text;
    public string Password => txtPassword.Text;
    public string RepeatPassword => txtRepeatPassword.Text;
    public string FirstName => txtFirstName.Text;
    public string LastName => txtLastName.Text;
    public string Country => txtCountry.Text;
    public bool AcceptTerms => chkIAcceptTermsAndConditions.Checked;

    public event EventHandler RegisterEvent;
    public event EventHandler LoginEvent;

    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
