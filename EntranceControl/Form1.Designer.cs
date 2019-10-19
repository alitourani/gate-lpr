namespace EntranceControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabOnlineMonitoring = new System.Windows.Forms.TabPage();
            this.panelOnlineMonitoring = new System.Windows.Forms.Panel();
            this.groupBox_Last = new System.Windows.Forms.GroupBox();
            this.pictureBox_LastCarImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_LastLPImage = new System.Windows.Forms.PictureBox();
            this.label_LastOwner = new System.Windows.Forms.Label();
            this.pictureBox_LastOwnerImage = new System.Windows.Forms.PictureBox();
            this.label_LastLP = new System.Windows.Forms.Label();
            this.label_LastDateTime = new System.Windows.Forms.Label();
            this.groupBox_RecentReport = new System.Windows.Forms.GroupBox();
            this.label_HintReport = new System.Windows.Forms.Label();
            this.dataGridView_Recent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_OnlineWatch = new System.Windows.Forms.GroupBox();
            this.button_ClearLoadedFrame = new System.Windows.Forms.Button();
            this.pictureBox_Online = new System.Windows.Forms.PictureBox();
            this.button_OfflinePicture = new System.Windows.Forms.Button();
            this.button_OfflineVideo = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.panelReport = new System.Windows.Forms.Panel();
            this.groupBox_Filtration = new System.Windows.Forms.GroupBox();
            this.button_ApplyFilter = new System.Windows.Forms.Button();
            this.textBox_TillDate = new System.Windows.Forms.TextBox();
            this.textBox_FromDate = new System.Windows.Forms.TextBox();
            this.label_TillDate = new System.Windows.Forms.Label();
            this.label_FromDate = new System.Windows.Forms.Label();
            this.button_Excel = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.groupBox_SearchReports = new System.Windows.Forms.GroupBox();
            this.textBox_SearchOwnerReports = new System.Windows.Forms.TextBox();
            this.label_SearchOwnerReports = new System.Windows.Forms.Label();
            this.textBox_SearchLPReports = new System.Windows.Forms.TextBox();
            this.label_SearchLP = new System.Windows.Forms.Label();
            this.groupBox_Report = new System.Windows.Forms.GroupBox();
            this.dataGridView_Report = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabValidPeople = new System.Windows.Forms.TabPage();
            this.panelValidCars = new System.Windows.Forms.Panel();
            this.groupBox_VehicleList = new System.Windows.Forms.GroupBox();
            this.groupBox_ValidSearch = new System.Windows.Forms.GroupBox();
            this.textBox_Surname_Search = new System.Windows.Forms.TextBox();
            this.label_Surname_Search = new System.Windows.Forms.Label();
            this.textBox_LP_Search = new System.Windows.Forms.TextBox();
            this.label_LP_Search = new System.Windows.Forms.Label();
            this.textBox_NationalCode_Search = new System.Windows.Forms.TextBox();
            this.label_NationalCode_Search = new System.Windows.Forms.Label();
            this.dataGridView_Valid = new System.Windows.Forms.DataGridView();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.OwnerImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Vehicles = new System.Windows.Forms.GroupBox();
            this.pictureBox_VehicleImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_OwnerImage = new System.Windows.Forms.PictureBox();
            this.textBox_NationalCode = new System.Windows.Forms.TextBox();
            this.label_NationalCode = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.label_OwnerDescription = new System.Windows.Forms.Label();
            this.textBox_OwnerDescription = new System.Windows.Forms.TextBox();
            this.textBox_OwnerSurname = new System.Windows.Forms.TextBox();
            this.textBox_OwnerName = new System.Windows.Forms.TextBox();
            this.textBox_VehicleColor = new System.Windows.Forms.TextBox();
            this.label_VehicleColor = new System.Windows.Forms.Label();
            this.textBox_VehicleType = new System.Windows.Forms.TextBox();
            this.label_VehicleType = new System.Windows.Forms.Label();
            this.labelVehicleOwner = new System.Windows.Forms.Label();
            this.comboBox_LP_Char_VehicleProperties = new System.Windows.Forms.ComboBox();
            this.numericUpDown_LP_City_VehicleProperties = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_LP_NumberR_VehicleProperties = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_LP_NumberL_VehicleProperties = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxLicensePlate_groupBoxVehicles = new System.Windows.Forms.PictureBox();
            this.labelLicensePlate = new System.Windows.Forms.Label();
            this.radioButton_Woman = new System.Windows.Forms.RadioButton();
            this.radioButton_Man = new System.Windows.Forms.RadioButton();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupBoxAdvanced = new System.Windows.Forms.GroupBox();
            this.radioButton_CC1 = new System.Windows.Forms.RadioButton();
            this.radioButton_CC3 = new System.Windows.Forms.RadioButton();
            this.radioButton_CC2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SobelResult = new System.Windows.Forms.RadioButton();
            this.radioButton_ThresholdDiffered = new System.Windows.Forms.RadioButton();
            this.radioButton_FilteredFrame = new System.Windows.Forms.RadioButton();
            this.numericUpDownSobelKernel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDifferenceThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAvgFilter = new System.Windows.Forms.NumericUpDown();
            this.label_AvgFilter = new System.Windows.Forms.Label();
            this.numericUpDownMedianBlur = new System.Windows.Forms.NumericUpDown();
            this.label_MedianBlur = new System.Windows.Forms.Label();
            this.numericUpDownThresholdParam1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThresholdBlockSize = new System.Windows.Forms.NumericUpDown();
            this.button_DefaultCalibration = new System.Windows.Forms.Button();
            this.button_SubmitCalibration = new System.Windows.Forms.Button();
            this.numericUpDownMorphological_Close = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEdge2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ShowMorphological = new System.Windows.Forms.RadioButton();
            this.numericUpDownMorphological_Open = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ShowThreshold = new System.Windows.Forms.RadioButton();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ShowGaussian = new System.Windows.Forms.RadioButton();
            this.numericUpDownGaussian = new System.Windows.Forms.NumericUpDown();
            this.radioButton_ShowGrayscale = new System.Windows.Forms.RadioButton();
            this.radioButton_ShowEdge = new System.Windows.Forms.RadioButton();
            this.radioButton_ShowMainFrame = new System.Windows.Forms.RadioButton();
            this.numericUpDownEdge1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxROIControl = new System.Windows.Forms.GroupBox();
            this.radioButtonROIDisabled = new System.Windows.Forms.RadioButton();
            this.radioButtonROIEnabled = new System.Windows.Forms.RadioButton();
            this.groupBoxROILocation = new System.Windows.Forms.GroupBox();
            this.groupBoxROICoverage = new System.Windows.Forms.GroupBox();
            this.numericUpDownROIW = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownROIH = new System.Windows.Forms.NumericUpDown();
            this.buttonSetROICoverage = new System.Windows.Forms.Button();
            this.labelROICoverageW = new System.Windows.Forms.Label();
            this.labelROICoverageH = new System.Windows.Forms.Label();
            this.groupBoxROITrackbar = new System.Windows.Forms.GroupBox();
            this.labelROILocationV = new System.Windows.Forms.Label();
            this.labelROILocationH = new System.Windows.Forms.Label();
            this.trackBarROIVertical = new System.Windows.Forms.TrackBar();
            this.trackBarROIHorizontal = new System.Windows.Forms.TrackBar();
            this.pictureBoxROISetting = new System.Windows.Forms.PictureBox();
            this.groupBoxGateConnection = new System.Windows.Forms.GroupBox();
            this.radioButtonGateDisconnected = new System.Windows.Forms.RadioButton();
            this.radioButtonGateConnected = new System.Windows.Forms.RadioButton();
            this.groupBoxCameraSettings = new System.Windows.Forms.GroupBox();
            this.radioButtonCameraOff = new System.Windows.Forms.RadioButton();
            this.radioButtonCameraOn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainTab.SuspendLayout();
            this.tabOnlineMonitoring.SuspendLayout();
            this.panelOnlineMonitoring.SuspendLayout();
            this.groupBox_Last.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastLPImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastOwnerImage)).BeginInit();
            this.groupBox_RecentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recent)).BeginInit();
            this.groupBox_OnlineWatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Online)).BeginInit();
            this.tabReport.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.groupBox_Filtration.SuspendLayout();
            this.groupBox_SearchReports.SuspendLayout();
            this.groupBox_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).BeginInit();
            this.tabValidPeople.SuspendLayout();
            this.panelValidCars.SuspendLayout();
            this.groupBox_VehicleList.SuspendLayout();
            this.groupBox_ValidSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Valid)).BeginInit();
            this.groupBox_Vehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VehicleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OwnerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_City_VehicleProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_NumberR_VehicleProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_NumberL_VehicleProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicensePlate_groupBoxVehicles)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.groupBoxAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSobelKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifferenceThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvgFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedianBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThresholdParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThresholdBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorphological_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorphological_Open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdge1)).BeginInit();
            this.groupBoxROIControl.SuspendLayout();
            this.groupBoxROILocation.SuspendLayout();
            this.groupBoxROICoverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROIW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROIH)).BeginInit();
            this.groupBoxROITrackbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarROIVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarROIHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROISetting)).BeginInit();
            this.groupBoxGateConnection.SuspendLayout();
            this.groupBoxCameraSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.linkLabel1.Location = new System.Drawing.Point(1069, 663);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(236, 16);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CopyRight 2019 - See More Info Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabOnlineMonitoring);
            this.mainTab.Controls.Add(this.tabReport);
            this.mainTab.Controls.Add(this.tabValidPeople);
            this.mainTab.Controls.Add(this.tabSettings);
            this.mainTab.Location = new System.Drawing.Point(21, 12);
            this.mainTab.Name = "mainTab";
            this.mainTab.RightToLeftLayout = true;
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1288, 645);
            this.mainTab.TabIndex = 40;
            // 
            // tabOnlineMonitoring
            // 
            this.tabOnlineMonitoring.Controls.Add(this.panelOnlineMonitoring);
            this.tabOnlineMonitoring.Location = new System.Drawing.Point(4, 39);
            this.tabOnlineMonitoring.Name = "tabOnlineMonitoring";
            this.tabOnlineMonitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnlineMonitoring.Size = new System.Drawing.Size(1280, 602);
            this.tabOnlineMonitoring.TabIndex = 0;
            this.tabOnlineMonitoring.Text = "نظارت آنلاین";
            this.tabOnlineMonitoring.UseVisualStyleBackColor = true;
            // 
            // panelOnlineMonitoring
            // 
            this.panelOnlineMonitoring.BackColor = System.Drawing.SystemColors.Control;
            this.panelOnlineMonitoring.Controls.Add(this.groupBox_Last);
            this.panelOnlineMonitoring.Controls.Add(this.groupBox_RecentReport);
            this.panelOnlineMonitoring.Controls.Add(this.groupBox_OnlineWatch);
            this.panelOnlineMonitoring.Location = new System.Drawing.Point(3, 3);
            this.panelOnlineMonitoring.Name = "panelOnlineMonitoring";
            this.panelOnlineMonitoring.Size = new System.Drawing.Size(1277, 599);
            this.panelOnlineMonitoring.TabIndex = 3;
            // 
            // groupBox_Last
            // 
            this.groupBox_Last.Controls.Add(this.pictureBox_LastCarImage);
            this.groupBox_Last.Controls.Add(this.pictureBox_LastLPImage);
            this.groupBox_Last.Controls.Add(this.label_LastOwner);
            this.groupBox_Last.Controls.Add(this.pictureBox_LastOwnerImage);
            this.groupBox_Last.Controls.Add(this.label_LastLP);
            this.groupBox_Last.Controls.Add(this.label_LastDateTime);
            this.groupBox_Last.Location = new System.Drawing.Point(13, 506);
            this.groupBox_Last.Name = "groupBox_Last";
            this.groupBox_Last.Size = new System.Drawing.Size(1252, 79);
            this.groupBox_Last.TabIndex = 42;
            this.groupBox_Last.TabStop = false;
            this.groupBox_Last.Text = "آخرین تردد";
            // 
            // pictureBox_LastCarImage
            // 
            this.pictureBox_LastCarImage.InitialImage = global::EntranceControl.Properties.Resources.OwnerImage;
            this.pictureBox_LastCarImage.Location = new System.Drawing.Point(259, 21);
            this.pictureBox_LastCarImage.Name = "pictureBox_LastCarImage";
            this.pictureBox_LastCarImage.Size = new System.Drawing.Size(73, 52);
            this.pictureBox_LastCarImage.TabIndex = 67;
            this.pictureBox_LastCarImage.TabStop = false;
            // 
            // pictureBox_LastLPImage
            // 
            this.pictureBox_LastLPImage.InitialImage = global::EntranceControl.Properties.Resources.VehicleImage;
            this.pictureBox_LastLPImage.Location = new System.Drawing.Point(549, 21);
            this.pictureBox_LastLPImage.Name = "pictureBox_LastLPImage";
            this.pictureBox_LastLPImage.Size = new System.Drawing.Size(233, 52);
            this.pictureBox_LastLPImage.TabIndex = 65;
            this.pictureBox_LastLPImage.TabStop = false;
            // 
            // label_LastOwner
            // 
            this.label_LastOwner.AutoSize = true;
            this.label_LastOwner.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LastOwner.ForeColor = System.Drawing.Color.Green;
            this.label_LastOwner.Location = new System.Drawing.Point(43, 38);
            this.label_LastOwner.Name = "label_LastOwner";
            this.label_LastOwner.Size = new System.Drawing.Size(146, 26);
            this.label_LastOwner.TabIndex = 66;
            this.label_LastOwner.Text = "مجاز (آقای رضایی)";
            // 
            // pictureBox_LastOwnerImage
            // 
            this.pictureBox_LastOwnerImage.InitialImage = global::EntranceControl.Properties.Resources.OwnerImage;
            this.pictureBox_LastOwnerImage.Location = new System.Drawing.Point(409, 21);
            this.pictureBox_LastOwnerImage.Name = "pictureBox_LastOwnerImage";
            this.pictureBox_LastOwnerImage.Size = new System.Drawing.Size(73, 52);
            this.pictureBox_LastOwnerImage.TabIndex = 64;
            this.pictureBox_LastOwnerImage.TabStop = false;
            // 
            // label_LastLP
            // 
            this.label_LastLP.AutoSize = true;
            this.label_LastLP.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LastLP.Location = new System.Drawing.Point(852, 34);
            this.label_LastLP.Name = "label_LastLP";
            this.label_LastLP.Size = new System.Drawing.Size(145, 30);
            this.label_LastLP.TabIndex = 65;
            this.label_LastLP.Text = "45 - 97ب232";
            // 
            // label_LastDateTime
            // 
            this.label_LastDateTime.AutoSize = true;
            this.label_LastDateTime.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LastDateTime.Location = new System.Drawing.Point(1059, 38);
            this.label_LastDateTime.Name = "label_LastDateTime";
            this.label_LastDateTime.Size = new System.Drawing.Size(151, 26);
            this.label_LastDateTime.TabIndex = 64;
            this.label_LastDateTime.Text = "97/05/12 - 19:12";
            // 
            // groupBox_RecentReport
            // 
            this.groupBox_RecentReport.Controls.Add(this.label_HintReport);
            this.groupBox_RecentReport.Controls.Add(this.dataGridView_Recent);
            this.groupBox_RecentReport.Location = new System.Drawing.Point(838, 12);
            this.groupBox_RecentReport.Name = "groupBox_RecentReport";
            this.groupBox_RecentReport.Size = new System.Drawing.Size(433, 488);
            this.groupBox_RecentReport.TabIndex = 62;
            this.groupBox_RecentReport.TabStop = false;
            this.groupBox_RecentReport.Text = "خلاصه ترددهای اخیر";
            // 
            // label_HintReport
            // 
            this.label_HintReport.AutoSize = true;
            this.label_HintReport.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_HintReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_HintReport.Location = new System.Drawing.Point(67, 451);
            this.label_HintReport.Name = "label_HintReport";
            this.label_HintReport.Size = new System.Drawing.Size(265, 23);
            this.label_HintReport.TabIndex = 10;
            this.label_HintReport.Text = "گزارش با جزئیات بیشتر در زبانه گزارش ترددها";
            // 
            // dataGridView_Recent
            // 
            this.dataGridView_Recent.AllowUserToAddRows = false;
            this.dataGridView_Recent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Recent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Recent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Recent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Recent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView_Recent.Location = new System.Drawing.Point(11, 31);
            this.dataGridView_Recent.Name = "dataGridView_Recent";
            this.dataGridView_Recent.RowHeadersVisible = false;
            this.dataGridView_Recent.RowHeadersWidth = 51;
            this.dataGridView_Recent.RowTemplate.Height = 25;
            this.dataGridView_Recent.Size = new System.Drawing.Size(416, 409);
            this.dataGridView_Recent.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "شماره پلاک";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 124;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "ساعت";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 87;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "مجوز عبور";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 115;
            // 
            // groupBox_OnlineWatch
            // 
            this.groupBox_OnlineWatch.Controls.Add(this.button_ClearLoadedFrame);
            this.groupBox_OnlineWatch.Controls.Add(this.pictureBox_Online);
            this.groupBox_OnlineWatch.Controls.Add(this.button_OfflinePicture);
            this.groupBox_OnlineWatch.Controls.Add(this.button_OfflineVideo);
            this.groupBox_OnlineWatch.Location = new System.Drawing.Point(13, 12);
            this.groupBox_OnlineWatch.Name = "groupBox_OnlineWatch";
            this.groupBox_OnlineWatch.Size = new System.Drawing.Size(819, 488);
            this.groupBox_OnlineWatch.TabIndex = 42;
            this.groupBox_OnlineWatch.TabStop = false;
            this.groupBox_OnlineWatch.Text = "نظارت آنلاین";
            // 
            // button_ClearLoadedFrame
            // 
            this.button_ClearLoadedFrame.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_ClearLoadedFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_ClearLoadedFrame.Location = new System.Drawing.Point(474, 448);
            this.button_ClearLoadedFrame.Name = "button_ClearLoadedFrame";
            this.button_ClearLoadedFrame.Size = new System.Drawing.Size(62, 28);
            this.button_ClearLoadedFrame.TabIndex = 62;
            this.button_ClearLoadedFrame.Text = "پاک کردن";
            this.button_ClearLoadedFrame.UseVisualStyleBackColor = true;
            this.button_ClearLoadedFrame.Click += new System.EventHandler(this.button_ClearLoadedFrame_Click);
            // 
            // pictureBox_Online
            // 
            this.pictureBox_Online.Location = new System.Drawing.Point(43, 24);
            this.pictureBox_Online.Name = "pictureBox_Online";
            this.pictureBox_Online.Size = new System.Drawing.Size(752, 416);
            this.pictureBox_Online.TabIndex = 41;
            this.pictureBox_Online.TabStop = false;
            // 
            // button_OfflinePicture
            // 
            this.button_OfflinePicture.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_OfflinePicture.Location = new System.Drawing.Point(324, 448);
            this.button_OfflinePicture.Name = "button_OfflinePicture";
            this.button_OfflinePicture.Size = new System.Drawing.Size(125, 28);
            this.button_OfflinePicture.TabIndex = 60;
            this.button_OfflinePicture.Text = "بارگذاری تصویر آفلاین";
            this.button_OfflinePicture.UseVisualStyleBackColor = true;
            this.button_OfflinePicture.Click += new System.EventHandler(this.button_OfflinePicture_Click);
            // 
            // button_OfflineVideo
            // 
            this.button_OfflineVideo.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_OfflineVideo.Location = new System.Drawing.Point(184, 448);
            this.button_OfflineVideo.Name = "button_OfflineVideo";
            this.button_OfflineVideo.Size = new System.Drawing.Size(120, 28);
            this.button_OfflineVideo.TabIndex = 61;
            this.button_OfflineVideo.Text = "بارگذاری ویدئوی آفلاین";
            this.button_OfflineVideo.UseVisualStyleBackColor = true;
            this.button_OfflineVideo.Click += new System.EventHandler(this.button_OfflineVideo_Click);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.panelReport);
            this.tabReport.Location = new System.Drawing.Point(4, 39);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1280, 602);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "گزارش ترددها";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.SystemColors.Control;
            this.panelReport.Controls.Add(this.groupBox_Filtration);
            this.panelReport.Controls.Add(this.button_Excel);
            this.panelReport.Controls.Add(this.button_Print);
            this.panelReport.Controls.Add(this.groupBox_SearchReports);
            this.panelReport.Controls.Add(this.groupBox_Report);
            this.panelReport.Location = new System.Drawing.Point(3, 3);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1281, 599);
            this.panelReport.TabIndex = 2;
            // 
            // groupBox_Filtration
            // 
            this.groupBox_Filtration.Controls.Add(this.button_ApplyFilter);
            this.groupBox_Filtration.Controls.Add(this.textBox_TillDate);
            this.groupBox_Filtration.Controls.Add(this.textBox_FromDate);
            this.groupBox_Filtration.Controls.Add(this.label_TillDate);
            this.groupBox_Filtration.Controls.Add(this.label_FromDate);
            this.groupBox_Filtration.Location = new System.Drawing.Point(192, 518);
            this.groupBox_Filtration.Name = "groupBox_Filtration";
            this.groupBox_Filtration.Size = new System.Drawing.Size(505, 75);
            this.groupBox_Filtration.TabIndex = 67;
            this.groupBox_Filtration.TabStop = false;
            this.groupBox_Filtration.Text = "فیلتر زمانی";
            // 
            // button_ApplyFilter
            // 
            this.button_ApplyFilter.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_ApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ApplyFilter.Location = new System.Drawing.Point(6, 32);
            this.button_ApplyFilter.Name = "button_ApplyFilter";
            this.button_ApplyFilter.Size = new System.Drawing.Size(113, 32);
            this.button_ApplyFilter.TabIndex = 62;
            this.button_ApplyFilter.Text = "اعمال";
            this.button_ApplyFilter.UseVisualStyleBackColor = true;
            // 
            // textBox_TillDate
            // 
            this.textBox_TillDate.Location = new System.Drawing.Point(164, 31);
            this.textBox_TillDate.MaxLength = 250;
            this.textBox_TillDate.Name = "textBox_TillDate";
            this.textBox_TillDate.Size = new System.Drawing.Size(119, 38);
            this.textBox_TillDate.TabIndex = 68;
            this.textBox_TillDate.Text = "1397/01/02";
            this.textBox_TillDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FromDate
            // 
            this.textBox_FromDate.Location = new System.Drawing.Point(336, 30);
            this.textBox_FromDate.MaxLength = 250;
            this.textBox_FromDate.Name = "textBox_FromDate";
            this.textBox_FromDate.Size = new System.Drawing.Size(122, 38);
            this.textBox_FromDate.TabIndex = 67;
            this.textBox_FromDate.Text = "1397/01/01";
            this.textBox_FromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_TillDate
            // 
            this.label_TillDate.AutoSize = true;
            this.label_TillDate.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_TillDate.Location = new System.Drawing.Point(289, 37);
            this.label_TillDate.Name = "label_TillDate";
            this.label_TillDate.Size = new System.Drawing.Size(27, 26);
            this.label_TillDate.TabIndex = 65;
            this.label_TillDate.Text = "تا:";
            // 
            // label_FromDate
            // 
            this.label_FromDate.AutoSize = true;
            this.label_FromDate.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_FromDate.Location = new System.Drawing.Point(459, 37);
            this.label_FromDate.Name = "label_FromDate";
            this.label_FromDate.Size = new System.Drawing.Size(29, 26);
            this.label_FromDate.TabIndex = 63;
            this.label_FromDate.Text = "از:";
            // 
            // button_Excel
            // 
            this.button_Excel.Enabled = false;
            this.button_Excel.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Excel.ForeColor = System.Drawing.Color.Green;
            this.button_Excel.Location = new System.Drawing.Point(17, 561);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(156, 32);
            this.button_Excel.TabIndex = 61;
            this.button_Excel.Text = "خروجی اکسل";
            this.button_Excel.UseVisualStyleBackColor = true;
            // 
            // button_Print
            // 
            this.button_Print.Enabled = false;
            this.button_Print.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Print.ForeColor = System.Drawing.Color.Teal;
            this.button_Print.Location = new System.Drawing.Point(17, 518);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(156, 37);
            this.button_Print.TabIndex = 60;
            this.button_Print.Text = "ارائه نسخه چاپی";
            this.button_Print.UseVisualStyleBackColor = true;
            // 
            // groupBox_SearchReports
            // 
            this.groupBox_SearchReports.Controls.Add(this.textBox_SearchOwnerReports);
            this.groupBox_SearchReports.Controls.Add(this.label_SearchOwnerReports);
            this.groupBox_SearchReports.Controls.Add(this.textBox_SearchLPReports);
            this.groupBox_SearchReports.Controls.Add(this.label_SearchLP);
            this.groupBox_SearchReports.Location = new System.Drawing.Point(718, 519);
            this.groupBox_SearchReports.Name = "groupBox_SearchReports";
            this.groupBox_SearchReports.Size = new System.Drawing.Size(539, 74);
            this.groupBox_SearchReports.TabIndex = 9;
            this.groupBox_SearchReports.TabStop = false;
            this.groupBox_SearchReports.Text = "جستجو در فهرست";
            // 
            // textBox_SearchOwnerReports
            // 
            this.textBox_SearchOwnerReports.Location = new System.Drawing.Point(6, 30);
            this.textBox_SearchOwnerReports.MaxLength = 250;
            this.textBox_SearchOwnerReports.Name = "textBox_SearchOwnerReports";
            this.textBox_SearchOwnerReports.Size = new System.Drawing.Size(144, 38);
            this.textBox_SearchOwnerReports.TabIndex = 66;
            // 
            // label_SearchOwnerReports
            // 
            this.label_SearchOwnerReports.AutoSize = true;
            this.label_SearchOwnerReports.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_SearchOwnerReports.Location = new System.Drawing.Point(156, 37);
            this.label_SearchOwnerReports.Name = "label_SearchOwnerReports";
            this.label_SearchOwnerReports.Size = new System.Drawing.Size(130, 26);
            this.label_SearchOwnerReports.TabIndex = 65;
            this.label_SearchOwnerReports.Text = "نام خانوادگی مالک:";
            // 
            // textBox_SearchLPReports
            // 
            this.textBox_SearchLPReports.Location = new System.Drawing.Point(301, 30);
            this.textBox_SearchLPReports.MaxLength = 250;
            this.textBox_SearchLPReports.Name = "textBox_SearchLPReports";
            this.textBox_SearchLPReports.Size = new System.Drawing.Size(130, 38);
            this.textBox_SearchLPReports.TabIndex = 64;
            // 
            // label_SearchLP
            // 
            this.label_SearchLP.AutoSize = true;
            this.label_SearchLP.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_SearchLP.Location = new System.Drawing.Point(435, 36);
            this.label_SearchLP.Name = "label_SearchLP";
            this.label_SearchLP.Size = new System.Drawing.Size(87, 26);
            this.label_SearchLP.TabIndex = 63;
            this.label_SearchLP.Text = "شماره پلاک:";
            // 
            // groupBox_Report
            // 
            this.groupBox_Report.Controls.Add(this.dataGridView_Report);
            this.groupBox_Report.Location = new System.Drawing.Point(17, 14);
            this.groupBox_Report.Name = "groupBox_Report";
            this.groupBox_Report.Size = new System.Drawing.Size(1254, 498);
            this.groupBox_Report.TabIndex = 8;
            this.groupBox_Report.TabStop = false;
            this.groupBox_Report.Text = "گزارش آخرین ترددها";
            // 
            // dataGridView_Report
            // 
            this.dataGridView_Report.AllowUserToAddRows = false;
            this.dataGridView_Report.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn1});
            this.dataGridView_Report.Location = new System.Drawing.Point(7, 32);
            this.dataGridView_Report.Name = "dataGridView_Report";
            this.dataGridView_Report.RowHeadersWidth = 51;
            this.dataGridView_Report.RowTemplate.Height = 150;
            this.dataGridView_Report.Size = new System.Drawing.Size(1233, 452);
            this.dataGridView_Report.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره پلاک";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 124;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "ساعت";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "مجوز عبور";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "مالک";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "تصویر پلاک";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 127;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "تصویر خودرو";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 140;
            // 
            // tabValidPeople
            // 
            this.tabValidPeople.Controls.Add(this.panelValidCars);
            this.tabValidPeople.Location = new System.Drawing.Point(4, 39);
            this.tabValidPeople.Name = "tabValidPeople";
            this.tabValidPeople.Size = new System.Drawing.Size(1280, 602);
            this.tabValidPeople.TabIndex = 2;
            this.tabValidPeople.Text = "خودروهای مجاز";
            this.tabValidPeople.UseVisualStyleBackColor = true;
            // 
            // panelValidCars
            // 
            this.panelValidCars.BackColor = System.Drawing.SystemColors.Control;
            this.panelValidCars.Controls.Add(this.groupBox_VehicleList);
            this.panelValidCars.Controls.Add(this.groupBox_Vehicles);
            this.panelValidCars.Location = new System.Drawing.Point(3, 3);
            this.panelValidCars.Name = "panelValidCars";
            this.panelValidCars.Size = new System.Drawing.Size(1277, 596);
            this.panelValidCars.TabIndex = 2;
            // 
            // groupBox_VehicleList
            // 
            this.groupBox_VehicleList.Controls.Add(this.groupBox_ValidSearch);
            this.groupBox_VehicleList.Controls.Add(this.dataGridView_Valid);
            this.groupBox_VehicleList.Location = new System.Drawing.Point(17, 13);
            this.groupBox_VehicleList.Name = "groupBox_VehicleList";
            this.groupBox_VehicleList.Size = new System.Drawing.Size(843, 567);
            this.groupBox_VehicleList.TabIndex = 7;
            this.groupBox_VehicleList.TabStop = false;
            this.groupBox_VehicleList.Text = "لیست خودروهای مجاز";
            // 
            // groupBox_ValidSearch
            // 
            this.groupBox_ValidSearch.Controls.Add(this.textBox_Surname_Search);
            this.groupBox_ValidSearch.Controls.Add(this.label_Surname_Search);
            this.groupBox_ValidSearch.Controls.Add(this.textBox_LP_Search);
            this.groupBox_ValidSearch.Controls.Add(this.label_LP_Search);
            this.groupBox_ValidSearch.Controls.Add(this.textBox_NationalCode_Search);
            this.groupBox_ValidSearch.Controls.Add(this.label_NationalCode_Search);
            this.groupBox_ValidSearch.Location = new System.Drawing.Point(7, 478);
            this.groupBox_ValidSearch.Name = "groupBox_ValidSearch";
            this.groupBox_ValidSearch.Size = new System.Drawing.Size(818, 76);
            this.groupBox_ValidSearch.TabIndex = 6;
            this.groupBox_ValidSearch.TabStop = false;
            this.groupBox_ValidSearch.Text = "جستجو در فهرست";
            // 
            // textBox_Surname_Search
            // 
            this.textBox_Surname_Search.Location = new System.Drawing.Point(18, 28);
            this.textBox_Surname_Search.MaxLength = 250;
            this.textBox_Surname_Search.Name = "textBox_Surname_Search";
            this.textBox_Surname_Search.Size = new System.Drawing.Size(156, 38);
            this.textBox_Surname_Search.TabIndex = 66;
            // 
            // label_Surname_Search
            // 
            this.label_Surname_Search.AutoSize = true;
            this.label_Surname_Search.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Surname_Search.Location = new System.Drawing.Point(181, 34);
            this.label_Surname_Search.Name = "label_Surname_Search";
            this.label_Surname_Search.Size = new System.Drawing.Size(130, 26);
            this.label_Surname_Search.TabIndex = 65;
            this.label_Surname_Search.Text = "نام خانوادگی مالک:";
            // 
            // textBox_LP_Search
            // 
            this.textBox_LP_Search.Location = new System.Drawing.Point(558, 28);
            this.textBox_LP_Search.MaxLength = 250;
            this.textBox_LP_Search.Name = "textBox_LP_Search";
            this.textBox_LP_Search.Size = new System.Drawing.Size(149, 38);
            this.textBox_LP_Search.TabIndex = 64;
            // 
            // label_LP_Search
            // 
            this.label_LP_Search.AutoSize = true;
            this.label_LP_Search.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LP_Search.Location = new System.Drawing.Point(711, 34);
            this.label_LP_Search.Name = "label_LP_Search";
            this.label_LP_Search.Size = new System.Drawing.Size(87, 26);
            this.label_LP_Search.TabIndex = 63;
            this.label_LP_Search.Text = "شماره پلاک:";
            // 
            // textBox_NationalCode_Search
            // 
            this.textBox_NationalCode_Search.Location = new System.Drawing.Point(338, 28);
            this.textBox_NationalCode_Search.MaxLength = 250;
            this.textBox_NationalCode_Search.Name = "textBox_NationalCode_Search";
            this.textBox_NationalCode_Search.Size = new System.Drawing.Size(130, 38);
            this.textBox_NationalCode_Search.TabIndex = 62;
            // 
            // label_NationalCode_Search
            // 
            this.label_NationalCode_Search.AutoSize = true;
            this.label_NationalCode_Search.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_NationalCode_Search.Location = new System.Drawing.Point(474, 34);
            this.label_NationalCode_Search.Name = "label_NationalCode_Search";
            this.label_NationalCode_Search.Size = new System.Drawing.Size(61, 26);
            this.label_NationalCode_Search.TabIndex = 61;
            this.label_NationalCode_Search.Text = "کد ملی:";
            // 
            // dataGridView_Valid
            // 
            this.dataGridView_Valid.AllowUserToAddRows = false;
            this.dataGridView_Valid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Valid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Valid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LicensePlate,
            this.Owner,
            this.Car,
            this.VehicleImage,
            this.OwnerImage,
            this.NationalCode,
            this.Description});
            this.dataGridView_Valid.Location = new System.Drawing.Point(7, 32);
            this.dataGridView_Valid.Name = "dataGridView_Valid";
            this.dataGridView_Valid.RowHeadersWidth = 51;
            this.dataGridView_Valid.RowTemplate.Height = 150;
            this.dataGridView_Valid.Size = new System.Drawing.Size(818, 440);
            this.dataGridView_Valid.TabIndex = 0;
            // 
            // LicensePlate
            // 
            this.LicensePlate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LicensePlate.HeaderText = "شماره پلاک";
            this.LicensePlate.MaxInputLength = 9;
            this.LicensePlate.MinimumWidth = 6;
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.Width = 124;
            // 
            // Owner
            // 
            this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Owner.HeaderText = "مالک";
            this.Owner.MaxInputLength = 50;
            this.Owner.MinimumWidth = 6;
            this.Owner.Name = "Owner";
            this.Owner.Width = 77;
            // 
            // Car
            // 
            this.Car.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Car.HeaderText = "خودرو";
            this.Car.MaxInputLength = 50;
            this.Car.MinimumWidth = 6;
            this.Car.Name = "Car";
            this.Car.Width = 88;
            // 
            // VehicleImage
            // 
            this.VehicleImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VehicleImage.HeaderText = "تصویر خودرو";
            this.VehicleImage.MinimumWidth = 6;
            this.VehicleImage.Name = "VehicleImage";
            this.VehicleImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VehicleImage.Width = 140;
            // 
            // OwnerImage
            // 
            this.OwnerImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OwnerImage.HeaderText = "تصویر مالک";
            this.OwnerImage.MinimumWidth = 6;
            this.OwnerImage.Name = "OwnerImage";
            this.OwnerImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnerImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OwnerImage.Width = 129;
            // 
            // NationalCode
            // 
            this.NationalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NationalCode.HeaderText = "کد ملی";
            this.NationalCode.MaxInputLength = 10;
            this.NationalCode.MinimumWidth = 6;
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.Width = 93;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "توضیح کوتاه";
            this.Description.MaxInputLength = 100;
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 133;
            // 
            // groupBox_Vehicles
            // 
            this.groupBox_Vehicles.Controls.Add(this.pictureBox_VehicleImage);
            this.groupBox_Vehicles.Controls.Add(this.pictureBox_OwnerImage);
            this.groupBox_Vehicles.Controls.Add(this.textBox_NationalCode);
            this.groupBox_Vehicles.Controls.Add(this.label_NationalCode);
            this.groupBox_Vehicles.Controls.Add(this.button_Clear);
            this.groupBox_Vehicles.Controls.Add(this.button_Register);
            this.groupBox_Vehicles.Controls.Add(this.label_OwnerDescription);
            this.groupBox_Vehicles.Controls.Add(this.textBox_OwnerDescription);
            this.groupBox_Vehicles.Controls.Add(this.textBox_OwnerSurname);
            this.groupBox_Vehicles.Controls.Add(this.textBox_OwnerName);
            this.groupBox_Vehicles.Controls.Add(this.textBox_VehicleColor);
            this.groupBox_Vehicles.Controls.Add(this.label_VehicleColor);
            this.groupBox_Vehicles.Controls.Add(this.textBox_VehicleType);
            this.groupBox_Vehicles.Controls.Add(this.label_VehicleType);
            this.groupBox_Vehicles.Controls.Add(this.labelVehicleOwner);
            this.groupBox_Vehicles.Controls.Add(this.comboBox_LP_Char_VehicleProperties);
            this.groupBox_Vehicles.Controls.Add(this.numericUpDown_LP_City_VehicleProperties);
            this.groupBox_Vehicles.Controls.Add(this.numericUpDown_LP_NumberR_VehicleProperties);
            this.groupBox_Vehicles.Controls.Add(this.numericUpDown_LP_NumberL_VehicleProperties);
            this.groupBox_Vehicles.Controls.Add(this.pictureBoxLicensePlate_groupBoxVehicles);
            this.groupBox_Vehicles.Controls.Add(this.labelLicensePlate);
            this.groupBox_Vehicles.Controls.Add(this.radioButton_Woman);
            this.groupBox_Vehicles.Controls.Add(this.radioButton_Man);
            this.groupBox_Vehicles.Location = new System.Drawing.Point(876, 13);
            this.groupBox_Vehicles.Name = "groupBox_Vehicles";
            this.groupBox_Vehicles.Size = new System.Drawing.Size(387, 567);
            this.groupBox_Vehicles.TabIndex = 6;
            this.groupBox_Vehicles.TabStop = false;
            this.groupBox_Vehicles.Text = "مشخصات خودروها";
            // 
            // pictureBox_VehicleImage
            // 
            this.pictureBox_VehicleImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_VehicleImage.InitialImage = global::EntranceControl.Properties.Resources.VehicleImage;
            this.pictureBox_VehicleImage.Location = new System.Drawing.Point(37, 430);
            this.pictureBox_VehicleImage.Name = "pictureBox_VehicleImage";
            this.pictureBox_VehicleImage.Size = new System.Drawing.Size(133, 82);
            this.pictureBox_VehicleImage.TabIndex = 63;
            this.pictureBox_VehicleImage.TabStop = false;
            this.pictureBox_VehicleImage.Click += new System.EventHandler(this.pictureBox_VehicleImage_Click);
            // 
            // pictureBox_OwnerImage
            // 
            this.pictureBox_OwnerImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OwnerImage.InitialImage = global::EntranceControl.Properties.Resources.OwnerImage;
            this.pictureBox_OwnerImage.Location = new System.Drawing.Point(216, 430);
            this.pictureBox_OwnerImage.Name = "pictureBox_OwnerImage";
            this.pictureBox_OwnerImage.Size = new System.Drawing.Size(97, 82);
            this.pictureBox_OwnerImage.TabIndex = 62;
            this.pictureBox_OwnerImage.TabStop = false;
            this.pictureBox_OwnerImage.Click += new System.EventHandler(this.pictureBox_OwnerImage_Click);
            // 
            // textBox_NationalCode
            // 
            this.textBox_NationalCode.Location = new System.Drawing.Point(13, 331);
            this.textBox_NationalCode.MaxLength = 10;
            this.textBox_NationalCode.Name = "textBox_NationalCode";
            this.textBox_NationalCode.Size = new System.Drawing.Size(233, 38);
            this.textBox_NationalCode.TabIndex = 61;
            // 
            // label_NationalCode
            // 
            this.label_NationalCode.AutoSize = true;
            this.label_NationalCode.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_NationalCode.Location = new System.Drawing.Point(311, 334);
            this.label_NationalCode.Name = "label_NationalCode";
            this.label_NationalCode.Size = new System.Drawing.Size(70, 30);
            this.label_NationalCode.TabIndex = 60;
            this.label_NationalCode.Text = "کد ملی:";
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Clear.ForeColor = System.Drawing.Color.Teal;
            this.button_Clear.Location = new System.Drawing.Point(13, 518);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(137, 36);
            this.button_Clear.TabIndex = 59;
            this.button_Clear.Text = "پاک کردن فرم";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Register.ForeColor = System.Drawing.Color.Green;
            this.button_Register.Location = new System.Drawing.Point(156, 518);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(225, 36);
            this.button_Register.TabIndex = 56;
            this.button_Register.Text = "ثبت به‌عنوان خودروی مجاز جدید";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label_OwnerDescription
            // 
            this.label_OwnerDescription.AutoSize = true;
            this.label_OwnerDescription.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_OwnerDescription.Location = new System.Drawing.Point(271, 382);
            this.label_OwnerDescription.Name = "label_OwnerDescription";
            this.label_OwnerDescription.Size = new System.Drawing.Size(110, 30);
            this.label_OwnerDescription.TabIndex = 55;
            this.label_OwnerDescription.Text = "توضیح کوتاه:";
            // 
            // textBox_OwnerDescription
            // 
            this.textBox_OwnerDescription.Location = new System.Drawing.Point(13, 379);
            this.textBox_OwnerDescription.MaxLength = 50;
            this.textBox_OwnerDescription.Name = "textBox_OwnerDescription";
            this.textBox_OwnerDescription.Size = new System.Drawing.Size(233, 38);
            this.textBox_OwnerDescription.TabIndex = 54;
            // 
            // textBox_OwnerSurname
            // 
            this.textBox_OwnerSurname.Location = new System.Drawing.Point(13, 278);
            this.textBox_OwnerSurname.MaxLength = 30;
            this.textBox_OwnerSurname.Name = "textBox_OwnerSurname";
            this.textBox_OwnerSurname.Size = new System.Drawing.Size(168, 38);
            this.textBox_OwnerSurname.TabIndex = 53;
            // 
            // textBox_OwnerName
            // 
            this.textBox_OwnerName.Location = new System.Drawing.Point(187, 278);
            this.textBox_OwnerName.MaxLength = 20;
            this.textBox_OwnerName.Name = "textBox_OwnerName";
            this.textBox_OwnerName.Size = new System.Drawing.Size(189, 38);
            this.textBox_OwnerName.TabIndex = 52;
            // 
            // textBox_VehicleColor
            // 
            this.textBox_VehicleColor.Location = new System.Drawing.Point(13, 188);
            this.textBox_VehicleColor.MaxLength = 20;
            this.textBox_VehicleColor.Name = "textBox_VehicleColor";
            this.textBox_VehicleColor.Size = new System.Drawing.Size(233, 38);
            this.textBox_VehicleColor.TabIndex = 51;
            // 
            // label_VehicleColor
            // 
            this.label_VehicleColor.AutoSize = true;
            this.label_VehicleColor.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_VehicleColor.Location = new System.Drawing.Point(280, 191);
            this.label_VehicleColor.Name = "label_VehicleColor";
            this.label_VehicleColor.Size = new System.Drawing.Size(101, 30);
            this.label_VehicleColor.TabIndex = 50;
            this.label_VehicleColor.Text = "رنگ خودرو:";
            // 
            // textBox_VehicleType
            // 
            this.textBox_VehicleType.Location = new System.Drawing.Point(13, 142);
            this.textBox_VehicleType.MaxLength = 20;
            this.textBox_VehicleType.Name = "textBox_VehicleType";
            this.textBox_VehicleType.Size = new System.Drawing.Size(233, 38);
            this.textBox_VehicleType.TabIndex = 49;
            // 
            // label_VehicleType
            // 
            this.label_VehicleType.AutoSize = true;
            this.label_VehicleType.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_VehicleType.Location = new System.Drawing.Point(285, 145);
            this.label_VehicleType.Name = "label_VehicleType";
            this.label_VehicleType.Size = new System.Drawing.Size(96, 30);
            this.label_VehicleType.TabIndex = 48;
            this.label_VehicleType.Text = "نوع خودرو:";
            // 
            // labelVehicleOwner
            // 
            this.labelVehicleOwner.AutoSize = true;
            this.labelVehicleOwner.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelVehicleOwner.Location = new System.Drawing.Point(276, 232);
            this.labelVehicleOwner.Name = "labelVehicleOwner";
            this.labelVehicleOwner.Size = new System.Drawing.Size(105, 30);
            this.labelVehicleOwner.TabIndex = 47;
            this.labelVehicleOwner.Text = "مالک خودرو:";
            // 
            // comboBox_LP_Char_VehicleProperties
            // 
            this.comboBox_LP_Char_VehicleProperties.FormattingEnabled = true;
            this.comboBox_LP_Char_VehicleProperties.Location = new System.Drawing.Point(114, 80);
            this.comboBox_LP_Char_VehicleProperties.Name = "comboBox_LP_Char_VehicleProperties";
            this.comboBox_LP_Char_VehicleProperties.Size = new System.Drawing.Size(77, 38);
            this.comboBox_LP_Char_VehicleProperties.TabIndex = 46;
            // 
            // numericUpDown_LP_City_VehicleProperties
            // 
            this.numericUpDown_LP_City_VehicleProperties.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDown_LP_City_VehicleProperties.Location = new System.Drawing.Point(311, 84);
            this.numericUpDown_LP_City_VehicleProperties.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_LP_City_VehicleProperties.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_LP_City_VehicleProperties.Name = "numericUpDown_LP_City_VehicleProperties";
            this.numericUpDown_LP_City_VehicleProperties.Size = new System.Drawing.Size(50, 32);
            this.numericUpDown_LP_City_VehicleProperties.TabIndex = 45;
            this.numericUpDown_LP_City_VehicleProperties.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // numericUpDown_LP_NumberR_VehicleProperties
            // 
            this.numericUpDown_LP_NumberR_VehicleProperties.Location = new System.Drawing.Point(216, 80);
            this.numericUpDown_LP_NumberR_VehicleProperties.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_LP_NumberR_VehicleProperties.Minimum = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.numericUpDown_LP_NumberR_VehicleProperties.Name = "numericUpDown_LP_NumberR_VehicleProperties";
            this.numericUpDown_LP_NumberR_VehicleProperties.Size = new System.Drawing.Size(71, 38);
            this.numericUpDown_LP_NumberR_VehicleProperties.TabIndex = 44;
            this.numericUpDown_LP_NumberR_VehicleProperties.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            // 
            // numericUpDown_LP_NumberL_VehicleProperties
            // 
            this.numericUpDown_LP_NumberL_VehicleProperties.Location = new System.Drawing.Point(37, 80);
            this.numericUpDown_LP_NumberL_VehicleProperties.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_LP_NumberL_VehicleProperties.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown_LP_NumberL_VehicleProperties.Name = "numericUpDown_LP_NumberL_VehicleProperties";
            this.numericUpDown_LP_NumberL_VehicleProperties.Size = new System.Drawing.Size(57, 38);
            this.numericUpDown_LP_NumberL_VehicleProperties.TabIndex = 43;
            this.numericUpDown_LP_NumberL_VehicleProperties.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // pictureBoxLicensePlate_groupBoxVehicles
            // 
            this.pictureBoxLicensePlate_groupBoxVehicles.InitialImage = global::EntranceControl.Properties.Resources.LP;
            this.pictureBoxLicensePlate_groupBoxVehicles.Location = new System.Drawing.Point(13, 65);
            this.pictureBoxLicensePlate_groupBoxVehicles.Name = "pictureBoxLicensePlate_groupBoxVehicles";
            this.pictureBoxLicensePlate_groupBoxVehicles.Size = new System.Drawing.Size(363, 65);
            this.pictureBoxLicensePlate_groupBoxVehicles.TabIndex = 42;
            this.pictureBoxLicensePlate_groupBoxVehicles.TabStop = false;
            // 
            // labelLicensePlate
            // 
            this.labelLicensePlate.AutoSize = true;
            this.labelLicensePlate.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelLicensePlate.Location = new System.Drawing.Point(278, 32);
            this.labelLicensePlate.Name = "labelLicensePlate";
            this.labelLicensePlate.Size = new System.Drawing.Size(103, 30);
            this.labelLicensePlate.TabIndex = 9;
            this.labelLicensePlate.Text = "پلاک خودرو:";
            // 
            // radioButton_Woman
            // 
            this.radioButton_Woman.AutoSize = true;
            this.radioButton_Woman.Location = new System.Drawing.Point(13, 232);
            this.radioButton_Woman.Name = "radioButton_Woman";
            this.radioButton_Woman.Size = new System.Drawing.Size(67, 34);
            this.radioButton_Woman.TabIndex = 4;
            this.radioButton_Woman.Text = "خانم";
            this.radioButton_Woman.UseVisualStyleBackColor = true;
            // 
            // radioButton_Man
            // 
            this.radioButton_Man.AutoSize = true;
            this.radioButton_Man.Checked = true;
            this.radioButton_Man.Location = new System.Drawing.Point(84, 232);
            this.radioButton_Man.Name = "radioButton_Man";
            this.radioButton_Man.Size = new System.Drawing.Size(55, 34);
            this.radioButton_Man.TabIndex = 2;
            this.radioButton_Man.TabStop = true;
            this.radioButton_Man.Text = "آقا";
            this.radioButton_Man.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.panelSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1280, 602);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "تنظیمات";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.Control;
            this.panelSettings.Controls.Add(this.groupBoxAdvanced);
            this.panelSettings.Controls.Add(this.groupBoxROIControl);
            this.panelSettings.Controls.Add(this.groupBoxROILocation);
            this.panelSettings.Controls.Add(this.groupBoxGateConnection);
            this.panelSettings.Controls.Add(this.groupBoxCameraSettings);
            this.panelSettings.Location = new System.Drawing.Point(3, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1274, 603);
            this.panelSettings.TabIndex = 1;
            // 
            // groupBoxAdvanced
            // 
            this.groupBoxAdvanced.Controls.Add(this.radioButton_CC1);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_CC3);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_CC2);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_SobelResult);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ThresholdDiffered);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_FilteredFrame);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownSobelKernel);
            this.groupBoxAdvanced.Controls.Add(this.label2);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownDifferenceThreshold);
            this.groupBoxAdvanced.Controls.Add(this.label1);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownAvgFilter);
            this.groupBoxAdvanced.Controls.Add(this.label_AvgFilter);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownMedianBlur);
            this.groupBoxAdvanced.Controls.Add(this.label_MedianBlur);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownThresholdParam1);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownThresholdBlockSize);
            this.groupBoxAdvanced.Controls.Add(this.button_DefaultCalibration);
            this.groupBoxAdvanced.Controls.Add(this.button_SubmitCalibration);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownMorphological_Close);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownEdge2);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowMorphological);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownMorphological_Open);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowThreshold);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownThreshold);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowGaussian);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownGaussian);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowGrayscale);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowEdge);
            this.groupBoxAdvanced.Controls.Add(this.radioButton_ShowMainFrame);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownEdge1);
            this.groupBoxAdvanced.Location = new System.Drawing.Point(659, 157);
            this.groupBoxAdvanced.Name = "groupBoxAdvanced";
            this.groupBoxAdvanced.Size = new System.Drawing.Size(612, 439);
            this.groupBoxAdvanced.TabIndex = 8;
            this.groupBoxAdvanced.TabStop = false;
            this.groupBoxAdvanced.Text = "تنظیمات پیشرفته کالیبراسیون";
            // 
            // radioButton_CC1
            // 
            this.radioButton_CC1.AutoSize = true;
            this.radioButton_CC1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_CC1.Location = new System.Drawing.Point(93, 178);
            this.radioButton_CC1.Name = "radioButton_CC1";
            this.radioButton_CC1.Size = new System.Drawing.Size(158, 27);
            this.radioButton_CC1.TabIndex = 78;
            this.radioButton_CC1.Text = "خروجی اجزاء مرتبط اول";
            this.radioButton_CC1.UseVisualStyleBackColor = true;
            this.radioButton_CC1.CheckedChanged += new System.EventHandler(this.RadioButton_CC1_CheckedChanged);
            // 
            // radioButton_CC3
            // 
            this.radioButton_CC3.AutoSize = true;
            this.radioButton_CC3.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_CC3.Location = new System.Drawing.Point(88, 244);
            this.radioButton_CC3.Name = "radioButton_CC3";
            this.radioButton_CC3.Size = new System.Drawing.Size(163, 27);
            this.radioButton_CC3.TabIndex = 77;
            this.radioButton_CC3.Text = "خروجی اجزاء مرتبط سوم";
            this.radioButton_CC3.UseVisualStyleBackColor = true;
            this.radioButton_CC3.CheckedChanged += new System.EventHandler(this.RadioButton_CC3_CheckedChanged);
            // 
            // radioButton_CC2
            // 
            this.radioButton_CC2.AutoSize = true;
            this.radioButton_CC2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_CC2.Location = new System.Drawing.Point(92, 211);
            this.radioButton_CC2.Name = "radioButton_CC2";
            this.radioButton_CC2.Size = new System.Drawing.Size(159, 27);
            this.radioButton_CC2.TabIndex = 76;
            this.radioButton_CC2.Text = "خروجی اجزاء مرتبط دوم";
            this.radioButton_CC2.UseVisualStyleBackColor = true;
            this.radioButton_CC2.CheckedChanged += new System.EventHandler(this.RadioButton_CC2_CheckedChanged);
            // 
            // radioButton_SobelResult
            // 
            this.radioButton_SobelResult.AutoSize = true;
            this.radioButton_SobelResult.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_SobelResult.Location = new System.Drawing.Point(99, 142);
            this.radioButton_SobelResult.Name = "radioButton_SobelResult";
            this.radioButton_SobelResult.Size = new System.Drawing.Size(152, 27);
            this.radioButton_SobelResult.TabIndex = 75;
            this.radioButton_SobelResult.Text = "خروجی لبه‌های Sobel";
            this.radioButton_SobelResult.UseVisualStyleBackColor = true;
            this.radioButton_SobelResult.CheckedChanged += new System.EventHandler(this.RadioButton_SobelResult_CheckedChanged);
            // 
            // radioButton_ThresholdDiffered
            // 
            this.radioButton_ThresholdDiffered.AutoSize = true;
            this.radioButton_ThresholdDiffered.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ThresholdDiffered.Location = new System.Drawing.Point(22, 103);
            this.radioButton_ThresholdDiffered.Name = "radioButton_ThresholdDiffered";
            this.radioButton_ThresholdDiffered.Size = new System.Drawing.Size(229, 27);
            this.radioButton_ThresholdDiffered.TabIndex = 74;
            this.radioButton_ThresholdDiffered.Text = "خروجی پس از تفاضل و آستانه‌گذاری";
            this.radioButton_ThresholdDiffered.UseVisualStyleBackColor = true;
            this.radioButton_ThresholdDiffered.CheckedChanged += new System.EventHandler(this.RadioButton_ThresholdDiffered_CheckedChanged);
            // 
            // radioButton_FilteredFrame
            // 
            this.radioButton_FilteredFrame.AutoSize = true;
            this.radioButton_FilteredFrame.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_FilteredFrame.Location = new System.Drawing.Point(29, 67);
            this.radioButton_FilteredFrame.Name = "radioButton_FilteredFrame";
            this.radioButton_FilteredFrame.Size = new System.Drawing.Size(222, 27);
            this.radioButton_FilteredFrame.TabIndex = 73;
            this.radioButton_FilteredFrame.Text = "خروجی پس از فیلتر میانه و میانگین";
            this.radioButton_FilteredFrame.UseVisualStyleBackColor = true;
            this.radioButton_FilteredFrame.CheckedChanged += new System.EventHandler(this.RadioButton_FilteredFrame_CheckedChanged);
            // 
            // numericUpDownSobelKernel
            // 
            this.numericUpDownSobelKernel.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownSobelKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSobelKernel.Location = new System.Drawing.Point(11, 339);
            this.numericUpDownSobelKernel.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDownSobelKernel.Name = "numericUpDownSobelKernel";
            this.numericUpDownSobelKernel.Size = new System.Drawing.Size(127, 30);
            this.numericUpDownSobelKernel.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(164, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "تنظیم لبه‌یاب سوبل:";
            // 
            // numericUpDownDifferenceThreshold
            // 
            this.numericUpDownDifferenceThreshold.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownDifferenceThreshold.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDifferenceThreshold.Location = new System.Drawing.Point(322, 340);
            this.numericUpDownDifferenceThreshold.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDownDifferenceThreshold.Name = "numericUpDownDifferenceThreshold";
            this.numericUpDownDifferenceThreshold.Size = new System.Drawing.Size(117, 30);
            this.numericUpDownDifferenceThreshold.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(445, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 69;
            this.label1.Text = "تنظیم آستانه تفاضلات:";
            // 
            // numericUpDownAvgFilter
            // 
            this.numericUpDownAvgFilter.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownAvgFilter.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAvgFilter.Location = new System.Drawing.Point(12, 305);
            this.numericUpDownAvgFilter.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDownAvgFilter.Name = "numericUpDownAvgFilter";
            this.numericUpDownAvgFilter.Size = new System.Drawing.Size(127, 30);
            this.numericUpDownAvgFilter.TabIndex = 68;
            // 
            // label_AvgFilter
            // 
            this.label_AvgFilter.AutoSize = true;
            this.label_AvgFilter.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_AvgFilter.Location = new System.Drawing.Point(164, 306);
            this.label_AvgFilter.Name = "label_AvgFilter";
            this.label_AvgFilter.Size = new System.Drawing.Size(142, 26);
            this.label_AvgFilter.TabIndex = 67;
            this.label_AvgFilter.Text = "تنظیم فیلتر میانگین:";
            // 
            // numericUpDownMedianBlur
            // 
            this.numericUpDownMedianBlur.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownMedianBlur.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMedianBlur.Location = new System.Drawing.Point(322, 305);
            this.numericUpDownMedianBlur.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDownMedianBlur.Name = "numericUpDownMedianBlur";
            this.numericUpDownMedianBlur.Size = new System.Drawing.Size(117, 30);
            this.numericUpDownMedianBlur.TabIndex = 66;
            // 
            // label_MedianBlur
            // 
            this.label_MedianBlur.AutoSize = true;
            this.label_MedianBlur.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_MedianBlur.Location = new System.Drawing.Point(475, 306);
            this.label_MedianBlur.Name = "label_MedianBlur";
            this.label_MedianBlur.Size = new System.Drawing.Size(125, 26);
            this.label_MedianBlur.TabIndex = 47;
            this.label_MedianBlur.Text = "تنظیم فیلتر میانه:";
            // 
            // numericUpDownThresholdParam1
            // 
            this.numericUpDownThresholdParam1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownThresholdParam1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownThresholdParam1.Location = new System.Drawing.Point(311, 103);
            this.numericUpDownThresholdParam1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownThresholdParam1.Name = "numericUpDownThresholdParam1";
            this.numericUpDownThresholdParam1.Size = new System.Drawing.Size(38, 30);
            this.numericUpDownThresholdParam1.TabIndex = 65;
            // 
            // numericUpDownThresholdBlockSize
            // 
            this.numericUpDownThresholdBlockSize.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownThresholdBlockSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownThresholdBlockSize.Location = new System.Drawing.Point(355, 103);
            this.numericUpDownThresholdBlockSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownThresholdBlockSize.Name = "numericUpDownThresholdBlockSize";
            this.numericUpDownThresholdBlockSize.Size = new System.Drawing.Size(38, 30);
            this.numericUpDownThresholdBlockSize.TabIndex = 64;
            // 
            // button_DefaultCalibration
            // 
            this.button_DefaultCalibration.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_DefaultCalibration.Location = new System.Drawing.Point(134, 398);
            this.button_DefaultCalibration.Name = "button_DefaultCalibration";
            this.button_DefaultCalibration.Size = new System.Drawing.Size(133, 35);
            this.button_DefaultCalibration.TabIndex = 63;
            this.button_DefaultCalibration.Text = "پیشفرض";
            this.button_DefaultCalibration.UseVisualStyleBackColor = true;
            this.button_DefaultCalibration.Click += new System.EventHandler(this.button_DefaultCalibration_Click);
            // 
            // button_SubmitCalibration
            // 
            this.button_SubmitCalibration.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_SubmitCalibration.Location = new System.Drawing.Point(297, 398);
            this.button_SubmitCalibration.Name = "button_SubmitCalibration";
            this.button_SubmitCalibration.Size = new System.Drawing.Size(248, 35);
            this.button_SubmitCalibration.TabIndex = 50;
            this.button_SubmitCalibration.Text = "ثبت تغییرات کالیبراسیون";
            this.button_SubmitCalibration.UseVisualStyleBackColor = true;
            this.button_SubmitCalibration.Click += new System.EventHandler(this.button_SubmitCalibration_Click);
            // 
            // numericUpDownMorphological_Close
            // 
            this.numericUpDownMorphological_Close.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownMorphological_Close.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMorphological_Close.Location = new System.Drawing.Point(312, 175);
            this.numericUpDownMorphological_Close.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownMorphological_Close.Name = "numericUpDownMorphological_Close";
            this.numericUpDownMorphological_Close.Size = new System.Drawing.Size(62, 30);
            this.numericUpDownMorphological_Close.TabIndex = 62;
            // 
            // numericUpDownEdge2
            // 
            this.numericUpDownEdge2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownEdge2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEdge2.Location = new System.Drawing.Point(312, 139);
            this.numericUpDownEdge2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEdge2.Name = "numericUpDownEdge2";
            this.numericUpDownEdge2.Size = new System.Drawing.Size(61, 30);
            this.numericUpDownEdge2.TabIndex = 61;
            // 
            // radioButton_ShowMorphological
            // 
            this.radioButton_ShowMorphological.AutoSize = true;
            this.radioButton_ShowMorphological.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowMorphological.Location = new System.Drawing.Point(458, 175);
            this.radioButton_ShowMorphological.Name = "radioButton_ShowMorphological";
            this.radioButton_ShowMorphological.Size = new System.Drawing.Size(137, 27);
            this.radioButton_ShowMorphological.TabIndex = 60;
            this.radioButton_ShowMorphological.Text = "خروجی مورفولوژی:";
            this.radioButton_ShowMorphological.UseVisualStyleBackColor = true;
            this.radioButton_ShowMorphological.CheckedChanged += new System.EventHandler(this.radioButton_ShowMorphological_CheckedChanged);
            // 
            // numericUpDownMorphological_Open
            // 
            this.numericUpDownMorphological_Open.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownMorphological_Open.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMorphological_Open.Location = new System.Drawing.Point(377, 175);
            this.numericUpDownMorphological_Open.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownMorphological_Open.Name = "numericUpDownMorphological_Open";
            this.numericUpDownMorphological_Open.Size = new System.Drawing.Size(62, 30);
            this.numericUpDownMorphological_Open.TabIndex = 59;
            // 
            // radioButton_ShowThreshold
            // 
            this.radioButton_ShowThreshold.AutoSize = true;
            this.radioButton_ShowThreshold.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowThreshold.Location = new System.Drawing.Point(480, 106);
            this.radioButton_ShowThreshold.Name = "radioButton_ShowThreshold";
            this.radioButton_ShowThreshold.Size = new System.Drawing.Size(115, 27);
            this.radioButton_ShowThreshold.TabIndex = 58;
            this.radioButton_ShowThreshold.Text = "تصویر دودویی:";
            this.radioButton_ShowThreshold.UseVisualStyleBackColor = true;
            this.radioButton_ShowThreshold.CheckedChanged += new System.EventHandler(this.radioButton_ShowThreshold_CheckedChanged);
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownThreshold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownThreshold.Location = new System.Drawing.Point(399, 103);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(40, 30);
            this.numericUpDownThreshold.TabIndex = 57;
            // 
            // radioButton_ShowGaussian
            // 
            this.radioButton_ShowGaussian.AutoSize = true;
            this.radioButton_ShowGaussian.Enabled = false;
            this.radioButton_ShowGaussian.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowGaussian.Location = new System.Drawing.Point(454, 70);
            this.radioButton_ShowGaussian.Name = "radioButton_ShowGaussian";
            this.radioButton_ShowGaussian.Size = new System.Drawing.Size(141, 27);
            this.radioButton_ShowGaussian.TabIndex = 56;
            this.radioButton_ShowGaussian.Text = "تابع گاوسی - هسته:";
            this.radioButton_ShowGaussian.UseVisualStyleBackColor = true;
            this.radioButton_ShowGaussian.CheckedChanged += new System.EventHandler(this.radioButton_ShowGaussian_CheckedChanged);
            // 
            // numericUpDownGaussian
            // 
            this.numericUpDownGaussian.Enabled = false;
            this.numericUpDownGaussian.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownGaussian.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownGaussian.Location = new System.Drawing.Point(312, 67);
            this.numericUpDownGaussian.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDownGaussian.Name = "numericUpDownGaussian";
            this.numericUpDownGaussian.Size = new System.Drawing.Size(127, 30);
            this.numericUpDownGaussian.TabIndex = 55;
            // 
            // radioButton_ShowGrayscale
            // 
            this.radioButton_ShowGrayscale.AutoSize = true;
            this.radioButton_ShowGrayscale.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowGrayscale.Location = new System.Drawing.Point(321, 37);
            this.radioButton_ShowGrayscale.Name = "radioButton_ShowGrayscale";
            this.radioButton_ShowGrayscale.Size = new System.Drawing.Size(118, 27);
            this.radioButton_ShowGrayscale.TabIndex = 54;
            this.radioButton_ShowGrayscale.Text = "تصویر خاکستری";
            this.radioButton_ShowGrayscale.UseVisualStyleBackColor = true;
            this.radioButton_ShowGrayscale.CheckedChanged += new System.EventHandler(this.radioButton_ShowGrayscale_CheckedChanged);
            // 
            // radioButton_ShowEdge
            // 
            this.radioButton_ShowEdge.AutoSize = true;
            this.radioButton_ShowEdge.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowEdge.Location = new System.Drawing.Point(477, 142);
            this.radioButton_ShowEdge.Name = "radioButton_ShowEdge";
            this.radioButton_ShowEdge.Size = new System.Drawing.Size(118, 27);
            this.radioButton_ShowEdge.TabIndex = 53;
            this.radioButton_ShowEdge.Text = "لبه‌های Canny:";
            this.radioButton_ShowEdge.UseVisualStyleBackColor = true;
            this.radioButton_ShowEdge.CheckedChanged += new System.EventHandler(this.radioButton_ShowEdge_CheckedChanged);
            // 
            // radioButton_ShowMainFrame
            // 
            this.radioButton_ShowMainFrame.AutoSize = true;
            this.radioButton_ShowMainFrame.Checked = true;
            this.radioButton_ShowMainFrame.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton_ShowMainFrame.Location = new System.Drawing.Point(498, 37);
            this.radioButton_ShowMainFrame.Name = "radioButton_ShowMainFrame";
            this.radioButton_ShowMainFrame.Size = new System.Drawing.Size(97, 27);
            this.radioButton_ShowMainFrame.TabIndex = 52;
            this.radioButton_ShowMainFrame.TabStop = true;
            this.radioButton_ShowMainFrame.Text = "تصویر اصلی";
            this.radioButton_ShowMainFrame.UseVisualStyleBackColor = true;
            this.radioButton_ShowMainFrame.CheckedChanged += new System.EventHandler(this.radioButton_ShowMainFrame_CheckedChanged);
            // 
            // numericUpDownEdge1
            // 
            this.numericUpDownEdge1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownEdge1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEdge1.Location = new System.Drawing.Point(377, 139);
            this.numericUpDownEdge1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownEdge1.Name = "numericUpDownEdge1";
            this.numericUpDownEdge1.Size = new System.Drawing.Size(62, 30);
            this.numericUpDownEdge1.TabIndex = 50;
            // 
            // groupBoxROIControl
            // 
            this.groupBoxROIControl.Controls.Add(this.radioButtonROIDisabled);
            this.groupBoxROIControl.Controls.Add(this.radioButtonROIEnabled);
            this.groupBoxROIControl.Location = new System.Drawing.Point(659, 84);
            this.groupBoxROIControl.Name = "groupBoxROIControl";
            this.groupBoxROIControl.Size = new System.Drawing.Size(612, 67);
            this.groupBoxROIControl.TabIndex = 7;
            this.groupBoxROIControl.TabStop = false;
            this.groupBoxROIControl.Text = "تنظیمات مربوط به ناحیه نظارتی";
            // 
            // radioButtonROIDisabled
            // 
            this.radioButtonROIDisabled.AutoSize = true;
            this.radioButtonROIDisabled.Location = new System.Drawing.Point(11, 26);
            this.radioButtonROIDisabled.Name = "radioButtonROIDisabled";
            this.radioButtonROIDisabled.Size = new System.Drawing.Size(204, 34);
            this.radioButtonROIDisabled.TabIndex = 4;
            this.radioButtonROIDisabled.Text = "عدم وجود ناحیه محدود";
            this.radioButtonROIDisabled.UseVisualStyleBackColor = true;
            this.radioButtonROIDisabled.CheckedChanged += new System.EventHandler(this.radioButtonROIDisabled_CheckedChanged);
            // 
            // radioButtonROIEnabled
            // 
            this.radioButtonROIEnabled.AutoSize = true;
            this.radioButtonROIEnabled.Checked = true;
            this.radioButtonROIEnabled.Location = new System.Drawing.Point(240, 27);
            this.radioButtonROIEnabled.Name = "radioButtonROIEnabled";
            this.radioButtonROIEnabled.Size = new System.Drawing.Size(177, 34);
            this.radioButtonROIEnabled.TabIndex = 2;
            this.radioButtonROIEnabled.TabStop = true;
            this.radioButtonROIEnabled.Text = "تعریف ناحیه محدود";
            this.radioButtonROIEnabled.UseVisualStyleBackColor = true;
            this.radioButtonROIEnabled.CheckedChanged += new System.EventHandler(this.radioButtonROIEnabled_CheckedChanged);
            // 
            // groupBoxROILocation
            // 
            this.groupBoxROILocation.Controls.Add(this.groupBoxROICoverage);
            this.groupBoxROILocation.Controls.Add(this.groupBoxROITrackbar);
            this.groupBoxROILocation.Controls.Add(this.pictureBoxROISetting);
            this.groupBoxROILocation.Location = new System.Drawing.Point(12, 8);
            this.groupBoxROILocation.Name = "groupBoxROILocation";
            this.groupBoxROILocation.Size = new System.Drawing.Size(624, 588);
            this.groupBoxROILocation.TabIndex = 7;
            this.groupBoxROILocation.TabStop = false;
            this.groupBoxROILocation.Text = "تنظیم محل ناحیه نظارتی";
            // 
            // groupBoxROICoverage
            // 
            this.groupBoxROICoverage.Controls.Add(this.numericUpDownROIW);
            this.groupBoxROICoverage.Controls.Add(this.numericUpDownROIH);
            this.groupBoxROICoverage.Controls.Add(this.buttonSetROICoverage);
            this.groupBoxROICoverage.Controls.Add(this.labelROICoverageW);
            this.groupBoxROICoverage.Controls.Add(this.labelROICoverageH);
            this.groupBoxROICoverage.Location = new System.Drawing.Point(16, 387);
            this.groupBoxROICoverage.Name = "groupBoxROICoverage";
            this.groupBoxROICoverage.Size = new System.Drawing.Size(271, 183);
            this.groupBoxROICoverage.TabIndex = 47;
            this.groupBoxROICoverage.TabStop = false;
            this.groupBoxROICoverage.Text = "درصد پوشش کل ویدئو";
            // 
            // numericUpDownROIW
            // 
            this.numericUpDownROIW.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownROIW.Location = new System.Drawing.Point(19, 73);
            this.numericUpDownROIW.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownROIW.Name = "numericUpDownROIW";
            this.numericUpDownROIW.Size = new System.Drawing.Size(183, 38);
            this.numericUpDownROIW.TabIndex = 49;
            // 
            // numericUpDownROIH
            // 
            this.numericUpDownROIH.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownROIH.Location = new System.Drawing.Point(19, 29);
            this.numericUpDownROIH.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownROIH.Name = "numericUpDownROIH";
            this.numericUpDownROIH.Size = new System.Drawing.Size(183, 38);
            this.numericUpDownROIH.TabIndex = 48;
            // 
            // buttonSetROICoverage
            // 
            this.buttonSetROICoverage.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSetROICoverage.Location = new System.Drawing.Point(6, 118);
            this.buttonSetROICoverage.Name = "buttonSetROICoverage";
            this.buttonSetROICoverage.Size = new System.Drawing.Size(259, 59);
            this.buttonSetROICoverage.TabIndex = 47;
            this.buttonSetROICoverage.Text = "ثبت";
            this.buttonSetROICoverage.UseVisualStyleBackColor = true;
            this.buttonSetROICoverage.Click += new System.EventHandler(this.buttonSetROICoverage_Click);
            // 
            // labelROICoverageW
            // 
            this.labelROICoverageW.AutoSize = true;
            this.labelROICoverageW.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelROICoverageW.Location = new System.Drawing.Point(212, 80);
            this.labelROICoverageW.Name = "labelROICoverageW";
            this.labelROICoverageW.Size = new System.Drawing.Size(52, 26);
            this.labelROICoverageW.TabIndex = 46;
            this.labelROICoverageW.Text = "عرضی";
            // 
            // labelROICoverageH
            // 
            this.labelROICoverageH.AutoSize = true;
            this.labelROICoverageH.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelROICoverageH.Location = new System.Drawing.Point(216, 35);
            this.labelROICoverageH.Name = "labelROICoverageH";
            this.labelROICoverageH.Size = new System.Drawing.Size(42, 26);
            this.labelROICoverageH.TabIndex = 8;
            this.labelROICoverageH.Text = "طولی";
            // 
            // groupBoxROITrackbar
            // 
            this.groupBoxROITrackbar.Controls.Add(this.labelROILocationV);
            this.groupBoxROITrackbar.Controls.Add(this.labelROILocationH);
            this.groupBoxROITrackbar.Controls.Add(this.trackBarROIVertical);
            this.groupBoxROITrackbar.Controls.Add(this.trackBarROIHorizontal);
            this.groupBoxROITrackbar.Location = new System.Drawing.Point(331, 387);
            this.groupBoxROITrackbar.Name = "groupBoxROITrackbar";
            this.groupBoxROITrackbar.Size = new System.Drawing.Size(271, 183);
            this.groupBoxROITrackbar.TabIndex = 42;
            this.groupBoxROITrackbar.TabStop = false;
            this.groupBoxROITrackbar.Text = "جابجایی افقی و عمودی ناحیه";
            // 
            // labelROILocationV
            // 
            this.labelROILocationV.AutoSize = true;
            this.labelROILocationV.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelROILocationV.Location = new System.Drawing.Point(216, 118);
            this.labelROILocationV.Name = "labelROILocationV";
            this.labelROILocationV.Size = new System.Drawing.Size(54, 26);
            this.labelROILocationV.TabIndex = 46;
            this.labelROILocationV.Text = "عمودی";
            // 
            // labelROILocationH
            // 
            this.labelROILocationH.AutoSize = true;
            this.labelROILocationH.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelROILocationH.Location = new System.Drawing.Point(220, 54);
            this.labelROILocationH.Name = "labelROILocationH";
            this.labelROILocationH.Size = new System.Drawing.Size(43, 26);
            this.labelROILocationH.TabIndex = 8;
            this.labelROILocationH.Text = "افقی";
            // 
            // trackBarROIVertical
            // 
            this.trackBarROIVertical.Location = new System.Drawing.Point(10, 113);
            this.trackBarROIVertical.Name = "trackBarROIVertical";
            this.trackBarROIVertical.RightToLeftLayout = true;
            this.trackBarROIVertical.Size = new System.Drawing.Size(201, 56);
            this.trackBarROIVertical.TabIndex = 45;
            this.trackBarROIVertical.Value = 5;
            this.trackBarROIVertical.Scroll += new System.EventHandler(this.trackBarROIVertical_Scroll);
            // 
            // trackBarROIHorizontal
            // 
            this.trackBarROIHorizontal.Location = new System.Drawing.Point(10, 50);
            this.trackBarROIHorizontal.Name = "trackBarROIHorizontal";
            this.trackBarROIHorizontal.RightToLeftLayout = true;
            this.trackBarROIHorizontal.Size = new System.Drawing.Size(201, 56);
            this.trackBarROIHorizontal.TabIndex = 44;
            this.trackBarROIHorizontal.Value = 5;
            this.trackBarROIHorizontal.Scroll += new System.EventHandler(this.trackBarROIHorizontal_Scroll);
            // 
            // pictureBoxROISetting
            // 
            this.pictureBoxROISetting.InitialImage = global::EntranceControl.Properties.Resources.Initialize;
            this.pictureBoxROISetting.Location = new System.Drawing.Point(16, 36);
            this.pictureBoxROISetting.Name = "pictureBoxROISetting";
            this.pictureBoxROISetting.Size = new System.Drawing.Size(586, 345);
            this.pictureBoxROISetting.TabIndex = 41;
            this.pictureBoxROISetting.TabStop = false;
            // 
            // groupBoxGateConnection
            // 
            this.groupBoxGateConnection.Controls.Add(this.radioButtonGateDisconnected);
            this.groupBoxGateConnection.Controls.Add(this.radioButtonGateConnected);
            this.groupBoxGateConnection.Location = new System.Drawing.Point(659, 19);
            this.groupBoxGateConnection.Name = "groupBoxGateConnection";
            this.groupBoxGateConnection.Size = new System.Drawing.Size(316, 59);
            this.groupBoxGateConnection.TabIndex = 6;
            this.groupBoxGateConnection.TabStop = false;
            this.groupBoxGateConnection.Text = "تنظیمات اتصال به گیت";
            // 
            // radioButtonGateDisconnected
            // 
            this.radioButtonGateDisconnected.AutoSize = true;
            this.radioButtonGateDisconnected.Checked = true;
            this.radioButtonGateDisconnected.Location = new System.Drawing.Point(12, 22);
            this.radioButtonGateDisconnected.Name = "radioButtonGateDisconnected";
            this.radioButtonGateDisconnected.Size = new System.Drawing.Size(103, 34);
            this.radioButtonGateDisconnected.TabIndex = 4;
            this.radioButtonGateDisconnected.TabStop = true;
            this.radioButtonGateDisconnected.Text = "غیرمتصل";
            this.radioButtonGateDisconnected.UseVisualStyleBackColor = true;
            this.radioButtonGateDisconnected.CheckedChanged += new System.EventHandler(this.radioButtonGateDisconnected_CheckedChanged);
            // 
            // radioButtonGateConnected
            // 
            this.radioButtonGateConnected.AutoSize = true;
            this.radioButtonGateConnected.Location = new System.Drawing.Point(105, 22);
            this.radioButtonGateConnected.Name = "radioButtonGateConnected";
            this.radioButtonGateConnected.Size = new System.Drawing.Size(78, 34);
            this.radioButtonGateConnected.TabIndex = 2;
            this.radioButtonGateConnected.Text = "متصل";
            this.radioButtonGateConnected.UseVisualStyleBackColor = true;
            this.radioButtonGateConnected.CheckedChanged += new System.EventHandler(this.radioButtonGateConnected_CheckedChanged);
            // 
            // groupBoxCameraSettings
            // 
            this.groupBoxCameraSettings.Controls.Add(this.radioButtonCameraOff);
            this.groupBoxCameraSettings.Controls.Add(this.radioButtonCameraOn);
            this.groupBoxCameraSettings.Location = new System.Drawing.Point(981, 8);
            this.groupBoxCameraSettings.Name = "groupBoxCameraSettings";
            this.groupBoxCameraSettings.Size = new System.Drawing.Size(290, 70);
            this.groupBoxCameraSettings.TabIndex = 5;
            this.groupBoxCameraSettings.TabStop = false;
            this.groupBoxCameraSettings.Text = "تنظیمات دوربین";
            // 
            // radioButtonCameraOff
            // 
            this.radioButtonCameraOff.AutoSize = true;
            this.radioButtonCameraOff.Location = new System.Drawing.Point(12, 27);
            this.radioButtonCameraOff.Name = "radioButtonCameraOff";
            this.radioButtonCameraOff.Size = new System.Drawing.Size(88, 34);
            this.radioButtonCameraOff.TabIndex = 4;
            this.radioButtonCameraOff.Text = "خاموش";
            this.radioButtonCameraOff.UseVisualStyleBackColor = true;
            this.radioButtonCameraOff.CheckedChanged += new System.EventHandler(this.radioButtonCameraOff_CheckedChanged);
            // 
            // radioButtonCameraOn
            // 
            this.radioButtonCameraOn.AutoSize = true;
            this.radioButtonCameraOn.Checked = true;
            this.radioButtonCameraOn.Location = new System.Drawing.Point(105, 27);
            this.radioButtonCameraOn.Name = "radioButtonCameraOn";
            this.radioButtonCameraOn.Size = new System.Drawing.Size(78, 34);
            this.radioButtonCameraOn.TabIndex = 2;
            this.radioButtonCameraOn.TabStop = true;
            this.radioButtonCameraOn.Text = "روشن";
            this.radioButtonCameraOn.UseVisualStyleBackColor = true;
            this.radioButtonCameraOn.CheckedChanged += new System.EventHandler(this.radioButtonCameraOn_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1321, 685);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("B Yekan", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سامانه کنترل تردد وسایل نقلیه - پارک علم و فناوری گیلان";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainTab.ResumeLayout(false);
            this.tabOnlineMonitoring.ResumeLayout(false);
            this.panelOnlineMonitoring.ResumeLayout(false);
            this.groupBox_Last.ResumeLayout(false);
            this.groupBox_Last.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastLPImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LastOwnerImage)).EndInit();
            this.groupBox_RecentReport.ResumeLayout(false);
            this.groupBox_RecentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recent)).EndInit();
            this.groupBox_OnlineWatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Online)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.groupBox_Filtration.ResumeLayout(false);
            this.groupBox_Filtration.PerformLayout();
            this.groupBox_SearchReports.ResumeLayout(false);
            this.groupBox_SearchReports.PerformLayout();
            this.groupBox_Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).EndInit();
            this.tabValidPeople.ResumeLayout(false);
            this.panelValidCars.ResumeLayout(false);
            this.groupBox_VehicleList.ResumeLayout(false);
            this.groupBox_ValidSearch.ResumeLayout(false);
            this.groupBox_ValidSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Valid)).EndInit();
            this.groupBox_Vehicles.ResumeLayout(false);
            this.groupBox_Vehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VehicleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OwnerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_City_VehicleProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_NumberR_VehicleProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LP_NumberL_VehicleProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicensePlate_groupBoxVehicles)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.groupBoxAdvanced.ResumeLayout(false);
            this.groupBoxAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSobelKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifferenceThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvgFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedianBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThresholdParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThresholdBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorphological_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorphological_Open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdge1)).EndInit();
            this.groupBoxROIControl.ResumeLayout(false);
            this.groupBoxROIControl.PerformLayout();
            this.groupBoxROILocation.ResumeLayout(false);
            this.groupBoxROICoverage.ResumeLayout(false);
            this.groupBoxROICoverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROIW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROIH)).EndInit();
            this.groupBoxROITrackbar.ResumeLayout(false);
            this.groupBoxROITrackbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarROIVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarROIHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROISetting)).EndInit();
            this.groupBoxGateConnection.ResumeLayout(false);
            this.groupBoxGateConnection.PerformLayout();
            this.groupBoxCameraSettings.ResumeLayout(false);
            this.groupBoxCameraSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabOnlineMonitoring;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabValidPeople;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.RadioButton radioButtonCameraOn;
        private System.Windows.Forms.Panel panelOnlineMonitoring;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelValidCars;
        private System.Windows.Forms.RadioButton radioButtonCameraOff;
        private System.Windows.Forms.GroupBox groupBoxCameraSettings;
        private System.Windows.Forms.GroupBox groupBoxGateConnection;
        private System.Windows.Forms.RadioButton radioButtonGateDisconnected;
        private System.Windows.Forms.RadioButton radioButtonGateConnected;
        private System.Windows.Forms.GroupBox groupBoxROILocation;
        private System.Windows.Forms.GroupBox groupBoxROIControl;
        private System.Windows.Forms.RadioButton radioButtonROIDisabled;
        private System.Windows.Forms.RadioButton radioButtonROIEnabled;
        private System.Windows.Forms.PictureBox pictureBoxROISetting;
        private System.Windows.Forms.Label labelROILocationH;
        private System.Windows.Forms.GroupBox groupBoxROITrackbar;
        private System.Windows.Forms.TrackBar trackBarROIVertical;
        private System.Windows.Forms.TrackBar trackBarROIHorizontal;
        private System.Windows.Forms.Label labelROILocationV;
        private System.Windows.Forms.GroupBox groupBoxROICoverage;
        private System.Windows.Forms.Label labelROICoverageW;
        private System.Windows.Forms.Label labelROICoverageH;
        private System.Windows.Forms.Button buttonSetROICoverage;
        private System.Windows.Forms.NumericUpDown numericUpDownROIW;
        private System.Windows.Forms.NumericUpDown numericUpDownROIH;
        private System.Windows.Forms.GroupBox groupBox_VehicleList;
        private System.Windows.Forms.GroupBox groupBox_Vehicles;
        private System.Windows.Forms.RadioButton radioButton_Woman;
        private System.Windows.Forms.RadioButton radioButton_Man;
        private System.Windows.Forms.Label labelLicensePlate;
        private System.Windows.Forms.PictureBox pictureBoxLicensePlate_groupBoxVehicles;
        private System.Windows.Forms.NumericUpDown numericUpDown_LP_City_VehicleProperties;
        private System.Windows.Forms.NumericUpDown numericUpDown_LP_NumberR_VehicleProperties;
        private System.Windows.Forms.NumericUpDown numericUpDown_LP_NumberL_VehicleProperties;
        private System.Windows.Forms.ComboBox comboBox_LP_Char_VehicleProperties;
        private System.Windows.Forms.Label labelVehicleOwner;
        private System.Windows.Forms.TextBox textBox_VehicleType;
        private System.Windows.Forms.Label label_VehicleType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_VehicleColor;
        private System.Windows.Forms.Label label_VehicleColor;
        private System.Windows.Forms.Label label_OwnerDescription;
        private System.Windows.Forms.TextBox textBox_OwnerDescription;
        private System.Windows.Forms.TextBox textBox_OwnerSurname;
        private System.Windows.Forms.TextBox textBox_OwnerName;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.TextBox textBox_NationalCode;
        private System.Windows.Forms.Label label_NationalCode;
        private System.Windows.Forms.DataGridView dataGridView_Valid;
        private System.Windows.Forms.GroupBox groupBox_ValidSearch;
        private System.Windows.Forms.TextBox textBox_Surname_Search;
        private System.Windows.Forms.Label label_Surname_Search;
        private System.Windows.Forms.TextBox textBox_LP_Search;
        private System.Windows.Forms.Label label_LP_Search;
        private System.Windows.Forms.TextBox textBox_NationalCode_Search;
        private System.Windows.Forms.Label label_NationalCode_Search;
        private System.Windows.Forms.PictureBox pictureBox_Online;
        private System.Windows.Forms.PictureBox pictureBox_VehicleImage;
        private System.Windows.Forms.PictureBox pictureBox_OwnerImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewImageColumn VehicleImage;
        private System.Windows.Forms.DataGridViewImageColumn OwnerImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.GroupBox groupBox_Report;
        private System.Windows.Forms.DataGridView dataGridView_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox_SearchReports;
        private System.Windows.Forms.TextBox textBox_SearchOwnerReports;
        private System.Windows.Forms.Label label_SearchOwnerReports;
        private System.Windows.Forms.TextBox textBox_SearchLPReports;
        private System.Windows.Forms.Label label_SearchLP;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.GroupBox groupBox_Filtration;
        private System.Windows.Forms.Label label_TillDate;
        private System.Windows.Forms.Label label_FromDate;
        private System.Windows.Forms.Button button_ApplyFilter;
        private System.Windows.Forms.TextBox textBox_TillDate;
        private System.Windows.Forms.TextBox textBox_FromDate;
        private System.Windows.Forms.GroupBox groupBox_OnlineWatch;
        private System.Windows.Forms.Button button_OfflineVideo;
        private System.Windows.Forms.Button button_OfflinePicture;
        private System.Windows.Forms.GroupBox groupBox_RecentReport;
        private System.Windows.Forms.DataGridView dataGridView_Recent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label_HintReport;
        private System.Windows.Forms.GroupBox groupBox_Last;
        private System.Windows.Forms.Label label_LastLP;
        private System.Windows.Forms.Label label_LastDateTime;
        private System.Windows.Forms.Label label_LastOwner;
        private System.Windows.Forms.PictureBox pictureBox_LastCarImage;
        private System.Windows.Forms.PictureBox pictureBox_LastLPImage;
        private System.Windows.Forms.PictureBox pictureBox_LastOwnerImage;
        private System.Windows.Forms.Button button_ClearLoadedFrame;
        private System.Windows.Forms.GroupBox groupBoxAdvanced;
        private System.Windows.Forms.NumericUpDown numericUpDownEdge1;
        private System.Windows.Forms.RadioButton radioButton_ShowEdge;
        private System.Windows.Forms.RadioButton radioButton_ShowMainFrame;
        private System.Windows.Forms.RadioButton radioButton_ShowGrayscale;
        private System.Windows.Forms.RadioButton radioButton_ShowGaussian;
        private System.Windows.Forms.NumericUpDown numericUpDownGaussian;
        private System.Windows.Forms.RadioButton radioButton_ShowThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.RadioButton radioButton_ShowMorphological;
        private System.Windows.Forms.NumericUpDown numericUpDownMorphological_Open;
        private System.Windows.Forms.NumericUpDown numericUpDownEdge2;
        private System.Windows.Forms.NumericUpDown numericUpDownMorphological_Close;
        private System.Windows.Forms.Button button_SubmitCalibration;
        private System.Windows.Forms.Button button_DefaultCalibration;
        private System.Windows.Forms.NumericUpDown numericUpDownThresholdParam1;
        private System.Windows.Forms.NumericUpDown numericUpDownThresholdBlockSize;
        private System.Windows.Forms.NumericUpDown numericUpDownMedianBlur;
        private System.Windows.Forms.Label label_MedianBlur;
        private System.Windows.Forms.Label label_AvgFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownAvgFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDifferenceThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSobelKernel;
        private System.Windows.Forms.RadioButton radioButton_FilteredFrame;
        private System.Windows.Forms.RadioButton radioButton_ThresholdDiffered;
        private System.Windows.Forms.RadioButton radioButton_SobelResult;
        private System.Windows.Forms.RadioButton radioButton_CC1;
        private System.Windows.Forms.RadioButton radioButton_CC3;
        private System.Windows.Forms.RadioButton radioButton_CC2;
    }
}

