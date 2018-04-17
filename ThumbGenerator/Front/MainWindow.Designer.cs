namespace ThumbGenerator
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CaptureButton = new System.Windows.Forms.Button();
            this.HeightEntry = new System.Windows.Forms.TextBox();
            this.WindowHeightLabel = new System.Windows.Forms.Label();
            this.WidthEntry = new System.Windows.Forms.TextBox();
            this.WindowWidthLabel = new System.Windows.Forms.Label();
            this.HeightPxEntry = new System.Windows.Forms.TextBox();
            this.HeightPxLabel = new System.Windows.Forms.Label();
            this.WidthPxEntry = new System.Windows.Forms.TextBox();
            this.WidthPxLabel = new System.Windows.Forms.Label();
            this.ResizeWindow = new System.Windows.Forms.Button();
            this.NewWindow = new System.Windows.Forms.Button();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.BorderSize = new System.Windows.Forms.TextBox();
            this.OpenPaint = new System.Windows.Forms.CheckBox();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptureButton
            // 
            this.CaptureButton.Enabled = false;
            this.CaptureButton.Location = new System.Drawing.Point(97, 88);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(70, 23);
            this.CaptureButton.TabIndex = 0;
            this.CaptureButton.Text = "Capturar";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButtonClick);
            // 
            // HeightEntry
            // 
            this.HeightEntry.Location = new System.Drawing.Point(130, 38);
            this.HeightEntry.Name = "HeightEntry";
            this.HeightEntry.Size = new System.Drawing.Size(34, 20);
            this.HeightEntry.TabIndex = 9;
            this.HeightEntry.Text = "680";
            this.HeightEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowHeightLabel
            // 
            this.WindowHeightLabel.AutoSize = true;
            this.WindowHeightLabel.Location = new System.Drawing.Point(93, 41);
            this.WindowHeightLabel.Name = "WindowHeightLabel";
            this.WindowHeightLabel.Size = new System.Drawing.Size(37, 13);
            this.WindowHeightLabel.TabIndex = 8;
            this.WindowHeightLabel.Text = "Altura:";
            // 
            // WidthEntry
            // 
            this.WidthEntry.Location = new System.Drawing.Point(48, 38);
            this.WidthEntry.Name = "WidthEntry";
            this.WidthEntry.Size = new System.Drawing.Size(34, 20);
            this.WidthEntry.TabIndex = 7;
            this.WidthEntry.Text = "680";
            this.WidthEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowWidthLabel
            // 
            this.WindowWidthLabel.AutoSize = true;
            this.WindowWidthLabel.Location = new System.Drawing.Point(3, 41);
            this.WindowWidthLabel.Name = "WindowWidthLabel";
            this.WindowWidthLabel.Size = new System.Drawing.Size(46, 13);
            this.WindowWidthLabel.TabIndex = 6;
            this.WindowWidthLabel.Text = "Largura:";
            // 
            // HeightPxEntry
            // 
            this.HeightPxEntry.Location = new System.Drawing.Point(130, 12);
            this.HeightPxEntry.Name = "HeightPxEntry";
            this.HeightPxEntry.Size = new System.Drawing.Size(34, 20);
            this.HeightPxEntry.TabIndex = 13;
            this.HeightPxEntry.Text = "64";
            this.HeightPxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightPxLabel
            // 
            this.HeightPxLabel.AutoSize = true;
            this.HeightPxLabel.Location = new System.Drawing.Point(105, 15);
            this.HeightPxLabel.Name = "HeightPxLabel";
            this.HeightPxLabel.Size = new System.Drawing.Size(22, 13);
            this.HeightPxLabel.TabIndex = 12;
            this.HeightPxLabel.Text = "Px:";
            // 
            // WidthPxEntry
            // 
            this.WidthPxEntry.Location = new System.Drawing.Point(48, 12);
            this.WidthPxEntry.Name = "WidthPxEntry";
            this.WidthPxEntry.Size = new System.Drawing.Size(34, 20);
            this.WidthPxEntry.TabIndex = 11;
            this.WidthPxEntry.Text = "64";
            this.WidthPxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WidthPxLabel
            // 
            this.WidthPxLabel.AutoSize = true;
            this.WidthPxLabel.Location = new System.Drawing.Point(22, 15);
            this.WidthPxLabel.Name = "WidthPxLabel";
            this.WidthPxLabel.Size = new System.Drawing.Size(22, 13);
            this.WidthPxLabel.TabIndex = 10;
            this.WidthPxLabel.Text = "Px:";
            // 
            // ResizeWindow
            // 
            this.ResizeWindow.Enabled = false;
            this.ResizeWindow.Image = global::CapturarSlide.Properties.Resources.redimensionar;
            this.ResizeWindow.Location = new System.Drawing.Point(40, 88);
            this.ResizeWindow.Name = "ResizeWindow";
            this.ResizeWindow.Size = new System.Drawing.Size(23, 23);
            this.ResizeWindow.TabIndex = 14;
            this.ResizeWindow.UseVisualStyleBackColor = true;
            this.ResizeWindow.Click += new System.EventHandler(this.ResizeButtonClicked);
            // 
            // NewWindow
            // 
            this.NewWindow.Image = global::CapturarSlide.Properties.Resources.novo;
            this.NewWindow.Location = new System.Drawing.Point(13, 88);
            this.NewWindow.Name = "NewWindow";
            this.NewWindow.Size = new System.Drawing.Size(23, 23);
            this.NewWindow.TabIndex = 1;
            this.NewWindow.UseVisualStyleBackColor = true;
            this.NewWindow.Click += new System.EventHandler(this.NewWindowClick);
            // 
            // BorderLabel
            // 
            this.BorderLabel.AutoSize = true;
            this.BorderLabel.Location = new System.Drawing.Point(7, 67);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(38, 13);
            this.BorderLabel.TabIndex = 15;
            this.BorderLabel.Text = "Borda:";
            // 
            // BorderSize
            // 
            this.BorderSize.Enabled = false;
            this.BorderSize.Location = new System.Drawing.Point(48, 64);
            this.BorderSize.Name = "BorderSize";
            this.BorderSize.Size = new System.Drawing.Size(34, 20);
            this.BorderSize.TabIndex = 16;
            this.BorderSize.Text = "1";
            this.BorderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorderSize.TextChanged += new System.EventHandler(this.OnBorderSizeChanged);
            // 
            // OpenPaint
            // 
            this.OpenPaint.AutoSize = true;
            this.OpenPaint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenPaint.Location = new System.Drawing.Point(90, 65);
            this.OpenPaint.Name = "OpenPaint";
            this.OpenPaint.Size = new System.Drawing.Size(74, 17);
            this.OpenPaint.TabIndex = 17;
            this.OpenPaint.Text = "Abrir Paint";
            this.OpenPaint.UseVisualStyleBackColor = true;
            // 
            // CloseWindow
            // 
            this.CloseWindow.Enabled = false;
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.Location = new System.Drawing.Point(66, 88);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(23, 23);
            this.CloseWindow.TabIndex = 18;
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.WindowCloseButtonClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 122);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.OpenPaint);
            this.Controls.Add(this.BorderSize);
            this.Controls.Add(this.BorderLabel);
            this.Controls.Add(this.ResizeWindow);
            this.Controls.Add(this.HeightPxEntry);
            this.Controls.Add(this.HeightPxLabel);
            this.Controls.Add(this.WidthPxEntry);
            this.Controls.Add(this.WidthPxLabel);
            this.Controls.Add(this.HeightEntry);
            this.Controls.Add(this.WindowHeightLabel);
            this.Controls.Add(this.WidthEntry);
            this.Controls.Add(this.WindowWidthLabel);
            this.Controls.Add(this.NewWindow);
            this.Controls.Add(this.CaptureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Slide";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Button NewWindow;
        private System.Windows.Forms.TextBox HeightEntry;
        private System.Windows.Forms.Label WindowHeightLabel;
        private System.Windows.Forms.TextBox WidthEntry;
        private System.Windows.Forms.Label WindowWidthLabel;
        private System.Windows.Forms.TextBox HeightPxEntry;
        private System.Windows.Forms.Label HeightPxLabel;
        private System.Windows.Forms.TextBox WidthPxEntry;
        private System.Windows.Forms.Label WidthPxLabel;
        private System.Windows.Forms.Button ResizeWindow;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.TextBox BorderSize;
        private System.Windows.Forms.CheckBox OpenPaint;
        private System.Windows.Forms.Button CloseWindow;
    }
}