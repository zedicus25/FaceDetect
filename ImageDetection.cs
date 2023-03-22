using Aws;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetect
{
    public partial class ImageDetection : Form
    {
        private AwsController _awsController = new AwsController();
        public ImageDetection()
        {
            InitializeComponent();
        }
        public string CurPicture { get; set; }
        private void DetectFaces_Click(object sender, EventArgs e)
        {


            foreach (var item in _awsController.DetectFaces(this.CurPicture))
            {

                double multiplyH = (double)this.panel1.Height / (double)this.panel1.BackgroundImage.Height;
                double multiplyW = (double)this.panel1.Width / (double)this.panel1.BackgroundImage.Width;

                int left = (int)(multiplyW * item.Left * this.panel1.BackgroundImage.Width);
                int top = (int)(multiplyH * item.Top * this.panel1.BackgroundImage.Height);
                int width = (int)(multiplyW * item.Width * this.panel1.BackgroundImage.Width);
                int height = (int)(multiplyH * item.Height * this.panel1.BackgroundImage.Height);



                this.panel1.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), 
                    new Rectangle(left,top,width,height));
            }
        }

        private void panel1_Paint(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg|*.jpg|png|*.png";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = fileDialog.FileName;
                    this.CurPicture = new FileInfo(path).Name;
                    _awsController.UploadFile(Path.GetFileName(path), path);
                    this.panel1.BackgroundImage = new Bitmap(path);
                }
            }
            catch
            {

            }
        }
    }
}
