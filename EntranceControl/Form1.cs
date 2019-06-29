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
        Mat uploadedOwnerImage, uploadedVehicleImage;

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
                    AttachDbFilename = D:\Git\gate-lpr\EntranceControl\GateDB.mdf";
                cnn = new SqlConnection(connectionString);
                dataAdapter = new SqlDataAdapter();
            } catch (Exception err) {
                MessageBox.Show("خطا در ارتباط با دیتابیس:\n" + err.ToString(), "خطا");
                System.Windows.Forms.Application.Exit();
            }

            ParametersInitialization();

            // Add rows to DataGridView
            gridView_Recent_Fill();
            gridView_LastCross_Fill();
            gridView_Valid_Fill();
            gridView_Report_Fill();            
        }
        
        public void ParametersInitialization() {
            // Create Necessary Folders
            Directory.CreateDirectory("Report");
            Directory.CreateDirectory("Owner");         // To Save Valid Persons Images
            Directory.CreateDirectory("Vehicle");       // To Save Valid Persons Vehicle Images
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

            // Data Management
            uploadedOwnerImage = null;
            uploadedVehicleImage = null;
        }

        private void gridView_Valid_Fill() {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT ValidList.LPNumber, Owner.Name, Owner.Surname, ValidList.VehicleType, ValidList.VehicleColor, " +
                    "ValidList.VehicleImage, ValidList.OwnerID, Owner.Description FROM ValidList INNER JOIN Owner ON ValidList.OwnerID=Owner.NationalCode " +
                    "ORDER BY LPNumber", cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read()) {
                    validList.LP = dataReader.GetValue(0).ToString();
                    validList.OwnerName = dataReader.GetValue(1).ToString().Replace(" ", "") + " " + dataReader.GetValue(2).ToString().Replace(" ", "");
                    validList.Car = dataReader.GetValue(3).ToString() + " " + dataReader.GetValue(4).ToString();
                    validList.CarImage = CvInvoke.Imread("Vehicle/" + dataReader.GetValue(5).ToString() + ".png");
                    validList.NationalCode = dataReader.GetValue(6).ToString();
                    validList.OwnerImage = CvInvoke.Imread("Owner/" + validList.NationalCode + ".png");
                    validList.Description = dataReader.GetValue(7).ToString();
                    CvInvoke.Resize(validList.CarImage, validList.CarImage, new Size(150, 150), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    CvInvoke.Resize(validList.OwnerImage, validList.OwnerImage, new Size(150, 150), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
                    dataGridView_Valid.Rows.Add(validList.LP, validList.OwnerName, validList.Car, new Bitmap(validList.CarImage.Bitmap),
                        new Bitmap(validList.OwnerImage.Bitmap), validList.NationalCode, validList.Description);
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در پر کردن لیست افراد مجاز:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void gridView_Report_Fill()
        {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT Report.LPNumber, Report.Date, Report.Time, Report.Valid, Owner.Name, Owner.Surname, Report.LPImage, " +
                    "Report.VehicleImage FROM Report LEFT JOIN Owner ON Report.OwnerID=Owner.NationalCode ORDER BY Report.Date", cnn);
                dataReader = command.ExecuteReader();
                string validityText = "مجاز";
                while (dataReader.Read()) {
                    detectionReport.LP = dataReader.GetValue(0).ToString();
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString().Substring(0, dataReader.GetValue(1).ToString().IndexOf(" "));
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString().Substring(0, 5);
                    detectionReport.Validity = (bool) dataReader.GetValue(3);                    
                    if (!detectionReport.Validity) validityText = "غیرمجاز";
                    detectionReport.OwnerName = dataReader.GetValue(4).ToString().Replace(" ", "") + " " + dataReader.GetValue(5).ToString().Replace(" ", "");
                    string LPImageName = dataReader.GetValue(6).ToString();
                    string CarImageName = dataReader.GetValue(7).ToString();
                    detectionReport.LPImage = CvInvoke.Imread("Report/" + LPImageName.Substring(0, 4) + "/" + LPImageName.Substring(4, 2) + "/" + LPImageName + ".png");
                    detectionReport.CarImage = CvInvoke.Imread("Report/" + CarImageName.Substring(0, 4) + "/" + CarImageName.Substring(4, 2) + "/" + CarImageName + ".png");
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
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString().Substring(0, dataReader.GetValue(1).ToString().IndexOf(" "));
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString().Substring(0, 5);
                    detectionReport.Validity = (bool) dataReader.GetValue(3);

                    if (!detectionReport.Validity) validityText = "غیرمجاز";

                    dataGridView_Recent.Rows.Add(detectionReport.LP, detectionReport.DetectionDate, detectionReport.DetectionTime, validityText);
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در واکشی رکوردهای لیست آخرین تردد:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void gridView_LastCross_Fill()
        {
            try {
                cnn.Open();
                command = new SqlCommand("SELECT TOP 1 Report.LPNumber, Report.Date, Report.Time, Report.Valid, Owner.Name, " +
                    "Owner.Surname, Report.OwnerID, Report.LPImage, Report.VehicleImage FROM Report INNER JOIN Owner ON Report.OwnerID=Owner.NationalCode ORDER BY Date", cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read()) {
                    detectionReport.LP = dataReader.GetValue(0).ToString();
                    detectionReport.DetectionDate = dataReader.GetValue(1).ToString().Substring(0, dataReader.GetValue(1).ToString().IndexOf(" "));
                    detectionReport.DetectionTime = dataReader.GetValue(2).ToString().Substring(0, 5);
                    detectionReport.Validity = (bool) dataReader.GetValue(3);
                    detectionReport.OwnerName = dataReader.GetValue(4).ToString().Replace(" ", "") + " " + dataReader.GetValue(5).ToString().Replace(" ", "");
                    detectionReport.OwnerImage = CvInvoke.Imread("Owner/" + dataReader.GetValue(6) + ".png");
                    string LPImageName = dataReader.GetValue(7).ToString();
                    string CarImageName = dataReader.GetValue(8).ToString();
                    detectionReport.LPImage = CvInvoke.Imread("Report/" + LPImageName.Substring(0,4) + "/" + LPImageName.Substring(4,2) + "/" + LPImageName + ".png");
                    detectionReport.CarImage = CvInvoke.Imread("Report/" + CarImageName.Substring(0,4) + "/" + CarImageName.Substring(4,2) + "/" + CarImageName + ".png");
                }
                dataReader.Close();
                command.Dispose();
                
                string validityText = "مجاز (" + detectionReport.OwnerName + ")";
                if (!detectionReport.Validity) validityText = "غیرمجاز";

                label_LastDateTime.Text = detectionReport.DetectionDate + " - " + detectionReport.DetectionTime;
                label_LastLP.Text = detectionReport.LP;
                label_LastOwner.Text = validityText;
                pictureBox_LastLPImage.Image = new Bitmap(detectionReport.LPImage.Bitmap);
                pictureBox_LastCarImage.Image = new Bitmap(detectionReport.CarImage.Bitmap);
                pictureBox_LastOwnerImage.Image = new Bitmap(detectionReport.OwnerImage.Bitmap);
                
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در پر کردن اطلاعات آخرین تردد:\n" + err.ToString(), "خطا");
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
                FrameProcess();
                LicensePlateDetector();
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
                FrameProcess();
                LicensePlateDetector();
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
            radioButton_Woman.Checked = false;
            textBox_OwnerName.Text = "";
            textBox_OwnerSurname.Text = "";
            textBox_NationalCode.Text = "";
            textBox_OwnerDescription.Text = "";
            pictureBox_OwnerImage.Image = Properties.Resources.OwnerImage;
            pictureBox_VehicleImage.Image = Properties.Resources.VehicleImage;
            uploadedOwnerImage = null;
            uploadedVehicleImage = null;
        }

        private void pictureBox_OwnerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "تصویر مالک را انتخاب کنید";
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (dialog.ShowDialog() == DialogResult.OK) {
                try {
                    pictureBox_OwnerImage.Image = null;
                    uploadedOwnerImage = CvInvoke.Imread(dialog.FileName);
                    pictureBox_OwnerImage.Image = new Bitmap(uploadedOwnerImage.Bitmap);
                } catch (Exception error) {
                    MessageBox.Show("خطا در آپلود تصویر مالک خودرو: \r\n" + error.ToString(), "خطا");
                }
            }
        }

        private void pictureBox_VehicleImage_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "تصویر خودرو را انتخاب کنید";
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (dialog.ShowDialog() == DialogResult.OK) {
                try {
                    pictureBox_VehicleImage.Image = null;
                    uploadedVehicleImage = CvInvoke.Imread(dialog.FileName);
                    pictureBox_VehicleImage.Image = new Bitmap(uploadedVehicleImage.Bitmap);
                } catch (Exception error) {
                    MessageBox.Show("خطا در آپلود تصویر خودرو: \r\n" + error.ToString(), "خطا");
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
                    // imageSave(frame.FrameLoad, "Detection");
                }
                catch (Exception error) {
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
            string LPNumber = "";
            string NationalCode = "";
            // Add Owner Information
            if (textBox_OwnerName.Text.Length < 3 && textBox_OwnerSurname.Text.Length < 3 && textBox_NationalCode.Text.Length < 10) {
                MessageBox.Show("همه فیلدهای ضروری مربوط به مالک را پر کنید");
            } else {
                bool TempGender = radioButton_Man.Checked ? true : false;
                NationalCode = textBox_NationalCode.Text;
                string TempDescription = (textBox_OwnerDescription.Text.Length < 3) ? "-نامشخص-" : textBox_OwnerDescription.Text;
                db_Create_Owner(NationalCode, textBox_OwnerName.Text, textBox_OwnerSurname.Text, TempGender, TempDescription);
            }
            // Add Valid Car Information
            if (textBox_VehicleColor.Text.Length < 2 && textBox_VehicleType.Text.Length < 1) {
                MessageBox.Show("همه فیلدهای ضروری مربوط به خودروی مجاز را پر کنید");
            } else {
                LPNumber = numericUpDown_LP_NumberL_VehicleProperties.Value + "-" + comboBox_LP_Char_VehicleProperties.SelectedIndex
                    + "-" + numericUpDown_LP_NumberR_VehicleProperties.Value + "-" + numericUpDown_LP_City_VehicleProperties.Value;
                db_Create_ValidList(LPNumber, textBox_NationalCode.Text, textBox_VehicleType.Text, textBox_VehicleColor.Text, LPNumber);
            }
            // Add Vehicle Image
            try {
                String fileName = LPNumber + ".png";
                uploadedVehicleImage.Save(Path.Combine("Vehicle", fileName));
            } catch (Exception error) {
                MessageBox.Show("خطا در آپلود تصویر خودروی جدید: \r\n" + error, "خطا");
            }
            // Add Owner Image
            try {
                String fileName = NationalCode + ".png";
                uploadedOwnerImage.Save(Path.Combine("Owner", fileName));
            } catch (Exception error) {
                MessageBox.Show("خطا در آپلود تصویر مالک جدید: \r\n" + error, "خطا");
            }
            // Clear Fields
            button_Clear_Click(sender, e);
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
                drawROI(processedFrame);
                FrameProcess();
                LicensePlateDetector();
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

        private void db_Create_Owner(string NationalCode, string Name, string Surname, bool Gender, string Description)
        {
            try {
                cnn.Open();
                String query = "INSERT INTO Owner(NationalCode, Name, Surname, Gender, Description)" +
                    " VALUES (@NationalCode, @Name, @Surname, @Gender, @Description)";
                using (SqlCommand command = new SqlCommand(query, cnn)) {
                    command.Parameters.AddWithValue("@NationalCode", NationalCode);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Surname", Surname);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Description", Description);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در واردکردن داده جدید به لیست مالکین خودروها");
                    else
                        MessageBox.Show("مالک جدید به درستی وارد لیست شد");
                }
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Create_Report(string LPNumber, string OwnerID, bool Valid, string Date, string Time, string LPImage, string VehicleImage)
        {
            try {
                cnn.Open();
                String query = "INSERT INTO Report(LPNumber, OwnerID, Valid, Date, Time, LPImage, VehicleImage)" +
                    " VALUES (@LPNumber, @OwnerID, @Valid, @Date, @Time, @LPImage, @VehicleImage)";
                using (SqlCommand command = new SqlCommand(query, cnn)) {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@Valid", Valid);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Time", Time);
                    command.Parameters.AddWithValue("@LPImage", LPImage);
                    command.Parameters.AddWithValue("@VehicleImage", VehicleImage);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در واردکردن داده جدید به لیست گزارش");
                    else
                        MessageBox.Show("گزارش جدید به درستی وارد لیست شد");
                }
                cnn.Close();
                // Adding LP Image and Vehicle image to the directory
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Create_ValidList(string LPNumber, string OwnerID, string VehicleType, string VehicleColor, string VehicleImage)
        {
            try {
                cnn.Open();
                String query = "INSERT INTO ValidList(LPNumber, OwnerID, VehicleType, VehicleColor, VehicleImage)" +
                    " VALUES (@LPNumber, @OwnerID, @VehicleType, @VehicleColor, @VehicleImage)";
                using (SqlCommand command = new SqlCommand(query, cnn)) {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@VehicleType", VehicleType);
                    command.Parameters.AddWithValue("@VehicleColor", VehicleColor);
                    command.Parameters.AddWithValue("@VehicleImage", VehicleImage);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در واردکردن داده جدید به لیست گزارش");
                    else
                        MessageBox.Show("گزارش جدید به درستی وارد لیست شد");
                }
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Read_Owner(string ownerID)
        {
            try {
                command2 = new SqlCommand("SELECT Top 1 Name, Surname, Gender, Description FROM Owner WHERE NationalCode = '" + ownerID + "' ORDER BY NationalCode", cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read()) {
                    validList.OwnerName = dataReader2.GetValue(0).ToString() + " " + dataReader2.GetValue(1).ToString();
                    validList.Description = dataReader2.GetValue(3).ToString();
                }
                dataReader2.Close();
                command2.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Read_Report(string LPNumber)
        {
            try
            {
                command2 = new SqlCommand("SELECT Top 1 OwnerID, Valid, Date, Time, LPImage, VehicleImage FROM Report WHERE LPNumber = '" + LPNumber + "' ORDER BY LPNumber", cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read())
                {
                    // detectionReport.OwnerName = dataReader2.GetValue(0).ToString() + " " + dataReader2.GetValue(1).ToString();
                    // detectionReport.OwnerImage = CvInvoke.Imread("Temp_Person.jpg");     // Default should be 150x150
                }
                dataReader2.Close();
                command2.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Read_ValidList(string LPNumber)
        {
            try
            {
                command2 = new SqlCommand("SELECT Top 1 OwnerID, VehicleType, VehicleColor, VehicleImage FROM ValidList WHERE LPNumber = '" + LPNumber + "' ORDER BY LPNumber", cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read())
                {
                    // detectionReport.OwnerName = dataReader2.GetValue(0).ToString() + " " + dataReader2.GetValue(1).ToString();
                    // detectionReport.OwnerImage = CvInvoke.Imread("Temp_Person.jpg");     // Default should be 150x150
                }
                dataReader2.Close();
                command2.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        public void db_Delete_Owner(string NationalCode)
        {
            try
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Owner WHERE NationalCode = @NationalCode", cnn))
                {
                    command.Parameters.AddWithValue("@NationalCode", NationalCode);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در حذف مالک");
                    else
                        MessageBox.Show("مالک به درستی حذف شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در حذف مالک خودرو:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        public void db_Delete_Report(string LPNumber)
        {
            try
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Report WHERE LPNumber = @LPNumber", cnn))
                {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در حذف رکورد از گزارش");
                    else
                        MessageBox.Show("رکورد گزارش به درستی حذف شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در حذف رکورد گزارش:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        public void db_Delete_ValidList(string LPNumber)
        {
            try
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM ValidList WHERE LPNumber = @LPNumber", cnn))
                {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در حذف رکورد از لیست افراد مجاز");
                    else
                        MessageBox.Show("فرد مجاز به درستی حذف شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در حذف فرد مجاز:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Update_Owner(string NationalCode, string Name, string Surname, bool Gender, string Description)
        {
            try
            {
                cnn.Open();
                String query = "UPDATE Owner SET Name=@Name, Surname = @Surname, Gender = @Gender, Description = @Description" +
                    " WHERE NationalCode = @NationalCode";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@NationalCode", NationalCode);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Surname", Surname);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Description", Description);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در به روز رسانی لیست مالکین خودروها");
                    else
                        MessageBox.Show("مالک به درستی به روز شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Update_Report(string LPNumber, string OwnerID, bool Valid, string Date, string Time, string LPImage, string VehicleImage)
        {
            try
            {
                cnn.Open();
                String query = "UPDATE Report SET OwnerID = @OwnerID, Valid = @Valid, Date = @Date," +
                    "Time = @Time, LPImage = @LPImage, VehicleImage = @VehicleImage WHERE LPNumber = @LPNumber";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@Valid", Valid);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Time", Time);
                    command.Parameters.AddWithValue("@LPImage", LPImage);
                    command.Parameters.AddWithValue("@VehicleImage", VehicleImage);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در به روز رسانی لیست گزارش");
                    else
                        MessageBox.Show("گزارش به درستی به روز شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
            }
        }

        private void db_Update_ValidList(string LPNumber, string OwnerID, string VehicleType, string VehicleColor, string VehicleImage)
        {
            try
            {
                cnn.Open();
                String query = "UPDATE ValidList SET OwnerID = @OwnerID, VehicleType = @VehicleType, VehicleColor = @VehicleColor, VehicleImage = @VehicleImage" + 
                    " WHERE LPNumber = @LPNumber";
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@LPNumber", LPNumber);
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@VehicleType", VehicleType);
                    command.Parameters.AddWithValue("@VehicleColor", VehicleColor);
                    command.Parameters.AddWithValue("@VehicleImage", VehicleImage);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("خطا در به روز رسانی لیست گزارش");
                    else
                        MessageBox.Show("گزارش به درستی به روز شد");
                }
                cnn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("خطا در تراکنش‌های دیتابیس:\n" + err.ToString(), "خطا");
                cnn.Close();
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
                                if (ratio >= 3 && ratio <= 7) {
                                    CvInvoke.Rectangle(ColorFrame, boundingBox, new MCvScalar(0, 255, 255), 2);
                                    if (((boundingBox.X + boundingBox.Width) <= croppedFrame.Cols) & ((boundingBox.Y + boundingBox.Height) <= croppedFrame.Rows))
                                        imageSave(new Mat(ColorFrame, boundingBox), "Detection");
                                }
                                
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);
                                for (int j = 0; j < edges.Length; j++) {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100) {
                                        isRectangle = false;
                                        break;
                                    }
                                }
                                if (isRectangle) PlateImagesList.Add(CvInvoke.MinAreaRect(approxContour));                                
                            }
                        }
                    }
                }
                pictureBox_Online.Image = new Bitmap(ColorFrame.Bitmap);
            }
        }

        private void imageSave(Mat outputImage, string refFunction) {
            try {
                switch (refFunction) {
                    case "Detection":
                        String fileName = today.ToString("yyyyMMdd") + "-" + DateTime.Now.ToString("hhmmss") + ".png";
                        // Create a new folder if not exists
                        Directory.CreateDirectory(Path.Combine("Report", today.ToString("yyyy/MM")));
                        outputImage.Save(Path.Combine("Report", today.ToString("yyyy/MM"), fileName));
                        break;
                    case "Owner":
                        break;
            }                    
            } catch (Exception error) {
                MessageBox.Show("خطای زیر در ذخیره تصویر رخ داده است: \r\n" + error, "خطا");
            }
        }
    }
}
