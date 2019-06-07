using System.Collections.Generic;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System;
using System.Data.SqlClient;
using System.IO;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace EntranceControl
{
   
    public partial class MainForm : Form
    {
        bool cameraPower = true;                                // Set Camera On/Off (true/false)
        bool gatePower = false;                                 // Set Gate Connection On/Off (true/false)
        bool ROIEnabled = true;                                 // Set ROI Enabled On/Off (true/false)
        VideoCapture _capture;                                  // Capture Video
        DateTime today;

        // Database
        public SqlConnection cnn;
        string connectionString;
        SqlCommand command, command2;
        SqlDataReader dataReader, dataReader2;
        SqlDataAdapter dataAdapter;

        // ROI (Region of Interest) Size and Position
        public struct ROI {
            public decimal width;
            public decimal height;
            public decimal positionX;
            public decimal positionY;
        }
        ROI roi = new ROI();

        // Valid Data List
        public struct ValidList
        {
            public string LP;
            public string OwnerName;
            public string Car;
            public string NationalCode;
            public string Description;
            public Mat CarImage;
            public Mat OwnerImage;
        }
        ValidList validList = new ValidList();

        public struct DetectionReport
        {
            public bool Validity;
            public string LP;
            public string DetectionDate;
            public string DetectionTime;
            public string OwnerName;
            public Mat CarImage;
            public Mat LPImage;
            public Mat OwnerImage;
        }
        DetectionReport detectionReport = new DetectionReport();

        // Frame Which Contains Offline/Online Images/Videos
        public struct Frame
        {
            public Mat FrameLoad;
            public decimal width;
            public decimal height;
            public decimal FPS;
            public double TotalFrames;
        }
        Frame frame = new Frame();
        Mat processedFrame = new Mat();
        Mat croppedFrame = new Mat();           // Cropped region for LP detection
        Mat ColorFrame = new Mat();             // Color Frame to Show
        Mat GrayFrame = new Mat();              // Grayscale Frame
        Mat GaussianFrame = new Mat();          // Gaussian Frame
        Mat ThresholdedFrame = new Mat();       // Thresholded Frame
        Mat EdgeDetectionFrame = new Mat();     // Canny-enabled Frame
        Mat OpenMorphFrame = new Mat();         // Open Morphological Frame
        Mat CloseMorphFrame = new Mat();        // Close Morphological Frame
        int gaussianKernel, thresholdValue, cannyThresholdFirst, cannyThresholdSecond;
        int openKernel, closeKernel;

        // License-Plate
        List<RotatedRect> PlateImagesList = new List<RotatedRect>();

        public MainForm() {
            InitializeComponent();

            try {
                connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True; MultipleActiveResultSets = True;
                    AttachDbFilename = C:\Users\Alex\Documents\Visual Studio 2015\Projects\EntranceControl\EntranceControl\GateDB.mdf";
                cnn = new SqlConnection(connectionString);
                dataAdapter = new SqlDataAdapter();
            } catch (Exception err) {
                MessageBox.Show("خطا در ارتباط با دیتابیس:\n" + err.ToString(), "خطا");
                System.Windows.Forms.Application.Exit();
            }

            ParametersInitialization();

            // Temp: Add row to DataGridView
            gridView_Recent_Fill();
            gridView_LastCross_Fill();
            gridView_Valid_Fill();
            gridView_Report_Fill();

            // License-Plate Detector
            
        }
        
        public void ParametersInitialization() {
            // Create Output Folder
            Directory.CreateDirectory("Report");
            today = DateTime.UtcNow.Date;

            // Set PictureBox Settings
            pictureBox_Online.Image = Properties.Resources.Initialize;
            pictureBoxROISetting.Image = Properties.Resources.Initialize;
            pictureBoxLicensePlate_groupBoxVehicles.Image = Properties.Resources.LP;
            pictureBox_OwnerImage.Image = Properties.Resources.OwnerImage;
            pictureBox_VehicleImage.Image = Properties.Resources.VehicleImage;
            pictureBox_Online.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxROISetting.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLicensePlate_groupBoxVehicles.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_OwnerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_VehicleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_LastLPImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_LastCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_LastOwnerImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set Vehicle Properties Form Inputs
            comboBox_LP_Char_VehicleProperties.DisplayMember = "Char";
            var comboboxItems = new[] {
                new { Char = "الف" }, new { Char = "ب" }, new { Char = "ج" }, new { Char = "د" }, new { Char = "ه" },
                new { Char = "و" }, new { Char = "ز" }, new { Char = "ح" }, new { Char = "ط" }, new { Char = "ی" },
                new { Char = "ک" }, new { Char = "ل" }, new { Char = "م" }, new { Char = "ن" }, new { Char = "ق" },
                new { Char = "ش" }, new { Char = "ت" }, new { Char = "س" }, new { Char = "ص" }, new { Char = "س" },
                new { Char = "تاکسی" }, new { Char = "عمومی" }, new { Char = "ث" }
            };
            comboBox_LP_Char_VehicleProperties.DataSource = comboboxItems;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 200;
            toolTip1.InitialDelay = 50;
            toolTip1.SetToolTip(this.textBox_VehicleType, "نمونه: پژو 206");
            toolTip1.SetToolTip(this.textBox_VehicleColor, "نمونه: مشکی");
            toolTip1.SetToolTip(this.textBox_OwnerName, "نمونه: حسین");
            toolTip1.SetToolTip(this.textBox_OwnerSurname, "نمونه: رضایی");
            toolTip1.SetToolTip(this.textBox_OwnerDescription, "نمونه: کارمند مالی");
            toolTip1.SetToolTip(this.textBox_NationalCode, "یک عدد 10 رقمی بدون خط تیره");

            // Set ROI Size and Position
            roi.width = 50;
            roi.height = 50;
            roi.positionX = 5;
            roi.positionY = 5;
            numericUpDownROIW.Value = roi.width;
            numericUpDownROIH.Value = roi.height;
            trackBarROIHorizontal.Value = (int) roi.positionX;
            trackBarROIVertical.Value = (int) roi.positionY;

            // Input Frame
            frame.FrameLoad = new Mat();
            frame.width = 0;
            frame.height = 0;
            frame.FPS = 0;
            frame.TotalFrames = 0;
            processedFrame = null;

            // Image Processing
            gaussianKernel = 1;
            thresholdValue = 100;
            cannyThresholdFirst = 20;
            cannyThresholdSecond = 50;
            openKernel = 1;
            closeKernel = 5;
            numericUpDownGaussian.Value = gaussianKernel;
            numericUpDownThreshold.Value = thresholdValue;
            numericUpDownEdge1.Value = cannyThresholdFirst;
            numericUpDownEdge2.Value = cannyThresholdSecond;
            numericUpDownMorphological_Open.Value = openKernel;
            numericUpDownMorphological_Close.Value = closeKernel;
        }

        private void gridView_Valid_Fill() {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT LPNumber, OwnerID, VehicleType, VehicleColor, VehicleImage FROM ValidList WHERE LPNumber IS NOT NULL ORDER BY LPNumber", cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read()) {
                    validList.LP = dataReader.GetValue(0).ToString();
                    db_OwnerFind_Valid(dataReader.GetValue(1).ToString());
                    validList.Car = dataReader.GetValue(2).ToString() + " " + dataReader.GetValue(3).ToString();
                    validList.CarImage = convertBinaryToImage((byte[]) dataReader.GetValue(4));
                    //validList.CarImage = CvInvoke.Imread("Temp_Car.jpg");       // Default should be 150x150                    
                    CvInvoke.Resize(validList.CarImage, validList.CarImage, new Size(150, 150), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    CvInvoke.Resize(validList.OwnerImage, validList.OwnerImage, new Size(150, 150), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    dataGridView_Valid.Rows.Add(validList.LP, validList.OwnerName, validList.Car, new Bitmap(validList.CarImage.Bitmap),
                        new Bitmap(validList.OwnerImage.Bitmap), validList.NationalCode, validList.Description);
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void gridView_Report_Fill()
        {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT LPNumber, Date, Time, Valid, OwnerID, LPImage, VehicleImage FROM Report WHERE LPNumber IS NOT NULL ORDER BY Date", cnn);
                dataReader = command.ExecuteReader();
                string validityText = "مجاز";
                while (dataReader.Read()) {
                    detectionReport.LP = dataReader.GetValue(0).ToString();
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString();
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString();
                    detectionReport.Validity = (bool) dataReader.GetValue(3);                    
                    if (!detectionReport.Validity) validityText = "غیرمجاز";
                    db_OwnerFind_Report(dataReader.GetValue(4).ToString());
                    // detectionReport.LPImage = dataReader.GetValue(5); -------- Temp Next Row
                    detectionReport.LPImage = CvInvoke.Imread("Temp_LP.jpg");       // Default should be 150x150
                    // detectionReport.LPImage = dataReader.GetValue(6); -------- Temp Next Row
                    detectionReport.CarImage = CvInvoke.Imread("Temp_Car.jpg");     // Default should be 150x150
                    CvInvoke.Resize(detectionReport.CarImage, detectionReport.CarImage, new Size(150, 150), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    CvInvoke.Resize(detectionReport.LPImage, detectionReport.LPImage, new Size(300, 56), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    dataGridView_Report.Rows.Add(detectionReport.LP, detectionReport.DetectionDate, detectionReport.DetectionTime, validityText,
                        detectionReport.OwnerName, new Bitmap(detectionReport.LPImage.Bitmap), new Bitmap(detectionReport.CarImage.Bitmap));
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void gridView_Recent_Fill() {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT TOP 10 LPNumber, Date, Time, Valid FROM Report WHERE LPNumber IS NOT NULL ORDER BY Date", cnn);
                dataReader = command.ExecuteReader();
                string validityText = "مجاز";
                while (dataReader.Read()) {
                    detectionReport.LP = dataReader.GetValue(0).ToString();
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString();
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString();
                    detectionReport.Validity = (bool) dataReader.GetValue(3);

                    if (!detectionReport.Validity) validityText = "غیرمجاز";

                    dataGridView_Recent.Rows.Add(detectionReport.LP, detectionReport.DetectionDate, detectionReport.DetectionTime, validityText);
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void gridView_LastCross_Fill()
        {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT TOP 1 LPNumber, Date, Time, Valid, OwnerID, LPImage, VehicleImage FROM Report WHERE LPNumber IS NOT NULL ORDER BY Date", cnn);
                dataReader = command.ExecuteReader();
                //string validityText = "مجاز";
                while (dataReader.Read()) {
                    detectionReport.LP = dataReader.GetValue(0).ToString();
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString();
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString();
                    detectionReport.Validity = (bool)dataReader.GetValue(3);
                    // detectionReport.LPImage = dataReader.GetValue(5); -------- Temp Next Row
                    detectionReport.LPImage = CvInvoke.Imread("Temp_LP.jpg");       // Default should be 150x150
                    // detectionReport.LPImage = dataReader.GetValue(6); -------- Temp Next Row
                    detectionReport.CarImage = CvInvoke.Imread("Temp_Car.jpg");     // Default should be 150x150
                    db_OwnerFind_Report(dataReader.GetValue(4).ToString());
                }                
                dataReader.Close();
                command.Dispose();

                string validityText = "مجاز (" + detectionReport.OwnerName + ")";
                if (!detectionReport.Validity) validityText = "غیرمجاز";

                label_LastDateTime.Text = detectionReport.DetectionDate + " - " + detectionReport.DetectionTime;
                label_LastLP.Text = detectionReport.LP;
                label_LastOwner.Text = validityText;

                pictureBox_LastLPImage.Image = new Bitmap(detectionReport.LPImage.Bitmap);
                pictureBox_LastOwnerImage.Image = new Bitmap(detectionReport.OwnerImage.Bitmap);
                pictureBox_LastCarImage.Image = new Bitmap(detectionReport.CarImage.Bitmap);
                
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void drawROI(Mat frameContent)
        {
            Rectangle RegionOfInterest = new Rectangle((int)roi.positionX, (int)roi.positionY, (int)roi.width, (int)roi.height);
            CvInvoke.Rectangle(frameContent, RegionOfInterest, new MCvScalar(0, 0, 255), 2);
            pictureBoxROISetting.Image = new Bitmap(frameContent.Bitmap);
            croppedFrame = new Mat(frame.FrameLoad, RegionOfInterest);
            pictureBox_Online.Image = new Bitmap(croppedFrame.Bitmap);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            // System.Diagnostics.Process.Start("mailto:a.tourani1991@gmail.com");
            MessageBox.Show("Developers:\rAli Tourani <a.tourani1991@gmail.com>\rAtefeh Ranjkesh <at.ranjkesh@yahoo.com>\r" +
                "\rSupervisors:\rDr. Alireza Akushideh <akushide@yahoo.com>\rDr. Asadollah Shahbahrami <shahbahrami1@gmail.com>", 
                "Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void radioButtonCameraOn_CheckedChanged(object sender, System.EventArgs e)
        {
            cameraPower = true;
        }

        private void radioButtonCameraOff_CheckedChanged(object sender, System.EventArgs e)
        {
            cameraPower = false;
        }

        private void radioButtonGateConnected_CheckedChanged(object sender, System.EventArgs e)
        {
            gatePower = true;
        }

        private void radioButtonGateDisconnected_CheckedChanged(object sender, System.EventArgs e)
        {
            gatePower = false;
        }

        private void radioButtonROIEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            ROIEnabled = true;
        }

        private void radioButtonROIDisabled_CheckedChanged(object sender, System.EventArgs e)
        {
            ROIEnabled = false;
        }

        private void buttonSetROICoverage_Click(object sender, System.EventArgs e)
        {
            if ( numericUpDownROIH.Value >=0 && numericUpDownROIH.Value < 100 && numericUpDownROIW.Value >= 0 &&
                numericUpDownROIW.Value < 100) {
                processedFrame = frame.FrameLoad.Clone();
                roi.height = (numericUpDownROIH.Value / 100) * frame.FrameLoad.Rows;
                roi.width = (numericUpDownROIW.Value / 100) * frame.FrameLoad.Cols;
                pictureBoxROISetting.Image = null;
                drawROI(processedFrame);
            }
        }

        private void trackBarROIHorizontal_Scroll(object sender, EventArgs e)
        {
            try {
                processedFrame = frame.FrameLoad.Clone();
                roi.positionX = (trackBarROIHorizontal.Value - 1) * (frame.width / 10);
                if ((roi.positionX + roi.width) >= frame.width)
                    roi.width = frame.width - roi.positionX - 1;
                if (roi.positionX <= 0) {
                    roi.positionX = 1;
                }
                drawROI(processedFrame);
            } catch(Exception error) {
                MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
            }
        }

        private void trackBarROIVertical_Scroll(object sender, EventArgs e)
        {
            try {
                processedFrame = frame.FrameLoad.Clone();
                roi.positionY = (trackBarROIVertical.Value - 1) * (frame.height / 10);
                if ((roi.positionY + roi.height) >= frame.height)
                    roi.height = frame.height - roi.positionY - 1;
                if (roi.positionY <= 0)
                {
                    roi.positionY = 1;
                }
                drawROI(processedFrame);
            }
            catch (Exception error)
            {
                MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            numericUpDown_LP_NumberL_VehicleProperties.Value = 11;
            comboBox_LP_Char_VehicleProperties.SelectedIndex = 0;
            numericUpDown_LP_NumberR_VehicleProperties.Value = 111;
            numericUpDown_LP_City_VehicleProperties.Value = 11;
            textBox_VehicleType.Text = "";
            textBox_VehicleColor.Text = "";
            radioButton_Man.Checked = true;
            radioButton_Woman.Checked = true;
            textBox_OwnerName.Text = "";
            textBox_OwnerSurname.Text = "";
            textBox_NationalCode.Text = "";
            textBox_OwnerDescription.Text = "";
            pictureBox_OwnerImage.Image = Properties.Resources.OwnerImage;
            pictureBox_VehicleImage.Image = Properties.Resources.VehicleImage;
        }

        private void pictureBox_OwnerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "تصویر مالک را انتخاب کنید";
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (dialog.ShowDialog() == DialogResult.OK) {
                try {
                    pictureBox_OwnerImage.Image = null;
                    pictureBox_OwnerImage.Image = new Bitmap(dialog.FileName);
                } catch (Exception error) {
                    MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
                }
            }
        }

        private void pictureBox_VehicleImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "تصویر خودرو را انتخاب کنید";
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox_VehicleImage.Image = null;
                    pictureBox_VehicleImage.Image = new Bitmap(dialog.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
                }
            }
        }

        private void button_OfflinePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "تصویری از خروجی گیت را انتخاب کنید";
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (dialog.ShowDialog() == DialogResult.OK) {
                try {
                    ParametersInitialization();
                    frame.FrameLoad = CvInvoke.Imread(dialog.FileName);
                    frame.FPS = 0;
                    frame.TotalFrames = 0;
                    CvInvoke.Resize(frame.FrameLoad, frame.FrameLoad, new Size(700 * frame.FrameLoad.Cols / frame.FrameLoad.Rows, 700));
                    frame.width = frame.FrameLoad.Cols;
                    frame.height = frame.FrameLoad.Rows;
                    processedFrame = frame.FrameLoad.Clone();
                    pictureBox_Online.Image = new Bitmap(processedFrame.Bitmap);
                    pictureBoxROISetting.Image = new Bitmap(processedFrame.Bitmap);                    

                    // Set ROI Size and Position
                    roi.positionX = 1;
                    roi.positionY = 1;
                    roi.width = frame.width / 2;
                    roi.height = frame.height / 2;

                    radioButton_ShowMainFrame.Checked = true;
                    drawROI(processedFrame);
                    FrameProcess();
                    LicensePlateDetector();

                    // Temp: Save image
                    // imageSave(frame.FrameLoad);
                } catch (Exception error) {
                    MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
                }
            }
        }

        private void button_ClearLoadedFrame_Click(object sender, EventArgs e)
        {
            pictureBox_Online.Image = null;
            pictureBoxROISetting.Image = null;
            pictureBox_Online.Image = Properties.Resources.Initialize;
            pictureBoxROISetting.Image = Properties.Resources.Initialize;
        }

        private void button_OfflineVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "یک ویدئوی نمونه را انتخاب کنید";
            dialog.Filter = "All Video Files|*.mp4;*.avi;*.wmv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _capture = new VideoCapture(dialog.FileName);
                if (dialog.FileName == "")
                    MessageBox.Show("ویدئوی موردنظر را انتخاب کنید", "خطا");
                else {
                    try {
                        // Initialize frames
                        ParametersInitialization();
                        frame.FrameLoad = new Mat();
                        frame.FPS = Convert.ToDecimal(_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                        frame.height = Convert.ToDecimal(_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                        frame.width = Convert.ToDecimal(_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
                        frame.TotalFrames = Convert.ToDouble(_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));

                        // Set ROI Size and Position
                        roi.positionX = 1;
                        roi.positionY = 1;
                        roi.width = frame.width / 2;
                        roi.height = frame.height / 2;

                        _capture.ImageGrabbed += VideoProcess;
                        _capture.Start();
                    } catch (Exception error) {
                        MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
                    }
                }
            }
        }

        public void VideoProcess(object sender, EventArgs e)
        {
            // Capture the frame of video
            _capture.Retrieve(frame.FrameLoad);
            drawROI(frame.FrameLoad);
        }

        public void FrameProcess() {
            try {
                ColorFrame = processedFrame.Clone();
                CvInvoke.CvtColor(ColorFrame, processedFrame, Emgu.CV.CvEnum.ColorConversion.Bgra2Gray, 1);
                GrayFrame = processedFrame.Clone();
                CvInvoke.GaussianBlur(processedFrame, processedFrame, new Size(gaussianKernel, gaussianKernel), 1);
                GaussianFrame = processedFrame.Clone();
                CvInvoke.Threshold(processedFrame, processedFrame, thresholdValue, 100, Emgu.CV.CvEnum.ThresholdType.Binary);
                ThresholdedFrame = processedFrame.Clone();
                CvInvoke.Canny(processedFrame, processedFrame, cannyThresholdFirst, cannyThresholdSecond);
                EdgeDetectionFrame = processedFrame.Clone();
                var kernelOpen = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(openKernel, openKernel), new Point(-1, -1));
                CvInvoke.MorphologyEx(processedFrame, processedFrame, Emgu.CV.CvEnum.MorphOp.Open, kernelOpen, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());
                OpenMorphFrame = processedFrame.Clone();
                var kernelClose = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(closeKernel, closeKernel), new Point(-1, -1));
                CvInvoke.MorphologyEx(processedFrame, processedFrame, Emgu.CV.CvEnum.MorphOp.Close, kernelClose, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());
                CloseMorphFrame = processedFrame.Clone();
            } catch (Exception error) {
                MessageBox.Show("خطای زیر رخ داده است: \r\n" + error.ToString(), "خطا");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                //
            } catch (Exception err) {
                MessageBox.Show("خطای زیر در هنگام بستن ارتباط با دیتابیس رخ داده است: \r\n" + err.ToString(), "خطا");
            }
        }

        private void radioButton_ShowMainFrame_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowMainFrame.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(ColorFrame.Bitmap);
        }
                
        private void radioButton_ShowGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowGrayscale.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(GrayFrame.Bitmap);
        }

        private void radioButton_ShowGaussian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowGaussian.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(GaussianFrame.Bitmap);
        }

        private void radioButton_ShowEdge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowEdge.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(EdgeDetectionFrame.Bitmap);
        }

        private void radioButton_ShowThreshold_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowThreshold.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(ThresholdedFrame.Bitmap);
        }

        private void radioButton_ShowMorphological_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowMorphological.Checked && processedFrame != null)
                pictureBoxROISetting.Image = new Bitmap(CloseMorphFrame.Bitmap);
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            db_Insert_ValidList("19ق656", "1130136205", "Pride", "Sefid", processedFrame);
        }

        private void button_SubmitCalibration_Click(object sender, EventArgs e)
        {
            if (processedFrame != null) {
                gaussianKernel = (int) numericUpDownGaussian.Value;
                thresholdValue = (int) numericUpDownThreshold.Value;
                cannyThresholdFirst = (int) numericUpDownEdge1.Value;
                cannyThresholdSecond = (int) numericUpDownEdge2.Value;
                openKernel = (int) numericUpDownMorphological_Open.Value;
                closeKernel = (int) numericUpDownMorphological_Close.Value;
                processedFrame = frame.FrameLoad.Clone();
                pictureBoxROISetting.Image = new Bitmap(processedFrame.Bitmap);
                radioButton_ShowMainFrame.Checked = true;
                FrameProcess();
            }
        }

        private void button_DefaultCalibration_Click(object sender, EventArgs e)
        {
            gaussianKernel = 1;
            thresholdValue = 10;
            cannyThresholdFirst = 20;
            cannyThresholdSecond = 50;
            openKernel = 5;
            closeKernel = 5;
            numericUpDownGaussian.Value = gaussianKernel;
            numericUpDownThreshold.Value = thresholdValue;
            numericUpDownEdge1.Value = cannyThresholdFirst;
            numericUpDownEdge2.Value = cannyThresholdSecond;
            numericUpDownMorphological_Open.Value = openKernel;
            numericUpDownMorphological_Close.Value = closeKernel;
        }

        byte[] convertImageToBinary(Mat inputImage) {
            using (MemoryStream stream = new MemoryStream()) {
                Image imgeOrigenal = new Bitmap(inputImage.Bitmap);
                imgeOrigenal.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        Mat convertBinaryToImage(byte[] inputImageObject) {
            Mat imageMatrix = new Mat();
            using (MemoryStream stream = new MemoryStream(inputImageObject)) {
                imageMatrix = convertImageToMat(Image.FromStream(stream));
                return imageMatrix;
            }
        }

        private Mat convertImageToMat(Image image) {
            int stride = 0;
            Bitmap bmp = new Bitmap(image);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            System.Drawing.Imaging.PixelFormat pf = bmp.PixelFormat;
            if (pf == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                stride = bmp.Width * 4;
            else
                stride = bmp.Width * 3;

            Image<Bgra, byte> cvImage = new Image<Bgra, byte>(bmp.Width, bmp.Height, stride, (IntPtr)bmpData.Scan0);
            bmp.UnlockBits(bmpData);

            return cvImage.Mat;
        }

        private void db_OwnerFind_Report(string ownerID) {
            try {
                command2 = new SqlCommand("SELECT Top 1 Name, Surname, OwnerImage FROM Owner WHERE NationalCode = " + ownerID + " ORDER BY NationalCode", cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read()) {
                    detectionReport.OwnerName = dataReader2.GetValue(0).ToString() + " " + dataReader2.GetValue(1).ToString();
                    // --------------------- Temp Below Row -------------------------
                    // detectionReport.OwnerImage = dataReader.GetValue(2).ToString();
                    detectionReport.OwnerImage = CvInvoke.Imread("Temp_Person.jpg");     // Default should be 150x150
                }
                dataReader2.Close();
                command2.Dispose();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
            }
        }

        private void db_OwnerFind_Valid(string ownerID) {
            try {
                command2 = new SqlCommand("SELECT Top 1 NationalCode, Name, Surname, Description, OwnerImage FROM Owner WHERE NationalCode = " + ownerID + " ORDER BY NationalCode", cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read()) {
                    validList.NationalCode = dataReader2.GetValue(0).ToString();
                    validList.OwnerName = dataReader2.GetValue(1).ToString() + " " + dataReader2.GetValue(2).ToString();
                    validList.Description = dataReader2.GetValue(3).ToString();
                    // --------------------- Temp Below Row -------------------------
                    // validList.OwnerImage = dataReader2.GetValue(4).ToString();
                    validList.OwnerImage = CvInvoke.Imread("Temp_Person.jpg");  // Default should be 150x150
                }
                dataReader2.Close();
                command2.Dispose();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
            }
        }

        private void db_Insert_ValidList(string LPNumber, string OwnerID, string VehicleType, string VehicleColor, Mat VehicleImageMat) {
            try {
                cnn.Open();
                byte[] VehicleImage = convertImageToBinary(VehicleImageMat);

                String query = "INSERT INTO ValidList(LPNumber,OwnerID,VehicleType,VehicleColor,VehicleImage)" +
                    " VALUES (@LPNumber,@OwnerID,@VehicleType,@VehicleColor,@VehicleImage)";

                using (SqlCommand command = new SqlCommand(query, cnn)) {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@VehicleType", VehicleType);
                    command.Parameters.AddWithValue("@VehicleColor", VehicleColor);
                    command.Parameters.AddWithValue("@VehicleImage", VehicleImage);

                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                        MessageBox.Show("خطا در واردکردن داده جدید به لیست افراد مجاز");
                    else
                        MessageBox.Show("فرد مجاز به درستی وارد لیست شد");
                }
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
            }
        }

        private void LicensePlateDetector() {
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint()) {
                CvInvoke.FindContours(EdgeDetectionFrame, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++) {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint()) {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        CvInvoke.DrawContours(ThresholdedFrame, contours, i, new MCvScalar(90, 120, 255), 2);

                        var moments = CvInvoke.Moments(contours[i]);
                        int x = (int)(moments.M10 / moments.M00);
                        int y = (int)(moments.M01 / moments.M00);

                        // Set a threshold to consider only special areas
                        if (CvInvoke.ContourArea(approxContour, false) > 100) {
                            // If it has 4 vertices (rectangle)
                            if (approxContour.Size == 4) {
                                bool isRectangle = true;
                                Point[] pts = approxContour.ToArray();
                                Rectangle boundingBox = CvInvoke.BoundingRectangle(contours[i]);

                                double ratio = (double)(boundingBox.Width / boundingBox.Height);
                                // LP Ratio: 5.375
                                if (ratio >= 3 && ratio <= 7)
                                    CvInvoke.Rectangle(ColorFrame, boundingBox, new MCvScalar(0, 255, 255), 2);
                                // CvInvoke.PutText(ThresholdedFrame, "LP", new Point(x, y), FontFace.HersheySimplex, 0.5, new MCvScalar(0,0,255), 2);
                                /*
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);
                                for (int j = 0; j < edges.Length; j++) {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100) {
                                        isRectangle = false;
                                        break;
                                    }
                                }*/
                                if (isRectangle) PlateImagesList.Add(CvInvoke.MinAreaRect(approxContour));                                
                            }
                        }
                    }
                }
                pictureBox_Online.Image = new Bitmap(ColorFrame.Bitmap);
            }

            // Draw the detected LPs
            /*
            Mat rectangleImage = processedFrame.Clone();
            foreach (RotatedRect box in PlateImagesList) {
                int width = (int)Math.Round(box.Size.Height);
                int height = (int)Math.Round(box.Size.Width);
                Size axesSize = new Size(width, height);
                Point center = Point.Round(box.Center);
                CvInvoke.Ellipse(rectangleImage, center, axesSize, box.Angle, 0.0D, 360.0D, new MCvScalar(90, 120, 255), 2, LineType.EightConnected, 0);
            }*/
            // pictureBox_Online.Image = new Bitmap(rectangleImage.Bitmap);            
        }

        private void imageSave(Mat outputImage) {
            try {
                String fileName = today.ToString("yyyyMMdd") + "-" + DateTime.Now.ToString("hhmmss") + ".png";
                // Create a new folder if not exists
                Directory.CreateDirectory(Path.Combine("Report", today.ToString("yyyy/MM")));
                outputImage.Save(Path.Combine("Report", today.ToString("yyyy/MM"), fileName));
            } catch (Exception error) {
                MessageBox.Show("خطای زیر در ذخیره تصویر رخ داده است: \r\n" + error, "خطا");
            }            
        }
    }
}
