
namespace car_rental_system0100
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.mycar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mycar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).BeginInit();
            this.mycar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(184, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mycar
            // 
            this.mycar.Image = ((System.Drawing.Image)(resources.GetObject("mycar.Image")));
            this.mycar.ImageRotate = 0F;
            this.mycar.Location = new System.Drawing.Point(45, 69);
            this.mycar.Name = "mycar";
            this.mycar.Size = new System.Drawing.Size(167, 115);
            this.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mycar.TabIndex = 1;
            this.mycar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(298, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "RuSiRu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mycar1
            // 
            this.mycar1.BackColor = System.Drawing.Color.DarkRed;
            this.mycar1.Controls.Add(this.lblcount);
            this.mycar1.Controls.Add(this.mycar);
            this.mycar1.FillColor = System.Drawing.Color.DarkRed;
            this.mycar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mycar1.ForeColor = System.Drawing.Color.White;
            this.mycar1.Location = new System.Drawing.Point(206, 93);
            this.mycar1.Minimum = 0;
            this.mycar1.Name = "mycar1";
            this.mycar1.ProgressColor = System.Drawing.Color.White;
            this.mycar1.ProgressColor2 = System.Drawing.Color.White;
            this.mycar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mycar1.Size = new System.Drawing.Size(255, 255);
            this.mycar1.TabIndex = 3;
            this.mycar1.Text = "guna2CircleProgressBar1";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcount.Location = new System.Drawing.Point(92, 187);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(65, 23);
            this.lblcount.TabIndex = 4;
            this.lblcount.Text = "Count";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(656, 405);
            this.Controls.Add(this.mycar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).EndInit();
            this.mycar1.ResumeLayout(false);
            this.mycar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox mycar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar mycar1;
        private System.Windows.Forms.Label lblcount;
    }
}

