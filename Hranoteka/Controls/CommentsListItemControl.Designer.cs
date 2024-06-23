namespace Hranoteka.Controls
{
    partial class CommentsListItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            label21 = new Label();
            lblRate = new Label();
            lblComment = new Label();
            label23 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.LightGray;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(553, 74);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Jura";
            // 
            // label21
            // 
            label21.BackColor = Color.LightGray;
            label21.Location = new Point(553, 54);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 3;
            label21.Text = "Korisnik:";
            // 
            // lblRate
            // 
            lblRate.BackColor = Color.LightGray;
            lblRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRate.Location = new Point(553, 27);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(100, 27);
            lblRate.TabIndex = 2;
            lblRate.Text = "6/5";
            // 
            // lblComment
            // 
            lblComment.BackColor = Color.LightGray;
            lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComment.Location = new Point(0, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(542, 100);
            lblComment.TabIndex = 0;
            lblComment.Text = "Odlična pizza! Volim je pripremati i teta Ana i Nikola su oduševljeni!";
            // 
            // label23
            // 
            label23.BackColor = Color.LightGray;
            label23.Location = new Point(553, 0);
            label23.Name = "label23";
            label23.Size = new Size(100, 27);
            label23.TabIndex = 6;
            label23.Text = "Ocjena:";
            // 
            // CommentsListItemControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(lblUsername);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(lblRate);
            Controls.Add(lblComment);
            Name = "CommentsListItemControl";
            Size = new Size(661, 103);
            SizeChanged += CommentsListItemControl_SizeChanged;
            ResumeLayout(false);
        }

        #endregion
        private Label lblUsername;
        private Label label21;
        private Label lblRate;
        private Label lblComment;
        private Label label23;
    }
}
