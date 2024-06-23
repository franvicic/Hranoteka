namespace Hranoteka.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBase = new Panel();
            label4 = new Label();
            lnkGoToRegistration = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pnlBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.BackColor = Color.FromArgb(255, 224, 192);
            pnlBase.Controls.Add(label4);
            pnlBase.Controls.Add(lnkGoToRegistration);
            pnlBase.Controls.Add(btnLogin);
            pnlBase.Controls.Add(txtPassword);
            pnlBase.Controls.Add(label3);
            pnlBase.Controls.Add(txtUsername);
            pnlBase.Controls.Add(label1);
            pnlBase.Controls.Add(label2);
            pnlBase.Location = new Point(12, 12);
            pnlBase.Margin = new Padding(3, 2, 3, 2);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(322, 404);
            pnlBase.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 329);
            label4.Name = "label4";
            label4.Size = new Size(286, 27);
            label4.TabIndex = 7;
            label4.Text = "Novi korisnik?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkGoToRegistration
            // 
            lnkGoToRegistration.AutoSize = true;
            lnkGoToRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lnkGoToRegistration.Location = new Point(113, 359);
            lnkGoToRegistration.Margin = new Padding(3, 2, 3, 2);
            lnkGoToRegistration.Name = "lnkGoToRegistration";
            lnkGoToRegistration.Size = new Size(99, 21);
            lnkGoToRegistration.TabIndex = 6;
            lnkGoToRegistration.TabStop = true;
            lnkGoToRegistration.Text = "Registracija";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(120, 196);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Prijava";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(20, 155);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(286, 29);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 129);
            label3.Name = "label3";
            label3.Size = new Size(286, 27);
            label3.TabIndex = 3;
            label3.Text = "Lozinka:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(20, 86);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(286, 29);
            txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 44);
            label1.TabIndex = 0;
            label1.Text = "Prijavite se";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(286, 27);
            label2.TabIndex = 1;
            label2.Text = "Korisničko ime:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(349, 430);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka - prijava";
            pnlBase.ResumeLayout(false);
            pnlBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Label label4;
        private LinkLabel lnkGoToRegistration;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
    }
}