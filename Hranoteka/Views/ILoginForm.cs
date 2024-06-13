namespace Hranoteka.Views;

public interface ILoginForm : IForm
{
    string Username { get; }
    string Password { get; }

    event EventHandler LoginEvent;
    event EventHandler GoToRegistrationEvent;

}
