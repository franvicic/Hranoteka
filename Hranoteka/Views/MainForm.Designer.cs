using Hranoteka.Controls;

namespace Hranoteka.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            picProfile = new PictureBox();
            label2 = new Label();
            btnAddNewRecipe = new Button();
            btnSearchRecipes = new Button();
            lblTitle = new Label();
            txtRecipesSearch = new TextBox();
            label5 = new Label();
            pnlBase = new Panel();
            pnlContent = new Panel();
            label1 = new Label();
            chkMyRecipes = new CheckBox();
            btnShowMyProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            pnlBase.SuspendLayout();
            SuspendLayout();
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(192, 192, 0);
            picProfile.Location = new Point(12, 11);
            picProfile.Margin = new Padding(3, 2, 3, 2);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(131, 112);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 22;
            picProfile.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(860, 26);
            label2.TabIndex = 29;
            label2.Text = "Zadnje dodani recepti:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNewRecipe
            // 
            btnAddNewRecipe.BackColor = Color.DodgerBlue;
            btnAddNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewRecipe.ForeColor = Color.White;
            btnAddNewRecipe.Location = new Point(348, 58);
            btnAddNewRecipe.Margin = new Padding(3, 2, 3, 2);
            btnAddNewRecipe.Name = "btnAddNewRecipe";
            btnAddNewRecipe.Size = new Size(151, 38);
            btnAddNewRecipe.TabIndex = 28;
            btnAddNewRecipe.Text = "Novi recept";
            btnAddNewRecipe.UseVisualStyleBackColor = false;
            // 
            // btnSearchRecipes
            // 
            btnSearchRecipes.BackColor = Color.DodgerBlue;
            btnSearchRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchRecipes.ForeColor = Color.White;
            btnSearchRecipes.Image = (Image)resources.GetObject("btnSearchRecipes.Image");
            btnSearchRecipes.Location = new Point(707, 131);
            btnSearchRecipes.Margin = new Padding(3, 2, 3, 2);
            btnSearchRecipes.Name = "btnSearchRecipes";
            btnSearchRecipes.Size = new Size(25, 22);
            btnSearchRecipes.TabIndex = 26;
            btnSearchRecipes.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(149, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(723, 28);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Dobrodošli!";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipesSearch
            // 
            txtRecipesSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipesSearch.Location = new Point(410, 131);
            txtRecipesSearch.Margin = new Padding(3, 2, 3, 2);
            txtRecipesSearch.Name = "txtRecipesSearch";
            txtRecipesSearch.Size = new Size(294, 29);
            txtRecipesSearch.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(268, 135);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 23;
            label5.Text = "Pronađi recept:";
            // 
            // pnlBase
            // 
            pnlBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBase.AutoScroll = true;
            pnlBase.BackColor = Color.FromArgb(255, 224, 192);
            pnlBase.Controls.Add(pnlContent);
            pnlBase.Controls.Add(label1);
            pnlBase.Location = new Point(12, 199);
            pnlBase.Margin = new Padding(3, 2, 3, 2);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(860, 310);
            pnlBase.TabIndex = 30;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(255, 224, 192);
            pnlContent.Location = new Point(3, 2);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(835, 0);
            pnlContent.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(854, 26);
            label1.TabIndex = 30;
            label1.Text = "nema recepata";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMyRecipes
            // 
            chkMyRecipes.AutoSize = true;
            chkMyRecipes.BackColor = Color.Transparent;
            chkMyRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkMyRecipes.ForeColor = SystemColors.ControlText;
            chkMyRecipes.Location = new Point(450, 101);
            chkMyRecipes.Name = "chkMyRecipes";
            chkMyRecipes.Size = new Size(111, 25);
            chkMyRecipes.TabIndex = 31;
            chkMyRecipes.Text = "Moji recepti";
            chkMyRecipes.TextAlign = ContentAlignment.MiddleCenter;
            chkMyRecipes.UseVisualStyleBackColor = false;
            // 
            // btnShowMyProfile
            // 
            btnShowMyProfile.BackColor = Color.DodgerBlue;
            btnShowMyProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowMyProfile.ForeColor = Color.White;
            btnShowMyProfile.Location = new Point(513, 58);
            btnShowMyProfile.Margin = new Padding(3, 2, 3, 2);
            btnShowMyProfile.Name = "btnShowMyProfile";
            btnShowMyProfile.Size = new Size(151, 38);
            btnShowMyProfile.TabIndex = 32;
            btnShowMyProfile.Text = "Moji podaci";
            btnShowMyProfile.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(884, 520);
            Controls.Add(btnShowMyProfile);
            Controls.Add(chkMyRecipes);
            Controls.Add(pnlBase);
            Controls.Add(picProfile);
            Controls.Add(label2);
            Controls.Add(btnAddNewRecipe);
            Controls.Add(btnSearchRecipes);
            Controls.Add(lblTitle);
            Controls.Add(txtRecipesSearch);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hranoteka";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            pnlBase.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProfile;
        private Label label2;
        private Button btnAddNewRecipe;
        private Button btnSearchRecipes;
        private Label lblTitle;
        private TextBox txtRecipesSearch;
        private Label label5;
        private Panel pnlBase;
        private Panel pnlContent;
        private CheckBox chkMyRecipes;
        private Button btnShowMyProfile;
        private Label label1;
    }
}