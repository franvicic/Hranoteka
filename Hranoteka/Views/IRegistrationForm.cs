namespace Hranoteka.Views;

public interface IRegistrationForm : IForm
{
    string Username { get; }
    string Password { get; }
    string RepeatPassword { get; }
    string FirstName { get; }
    string LastName { get; }
    string Country { get; }
    bool AcceptTerms { get; }

    event EventHandler RegisterEvent;
    event EventHandler LoginEvent;
}
