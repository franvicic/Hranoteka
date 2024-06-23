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
            tabs.Controls.Add(tabPageTemplate1);
            tabs.Controls.Add(tabPageTemplate2);
            tabs.Location = new Point(10, 50);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(862, 464);
            tabs.TabIndex = 0;
            // 
            // tabPageTemplate1
            // 
            tabPageTemplate1.BackColor = Color.FromArgb(255, 224, 192);
            tabPageTemplate1.Controls.Add(recipeTemplate1);
            tabPageTemplate1.Location = new Point(4, 24);
            tabPageTemplate1.Name = "tabPageTemplate1";
            tabPageTemplate1.Padding = new Padding(3);
            tabPageTemplate1.Size = new Size(854, 436);
            tabPageTemplate1.TabIndex = 0;
            tabPageTemplate1.Text = "Predložak 1";
            // 
            // recipeTemplate1
            // 
            recipeTemplate1.Alergens = "";
            recipeTemplate1.Description = "";
            recipeTemplate1.ImagePath = null;
            recipeTemplate1.Kcal = new decimal(new int[] { 0, 0, 0, 0 });
            recipeTemplate1.Location = new Point(6, 6);
            recipeTemplate1.Name = "recipeTemplate1";
            recipeTemplate1.RecipeId = 0;
            recipeTemplate1.RecipeName = "";
            recipeTemplate1.SelectedCategory = null;
            recipeTemplate1.Size = new Size(842, 422);
            recipeTemplate1.TabIndex = 0;
            // 
            // tabPageTemplate2
            // 
            tabPageTemplate2.BackColor = Color.FromArgb(255, 224, 192);
            tabPageTemplate2.Controls.Add(recipeTemplate2);
            tabPageTemplate2.Location = new Point(4, 24);
            tabPageTemplate2.Name = "tabPageTemplate2";
            tabPageTemplate2.Padding = new Padding(3);
            tabPageTemplate2.Size = new Size(854, 436);
            tabPageTemplate2.TabIndex = 1;
            tabPageTemplate2.Text = "Predložak 2";
            // 
            // recipeTemplate2
            // 
            recipeTemplate2.Alergens = "";
            recipeTemplate2.Description = "";
            recipeTemplate2.ImagePath = null;
            recipeTemplate2.Kcal = new decimal(new int[] { 0, 0, 0, 0 });
            recipeTemplate2.Location = new Point(6, 6);
            recipeTemplate2.Margin = new Padding(7, 8, 7, 8);
            recipeTemplate2.Name = "recipeTemplate2";
            recipeTemplate2.RecipeId = 0;
            recipeTemplate2.RecipeName = "";
            recipeTemplate2.SelectedCategory = null;
            recipeTemplate2.Size = new Size(842, 419);
            recipeTemplate2.TabIndex = 0;
            // 
            // lblEditRecipeTitle
            // 
            lblEditRecipeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEditRecipeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditRecipeTitle.Location = new Point(14, 9);
            lblEditRecipeTitle.Name = "lblEditRecipeTitle";
            lblEditRecipeTitle.Size = new Size(854, 25);
            lblEditRecipeTitle.TabIndex = 25;
            lblEditRecipeTitle.Text = "Novi recept";
            lblEditRecipeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.BackColor = Color.DodgerBlue;
            btnSaveRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRecipe.ForeColor = Color.White;
            btnSaveRecipe.Location = new Point(358, 525);
            btnSaveRecipe.Margin = new Padding(3, 2, 3, 2);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(139, 30);
            btnSaveRecipe.TabIndex = 31;
            btnSaveRecipe.Text = "Snimi";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // EditRecipeForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(884, 566);
            Controls.Add(btnSaveRecipe);
            Controls.Add(lblEditRecipeTitle);
            Controls.Add(tabs);
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