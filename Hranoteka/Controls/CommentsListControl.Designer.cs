namespace Hranoteka.Controls
{
    partial class CommentsListControl
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
            pnlBase = new Panel();
            pnlContent = new Panel();
            pnlBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.AutoScroll = true;
            pnlBase.BackColor = Color.DodgerBlue;
            pnlBase.Controls.Add(pnlContent);
            pnlBase.Dock = DockStyle.Fill;
            pnlBase.Location = new Point(0, 0);
            pnlBase.Margin = new Padding(7, 5, 7, 5);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1846, 1093);
            pnlBase.TabIndex = 22;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.Blue;
            pnlContent.Location = new Point(12, 16);
            pnlContent.Margin = new Padding(7, 5, 7, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1816, 0);
            pnlContent.TabIndex = 0;
            // 
            // CommentsListControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBase);
            Margin = new Padding(7, 8, 7, 8);
            Name = "CommentsListControl";
            Size = new Size(1846, 1093);
            pnlBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBase;
        private Panel pnlContent;
    }
}
