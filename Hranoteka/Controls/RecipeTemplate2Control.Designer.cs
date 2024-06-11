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
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 456);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(894, 46);
            label3.TabIndex = 66;
            label3.Text = "Priprema";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIngredients
            // 
            txtIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtIngredients.Location = new Point(942, 508);
            txtIngredients.Margin = new Padding(7, 5, 7, 5);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ScrollBars = ScrollBars.Vertical;
            txtIngredients.Size = new Size(890, 414);
            txtIngredients.TabIndex = 65;
            // 
            // txtPreparation
            // 
            txtPreparation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPreparation.Location = new Point(7, 508);
            txtPreparation.Margin = new Padding(7, 5, 7, 5);
            txtPreparation.Multiline = true;
            txtPreparation.Name = "txtPreparation";
            txtPreparation.ScrollBars = ScrollBars.Vertical;
            txtPreparation.Size = new Size(890, 414);
            txtPreparation.TabIndex = 64;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(942, 965);
            label11.Margin = new Padding(7, 0, 7, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 46);
            label11.TabIndex = 62;
            label11.Text = "Kcal:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(459, 235);
            cmbCategory.Margin = new Padding(7, 5, 7, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(631, 53);
            cmbCategory.TabIndex = 60;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 970);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 46);
            label9.TabIndex = 59;
            label9.Text = "Alergeni:";
            // 
            // picImage
            // 
            picImage.BackColor = Color.FromArgb(192, 192, 0);
            picImage.Image = (Image)resources.GetObject("picImage.Image");
            picImage.Location = new Point(7, 5);
            picImage.Margin = new Padding(7, 5, 7, 5);
            picImage.Name = "picImage";
            picImage.Size = new Size(413, 355);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 53;
            picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.DodgerBlue;
            btnLoadImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(7, 372);
            btnLoadImage.Margin = new Padding(7, 5, 7, 5);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(413, 82);
            btnLoadImage.TabIndex = 57;
            btnLoadImage.Text = "Učitaj sliku";
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // txtAlergens
            // 
            txtAlergens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(7, 1022);
            txtAlergens.Margin = new Padding(7, 5, 7, 5);
            txtAlergens.Name = "txtAlergens";
            txtAlergens.Size = new Size(890, 53);
            txtAlergens.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(459, 178);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(179, 46);
            label7.TabIndex = 56;
            label7.Text = "Kategorija:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(459, 55);
            txtRecipeName.Margin = new Padding(7, 5, 7, 5);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(1374, 53);
            txtRecipeName.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(459, 0);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 46);
            label6.TabIndex = 54;
            label6.Text = "Naziv:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(942, 456);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(896, 46);
            label2.TabIndex = 52;
            label2.Text = "Namirnice";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudKcal
            // 
            nudKcal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nudKcal.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudKcal.Location = new Point(942, 1022);
            nudKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKcal.Name = "nudKcal";
            nudKcal.Size = new Size(329, 51);
            nudKcal.TabIndex = 67;
            // 
            // RecipeTemplate2Control
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Margin = new Padding(7, 8, 7, 8);
            Name = "RecipeTemplate2Control";
            Size = new Size(1846, 1093);
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
