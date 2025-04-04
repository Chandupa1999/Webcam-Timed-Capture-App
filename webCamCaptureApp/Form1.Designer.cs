namespace webCamCaptureApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            cboCamera = new ComboBox();
            pic = new PictureBox();
            btnStart = new Button();
            panel1 = new Panel();
            btnStop = new Button();
            btnCaptureStart = new Button();
            btnCaptureStop = new Button();
            panel2 = new Panel();
            label3 = new Label();
            lblMessage = new Label();
            panel3 = new Panel();
            label4 = new Label();
            btnViewImages = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            label2 = new Label();
            cboCaptureInterval = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 54);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Camera: ";
            // 
            // cboCamera
            // 
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(120, 80);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(191, 23);
            cboCamera.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackgroundImage = (Image)resources.GetObject("pic.BackgroundImage");
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(98, 147);
            pic.Name = "pic";
            pic.Size = new Size(1120, 499);
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            // 
            // btnStart
            // 
            btnStart.ForeColor = Color.Navy;
            btnStart.Location = new Point(231, 42);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(87, 25);
            btnStart.TabIndex = 3;
            btnStart.Text = "Connect";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(98, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 81);
            panel1.TabIndex = 4;
            // 
            // btnStop
            // 
            btnStop.ForeColor = SystemColors.Desktop;
            btnStop.Location = new Point(331, 42);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(87, 25);
            btnStop.TabIndex = 5;
            btnStop.Text = "Disconnect";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnCaptureStart
            // 
            btnCaptureStart.Font = new Font("Segoe UI", 9F);
            btnCaptureStart.ForeColor = Color.Chocolate;
            btnCaptureStart.Location = new Point(831, 79);
            btnCaptureStart.Name = "btnCaptureStart";
            btnCaptureStart.Size = new Size(102, 23);
            btnCaptureStart.TabIndex = 5;
            btnCaptureStart.Text = "Start Capture";
            btnCaptureStart.UseVisualStyleBackColor = true;
            btnCaptureStart.Click += btnCaptureStart_Click;
            // 
            // btnCaptureStop
            // 
            btnCaptureStop.ForeColor = Color.Red;
            btnCaptureStop.Location = new Point(130, 43);
            btnCaptureStop.Name = "btnCaptureStop";
            btnCaptureStop.Size = new Size(102, 23);
            btnCaptureStop.TabIndex = 6;
            btnCaptureStop.Text = "Stop Capture";
            btnCaptureStop.UseVisualStyleBackColor = true;
            btnCaptureStop.Click += btnCaptureStop_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCaptureStop);
            panel2.ForeColor = SystemColors.Highlight;
            panel2.Location = new Point(814, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 81);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(16, 18);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Capturing:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(98, 123);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(17, 25);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "l";
            lblMessage.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnViewImages);
            panel3.ForeColor = SystemColors.Highlight;
            panel3.Location = new Point(1090, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 81);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "View:";
            // 
            // btnViewImages
            // 
            btnViewImages.ForeColor = Color.ForestGreen;
            btnViewImages.Location = new Point(18, 43);
            btnViewImages.Name = "btnViewImages";
            btnViewImages.Size = new Size(92, 23);
            btnViewImages.TabIndex = 6;
            btnViewImages.Text = "View Captured";
            btnViewImages.UseVisualStyleBackColor = true;
            btnViewImages.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cboCaptureInterval);
            panel4.ForeColor = SystemColors.Highlight;
            panel4.Location = new Point(561, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 81);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(16, 18);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "Select Capture Interval:";
            label2.Click += label2_Click;
            // 
            // cboCaptureInterval
            // 
            cboCaptureInterval.FormattingEnabled = true;
            cboCaptureInterval.Location = new Point(16, 43);
            cboCaptureInterval.Name = "cboCaptureInterval";
            cboCaptureInterval.Size = new Size(191, 23);
            cboCaptureInterval.TabIndex = 0;
            cboCaptureInterval.SelectedIndexChanged += cboCaptureInterval_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1284, 9);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1325, 684);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnCaptureStart);
            Controls.Add(pic);
            Controls.Add(cboCamera);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lblMessage);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "r";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCamera;
        private PictureBox pic;
        private Button btnStart;
        private Panel panel1;
        private Button btnStop;
        private Button btnCaptureStart;
        private Button btnCaptureStop;
        private Panel panel2;
        private Panel panel3;
        private Button btnViewImages;
        private System.Windows.Forms.Timer timer1;
        private Label lblMessage;
        private Panel panel4;
        private ComboBox cboCaptureInterval;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
    }
}
