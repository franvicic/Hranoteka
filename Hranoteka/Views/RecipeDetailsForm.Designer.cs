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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)picRecipe).BeginInit();
            tabDetails.SuspendLayout();
            tabPageDetails.SuspendLayout();
            tabPageComments.SuspendLayout();
            tabPageRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRating.Location = new Point(15, 253);
            txtRating.Margin = new Padding(3, 2, 3, 2);
            txtRating.Name = "txtRating";
            txtRating.ReadOnly = true;
            txtRating.Size = new Size(137, 26);
            txtRating.TabIndex = 30;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 236);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 29;
            label4.Text = "Prosječna ocjena:";
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalCalories.Location = new Point(15, 193);
            txtTotalCalories.Margin = new Padding(3, 2, 3, 2);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.ReadOnly = true;
            txtTotalCalories.Size = new Size(137, 26);
            txtTotalCalories.TabIndex = 28;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(15, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(137, 25);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Kategorija";
            // 
            // picRecipe
            // 
            picRecipe.BackColor = Color.FromArgb(192, 192, 0);
            picRecipe.Image = (Image)resources.GetObject("picRecipe.Image");
            picRecipe.Location = new Point(15, 11);
            picRecipe.Margin = new Padding(3, 2, 3, 2);
            picRecipe.Name = "picRecipe";
            picRecipe.Size = new Size(137, 117);
            picRecipe.SizeMode = PictureBoxSizeMode.StretchImage;
            picRecipe.TabIndex = 26;
            picRecipe.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 166);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 25;
            label2.Text = "Ukupno kalorija:";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(709, 36);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Pizza (vege) by Vicko";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDetails
            // 
            tabDetails.Controls.Add(tabPageDetails);
            tabDetails.Controls.Add(tabPageComments);
            tabDetails.Controls.Add(tabPageRate);
            tabDetails.Dock = DockStyle.Fill;
            tabDetails.Location = new Point(0, 0);
            tabDetails.Name = "tabDetails";
            tabDetails.SelectedIndex = 0;
            tabDetails.Size = new Size(709, 473);
            tabDetails.TabIndex = 33;
            // 
            // tabPageDetails
            // 
            tabPageDetails.BackColor = Color.FromArgb(255, 224, 192);
            tabPageDetails.Controls.Add(recipeDetails);
            tabPageDetails.Location = new Point(4, 24);
            tabPageDetails.Name = "tabPageDetails";
            tabPageDetails.Padding = new Padding(3);
            tabPageDetails.Size = new Size(701, 445);
            tabPageDetails.TabIndex = 0;
            tabPageDetails.Text = "Detalji";
            // 
            // recipeDetails
            // 
            recipeDetails.Alergens = "";
            recipeDetails.Description = "";
            recipeDetails.Ingredients = "";
            recipeDetails.Location = new Point(3, 3);
            recipeDetails.Name = "recipeDetails";
            recipeDetails.Size = new Size(695, 436);
            recipeDetails.TabIndex = 0;
            // 
            // tabPageComments
            // 
            tabPageComments.BackColor = Color.FromArgb(255, 224, 192);
            tabPageComments.Controls.Add(commentsList);
            tabPageComments.Location = new Point(4, 24);
            tabPageComments.Name = "tabPageComments";
            tabPageComments.Padding = new Padding(3);
            tabPageComments.Size = new Size(701, 445);
            tabPageComments.TabIndex = 1;
            tabPageComments.Text = "Komentari i ocjene";
            // 
            // commentsList
            // 
            commentsList.Location = new Point(3, 3);
            commentsList.Name = "commentsList";
            commentsList.Size = new Size(695, 442);
            commentsList.TabIndex = 0;
            // 
            // tabPageRate
            // 
            tabPageRate.BackColor = Color.FromArgb(255, 224, 192);
            tabPageRate.Controls.Add(rate);
            tabPageRate.Location = new Point(4, 24);
            tabPageRate.Name = "tabPageRate";
            tabPageRate.Size = new Size(701, 445);
            tabPageRate.TabIndex = 2;
            tabPageRate.Text = "Ocijeni";
            // 
            // rate
            // 
            rate.Comment = "";
            rate.Location = new Point(0, 0);
            rate.Margin = new Padding(7, 8, 7, 8);
            rate.Name = "rate";
            rate.Rating = 0;
            rate.Size = new Size(698, 441);
            rate.TabIndex = 0;
            // 
            // btnEditMyRecipe
            // 
            btnEditMyRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditMyRecipe.BackColor = Color.DodgerBlue;
            btnEditMyRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditMyRecipe.ForeColor = Color.White;
            btnEditMyRecipe.Location = new Point(546, 36);
            btnEditMyRecipe.Margin = new Padding(3, 2, 3, 2);
            btnEditMyRecipe.Name = "btnEditMyRecipe";
            btnEditMyRecipe.Size = new Size(151, 38);
            btnEditMyRecipe.TabIndex = 34;
            btnEditMyRecipe.Text = "Izmijeni";
            btnEditMyRecipe.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(picRecipe);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lblCategory);
            splitContainer1.Panel1.Controls.Add(txtTotalCalories);
            splitContainer1.Panel1.Controls.Add(txtRating);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(884, 558);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.TabIndex = 35;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnEditMyRecipe);
            splitContainer2.Panel1.Controls.Add(lblTitle);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tabDetails);
            splitContainer2.Size = new Size(709, 558);
            splitContainer2.SplitterDistance = 81;
            splitContainer2.TabIndex = 0;
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(884, 558);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
    }
}