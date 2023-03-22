using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _webCameraDetection_Click(object sender, EventArgs e)
        {
            WebCameraDetection webCameraDetection = new WebCameraDetection();
            webCameraDetection.ShowDialog();
        }

        private void _imageDetection_Click(object sender, EventArgs e)
        {
            ImageDetection imageDetection = new ImageDetection();
            imageDetection.ShowDialog();
        }
    }
}
