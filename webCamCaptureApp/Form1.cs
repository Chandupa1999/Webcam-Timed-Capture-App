using System;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.IO;
using System.Timers;


namespace webCamCaptureApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            captureTimer = new System.Windows.Forms.Timer();
            captureTimer.Interval = 10000; // 10 seconds
            captureTimer.Tick += CaptureTimer_Tick;

            // Timer to hide the label after 3 seconds
            messageTimer = new System.Windows.Forms.Timer();
            messageTimer.Interval = 5000; // 3 seconds
            messageTimer.Tick += MessageTimer_Tick;


            // Ensure save directory exists
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }


            // Initialize lblMessage properties (optional if set in Designer)
            lblMessage.Visible = false;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.ForeColor = Color.Black;
            lblMessage.Font = new Font("Arial", 9, FontStyle.Bold);


        }






        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private System.Windows.Forms.Timer captureTimer; // Timer for auto-capturing
        private System.Windows.Forms.Timer messageTimer; // Timer to clear the overlay message
        private bool isCapturing = false; // Flag to track capturing state
        private string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "CapturedImages"); // Folder for saving images







        private void btnStart_Click_1(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            //btnStart.Enabled = false;
            //btnStop.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                pic.Image = null;  // Clear the picture box after stopping
            }
            //btnStart.Enabled = true;
            //btnStop.Enabled = false;
        }








        //image capturing part
        private void btnCaptureStart_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice == null || !videoCaptureDevice.IsRunning)
            {
                MessageBox.Show("Error: Please start the camera first!", "Camera Not Running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (isCapturing) return; // Prevent multiple messages

            isCapturing = true;
            captureTimer.Start(); // Start capturing every 10 seconds
            ShowMessage("Capturing Started...");
            MessageBox.Show("Images will be captured and stored from here...", "Start Capturing images", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Get the selected interval and apply it
            captureTimer.Interval = GetIntervalFromSelection(cboCaptureInterval.SelectedItem.ToString());
            captureTimer.Start();
            // Disable the dropdown while capturing
            cboCaptureInterval.Enabled = false;

            // Disable Start button and enable Stop button
           btnCaptureStart.Enabled = false;
            btnCaptureStop.Enabled = true;
        }

        private void btnCaptureStop_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice == null || !videoCaptureDevice.IsRunning)
            {
                MessageBox.Show("Error: Please start the camera first!", "Camera Not Running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!isCapturing) return; // Prevent multiple messages

            isCapturing = false;
            captureTimer.Stop(); // Stop capturing
            ShowMessage("Capturing Stopped");
            MessageBox.Show("Capturing Images will be stoped from here...", "Stop Capturing images", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Enable the dropdown again when capturing stops
            cboCaptureInterval.Enabled = true;

            // Disable Stop button and enable Start button
           btnCaptureStart.Enabled = true;
           btnCaptureStop.Enabled = false;
        }






        private void btnViewImages_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", savePath); // Open folder
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            if (isCapturing && pic.Image != null)
            {
                CaptureImage();
            }
        }

        private void CaptureImage()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string fileName = Path.Combine(savePath, $"Capture_{timestamp}.jpg");

            try
            {
                pic.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message);
            }
        }











        private void Form1_Load_1(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();



            // Populate the capture interval dropdown
            cboCaptureInterval.Items.AddRange(new object[]
            {
        "1 second","5 seconds", "10 seconds", "30 seconds", "1 minute",
        "2 minutes", "3 minutes", "5 minutes", "10 minutes",
        "15 minutes", "30 minutes", "1 hour", "2 hours",
        "3 hours", "5 hours", "10 hours", "12 hours", "24 hours"
            });

            // Set default interval to 10 seconds
            cboCaptureInterval.SelectedIndex = 1;

            // Attach event to handle selection change
            cboCaptureInterval.SelectedIndexChanged += cboCaptureInterval_SelectedIndexChanged;
        }








        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic.Invoke((MethodInvoker)delegate
            {
                pic.Image = (Bitmap)eventArgs.Frame.Clone();
            });
        }



















        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }








        // Function to show a message in the label for 3 seconds
        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
            lblMessage.Visible = true;
            messageTimer.Start(); // Start the 3-second countdown
        }

        // Function to hide the message after 3 seconds
        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            messageTimer.Stop();
        }











        private void cboCaptureInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            int interval = GetIntervalFromSelection(cboCaptureInterval.SelectedItem.ToString());
            captureTimer.Interval = interval;
        }

        // Helper function to convert selected text to milliseconds
        private int GetIntervalFromSelection(string selectedText)
        {
            switch (selectedText)
            {
                case "1 second": return 1000;
                case "5 seconds": return 5000;
                case "10 seconds": return 10000;
                case "30 seconds": return 30000;
                case "1 minute": return 60000;
                case "2 minutes": return 120000;
                case "3 minutes": return 180000;
                case "5 minutes": return 300000;
                case "10 minutes": return 600000;
                case "15 minutes": return 900000;
                case "30 minutes": return 1800000;
                case "1 hour": return 3600000;
                case "2 hours": return 7200000;
                case "3 hours": return 10800000;
                case "5 hours": return 18000000;
                case "10 hours": return 36000000;
                case "12 hours": return 43200000;
                case "24 hours": return 86400000;
                default: return 10000; // Default to 10 seconds if something goes wrong
            }
        }





















        private void pic_Click(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }




        private void btnCaptureStop_Click(object sender, EventArgs e)
        {

        }

        private void cboCaptureInterval_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aboutText = "Camera Capturing System\n\n" +
                       "Version: 1.0\n" +
                       "Developed by: Chandupa Perera\n\n" +
                       "This application allows users to capture images from a connected webcam at customizable time intervals. Users can start and stop capturing images, select a delay between captures, and access saved images.\n\n" +
                       "Features:\n" +
                       "✔ Displays a real-time preview of the selected camera.\n" +
                       "✔ Allows users to start and stop automatic image capturing.\n" +
                       "✔ Users can select time interval from 5 seconds to 24 hours.\n" +
                       "✔ Captured images are saved with timestamp as the filename.\n" +
                       "✔ A dedicated button to access and view saved images.\n\n" +
                       "📧 Contact: yashasvichandupa@gmail.com\n" +
                       "📞 Phone: +94713684090";


            MessageBox.Show(aboutText, "Camera Capturing System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
