namespace Hranoteka.Controls
{
    partial class RecipeTemplate1Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeTemplate1Control));
            label11 = new Label();
            cmbUnit = new ComboBox();
            label8 = new Label();
            cmbCategory = new ComboBox();
            label10 = new Label();
            txtDescription = new TextBox();
            label9 = new Label();
            picImage = new PictureBox();
            btnLoadImage = new Button();
            txtAlergens = new TextBox();
            label4 = new Label();
            lstIngredients = new ListBox();
            label3 = new Label();
            label7 = new Label();
            txtRecipeName = new TextBox();
            label6 = new Label();
            btnAddIngredientToList = new Button();
            txtIngredientName = new TextBox();
            label2 = new Label();
            nudKcal = new NumericUpDown();
            nudAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKcal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1484, 640);
            label11.Margin = new Padding(7, 0, 7, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 46);
            label11.TabIndex = 46;
            label11.Text = "Kcal:";
            // 
            // cmbUnit
            // 
            cmbUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(1423, 446);
            cmbUnit.Margin = new Padding(7, 5, 7, 5);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(407, 53);
            cmbUnit.TabIndex = 44;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(962, 246);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 46);
            label8.TabIndex = 43;
            label8.Text = "Naziv:";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(1326, 74);
            cmbCategory.Margin = new Padding(7, 5, 7, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(507, 49);
            cmbCategory.TabIndex = 42;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(454, 760);
            label10.Margin = new Padding(7, 0, 7, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 46);
            label10.TabIndex = 41;
            label10.Text = "Opis:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(454, 809);
            txtDescription.Margin = new Padding(7, 5, 7, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(1376, 269);
            txtDescription.TabIndex = 40;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(454, 640);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 46);
            label9.TabIndex = 39;
            label9.Text = "Alergeni:";
            // 
            // picImage
            // 
            picImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picImage.BackColor = Color.FromArgb(192, 192, 0);
            picImage.Image = (Image)resources.GetObject("picImage.Image");
            picImage.Location = new Point(7, 640);
            picImage.Margin = new Padding(7, 5, 7, 5);
            picImage.Name = "picImage";
            picImage.Size = new Size(413, 355);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 18;
            picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadImage.BackColor = Color.DodgerBlue;
            btnLoadImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(7, 1006);
            btnLoadImage.Margin = new Padding(7, 5, 7, 5);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(413, 82);
            btnLoadImage.TabIndex = 29;
            btnLoadImage.Text = "Učitaj sliku";
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // txtAlergens
            // 
            txtAlergens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(454, 692);
            txtAlergens.Margin = new Padding(7, 5, 7, 5);
            txtAlergens.Name = "txtAlergens";
            txtAlergens.Size = new Size(990, 53);
            txtAlergens.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(962, 388);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 46);
            label4.TabIndex = 36;
            label4.Text = "Količina:";
            // 
            // lstIngredients
            // 
            lstIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 41;
            lstIngredients.Location = new Point(7, 249);
            lstIngredients.Margin = new Padding(7, 5, 7, 5);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(934, 373);
            lstIngredients.TabIndex = 32;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1423, 388);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 46);
            label3.TabIndex = 34;
            label3.Text = "Jedinica:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1326, 14);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(179, 46);
            label7.TabIndex = 27;
            label7.Text = "Kategorija:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(7, 74);
            txtRecipeName.Margin = new Padding(7, 5, 7, 5);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(1264, 53);
            txtRecipeName.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 19);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 46);
            label6.TabIndex = 25;
            label6.Text = "Naziv:";
            // 
            // btnAddIngredientToList
            // 
            btnAddIngredientToList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddIngredientToList.BackColor = Color.DodgerBlue;
            btnAddIngredientToList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddIngredientToList.ForeColor = Color.White;
            btnAddIngredientToList.Location = new Point(964, 552);
            btnAddIngredientToList.Margin = new Padding(7, 5, 7, 5);
            btnAddIngredientToList.Name = "btnAddIngredientToList";
            btnAddIngredientToList.Size = new Size(342, 82);
            btnAddIngredientToList.TabIndex = 23;
            btnAddIngredientToList.Text = "<< Dodaj";
            btnAddIngredientToList.UseVisualStyleBackColor = false;
            // 
            // txtIngredientName
            // 
            txtIngredientName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIngredientName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngredientName.Location = new Point(964, 303);
            txtIngredientName.Margin = new Padding(7, 5, 7, 5);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.Size = new Size(869, 53);
            txtIngredientName.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 167);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(1836, 63);
            label2.TabIndex = 7;
            label2.Text = "Namirnice i priprema";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudKcal
            // 
            nudKcal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nudKcal.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudKcal.Location = new Point(1484, 692);
            nudKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKcal.Name = "nudKcal";
            nudKcal.Size = new Size(349, 51);
            nudKcal.TabIndex = 47;
            // 
            // nudAmount
            // 
            nudAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nudAmount.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudAmount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAmount.Location = new Point(964, 448);
            nudAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(405, 51);
            nudAmount.TabIndex = 48;
            // 
            // RecipeTemplate1Control
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nudAmount);
            Controls.Add(nudKcal);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(picImage);
            Controls.Add(btnLoadImage);
            Controls.Add(txtAlergens);
            Controls.Add(lstIngredients);
            Controls.Add(label7);
            Controls.Add(txtRecipeName);
            Controls.Add(label6);
            Controls.Add(btnAddIngredientToList);
            Controls.Add(txtIngredientName);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Margin = new Padding(7, 8, 7, 8);
            Name = "RecipeTemplate1Control";
            Size = new Size(1846, 1093);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKcal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ComboBox cmbUnit;
        private Label label8;
        private ComboBox cmbCategory;
        private Label label10;
        private TextBox txtDescription;
        private Label label9;
        private PictureBox picImage;
        private Button btnLoadImage;
        private TextBox txtAlergens;
        private Label label4;
        private ListBox lstIngredients;
        private Label label3;
        private Label label7;
        private TextBox txtRecipeName;
        private Label label6;
        private Button btnAddIngredientToList;
        private TextBox txtIngredientName;
        private Label label2;
        private NumericUpDown nudKcal;
        private NumericUpDown nudAmount;
    }
}
