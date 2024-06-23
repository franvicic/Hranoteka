namespace Hranoteka.Views;

public interface IProfileForm : IForm
{
    event EventHandler SaveProfileEvent;
    event EventHandler ChangePasswordEvent;
    event EventHandler ChangeImageEvent;

    string Username { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Country { get; set; }
    string CurrentPassword { get; }
    string NewPassword { get; }
    string NewPasswordRepeat { get; }
    string ProfileImagePath { get; set; }

    void ResetPasswords();

    DialogResult ShowOpenFileDialog();
    string SelectedFilePath { get; }

    FileInfo CreateFileInfo(string fileName);
}
