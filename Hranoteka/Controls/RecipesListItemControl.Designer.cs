namespace Hranoteka.Controls
{
    partial class RecipesListItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesListItemControl));
            lblAuthor = new Label();
            lblTitle = new Label();
            picRecipe = new PictureBox();
            btnOpenRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)picRecipe).BeginInit();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.FromArgb(255, 192, 128);
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(439, 9);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(200, 82);
            lblAuthor.TabIndex = 21;
            lblAuthor.Text = "Autor recepta";
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 192, 128);
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(105, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 82);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Naziv i opis recepta";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picRecipe
            // 
            picRecipe.BackColor = Color.FromArgb(192, 192, 0);
            picRecipe.Image = (Image)resources.GetObject("picRecipe.Image");
            picRecipe.Location = new Point(8, 9);
            picRecipe.Margin = new Padding(3, 2, 3, 2);
            picRecipe.Name = "picRecipe";
            picRecipe.Size = new Size(91, 82);
            picRecipe.SizeMode = PictureBoxSizeMode.StretchImage;
            picRecipe.TabIndex = 19;
            picRecipe.TabStop = false;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.BackColor = Color.DodgerBlue;
            btnOpenRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenRecipe.ForeColor = Color.White;
            btnOpenRecipe.Location = new Point(645, 9);
            btnOpenRecipe.Margin = new Padding(3, 2, 3, 2);
            btnOpenRecipe.Name = "btnOpenRecipe";
            btnOpenRecipe.Size = new Size(100, 82);
            btnOpenRecipe.TabIndex = 22;
            btnOpenRecipe.Text = "Otvori";
            btnOpenRecipe.UseVisualStyleBackColor = false;
            // 
            // RecipesListItemControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(btnOpenRecipe);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(picRecipe);
            Name = "RecipesListItemControl";
            Size = new Size(752, 102);
            ((System.ComponentModel.ISupportInitialize)picRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAuthor;
        private Label lblTitle;
        private PictureBox picRecipe;
        private Button btnOpenRecipe;
    }
}
