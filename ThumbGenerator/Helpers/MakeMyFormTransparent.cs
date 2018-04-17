using System;
using System.Drawing;
using System.Windows.Forms;
using ThumbGenerator.Helpers;

namespace ThumbGenerator
{
    public class TransparentAndClickable
    {
        private static Form _clickableForm;
        private static Form _transparentForm;
        private static MainWindow _mainWindow;
       
        public static void MakeMyFormTransparent(Form formToMakeTransparent, MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _transparentForm = formToMakeTransparent;

            formToMakeTransparent.BackColor = Color.Magenta;
            formToMakeTransparent.TransparencyKey = Color.Magenta;

            _clickableForm = new Form();
            _clickableForm.Size = formToMakeTransparent.Size;
            _clickableForm.FormBorderStyle = FormBorderStyle.None;
            _clickableForm.BackColor = Color.Black;
            _clickableForm.Opacity = 0.01;
            _clickableForm.ShowInTaskbar = false;
            _clickableForm.Show(formToMakeTransparent);
            _clickableForm.TransparencyKey = Color.Magenta;
            _clickableForm.Cursor = Cursors.SizeAll;
            _clickableForm.MouseDown += new MouseEventHandler(FormtransparentMouseDown);
            _clickableForm.KeyDown += ClickableFormKeyDown;

            formToMakeTransparent.LocationChanged += new EventHandler(FormTransparentLocationChanged);
            formToMakeTransparent.SizeChanged += TransparentFormSizeChanged;
            formToMakeTransparent.VisibleChanged += TransparentFormVisibleChanged;
            formToMakeTransparent.KeyDown += ClickableFormKeyDown;

            OnUpdateLocation();
        }

        private static void ClickableFormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F5)
                _mainWindow.CaptureButtonClick(null,null);
        }
        
        private static void FormtransparentMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(_transparentForm.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private static void TransparentFormVisibleChanged(object sender, EventArgs e) =>
            _clickableForm.Visible = _transparentForm.Visible;

        private static void TransparentFormSizeChanged(object sender, EventArgs e) =>
            _clickableForm.Size = _transparentForm.Size;

        private static void OnUpdateLocation() =>
            _clickableForm.Location = new Point(_transparentForm.Location.X, _transparentForm.Location.Y);
        
        private static void FormTransparentLocationChanged(object sender, EventArgs e) =>
            OnUpdateLocation();
    }
}