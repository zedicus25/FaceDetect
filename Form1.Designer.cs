namespace FaceDetect
{
    partial class Form1
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
            this._webCameraDetection = new System.Windows.Forms.Button();
            this._imageDetection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _webCameraDetection
            // 
            this._webCameraDetection.Location = new System.Drawing.Point(12, 12);
            this._webCameraDetection.Name = "_webCameraDetection";
            this._webCameraDetection.Size = new System.Drawing.Size(195, 109);
            this._webCameraDetection.TabIndex = 0;
            this._webCameraDetection.Text = "Camera Detection";
            this._webCameraDetection.UseVisualStyleBackColor = true;
            this._webCameraDetection.Click += new System.EventHandler(this._webCameraDetection_Click);
            // 
            // _imageDetection
            // 
            this._imageDetection.Location = new System.Drawing.Point(12, 127);
            this._imageDetection.Name = "_imageDetection";
            this._imageDetection.Size = new System.Drawing.Size(195, 109);
            this._imageDetection.TabIndex = 1;
            this._imageDetection.Text = "Image Detection";
            this._imageDetection.UseVisualStyleBackColor = true;
            this._imageDetection.Click += new System.EventHandler(this._imageDetection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 252);
            this.Controls.Add(this._imageDetection);
            this.Controls.Add(this._webCameraDetection);
            this.MaximumSize = new System.Drawing.Size(247, 291);
            this.MinimumSize = new System.Drawing.Size(247, 291);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _webCameraDetection;
        private System.Windows.Forms.Button _imageDetection;
    }
}

