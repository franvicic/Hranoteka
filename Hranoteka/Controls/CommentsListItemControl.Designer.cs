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
            label23 = new Label();
            lblComment = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUsername.BackColor = Color.LightGray;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(632, 65);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 16);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Jura";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.BackColor = Color.LightGray;
            label21.Location = new Point(632, 46);
            label21.Name = "label21";
            label21.Size = new Size(84, 19);
            label21.TabIndex = 3;
            label21.Text = "Korisnik:";
            // 
            // lblRate
            // 
            lblRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRate.BackColor = Color.LightGray;
            lblRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRate.Location = new Point(632, 27);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(84, 19);
            lblRate.TabIndex = 2;
            lblRate.Text = "6/5";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.BackColor = Color.LightGray;
            label23.Location = new Point(632, 10);
            label23.Name = "label23";
            label23.Size = new Size(84, 17);
            label23.TabIndex = 1;
            label23.Text = "Ocjena:";
            // 
            // lblComment
            // 
            lblComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblComment.BackColor = Color.LightGray;
            lblComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComment.Location = new Point(10, 10);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(612, 71);
            lblComment.TabIndex = 0;
            lblComment.Text = "Odlična pizza! Volim je pripremati i teta Ana i Nikola su oduševljeni!";
            // 
            // CommentListItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUsername);
            Controls.Add(label21);
            Controls.Add(lblComment);
            Controls.Add(lblRate);
            Controls.Add(label23);
            Name = "CommentListItemControl";
            Size = new Size(730, 93);
            ResumeLayout(false);
        }

        #endregion
        private Label lblUsername;
        private Label label21;
        private Label lblRate;
        private Label label23;
        private Label lblComment;
    }
}
