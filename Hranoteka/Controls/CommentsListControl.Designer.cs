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
            pnlContent = new FlowLayoutPanel();
            label1 = new Label();
            pnlBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.AutoScroll = true;
            pnlBase.BackColor = Color.FromArgb(255, 224, 192);
            pnlBase.Controls.Add(pnlContent);
            pnlBase.Controls.Add(label1);
            pnlBase.Dock = DockStyle.Fill;
            pnlBase.Location = new Point(0, 0);
            pnlBase.Margin = new Padding(3, 2, 3, 2);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(760, 400);
            pnlBase.TabIndex = 22;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Location = new Point(5, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(690, 11);
            pnlContent.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 19);
            label1.Name = "label1";
            label1.Size = new Size(748, 26);
            label1.TabIndex = 31;
            label1.Text = "no comment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CommentsListControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(pnlBase);
            Name = "CommentsListControl";
            Size = new Size(760, 400);
            pnlBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBase;
        private Label label1;
        private FlowLayoutPanel pnlContent;
    }
}
