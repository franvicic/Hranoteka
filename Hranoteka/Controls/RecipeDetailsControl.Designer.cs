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
            SuspendLayout();
            // 
            // txtAlergens
            // 
            txtAlergens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAlergens.BackColor = SystemColors.Window;
            txtAlergens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlergens.Location = new Point(0, 806);
            txtAlergens.Margin = new Padding(7, 5, 7, 5);
            txtAlergens.Multiline = true;
            txtAlergens.Name = "txtAlergens";
            txtAlergens.ReadOnly = true;
            txtAlergens.ScrollBars = ScrollBars.Vertical;
            txtAlergens.Size = new Size(1833, 266);
            txtAlergens.TabIndex = 29;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(1838, 79);
            label5.TabIndex = 24;
            label5.Text = "Priprema";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.Blue;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 722);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(1838, 79);
            label7.TabIndex = 28;
            label7.Text = "Alergeni";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = SystemColors.Window;
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(0, 85);
            txtDescription.Margin = new Padding(7, 5, 7, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(1833, 266);
            txtDescription.TabIndex = 25;
            // 
            // txtIngredients
            // 
            txtIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIngredients.BackColor = SystemColors.Window;
            txtIngredients.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngredients.Location = new Point(0, 448);
            txtIngredients.Margin = new Padding(7, 5, 7, 5);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ReadOnly = true;
            txtIngredients.ScrollBars = ScrollBars.Vertical;
            txtIngredients.Size = new Size(1833, 261);
            txtIngredients.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Blue;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 364);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(1838, 79);
            label6.TabIndex = 26;
            label6.Text = "Namirnice";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RecipeDetailsControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txtAlergens);
            Controls.Add(label5);
            Controls.Add(txtIngredients);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Margin = new Padding(7, 8, 7, 8);
            Name = "RecipeDetailsControl";
            Size = new Size(1846, 1093);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlergens;
        private Label label5;
        private Label label7;
        private TextBox txtDescription;
        private TextBox txtIngredients;
        private Label label6;
    }
}
