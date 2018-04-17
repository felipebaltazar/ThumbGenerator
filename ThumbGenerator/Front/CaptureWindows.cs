using ThumbGenerator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapturarSlide
{
    public partial class CaptureWindow : Form
    {
        MainWindow _mainWindow;

        public CaptureWindow(MainWindow main)
        {
            _mainWindow = main;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            TransparentAndClickable.MakeMyFormTransparent(this, _mainWindow);
            TransparencyKey = Color.Magenta;
        }
    }
}
