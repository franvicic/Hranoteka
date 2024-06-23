namespace Hranoteka.Views
{
    partial class ProfileForm
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
            label5 = new Label();
            txtCountry = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            picProfile = new PictureBox();
            btnChangePicture = new Button();
            btnSaveProfile = new Button();
            label6 = new Label();
            label7 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            label8 = new Label();
            txtNewPasswordRepeat = new TextBox();
            label9 = new Label();
            btnChangePassword = new Button();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(169, 11);
            label5.Name = "label5";
            label5.Size = new Size(522, 29);
            label5.TabIndex = 39;
            label5.Text = "Moj profil";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(180, 266);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(505, 29);
            txtCountry.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(180, 239);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 37;
            label4.Text = "Država:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(180, 206);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(505, 29);
            txtLastName.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 179);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 35;
            label3.Text = "Prezime:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(180, 145);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(505, 29);
            txtFirstName.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 118);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 33;
            label1.Text = "Ime:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(180, 85);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(505, 29);
            txtUsername.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 58);
            label2.Name = "label2";
            label2.Size = new Size(221, 21);
            label2.TabIndex = 31;
            label2.Text = "Korisničko ime (javno vidljivo):";
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(192, 192, 0);
            picProfile.Location = new Point(12, 11);
            picProfile.Margin = new Padding(3, 2, 3, 2);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(151, 123);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 30;
            picProfile.TabStop = false;
            // 
            // btnChangePicture
            // 
            btnChangePicture.BackColor = Color.DodgerBlue;
            btnChangePicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePicture.ForeColor = Color.White;
            btnChangePicture.Location = new Point(12, 138);
            btnChangePicture.Margin = new Padding(3, 2, 3, 2);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(151, 38);
            btnChangePicture.TabIndex = 41;
            btnChangePicture.Text = "Izmijeni sliku";
            btnChangePicture.UseVisualStyleBackColor = false;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.DodgerBlue;
            btnSaveProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(534, 311);
            btnSaveProfile.Margin = new Padding(3, 2, 3, 2);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(151, 38);
            btnSaveProfile.TabIndex = 42;
            btnSaveProfile.Text = "Spremi";
            btnSaveProfile.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 350);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 43;
            label6.Text = "Izmjena šifre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 385);
            label7.Name = "label7";
            label7.Size = new Size(108, 21);
            label7.TabIndex = 44;
            label7.Text = "Trenutna šifra:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPassword.Location = new Point(12, 408);
            txtCurrentPassword.Margin = new Padding(3, 2, 3, 2);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(210, 29);
            txtCurrentPassword.TabIndex = 45;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(243, 408);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(210, 29);
            txtNewPassword.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(243, 385);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 46;
            label8.Text = "Nova šifra:";
            // 
            // txtNewPasswordRepeat
            // 
            txtNewPasswordRepeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPasswordRepeat.Location = new Point(475, 408);
            txtNewPasswordRepeat.Margin = new Padding(3, 2, 3, 2);
            txtNewPasswordRepeat.Name = "txtNewPasswordRepeat";
            txtNewPasswordRepeat.PasswordChar = '*';
            txtNewPasswordRepeat.Size = new Size(210, 29);
            txtNewPasswordRepeat.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(475, 385);
            label9.Name = "label9";
            label9.Size = new Size(134, 21);
            label9.TabIndex = 48;
            label9.Text = "Ponovi novu šifru:";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DodgerBlue;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(534, 457);
            btnChangePassword.Margin = new Padding(3, 2, 3, 2);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(151, 38);
            btnChangePassword.TabIndex = 50;
            btnChangePassword.Text = "Izmijeni šifru";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(705, 506);
            Controls.Add(btnChangePassword);
            Controls.Add(txtNewPasswordRepeat);
            Controls.Add(label9);
            Controls.Add(txtNewPassword);
            Controls.Add(label8);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnSaveProfile);
            Controls.Add(btnChangePicture);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(picProfile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka - moj profil";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtCountry;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private PictureBox picProfile;
        private Button btnChangePicture;
        private Button btnSaveProfile;
        private Label label6;
        private Label label7;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private Label label8;
        private TextBox txtNewPasswordRepeat;
        private Label label9;
        private Button btnChangePassword;
    }
}