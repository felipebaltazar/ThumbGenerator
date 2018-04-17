namespace CapturarSlide
{
    partial class CaptureWindow
    {
        private System.ComponentModel.IContainer components = null;

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
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.TransparentPanel = new System.Windows.Forms.Panel();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderPanel.BackColor = System.Drawing.Color.Red;
            this.BorderPanel.Controls.Add(this.TransparentPanel);
            this.BorderPanel.ForeColor = System.Drawing.Color.Red;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(284, 261);
            this.BorderPanel.TabIndex = 0;
            // 
            // TransparentPanel
            // 
            this.TransparentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparentPanel.BackColor = System.Drawing.Color.Magenta;
            this.TransparentPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TransparentPanel.Location = new System.Drawing.Point(1, 1);
            this.TransparentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TransparentPanel.Name = "TransparentPanel";
            this.TransparentPanel.Size = new System.Drawing.Size(282, 259);
            this.TransparentPanel.TabIndex = 1;
            // 
            // CaptureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.OnLoad);
            this.BorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Panel TransparentPanel;
    }
}