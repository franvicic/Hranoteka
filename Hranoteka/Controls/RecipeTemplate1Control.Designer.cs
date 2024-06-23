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
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(611, 234);
            label11.Name = "label11";
            label11.Size = new Size(36, 19);
            label11.TabIndex = 46;
            label11.Text = "Kcal:";
            // 
            // cmbUnit
            // 
            cmbUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(586, 163);
            cmbUnit.Margin = new Padding(3, 2, 3, 2);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(170, 25);
            cmbUnit.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(396, 90);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 43;
            label8.Text = "Naziv:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(546, 27);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(211, 23);
            cmbCategory.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(187, 278);
            label10.Name = "label10";
            label10.Size = new Size(67, 19);
            label10.TabIndex = 41;
            label10.Text = "Priprema:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(187, 296);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(569, 101);
            txtDescription.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(187, 234);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 39;
            label9.Text = "Alergeni:";
            // 
            // picImage
            // 
            picImage.BackColor = Color.FromArgb(192, 192, 0);
            picImage.Image = (Image)resources.GetObject("picImage.Image");
            picImage.Location = new Point(3, 234);
            picImage.Margin = new Padding(3, 2, 3, 2);
            picImage.Name = "picImage";
            picImage.Size = new Size(170, 130);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 18;
            picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.DodgerBlue;
            btnLoadImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(3, 368);
            btnLoadImage.Margin = new Padding(3, 2, 3, 2);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(170, 30);
            btnLoadImage.TabIndex = 29;
            btnLoadImage.Text = "Učitaj sliku";
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // txtAlergens
            // 
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(187, 253);
            txtAlergens.Margin = new Padding(3, 2, 3, 2);
            txtAlergens.Name = "txtAlergens";
            txtAlergens.Size = new Size(410, 26);
            txtAlergens.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(396, 142);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 36;
            label4.Text = "Količina:";
            // 
            // lstIngredients
            // 
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 15;
            lstIngredients.Location = new Point(3, 91);
            lstIngredients.Margin = new Padding(3, 2, 3, 2);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(387, 139);
            lstIngredients.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(586, 142);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 34;
            label3.Text = "Jedinica:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(546, 5);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 27;
            label7.Text = "Kategorija:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(3, 27);
            txtRecipeName.Margin = new Padding(3, 2, 3, 2);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(523, 26);
            txtRecipeName.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 25;
            label6.Text = "Naziv:";
            // 
            // btnAddIngredientToList
            // 
            btnAddIngredientToList.BackColor = Color.DodgerBlue;
            btnAddIngredientToList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddIngredientToList.ForeColor = Color.White;
            btnAddIngredientToList.Location = new Point(397, 202);
            btnAddIngredientToList.Margin = new Padding(3, 2, 3, 2);
            btnAddIngredientToList.Name = "btnAddIngredientToList";
            btnAddIngredientToList.Size = new Size(141, 30);
            btnAddIngredientToList.TabIndex = 23;
            btnAddIngredientToList.Text = "<< Dodaj";
            btnAddIngredientToList.UseVisualStyleBackColor = false;
            // 
            // txtIngredientName
            // 
            txtIngredientName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngredientName.Location = new Point(397, 111);
            txtIngredientName.Margin = new Padding(3, 2, 3, 2);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.Size = new Size(360, 26);
            txtIngredientName.TabIndex = 20;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 61);
            label2.Name = "label2";
            label2.Size = new Size(756, 23);
            label2.TabIndex = 7;
            label2.Text = "Namirnice i priprema";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudKcal
            // 
            nudKcal.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudKcal.Location = new Point(611, 253);
            nudKcal.Margin = new Padding(1);
            nudKcal.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKcal.Name = "nudKcal";
            nudKcal.Size = new Size(144, 25);
            nudKcal.TabIndex = 47;
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            nudAmount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAmount.Location = new Point(397, 164);
            nudAmount.Margin = new Padding(1);
            nudAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(167, 25);
            nudAmount.TabIndex = 48;
            // 
            // RecipeTemplate1Control
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
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
            Name = "RecipeTemplate1Control";
            Size = new Size(760, 400);
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
