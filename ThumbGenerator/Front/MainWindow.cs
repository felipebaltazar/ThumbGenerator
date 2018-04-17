using CapturarSlide;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ThumbGenerator.Helpers;

namespace ThumbGenerator
{
    public partial class MainWindow : Form
    {
        private Form _mainWindow;
        private int _width = 200;
        private int _height = 200;
        private bool ChangingSize;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void NewWindowClick(object sender, EventArgs e)
        {
            try
            {
                var sizeCastWorked = int.TryParse(WidthEntry.Text, out int width);
                sizeCastWorked = int.TryParse(HeightEntry.Text, out int height);

                if (!sizeCastWorked)
                {
                    MessageBox.Show("Não foi possivel aplicar dimensão informada na janela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   

                _mainWindow = new CaptureWindow(this);
                _mainWindow.TopMost = true;
                _mainWindow.BackColor = Color.Azure;
                _mainWindow.StartPosition = FormStartPosition.WindowsDefaultLocation;
                _mainWindow.Size = new Size(width, height);
                _mainWindow.Resize += OnMainWindowResize;
                _mainWindow.FormClosed += OnClosed;

                _mainWindow.Show();

                BorderSize.Enabled = true;
                ResizeWindow.Enabled = true;
                CaptureButton.Enabled = true;
                NewWindow.Enabled = false;
                CloseWindow.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            NewWindow.Enabled = true;
            ResizeWindow.Enabled = false;
            CloseWindow.Enabled = false;
            CaptureButton.Enabled = false;
            BorderSize.Enabled = false;
        }

        private void ResizeButtonClicked(object sender, EventArgs e)
        {
            ChangingSize = true;

            var sizeCastWorked = int.TryParse(WidthEntry.Text, out int width);
            sizeCastWorked = int.TryParse(HeightEntry.Text, out int height);

            if (sizeCastWorked)
                _mainWindow.Size = new Size(width, height);

            ChangingSize = false;
        }

        private void OnBorderSizeChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BorderSize.Text) || (BorderSize?.Text?.Contains(" ") ?? true))
                return;

            if (int.TryParse(BorderSize.Text, out int newBorderSize))
            {
                if (!(newBorderSize > 0))
                    return;
                
                if (_mainWindow.Controls.Find("transparentPanel", true).FirstOrDefault() is Panel transparentPanel)
                {
                    transparentPanel.Location = new Point(newBorderSize, newBorderSize);
                    transparentPanel.Size = new Size(_mainWindow.Size.Width - (newBorderSize * 2), _mainWindow.Size.Height - (newBorderSize * 2));
                }           
            }
        }
        
        private void OnMainWindowResize(object sender, EventArgs e)
        {
            if(!ChangingSize)
            {
                WidthEntry.Text = _mainWindow?.Width.ToString();
                HeightEntry.Text = _mainWindow?.Height.ToString();
            }
        }

        public void CaptureButtonClick(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(WidthPxEntry.Text, out _width);
                int.TryParse(HeightPxEntry.Text, out _height);
                Process process = null;

                _mainWindow.Hide();
                CaptureScreentoClipboard(_mainWindow.Location.X, _mainWindow.Location.Y, _mainWindow.Width, _mainWindow.Height);
                _mainWindow?.Show();
                
                if (OpenPaint.Checked)
                {
                    var screenCaptured = Clipboard.GetImage();
                    var version = 0;
                    var fileName = Path.GetTempPath() + "thumb.jpg";

                    while (File.Exists(fileName))
                    {
                        fileName = Path.GetTempPath() + $"thumb{version}.jpg";
                        version++;
                    }

                    screenCaptured.Save(fileName);
                    process = Process.Start("mspaint.exe", fileName);
                    
                    Thread.Sleep(800);
                    File.Delete(fileName);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void CaptureScreentoClipboard(int x, int y, int wid, int hei)
        {
            var hdcSrc = NativeMethods.CreateDC("DISPLAY", null, null, IntPtr.Zero);
            var hdcDest = NativeMethods.CreateCompatibleDC(hdcSrc);
            var hBitmap = NativeMethods.CreateCompatibleBitmap(hdcSrc, wid, hei);

            NativeMethods.SelectObject(hdcDest, hBitmap);

            using (var bitmap = new Bitmap(wid, hei))
            using (var image = (Image)bitmap)
            using (var graphics = Graphics.FromImage(image))
            {
                var hdc = graphics.GetHdc();
                NativeMethods.BitBlt(hdcDest, 0, 0, wid, hei, (int)hdc, 0, 0, 0x00FF0062);
            }
            
            var screendata = Screen.AllScreens;

            int X, X1, Y, Y1;

            for (int i = 0; i < screendata.Length; i++)
            {
                if (screendata[i].Bounds.X > (x + wid) ||
                    (screendata[i].Bounds.X + screendata[i].Bounds.Width) < x || 
                    screendata[i].Bounds.Y > (y + hei) ||
                   (screendata[i].Bounds.Y + screendata[i].Bounds.Height) < y)
                {
                    // no common area
                }
                else
                {
                    if (x < screendata[i].Bounds.X)
                        X = screendata[i].Bounds.X;
                    else
                        X = x;

                    if ((x + wid) > (screendata[i].Bounds.X + screendata[i].Bounds.Width))
                        X1 = screendata[i].Bounds.X + screendata[i].Bounds.Width;
                    else X1 = x + wid;

                    if (y < screendata[i].Bounds.Y)
                        Y = screendata[i].Bounds.Y;
                    else
                        Y = y;

                    if ((y + hei) > (screendata[i].Bounds.Y + screendata[i].Bounds.Height))
                        Y1 = screendata[i].Bounds.Y + screendata[i].Bounds.Height;
                    else
                        Y1 = y + hei;
                    
                    NativeMethods.BitBlt(hdcDest, X - x, Y - y, X1 - X, Y1 - Y, hdcSrc, X, Y,
                             0x40000000 | 0x00CC0020);
                }
            }

            using (var image = Image.FromHbitmap(new IntPtr(hBitmap)))
            {
                using (var newImage = new Bitmap(_width, _height))
                {
                    Graphics.FromImage(newImage).DrawImage(image, 0, 0, _width, _height);
                    Bitmap bmpp = new Bitmap(newImage);

                    Clipboard.SetImage(bmpp);

                    NativeMethods.DeleteDC(hdcSrc);
                    NativeMethods.DeleteDC(hdcDest);
                    NativeMethods.DeleteObject(hBitmap);
                }   
            }
        }
        
        private void WindowCloseButtonClick(object sender, EventArgs e) =>
            _mainWindow.Close();
    }   
}