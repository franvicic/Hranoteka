namespace Hranoteka.Views
{
    partial class EditRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecipeForm));
            tabs = new TabControl();
            tabPageTemplate1 = new TabPage();
            recipeTemplate1 = new Controls.RecipeTemplate1Control();
            tabPageTemplate2 = new TabPage();
            recipeTemplate2 = new Controls.RecipeTemplate2Control();
            lblEditRecipeTitle = new Label();
            btnSaveRecipe = new Button();
            tabs.SuspendLayout();
            tabPageTemplate1.SuspendLayout();
            tabPageTemplate2.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabs.Controls.Add(tabPageTemplate1);
            tabs.Controls.Add(tabPageTemplate2);
            tabs.Location = new Point(24, 137);
            tabs.Margin = new Padding(7, 8, 7, 8);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(2093, 1279);
            tabs.TabIndex = 0;
            // 
            // tabPageTemplate1
            // 
            tabPageTemplate1.BackColor = Color.FromArgb(255, 224, 192);
            tabPageTemplate1.Controls.Add(recipeTemplate1);
            tabPageTemplate1.Location = new Point(10, 58);
            tabPageTemplate1.Margin = new Padding(7, 8, 7, 8);
            tabPageTemplate1.Name = "tabPageTemplate1";
            tabPageTemplate1.Padding = new Padding(7, 8, 7, 8);
            tabPageTemplate1.Size = new Size(2073, 1211);
            tabPageTemplate1.TabIndex = 0;
            tabPageTemplate1.Text = "Predložak 1";
            // 
            // recipeTemplate1
            // 
            recipeTemplate1.Alergens = "";
            recipeTemplate1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeTemplate1.Description = "";
            recipeTemplate1.ImagePath = null;
            recipeTemplate1.Kcal = new decimal(new int[] { 0, 0, 0, 0 });
            recipeTemplate1.Location = new Point(14, 16);
            recipeTemplate1.Margin = new Padding(7, 8, 7, 8);
            recipeTemplate1.Name = "recipeTemplate1";
            recipeTemplate1.RecipeName = "";
            recipeTemplate1.Size = new Size(2045, 1164);
            recipeTemplate1.TabIndex = 0;
            // 
            // tabPageTemplate2
            // 
            tabPageTemplate2.BackColor = Color.FromArgb(255, 224, 192);
            tabPageTemplate2.Controls.Add(recipeTemplate2);
            tabPageTemplate2.Location = new Point(10, 58);
            tabPageTemplate2.Margin = new Padding(7, 8, 7, 8);
            tabPageTemplate2.Name = "tabPageTemplate2";
            tabPageTemplate2.Padding = new Padding(7, 8, 7, 8);
            tabPageTemplate2.Size = new Size(2073, 1211);
            tabPageTemplate2.TabIndex = 1;
            tabPageTemplate2.Text = "Predložak 2";
            // 
            // recipeTemplate2
            // 
            recipeTemplate2.Alergens = "";
            recipeTemplate2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeTemplate2.Description = "";
            recipeTemplate2.ImagePath = null;
            recipeTemplate2.Kcal = new decimal(new int[] { 0, 0, 0, 0 });
            recipeTemplate2.Location = new Point(15, 16);
            recipeTemplate2.Margin = new Padding(17, 22, 17, 22);
            recipeTemplate2.Name = "recipeTemplate2";
            recipeTemplate2.RecipeName = "";
            recipeTemplate2.Size = new Size(2045, 1170);
            recipeTemplate2.TabIndex = 0;
            // 
            // lblEditRecipeTitle
            // 
            lblEditRecipeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEditRecipeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditRecipeTitle.Location = new Point(34, 25);
            lblEditRecipeTitle.Margin = new Padding(7, 0, 7, 0);
            lblEditRecipeTitle.Name = "lblEditRecipeTitle";
            lblEditRecipeTitle.Size = new Size(2074, 68);
            lblEditRecipeTitle.TabIndex = 25;
            lblEditRecipeTitle.Text = "Novi recept";
            lblEditRecipeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.BackColor = Color.DodgerBlue;
            btnSaveRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRecipe.ForeColor = Color.White;
            btnSaveRecipe.Location = new Point(908, 1430);
            btnSaveRecipe.Margin = new Padding(7, 5, 7, 5);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(338, 82);
            btnSaveRecipe.TabIndex = 31;
            btnSaveRecipe.Text = "Snimi";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // EditRecipeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2147, 1533);
            Controls.Add(btnSaveRecipe);
            Controls.Add(lblEditRecipeTitle);
            Controls.Add(tabs);
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditRecipeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka - uređivanje recepta";
            tabs.ResumeLayout(false);
            tabPageTemplate1.ResumeLayout(false);
            tabPageTemplate2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage tabPageTemplate1;
        private TabPage tabPageTemplate2;
        private Label lblEditRecipeTitle;
        private Button btnSaveRecipe;
        private Controls.RecipeTemplate2Control recipeTemplate2;
        private Controls.RecipeTemplate1Control recipeTemplate1;
    }
}