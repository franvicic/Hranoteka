namespace Hranoteka.Views
{
    partial class RecipeDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetailsForm));
            txtRating = new TextBox();
            label4 = new Label();
            txtTotalCalories = new TextBox();
            lblCategory = new Label();
            picRecipe = new PictureBox();
            label2 = new Label();
            lblTitle = new Label();
            tabDetails = new TabControl();
            tabPageDetails = new TabPage();
            recipeDetails = new Controls.RecipeDetailsControl();
            tabPageComments = new TabPage();
            commentsList = new Controls.CommentsListControl();
            tabPageRate = new TabPage();
            rate = new Controls.RateControl();
            btnEditMyRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)picRecipe).BeginInit();
            tabDetails.SuspendLayout();
            tabPageDetails.SuspendLayout();
            tabPageComments.SuspendLayout();
            tabPageRate.SuspendLayout();
            SuspendLayout();
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRating.Location = new Point(29, 804);
            txtRating.Margin = new Padding(7, 5, 7, 5);
            txtRating.Name = "txtRating";
            txtRating.ReadOnly = true;
            txtRating.Size = new Size(327, 53);
            txtRating.TabIndex = 30;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 754);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(296, 68);
            label4.TabIndex = 29;
            label4.Text = "Prosječna ocjena:";
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalCalories.Location = new Point(29, 656);
            txtTotalCalories.Margin = new Padding(7, 5, 7, 5);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.ReadOnly = true;
            txtTotalCalories.Size = new Size(327, 53);
            txtTotalCalories.TabIndex = 28;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(29, 530);
            lblCategory.Margin = new Padding(7, 0, 7, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(333, 68);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Kategorija";
            // 
            // picRecipe
            // 
            picRecipe.BackColor = Color.FromArgb(192, 192, 0);
            picRecipe.Image = (Image)resources.GetObject("picRecipe.Image");
            picRecipe.Location = new Point(29, 175);
            picRecipe.Margin = new Padding(7, 5, 7, 5);
            picRecipe.Name = "picRecipe";
            picRecipe.Size = new Size(333, 320);
            picRecipe.SizeMode = PictureBoxSizeMode.StretchImage;
            picRecipe.TabIndex = 26;
            picRecipe.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 599);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 68);
            label2.TabIndex = 25;
            label2.Text = "Ukupno kalorija:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(376, 25);
            lblTitle.Margin = new Padding(7, 0, 7, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1732, 98);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Pizza (vege) by Vicko";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDetails
            // 
            tabDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDetails.Controls.Add(tabPageDetails);
            tabDetails.Controls.Add(tabPageComments);
            tabDetails.Controls.Add(tabPageRate);
            tabDetails.Location = new Point(376, 175);
            tabDetails.Margin = new Padding(7, 8, 7, 8);
            tabDetails.Name = "tabDetails";
            tabDetails.SelectedIndex = 0;
            tabDetails.Size = new Size(1741, 1353);
            tabDetails.TabIndex = 33;
            // 
            // tabPageDetails
            // 
            tabPageDetails.BackColor = Color.FromArgb(255, 224, 192);
            tabPageDetails.Controls.Add(recipeDetails);
            tabPageDetails.Location = new Point(10, 58);
            tabPageDetails.Margin = new Padding(7, 8, 7, 8);
            tabPageDetails.Name = "tabPageDetails";
            tabPageDetails.Padding = new Padding(7, 8, 7, 8);
            tabPageDetails.Size = new Size(1721, 1285);
            tabPageDetails.TabIndex = 0;
            tabPageDetails.Text = "Detalji";
            // 
            // recipeDetails
            // 
            recipeDetails.Alergens = "";
            recipeDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeDetails.Description = "";
            recipeDetails.Ingredients = "";
            recipeDetails.Location = new Point(14, 16);
            recipeDetails.Margin = new Padding(7, 8, 7, 8);
            recipeDetails.Name = "recipeDetails";
            recipeDetails.Size = new Size(1693, 1253);
            recipeDetails.TabIndex = 0;
            // 
            // tabPageComments
            // 
            tabPageComments.BackColor = Color.FromArgb(255, 224, 192);
            tabPageComments.Controls.Add(commentsList);
            tabPageComments.Location = new Point(10, 58);
            tabPageComments.Margin = new Padding(7, 8, 7, 8);
            tabPageComments.Name = "tabPageComments";
            tabPageComments.Padding = new Padding(7, 8, 7, 8);
            tabPageComments.Size = new Size(1721, 1285);
            tabPageComments.TabIndex = 1;
            tabPageComments.Text = "Komentari i ocjene";
            // 
            // commentsList
            // 
            commentsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            commentsList.Location = new Point(14, 16);
            commentsList.Margin = new Padding(7, 8, 7, 8);
            commentsList.Name = "commentsList";
            commentsList.Size = new Size(1693, 1253);
            commentsList.TabIndex = 0;
            // 
            // tabPageRate
            // 
            tabPageRate.BackColor = Color.FromArgb(255, 224, 192);
            tabPageRate.Controls.Add(rate);
            tabPageRate.Location = new Point(10, 58);
            tabPageRate.Margin = new Padding(7, 8, 7, 8);
            tabPageRate.Name = "tabPageRate";
            tabPageRate.Size = new Size(1721, 1285);
            tabPageRate.TabIndex = 2;
            tabPageRate.Text = "Ocijeni";
            // 
            // rate
            // 
            rate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rate.Comment = "";
            rate.Location = new Point(24, 27);
            rate.Margin = new Padding(17, 22, 17, 22);
            rate.Name = "rate";
            rate.Rating = 0;
            rate.Size = new Size(1671, 1233);
            rate.TabIndex = 0;
            // 
            // btnEditMyRecipe
            // 
            btnEditMyRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditMyRecipe.BackColor = Color.DodgerBlue;
            btnEditMyRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditMyRecipe.ForeColor = Color.White;
            btnEditMyRecipe.Location = new Point(1751, 93);
            btnEditMyRecipe.Margin = new Padding(7, 5, 7, 5);
            btnEditMyRecipe.Name = "btnEditMyRecipe";
            btnEditMyRecipe.Size = new Size(367, 104);
            btnEditMyRecipe.TabIndex = 34;
            btnEditMyRecipe.Text = "Izmijeni";
            btnEditMyRecipe.UseVisualStyleBackColor = false;
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2147, 1533);
            Controls.Add(btnEditMyRecipe);
            Controls.Add(tabDetails);
            Controls.Add(lblTitle);
            Controls.Add(txtRating);
            Controls.Add(label4);
            Controls.Add(txtTotalCalories);
            Controls.Add(lblCategory);
            Controls.Add(picRecipe);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecipeDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka - detalji recepta";
            ((System.ComponentModel.ISupportInitialize)picRecipe).EndInit();
            tabDetails.ResumeLayout(false);
            tabPageDetails.ResumeLayout(false);
            tabPageComments.ResumeLayout(false);
            tabPageRate.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRating;
        private Label label4;
        private TextBox txtTotalCalories;
        private Label lblCategory;
        private PictureBox picRecipe;
        private Label label2;
        private Label lblTitle;
        private TabControl tabDetails;
        private TabPage tabPageDetails;
        private TabPage tabPageComments;
        private TabPage tabPageRate;
        private Controls.RateControl rate;
        private Button btnEditMyRecipe;
        private Controls.RecipeDetailsControl recipeDetails;
        private Controls.CommentsListControl commentsList;
    }
}