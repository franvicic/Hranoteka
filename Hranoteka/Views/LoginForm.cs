using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hranoteka.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += (s, e) => LoginEvent?.Invoke(s, e);
            lnkGoToRegistration.Click += (s, e) => GoToRegistrationEvent?.Invoke(s, e);
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public event EventHandler LoginEvent;
        public event EventHandler GoToRegistrationEvent;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
