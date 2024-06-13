namespace Hranoteka.Views
{
    partial class RegistrationForm
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
            panel1 = new Panel();
            lnkLogin = new LinkLabel();
            chkIAcceptTermsAndConditions = new CheckBox();
            txtRepeatPassword = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            label7 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            btnRegister = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(lnkLogin);
            panel1.Controls.Add(chkIAcceptTermsAndConditions);
            panel1.Controls.Add(txtRepeatPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 30);
            panel1.Margin = new Padding(7, 5, 7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1547, 1047);
            panel1.TabIndex = 2;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLogin.Location = new Point(697, 965);
            lnkLogin.Margin = new Padding(7, 0, 7, 0);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(140, 54);
            lnkLogin.TabIndex = 8;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "prijava";
            // 
            // chkIAcceptTermsAndConditions
            // 
            chkIAcceptTermsAndConditions.AutoSize = true;
            chkIAcceptTermsAndConditions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIAcceptTermsAndConditions.Location = new Point(447, 768);
            chkIAcceptTermsAndConditions.Margin = new Padding(7, 5, 7, 5);
            chkIAcceptTermsAndConditions.Name = "chkIAcceptTermsAndConditions";
            chkIAcceptTermsAndConditions.Size = new Size(579, 58);
            chkIAcceptTermsAndConditions.TabIndex = 6;
            chkIAcceptTermsAndConditions.Text = "Pristajem na uvjete korištenja";
            chkIAcceptTermsAndConditions.UseVisualStyleBackColor = true;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepeatPassword.Location = new Point(36, 615);
            txtRepeatPassword.Margin = new Padding(7, 5, 7, 5);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '*';
            txtRepeatPassword.Size = new Size(708, 61);
            txtRepeatPassword.TabIndex = 2;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 549);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(714, 68);
            label6.TabIndex = 19;
            label6.Text = "Ponovi lozniku:";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(797, 615);
            txtCountry.Margin = new Padding(7, 5, 7, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(708, 61);
            txtCountry.TabIndex = 5;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(797, 549);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(714, 68);
            label7.TabIndex = 15;
            label7.Text = "Država:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(797, 432);
            txtLastName.Margin = new Padding(7, 5, 7, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(708, 61);
            txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(797, 366);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(714, 68);
            label4.TabIndex = 13;
            label4.Text = "Prezime:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(797, 257);
            txtFirstName.Margin = new Padding(7, 5, 7, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(708, 61);
            txtFirstName.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(797, 191);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(714, 68);
            label5.TabIndex = 11;
            label5.Text = "Ime:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(36, 432);
            txtPassword.Margin = new Padding(7, 5, 7, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(708, 61);
            txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 366);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(714, 68);
            label3.TabIndex = 9;
            label3.Text = "Lozinka:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(36, 257);
            txtUsername.Margin = new Padding(7, 5, 7, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(708, 61);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 191);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(714, 68);
            label2.TabIndex = 7;
            label2.Text = "Korisničko ime:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(415, 845);
            btnRegister.Margin = new Padding(7, 5, 7, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(670, 104);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Registracija";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 0);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(1540, 109);
            label1.TabIndex = 0;
            label1.Text = "Registracija";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 1107);
            Controls.Add(panel1);
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka - registracija";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkIAcceptTermsAndConditions;
        private TextBox txtRepeatPassword;
        private Label label6;
        private TextBox txtCountry;
        private Label label7;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Button btnRegister;
        private Label label1;
        private LinkLabel lnkLogin;
    }
}