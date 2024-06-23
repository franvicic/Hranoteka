namespace Hranoteka.Controls
{
    partial class RecipeDetailsControl
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
            txtAlergens = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtDescription = new TextBox();
            txtIngredients = new TextBox();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAlergens
            // 
            txtAlergens.BackColor = SystemColors.Window;
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(3, 294);
            txtAlergens.Margin = new Padding(3, 2, 3, 2);
            txtAlergens.Multiline = true;
            txtAlergens.Name = "txtAlergens";
            txtAlergens.ReadOnly = true;
            txtAlergens.ScrollBars = ScrollBars.Vertical;
            txtAlergens.Size = new Size(757, 100);
            txtAlergens.TabIndex = 29;
            // 
            // label5
            // 
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(757, 29);
            label5.TabIndex = 24;
            label5.Text = "Priprema";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Blue;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 262);
            label7.Name = "label7";
            label7.Size = new Size(757, 29);
            label7.TabIndex = 28;
            label7.Text = "Alergeni";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Window;
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(3, 32);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(757, 96);
            txtDescription.TabIndex = 25;
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = SystemColors.Window;
            txtIngredients.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngredients.Location = new Point(3, 162);
            txtIngredients.Margin = new Padding(3, 2, 3, 2);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ReadOnly = true;
            txtIngredients.ScrollBars = ScrollBars.Vertical;
            txtIngredients.Size = new Size(757, 98);
            txtIngredients.TabIndex = 27;
            // 
            // label6
            // 
            label6.BackColor = Color.Blue;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(757, 29);
            label6.TabIndex = 26;
            label6.Text = "Namirnice";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txtAlergens, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(txtIngredients, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(800, 400);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // RecipeDetailsControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Name = "RecipeDetailsControl";
            Size = new Size(800, 400);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAlergens;
        private Label label5;
        private Label label7;
        private TextBox txtDescription;
        private TextBox txtIngredients;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
