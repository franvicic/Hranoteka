namespace Hranoteka.Controls
{
    partial class RateControl
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
            rad2 = new RadioButton();
            rad3 = new RadioButton();
            rad4 = new RadioButton();
            rad5 = new RadioButton();
            rad1 = new RadioButton();
            label26 = new Label();
            btnSaveCommentAndRate = new Button();
            label27 = new Label();
            txtComment = new TextBox();
            SuspendLayout();
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(81, 55);
            rad2.Margin = new Padding(3, 2, 3, 2);
            rad2.Name = "rad2";
            rad2.Size = new Size(31, 19);
            rad2.TabIndex = 42;
            rad2.TabStop = true;
            rad2.Text = "2";
            rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(134, 55);
            rad3.Margin = new Padding(3, 2, 3, 2);
            rad3.Name = "rad3";
            rad3.Size = new Size(31, 19);
            rad3.TabIndex = 41;
            rad3.TabStop = true;
            rad3.Text = "3";
            rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            rad4.AutoSize = true;
            rad4.Location = new Point(188, 55);
            rad4.Margin = new Padding(3, 2, 3, 2);
            rad4.Name = "rad4";
            rad4.Size = new Size(31, 19);
            rad4.TabIndex = 40;
            rad4.TabStop = true;
            rad4.Text = "4";
            rad4.UseVisualStyleBackColor = true;
            // 
            // rad5
            // 
            rad5.AutoSize = true;
            rad5.Location = new Point(242, 55);
            rad5.Margin = new Padding(3, 2, 3, 2);
            rad5.Name = "rad5";
            rad5.Size = new Size(31, 19);
            rad5.TabIndex = 39;
            rad5.TabStop = true;
            rad5.Text = "5";
            rad5.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(32, 55);
            rad1.Margin = new Padding(3, 2, 3, 2);
            rad1.Name = "rad1";
            rad1.Size = new Size(31, 19);
            rad1.TabIndex = 38;
            rad1.TabStop = true;
            rad1.Text = "1";
            rad1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(22, 117);
            label26.Name = "label26";
            label26.Size = new Size(112, 21);
            label26.TabIndex = 36;
            label26.Text = "Tvoj komentar:";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveCommentAndRate
            // 
            btnSaveCommentAndRate.BackColor = Color.DodgerBlue;
            btnSaveCommentAndRate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCommentAndRate.ForeColor = Color.White;
            btnSaveCommentAndRate.Location = new Point(312, 314);
            btnSaveCommentAndRate.Margin = new Padding(3, 2, 3, 2);
            btnSaveCommentAndRate.Name = "btnSaveCommentAndRate";
            btnSaveCommentAndRate.Size = new Size(133, 38);
            btnSaveCommentAndRate.TabIndex = 35;
            btnSaveCommentAndRate.Text = "Spremi";
            btnSaveCommentAndRate.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(22, 27);
            label27.Name = "label27";
            label27.Size = new Size(98, 21);
            label27.TabIndex = 34;
            label27.Text = "Tvoja ocjena:";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComment.Location = new Point(22, 140);
            txtComment.Margin = new Padding(3, 2, 3, 2);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Size = new Size(646, 147);
            txtComment.TabIndex = 33;
            // 
            // RateControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(rad2);
            Controls.Add(rad3);
            Controls.Add(label27);
            Controls.Add(rad4);
            Controls.Add(txtComment);
            Controls.Add(rad5);
            Controls.Add(btnSaveCommentAndRate);
            Controls.Add(rad1);
            Controls.Add(label26);
            Name = "RateControl";
            Size = new Size(691, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rad2;
        private RadioButton rad3;
        private RadioButton rad4;
        private RadioButton rad5;
        private RadioButton rad1;
        private Label label26;
        private Button btnSaveCommentAndRate;
        private Label label27;
        private TextBox txtComment;
    }
}
