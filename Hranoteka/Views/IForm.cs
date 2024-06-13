namespace Hranoteka.Views;

public interface IForm
{
    void Show();
    DialogResult ShowDialog();
    void Hide();
    void Close();
    void ShowMessage(string message);

    void ShowErrorMessage(string message);
}
