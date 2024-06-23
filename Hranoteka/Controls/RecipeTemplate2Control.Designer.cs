namespace Hranoteka.Controls
{
    partial class RecipeTemplate2Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeTemplate2Control));
            label3 = new Label();
            txtIngredients = new TextBox();
            txtPreparation = new TextBox();
            label11 = new Label();
            cmbCategory = new ComboBox();
            label9 = new Label();
            picImage = new PictureBox();
            btnLoadImage = new Button();
            txtAlergens = new TextBox();
            label7 = new Label();
            txtRecipeName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            nudKcal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKcal).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 167);
            label3.Name = "label3";
            label3.Size = new Size(368, 17);
            label3.TabIndex = 66;
            label3.Text = "Priprema";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIngredients
            // 
            txtIngredients.Location = new Point(388, 186);
            txtIngredients.Margin = new Padding(3, 2, 3, 2);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ScrollBars = ScrollBars.Vertical;
            txtIngredients.Size = new Size(369, 154);
            txtIngredients.TabIndex = 65;
            // 
            // txtPreparation
            // 
            txtPreparation.Location = new Point(3, 186);
            txtPreparation.Margin = new Padding(3, 2, 3, 2);
            txtPreparation.Multiline = true;
            txtPreparation.Name = "txtPreparation";
            txtPreparation.ScrollBars = ScrollBars.Vertical;
            txtPreparation.Size = new Size(369, 154);
            txtPreparation.TabIndex = 64;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(388, 350);
            label11.Name = "label11";
            label11.Size = new Size(36, 19);
            label11.TabIndex = 62;
            label11.Text = "Kcal:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(189, 86);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(262, 25);
            cmbCategory.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 352);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 59;
            label9.Text = "Alergeni:";
            // 
            // picImage
            // 
            picImage.BackColor = Color.FromArgb(192, 192, 0);
            picImage.Image = (Image)resources.GetObject("picImage.Image");
            picImage.Location = new Point(3, 2);
            picImage.Margin = new Padding(3, 2, 3, 2);
            picImage.Name = "picImage";
            picImage.Size = new Size(170, 130);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 53;
            picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.DodgerBlue;
            btnLoadImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(3, 136);
            btnLoadImage.Margin = new Padding(3, 2, 3, 2);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(170, 30);
            btnLoadImage.TabIndex = 57;
            btnLoadImage.Text = "Učitaj sliku";
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // txtAlergens
            // 
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(3, 371);
            txtAlergens.Margin = new Padding(3, 2, 3, 2);
            txtAlergens.Name = "txtAlergens";
            txtAlergens.Size = new Size(369, 26);
            txtAlergens.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(189, 65);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 56;
            label7.Text = "Kategorija:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(189, 20);
            txtRecipeName.Margin = new Padding(3, 2, 3, 2);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(568, 26);
            txtRecipeName.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(189, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 54;
            label6.Text = "Naziv:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 167);
            label2.Name = "label2";
            label2.Size = new Size(369, 17);
            label2.TabIndex = 52;
            label2.Text = "Namirnice";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudKcal
            // 
            nudKcal.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudKcal.Location = new Point(388, 371);
            nudKcal.Margin = new Padding(1);
            nudKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKcal.Name = "nudKcal";
            nudKcal.Size = new Size(135, 25);
            nudKcal.TabIndex = 67;
            // 
            // RecipeTemplate2Control
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(nudKcal);
            Controls.Add(label3);
            Controls.Add(txtIngredients);
            Controls.Add(txtPreparation);
            Controls.Add(label11);
            Controls.Add(cmbCategory);
            Controls.Add(label9);
            Controls.Add(picImage);
            Controls.Add(btnLoadImage);
            Controls.Add(txtAlergens);
            Controls.Add(label7);
            Controls.Add(txtRecipeName);
            Controls.Add(label6);
            Controls.Add(label2);
            Name = "RecipeTemplate2Control";
            Size = new Size(760, 400);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKcal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtIngredients;
        private TextBox txtPreparation;
        private Label label11;
        private ComboBox cmbCategory;
        private Label label9;
        private PictureBox picImage;
        private Button btnLoadImage;
        private TextBox txtAlergens;
        private Label label7;
        private TextBox txtRecipeName;
        private Label label6;
        private Label label2;
        private NumericUpDown nudKcal;
    }
}
