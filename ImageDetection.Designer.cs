using System.Windows.Forms;

namespace FaceDetect
{
    partial class ImageDetection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DetectFaces = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // DetectFaces
            // 
            this.DetectFaces.Location = new System.Drawing.Point(12, 389);
            this.DetectFaces.Name = "DetectFaces";
            this.DetectFaces.Size = new System.Drawing.Size(347, 60);
            this.DetectFaces.TabIndex = 0;
            this.DetectFaces.Text = "DetectFaces";
            this.DetectFaces.UseVisualStyleBackColor = true;
            this.DetectFaces.Click += new System.EventHandler(this.DetectFaces_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(365, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 320);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetectFaces);
            this.Name = "Image Detection";
            this.Text = "Image Detection";
            this.ResumeLayout(false);

        }

        #endregion

        private Button DetectFaces;
        private Panel panel1;
        private ImageList imageList1;
    }
}