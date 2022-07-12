
using System.Windows.Forms;

namespace Media_Bazaar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLogoInLogin = new System.Windows.Forms.PictureBox();
            this.ScheduleEmployee = new System.Windows.Forms.TabPage();
            this.lblScheduleToday = new System.Windows.Forms.Label();
            this.cbScheduleYear = new System.Windows.Forms.ComboBox();
            this.lblScheduleYear = new System.Windows.Forms.Label();
            this.cbScheduleWeek = new System.Windows.Forms.ComboBox();
            this.lblScheduleWeek = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbScheduleDep = new System.Windows.Forms.ComboBox();
            this.lblScheduleDep = new System.Windows.Forms.Label();
            this.ScheduleManager = new System.Windows.Forms.TabPage();
            this.lblScheduleMToday = new System.Windows.Forms.Label();
            this.cbScheduleMYear = new System.Windows.Forms.ComboBox();
            this.lblScheduleMYear = new System.Windows.Forms.Label();
            this.gbScheduleEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.btnScheduleMPreferences = new System.Windows.Forms.Button();
            this.lblHoursToAssign = new System.Windows.Forms.Label();
            this.cbScheduleWeekM = new System.Windows.Forms.ComboBox();
            this.lblScheduleWeekM = new System.Windows.Forms.Label();
            this.gbChangeShift = new System.Windows.Forms.GroupBox();
            this.btnScheduleEditShift = new System.Windows.Forms.Button();
            this.lblAddShiftEmployee = new System.Windows.Forms.Label();
            this.cbAddShiftEmployee = new System.Windows.Forms.ComboBox();
            this.dgvScheduleM = new System.Windows.Forms.DataGridView();
            this.ColShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadWeekset = new System.Windows.Forms.Button();
            this.btnSaveWeek = new System.Windows.Forms.Button();
            this.btnRemoveShift = new System.Windows.Forms.Button();
            this.btnAddWeekset = new System.Windows.Forms.Button();
            this.cbScheduleDepM = new System.Windows.Forms.ComboBox();
            this.lblScheduleDepM = new System.Windows.Forms.Label();
            this.Reshelving = new System.Windows.Forms.TabPage();
            this.dgvReShelving = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReShelvingHistory = new System.Windows.Forms.Button();
            this.btnRejectRequestManager = new System.Windows.Forms.Button();
            this.btnConfirmRequestManager = new System.Windows.Forms.Button();
            this.lblRequests = new System.Windows.Forms.Label();
            this.ReshelvingRequest = new System.Windows.Forms.TabPage();
            this.reshelvingRequestDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSItemName = new System.Windows.Forms.TextBox();
            this.rSRequestReject = new System.Windows.Forms.Button();
            this.rSRequestConfirm = new System.Windows.Forms.Button();
            this.rSDepTb = new System.Windows.Forms.TextBox();
            this.rSDepLbl = new System.Windows.Forms.Label();
            this.rSAmountTb = new System.Windows.Forms.TextBox();
            this.rSAmountLbl = new System.Windows.Forms.Label();
            this.rSSpecTb = new System.Windows.Forms.TextBox();
            this.rSSpecLbl = new System.Windows.Forms.Label();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.btnProductHistory = new System.Windows.Forms.Button();
            this.gbIncreaseDecreaseStock = new System.Windows.Forms.GroupBox();
            this.btnIncPrdct = new System.Windows.Forms.Button();
            this.btnDecPrdct = new System.Windows.Forms.Button();
            this.tbIncDecPrdctAmount = new System.Windows.Forms.TextBox();
            this.lblIncDecPrdctAmount = new System.Windows.Forms.Label();
            this.productFIlterTb = new System.Windows.Forms.TextBox();
            this.btnAddNewPrdct = new System.Windows.Forms.Button();
            this.btnDeletePrdct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditPrdct = new System.Windows.Forms.Button();
            this.btnRefreshPrdct = new System.Windows.Forms.Button();
            this.EmployeeManagement = new System.Windows.Forms.TabPage();
            this.btnSeeEmployeeInfo = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbxSearchEmployeeBar = new System.Windows.Forms.TextBox();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.colEmpMngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngFTEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Settings = new System.Windows.Forms.TabPage();
            this.gbxChangePassword = new System.Windows.Forms.GroupBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.tbxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInLogin)).BeginInit();
            this.ScheduleEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.ScheduleManager.SuspendLayout();
            this.gbScheduleEmployeeInfo.SuspendLayout();
            this.gbChangeShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleM)).BeginInit();
            this.Reshelving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReShelving)).BeginInit();
            this.ReshelvingRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reshelvingRequestDGV)).BeginInit();
            this.ProductPage.SuspendLayout();
            this.gbIncreaseDecreaseStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.EmployeeManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.Settings.SuspendLayout();
            this.gbxChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Login);
            this.tabControl.Controls.Add(this.ScheduleEmployee);
            this.tabControl.Controls.Add(this.ScheduleManager);
            this.tabControl.Controls.Add(this.Reshelving);
            this.tabControl.Controls.Add(this.ReshelvingRequest);
            this.tabControl.Controls.Add(this.ProductPage);
            this.tabControl.Controls.Add(this.EmployeeManagement);
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Location = new System.Drawing.Point(12, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1112, 724);
            this.tabControl.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Moccasin;
            this.Login.Controls.Add(this.btnLogin);
            this.Login.Controls.Add(this.tbxPassword);
            this.Login.Controls.Add(this.tbxUserName);
            this.Login.Controls.Add(this.pbPassword);
            this.Login.Controls.Add(this.pbUser);
            this.Login.Controls.Add(this.pbLogoInLogin);
            this.Login.Location = new System.Drawing.Point(4, 34);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(1104, 686);
            this.Login.TabIndex = 0;
            this.Login.Text = "LoginPage";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.Location = new System.Drawing.Point(597, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(566, 306);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(160, 31);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(566, 193);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(160, 31);
            this.tbxUserName.TabIndex = 3;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(451, 268);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(64, 70);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 2;
            this.pbPassword.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(451, 155);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(64, 70);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // pbLogoInLogin
            // 
            this.pbLogoInLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoInLogin.Image")));
            this.pbLogoInLogin.Location = new System.Drawing.Point(7, 6);
            this.pbLogoInLogin.Name = "pbLogoInLogin";
            this.pbLogoInLogin.Size = new System.Drawing.Size(216, 183);
            this.pbLogoInLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoInLogin.TabIndex = 0;
            this.pbLogoInLogin.TabStop = false;
            // 
            // ScheduleEmployee
            // 
            this.ScheduleEmployee.BackColor = System.Drawing.Color.Moccasin;
            this.ScheduleEmployee.Controls.Add(this.lblScheduleToday);
            this.ScheduleEmployee.Controls.Add(this.cbScheduleYear);
            this.ScheduleEmployee.Controls.Add(this.lblScheduleYear);
            this.ScheduleEmployee.Controls.Add(this.cbScheduleWeek);
            this.ScheduleEmployee.Controls.Add(this.lblScheduleWeek);
            this.ScheduleEmployee.Controls.Add(this.dgvSchedule);
            this.ScheduleEmployee.Controls.Add(this.cbScheduleDep);
            this.ScheduleEmployee.Controls.Add(this.lblScheduleDep);
            this.ScheduleEmployee.Location = new System.Drawing.Point(4, 34);
            this.ScheduleEmployee.Name = "ScheduleEmployee";
            this.ScheduleEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleEmployee.Size = new System.Drawing.Size(1104, 686);
            this.ScheduleEmployee.TabIndex = 1;
            this.ScheduleEmployee.Text = "Schedule";
            // 
            // lblScheduleToday
            // 
            this.lblScheduleToday.AutoSize = true;
            this.lblScheduleToday.Location = new System.Drawing.Point(767, 27);
            this.lblScheduleToday.Name = "lblScheduleToday";
            this.lblScheduleToday.Size = new System.Drawing.Size(119, 25);
            this.lblScheduleToday.TabIndex = 42;
            this.lblScheduleToday.Text = "<Date here>";
            // 
            // cbScheduleYear
            // 
            this.cbScheduleYear.FormattingEnabled = true;
            this.cbScheduleYear.Location = new System.Drawing.Point(482, 24);
            this.cbScheduleYear.Name = "cbScheduleYear";
            this.cbScheduleYear.Size = new System.Drawing.Size(83, 33);
            this.cbScheduleYear.TabIndex = 41;
            // 
            // lblScheduleYear
            // 
            this.lblScheduleYear.AutoSize = true;
            this.lblScheduleYear.Location = new System.Drawing.Point(434, 27);
            this.lblScheduleYear.Name = "lblScheduleYear";
            this.lblScheduleYear.Size = new System.Drawing.Size(51, 25);
            this.lblScheduleYear.TabIndex = 40;
            this.lblScheduleYear.Text = "Year:";
            // 
            // cbScheduleWeek
            // 
            this.cbScheduleWeek.FormattingEnabled = true;
            this.cbScheduleWeek.Location = new System.Drawing.Point(345, 24);
            this.cbScheduleWeek.Name = "cbScheduleWeek";
            this.cbScheduleWeek.Size = new System.Drawing.Size(68, 33);
            this.cbScheduleWeek.TabIndex = 38;
            // 
            // lblScheduleWeek
            // 
            this.lblScheduleWeek.AutoSize = true;
            this.lblScheduleWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduleWeek.Location = new System.Drawing.Point(278, 27);
            this.lblScheduleWeek.Name = "lblScheduleWeek";
            this.lblScheduleWeek.Size = new System.Drawing.Size(63, 25);
            this.lblScheduleWeek.TabIndex = 39;
            this.lblScheduleWeek.Text = "Week:";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvSchedule.Location = new System.Drawing.Point(27, 77);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 29;
            this.dgvSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSchedule.Size = new System.Drawing.Size(1051, 470);
            this.dgvSchedule.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Shift";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Thursday";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn9.HeaderText = "Saturday";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn10.HeaderText = "Sunday";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // cbScheduleDep
            // 
            this.cbScheduleDep.FormattingEnabled = true;
            this.cbScheduleDep.Items.AddRange(new object[] {
            "Electronics",
            "Kitchenware"});
            this.cbScheduleDep.Location = new System.Drawing.Point(134, 24);
            this.cbScheduleDep.Name = "cbScheduleDep";
            this.cbScheduleDep.Size = new System.Drawing.Size(138, 33);
            this.cbScheduleDep.TabIndex = 21;
            this.cbScheduleDep.SelectedIndexChanged += new System.EventHandler(this.cbScheduleDep_SelectedIndexChanged);
            // 
            // lblScheduleDep
            // 
            this.lblScheduleDep.AutoSize = true;
            this.lblScheduleDep.Location = new System.Drawing.Point(8, 24);
            this.lblScheduleDep.Name = "lblScheduleDep";
            this.lblScheduleDep.Size = new System.Drawing.Size(118, 25);
            this.lblScheduleDep.TabIndex = 20;
            this.lblScheduleDep.Text = "Department:";
            // 
            // ScheduleManager
            // 
            this.ScheduleManager.BackColor = System.Drawing.Color.Moccasin;
            this.ScheduleManager.Controls.Add(this.btnGenerateSchedule);
            this.ScheduleManager.Controls.Add(this.lblScheduleMToday);
            this.ScheduleManager.Controls.Add(this.cbScheduleMYear);
            this.ScheduleManager.Controls.Add(this.lblScheduleMYear);
            this.ScheduleManager.Controls.Add(this.gbScheduleEmployeeInfo);
            this.ScheduleManager.Controls.Add(this.cbScheduleWeekM);
            this.ScheduleManager.Controls.Add(this.lblScheduleWeekM);
            this.ScheduleManager.Controls.Add(this.gbChangeShift);
            this.ScheduleManager.Controls.Add(this.dgvScheduleM);
            this.ScheduleManager.Controls.Add(this.btnLoadWeekset);
            this.ScheduleManager.Controls.Add(this.btnSaveWeek);
            this.ScheduleManager.Controls.Add(this.btnRemoveShift);
            this.ScheduleManager.Controls.Add(this.btnAddWeekset);
            this.ScheduleManager.Controls.Add(this.cbScheduleDepM);
            this.ScheduleManager.Controls.Add(this.lblScheduleDepM);
            this.ScheduleManager.Location = new System.Drawing.Point(4, 34);
            this.ScheduleManager.Name = "ScheduleManager";
            this.ScheduleManager.Size = new System.Drawing.Size(1104, 686);
            this.ScheduleManager.TabIndex = 5;
            this.ScheduleManager.Text = "Schedule";
            // 
            // lblScheduleMToday
            // 
            this.lblScheduleMToday.AutoSize = true;
            this.lblScheduleMToday.Location = new System.Drawing.Point(781, 21);
            this.lblScheduleMToday.Name = "lblScheduleMToday";
            this.lblScheduleMToday.Size = new System.Drawing.Size(119, 25);
            this.lblScheduleMToday.TabIndex = 37;
            this.lblScheduleMToday.Text = "<Date here>";
            // 
            // cbScheduleMYear
            // 
            this.cbScheduleMYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbScheduleMYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbScheduleMYear.FormattingEnabled = true;
            this.cbScheduleMYear.Location = new System.Drawing.Point(558, 18);
            this.cbScheduleMYear.Name = "cbScheduleMYear";
            this.cbScheduleMYear.Size = new System.Drawing.Size(83, 33);
            this.cbScheduleMYear.TabIndex = 36;
            // 
            // lblScheduleMYear
            // 
            this.lblScheduleMYear.AutoSize = true;
            this.lblScheduleMYear.Location = new System.Drawing.Point(510, 21);
            this.lblScheduleMYear.Name = "lblScheduleMYear";
            this.lblScheduleMYear.Size = new System.Drawing.Size(51, 25);
            this.lblScheduleMYear.TabIndex = 35;
            this.lblScheduleMYear.Text = "Year:";
            // 
            // gbScheduleEmployeeInfo
            // 
            this.gbScheduleEmployeeInfo.Controls.Add(this.btnScheduleMPreferences);
            this.gbScheduleEmployeeInfo.Controls.Add(this.lblHoursToAssign);
            this.gbScheduleEmployeeInfo.Location = new System.Drawing.Point(388, 566);
            this.gbScheduleEmployeeInfo.Name = "gbScheduleEmployeeInfo";
            this.gbScheduleEmployeeInfo.Size = new System.Drawing.Size(191, 117);
            this.gbScheduleEmployeeInfo.TabIndex = 34;
            this.gbScheduleEmployeeInfo.TabStop = false;
            this.gbScheduleEmployeeInfo.Text = "Employee Info";
            // 
            // btnScheduleMPreferences
            // 
            this.btnScheduleMPreferences.Location = new System.Drawing.Point(12, 60);
            this.btnScheduleMPreferences.Name = "btnScheduleMPreferences";
            this.btnScheduleMPreferences.Size = new System.Drawing.Size(108, 51);
            this.btnScheduleMPreferences.TabIndex = 1;
            this.btnScheduleMPreferences.Text = "Prefences";
            this.btnScheduleMPreferences.UseVisualStyleBackColor = true;
            this.btnScheduleMPreferences.Click += new System.EventHandler(this.btnScheduleMPreferences_Click);
            // 
            // lblHoursToAssign
            // 
            this.lblHoursToAssign.AutoSize = true;
            this.lblHoursToAssign.Location = new System.Drawing.Point(12, 29);
            this.lblHoursToAssign.Name = "lblHoursToAssign";
            this.lblHoursToAssign.Size = new System.Drawing.Size(99, 25);
            this.lblHoursToAssign.TabIndex = 0;
            this.lblHoursToAssign.Text = "Hours left:";
            // 
            // cbScheduleWeekM
            // 
            this.cbScheduleWeekM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbScheduleWeekM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbScheduleWeekM.FormattingEnabled = true;
            this.cbScheduleWeekM.Location = new System.Drawing.Point(421, 18);
            this.cbScheduleWeekM.Name = "cbScheduleWeekM";
            this.cbScheduleWeekM.Size = new System.Drawing.Size(68, 33);
            this.cbScheduleWeekM.TabIndex = 31;
            this.cbScheduleWeekM.SelectedIndexChanged += new System.EventHandler(this.cbScheduleWeekM_SelectedIndexChanged);
            // 
            // lblScheduleWeekM
            // 
            this.lblScheduleWeekM.AutoSize = true;
            this.lblScheduleWeekM.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduleWeekM.Location = new System.Drawing.Point(354, 21);
            this.lblScheduleWeekM.Name = "lblScheduleWeekM";
            this.lblScheduleWeekM.Size = new System.Drawing.Size(63, 25);
            this.lblScheduleWeekM.TabIndex = 32;
            this.lblScheduleWeekM.Text = "Week:";
            // 
            // gbChangeShift
            // 
            this.gbChangeShift.Controls.Add(this.btnScheduleEditShift);
            this.gbChangeShift.Controls.Add(this.lblAddShiftEmployee);
            this.gbChangeShift.Controls.Add(this.cbAddShiftEmployee);
            this.gbChangeShift.Location = new System.Drawing.Point(29, 566);
            this.gbChangeShift.Name = "gbChangeShift";
            this.gbChangeShift.Size = new System.Drawing.Size(335, 117);
            this.gbChangeShift.TabIndex = 30;
            this.gbChangeShift.TabStop = false;
            this.gbChangeShift.Text = "Edit Shift";
            // 
            // btnScheduleEditShift
            // 
            this.btnScheduleEditShift.Location = new System.Drawing.Point(201, 56);
            this.btnScheduleEditShift.Name = "btnScheduleEditShift";
            this.btnScheduleEditShift.Size = new System.Drawing.Size(115, 40);
            this.btnScheduleEditShift.TabIndex = 2;
            this.btnScheduleEditShift.Text = "Confirm";
            this.btnScheduleEditShift.UseVisualStyleBackColor = true;
            this.btnScheduleEditShift.Click += new System.EventHandler(this.btnScheduleEditShift_Click);
            // 
            // lblAddShiftEmployee
            // 
            this.lblAddShiftEmployee.AutoSize = true;
            this.lblAddShiftEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblAddShiftEmployee.Location = new System.Drawing.Point(5, 31);
            this.lblAddShiftEmployee.Name = "lblAddShiftEmployee";
            this.lblAddShiftEmployee.Size = new System.Drawing.Size(97, 25);
            this.lblAddShiftEmployee.TabIndex = 1;
            this.lblAddShiftEmployee.Text = "Employee:";
            // 
            // cbAddShiftEmployee
            // 
            this.cbAddShiftEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAddShiftEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAddShiftEmployee.FormattingEnabled = true;
            this.cbAddShiftEmployee.Location = new System.Drawing.Point(6, 59);
            this.cbAddShiftEmployee.Name = "cbAddShiftEmployee";
            this.cbAddShiftEmployee.Size = new System.Drawing.Size(189, 33);
            this.cbAddShiftEmployee.TabIndex = 0;
            this.cbAddShiftEmployee.SelectedIndexChanged += new System.EventHandler(this.cbAddShiftEmployee_SelectedIndexChanged);
            // 
            // dgvScheduleM
            // 
            this.dgvScheduleM.AllowUserToAddRows = false;
            this.dgvScheduleM.AllowUserToDeleteRows = false;
            this.dgvScheduleM.AllowUserToResizeRows = false;
            this.dgvScheduleM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScheduleM.BackgroundColor = System.Drawing.Color.White;
            this.dgvScheduleM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduleM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColShift,
            this.ColMonday,
            this.ColTuesday,
            this.ColWednesday,
            this.ColThursday,
            this.ColFriday,
            this.ColSaturday,
            this.ColSunday,
            this.colID});
            this.dgvScheduleM.Location = new System.Drawing.Point(27, 77);
            this.dgvScheduleM.MultiSelect = false;
            this.dgvScheduleM.Name = "dgvScheduleM";
            this.dgvScheduleM.ReadOnly = true;
            this.dgvScheduleM.RowHeadersVisible = false;
            this.dgvScheduleM.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvScheduleM.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvScheduleM.RowTemplate.Height = 29;
            this.dgvScheduleM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvScheduleM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvScheduleM.Size = new System.Drawing.Size(1051, 470);
            this.dgvScheduleM.TabIndex = 29;
            this.dgvScheduleM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduleM_CellClick);
            this.dgvScheduleM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvScheduleM_CellFormatting);
            this.dgvScheduleM.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvScheduleM_CellPainting);
            // 
            // ColShift
            // 
            this.ColShift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ColShift.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColShift.HeaderText = "Shift";
            this.ColShift.MinimumWidth = 6;
            this.ColShift.Name = "ColShift";
            this.ColShift.ReadOnly = true;
            this.ColShift.Width = 79;
            // 
            // ColMonday
            // 
            this.ColMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMonday.HeaderText = "Monday";
            this.ColMonday.MinimumWidth = 6;
            this.ColMonday.Name = "ColMonday";
            this.ColMonday.ReadOnly = true;
            // 
            // ColTuesday
            // 
            this.ColTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTuesday.HeaderText = "Tuesday";
            this.ColTuesday.MinimumWidth = 6;
            this.ColTuesday.Name = "ColTuesday";
            this.ColTuesday.ReadOnly = true;
            // 
            // ColWednesday
            // 
            this.ColWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColWednesday.HeaderText = "Wednesday";
            this.ColWednesday.MinimumWidth = 6;
            this.ColWednesday.Name = "ColWednesday";
            this.ColWednesday.ReadOnly = true;
            // 
            // ColThursday
            // 
            this.ColThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColThursday.HeaderText = "Thursday";
            this.ColThursday.MinimumWidth = 6;
            this.ColThursday.Name = "ColThursday";
            this.ColThursday.ReadOnly = true;
            this.ColThursday.Width = 116;
            // 
            // ColFriday
            // 
            this.ColFriday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFriday.HeaderText = "Friday";
            this.ColFriday.MinimumWidth = 6;
            this.ColFriday.Name = "ColFriday";
            this.ColFriday.ReadOnly = true;
            // 
            // ColSaturday
            // 
            this.ColSaturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColSaturday.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColSaturday.HeaderText = "Saturday";
            this.ColSaturday.MinimumWidth = 6;
            this.ColSaturday.Name = "ColSaturday";
            this.ColSaturday.ReadOnly = true;
            // 
            // ColSunday
            // 
            this.ColSunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColSunday.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColSunday.HeaderText = "Sunday";
            this.ColSunday.MinimumWidth = 6;
            this.ColSunday.Name = "ColSunday";
            this.ColSunday.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // btnLoadWeekset
            // 
            this.btnLoadWeekset.Location = new System.Drawing.Point(684, 616);
            this.btnLoadWeekset.Name = "btnLoadWeekset";
            this.btnLoadWeekset.Size = new System.Drawing.Size(84, 61);
            this.btnLoadWeekset.TabIndex = 28;
            this.btnLoadWeekset.Text = "Paste Week";
            this.btnLoadWeekset.UseVisualStyleBackColor = true;
            this.btnLoadWeekset.Click += new System.EventHandler(this.btnLoadWeekset_Click);
            // 
            // btnSaveWeek
            // 
            this.btnSaveWeek.Location = new System.Drawing.Point(935, 599);
            this.btnSaveWeek.Name = "btnSaveWeek";
            this.btnSaveWeek.Size = new System.Drawing.Size(134, 62);
            this.btnSaveWeek.TabIndex = 27;
            this.btnSaveWeek.Text = "Save week";
            this.btnSaveWeek.UseVisualStyleBackColor = true;
            this.btnSaveWeek.Click += new System.EventHandler(this.btnSaveWeek_Click);
            // 
            // btnRemoveShift
            // 
            this.btnRemoveShift.Location = new System.Drawing.Point(795, 599);
            this.btnRemoveShift.Name = "btnRemoveShift";
            this.btnRemoveShift.Size = new System.Drawing.Size(134, 62);
            this.btnRemoveShift.TabIndex = 26;
            this.btnRemoveShift.Text = "Remove shift";
            this.btnRemoveShift.UseVisualStyleBackColor = true;
            this.btnRemoveShift.Click += new System.EventHandler(this.btnRemoveShift_Click);
            // 
            // btnAddWeekset
            // 
            this.btnAddWeekset.Location = new System.Drawing.Point(597, 616);
            this.btnAddWeekset.Name = "btnAddWeekset";
            this.btnAddWeekset.Size = new System.Drawing.Size(80, 61);
            this.btnAddWeekset.TabIndex = 25;
            this.btnAddWeekset.Text = "Copy Week";
            this.btnAddWeekset.UseVisualStyleBackColor = true;
            this.btnAddWeekset.Click += new System.EventHandler(this.btnAddWeekset_Click);
            // 
            // cbScheduleDepM
            // 
            this.cbScheduleDepM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbScheduleDepM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbScheduleDepM.FormattingEnabled = true;
            this.cbScheduleDepM.Location = new System.Drawing.Point(150, 18);
            this.cbScheduleDepM.Name = "cbScheduleDepM";
            this.cbScheduleDepM.Size = new System.Drawing.Size(198, 33);
            this.cbScheduleDepM.TabIndex = 24;
            this.cbScheduleDepM.SelectedIndexChanged += new System.EventHandler(this.cbScheduleDepM_SelectedIndexChanged);
            // 
            // lblScheduleDepM
            // 
            this.lblScheduleDepM.AutoSize = true;
            this.lblScheduleDepM.Location = new System.Drawing.Point(28, 21);
            this.lblScheduleDepM.Name = "lblScheduleDepM";
            this.lblScheduleDepM.Size = new System.Drawing.Size(118, 25);
            this.lblScheduleDepM.TabIndex = 23;
            this.lblScheduleDepM.Text = "Department:";
            // 
            // Reshelving
            // 
            this.Reshelving.BackColor = System.Drawing.Color.Moccasin;
            this.Reshelving.Controls.Add(this.dgvReShelving);
            this.Reshelving.Controls.Add(this.btnReShelvingHistory);
            this.Reshelving.Controls.Add(this.btnRejectRequestManager);
            this.Reshelving.Controls.Add(this.btnConfirmRequestManager);
            this.Reshelving.Controls.Add(this.lblRequests);
            this.Reshelving.Location = new System.Drawing.Point(4, 34);
            this.Reshelving.Name = "Reshelving";
            this.Reshelving.Padding = new System.Windows.Forms.Padding(3);
            this.Reshelving.Size = new System.Drawing.Size(1104, 686);
            this.Reshelving.TabIndex = 2;
            this.Reshelving.Text = "Reshelving";
            // 
            // dgvReShelving
            // 
            this.dgvReShelving.AllowUserToAddRows = false;
            this.dgvReShelving.AllowUserToDeleteRows = false;
            this.dgvReShelving.AllowUserToResizeColumns = false;
            this.dgvReShelving.AllowUserToResizeRows = false;
            this.dgvReShelving.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReShelving.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReShelving.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReShelving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReShelving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvReShelving.Location = new System.Drawing.Point(18, 47);
            this.dgvReShelving.MultiSelect = false;
            this.dgvReShelving.Name = "dgvReShelving";
            this.dgvReShelving.RowHeadersVisible = false;
            this.dgvReShelving.RowHeadersWidth = 51;
            this.dgvReShelving.RowTemplate.Height = 29;
            this.dgvReShelving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReShelving.Size = new System.Drawing.Size(1074, 460);
            this.dgvReShelving.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "RequestedAmount";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Department";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Specification";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // btnReShelvingHistory
            // 
            this.btnReShelvingHistory.Location = new System.Drawing.Point(19, 583);
            this.btnReShelvingHistory.Name = "btnReShelvingHistory";
            this.btnReShelvingHistory.Size = new System.Drawing.Size(112, 43);
            this.btnReShelvingHistory.TabIndex = 33;
            this.btnReShelvingHistory.Text = "History";
            this.btnReShelvingHistory.UseVisualStyleBackColor = true;
            this.btnReShelvingHistory.Click += new System.EventHandler(this.btnReShelvingHistory_Click);
            // 
            // btnRejectRequestManager
            // 
            this.btnRejectRequestManager.BackColor = System.Drawing.Color.LightGray;
            this.btnRejectRequestManager.Location = new System.Drawing.Point(914, 568);
            this.btnRejectRequestManager.Name = "btnRejectRequestManager";
            this.btnRejectRequestManager.Size = new System.Drawing.Size(68, 41);
            this.btnRejectRequestManager.TabIndex = 32;
            this.btnRejectRequestManager.Text = "✗";
            this.btnRejectRequestManager.UseVisualStyleBackColor = false;
            this.btnRejectRequestManager.Click += new System.EventHandler(this.btnRejectRequestManager_Click);
            // 
            // btnConfirmRequestManager
            // 
            this.btnConfirmRequestManager.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmRequestManager.Location = new System.Drawing.Point(817, 568);
            this.btnConfirmRequestManager.Name = "btnConfirmRequestManager";
            this.btnConfirmRequestManager.Size = new System.Drawing.Size(68, 41);
            this.btnConfirmRequestManager.TabIndex = 31;
            this.btnConfirmRequestManager.Text = "✓";
            this.btnConfirmRequestManager.UseVisualStyleBackColor = false;
            this.btnConfirmRequestManager.Click += new System.EventHandler(this.btnConfirmRequestManager_Click);
            // 
            // lblRequests
            // 
            this.lblRequests.BackColor = System.Drawing.Color.Moccasin;
            this.lblRequests.Location = new System.Drawing.Point(18, 12);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(113, 32);
            this.lblRequests.TabIndex = 0;
            this.lblRequests.Text = "Requests:";
            // 
            // ReshelvingRequest
            // 
            this.ReshelvingRequest.BackColor = System.Drawing.Color.Moccasin;
            this.ReshelvingRequest.Controls.Add(this.reshelvingRequestDGV);
            this.ReshelvingRequest.Controls.Add(this.rSItemName);
            this.ReshelvingRequest.Controls.Add(this.rSRequestReject);
            this.ReshelvingRequest.Controls.Add(this.rSRequestConfirm);
            this.ReshelvingRequest.Controls.Add(this.rSDepTb);
            this.ReshelvingRequest.Controls.Add(this.rSDepLbl);
            this.ReshelvingRequest.Controls.Add(this.rSAmountTb);
            this.ReshelvingRequest.Controls.Add(this.rSAmountLbl);
            this.ReshelvingRequest.Controls.Add(this.rSSpecTb);
            this.ReshelvingRequest.Controls.Add(this.rSSpecLbl);
            this.ReshelvingRequest.Location = new System.Drawing.Point(4, 34);
            this.ReshelvingRequest.Name = "ReshelvingRequest";
            this.ReshelvingRequest.Padding = new System.Windows.Forms.Padding(3);
            this.ReshelvingRequest.Size = new System.Drawing.Size(1104, 686);
            this.ReshelvingRequest.TabIndex = 8;
            this.ReshelvingRequest.Text = "Reshelving Request";
            // 
            // reshelvingRequestDGV
            // 
            this.reshelvingRequestDGV.AllowUserToAddRows = false;
            this.reshelvingRequestDGV.AllowUserToDeleteRows = false;
            this.reshelvingRequestDGV.AllowUserToResizeColumns = false;
            this.reshelvingRequestDGV.AllowUserToResizeRows = false;
            this.reshelvingRequestDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reshelvingRequestDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reshelvingRequestDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reshelvingRequestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reshelvingRequestDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19});
            this.reshelvingRequestDGV.Location = new System.Drawing.Point(27, 102);
            this.reshelvingRequestDGV.MultiSelect = false;
            this.reshelvingRequestDGV.Name = "reshelvingRequestDGV";
            this.reshelvingRequestDGV.RowHeadersVisible = false;
            this.reshelvingRequestDGV.RowHeadersWidth = 51;
            this.reshelvingRequestDGV.RowTemplate.Height = 29;
            this.reshelvingRequestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reshelvingRequestDGV.Size = new System.Drawing.Size(664, 455);
            this.reshelvingRequestDGV.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // rSItemName
            // 
            this.rSItemName.Location = new System.Drawing.Point(27, 40);
            this.rSItemName.Name = "rSItemName";
            this.rSItemName.PlaceholderText = "Type to filter items";
            this.rSItemName.Size = new System.Drawing.Size(239, 31);
            this.rSItemName.TabIndex = 44;
            this.rSItemName.TextChanged += new System.EventHandler(this.rSFilterButton_Click);
            // 
            // rSRequestReject
            // 
            this.rSRequestReject.BackColor = System.Drawing.Color.LightGray;
            this.rSRequestReject.Location = new System.Drawing.Point(889, 505);
            this.rSRequestReject.Name = "rSRequestReject";
            this.rSRequestReject.Size = new System.Drawing.Size(64, 41);
            this.rSRequestReject.TabIndex = 43;
            this.rSRequestReject.Text = "✗";
            this.rSRequestReject.UseVisualStyleBackColor = false;
            this.rSRequestReject.Click += new System.EventHandler(this.rSRequestReject_Click);
            // 
            // rSRequestConfirm
            // 
            this.rSRequestConfirm.BackColor = System.Drawing.Color.LightGray;
            this.rSRequestConfirm.Location = new System.Drawing.Point(776, 505);
            this.rSRequestConfirm.Name = "rSRequestConfirm";
            this.rSRequestConfirm.Size = new System.Drawing.Size(65, 41);
            this.rSRequestConfirm.TabIndex = 42;
            this.rSRequestConfirm.Text = "✓";
            this.rSRequestConfirm.UseVisualStyleBackColor = false;
            this.rSRequestConfirm.Click += new System.EventHandler(this.rSRequestConfirm_Click);
            // 
            // rSDepTb
            // 
            this.rSDepTb.Location = new System.Drawing.Point(776, 255);
            this.rSDepTb.Name = "rSDepTb";
            this.rSDepTb.Size = new System.Drawing.Size(177, 31);
            this.rSDepTb.TabIndex = 40;
            // 
            // rSDepLbl
            // 
            this.rSDepLbl.AutoSize = true;
            this.rSDepLbl.Location = new System.Drawing.Point(776, 212);
            this.rSDepLbl.Name = "rSDepLbl";
            this.rSDepLbl.Size = new System.Drawing.Size(118, 25);
            this.rSDepLbl.TabIndex = 39;
            this.rSDepLbl.Text = "Department:";
            // 
            // rSAmountTb
            // 
            this.rSAmountTb.Location = new System.Drawing.Point(776, 141);
            this.rSAmountTb.Name = "rSAmountTb";
            this.rSAmountTb.Size = new System.Drawing.Size(177, 31);
            this.rSAmountTb.TabIndex = 38;
            // 
            // rSAmountLbl
            // 
            this.rSAmountLbl.AutoSize = true;
            this.rSAmountLbl.Location = new System.Drawing.Point(776, 102);
            this.rSAmountLbl.Name = "rSAmountLbl";
            this.rSAmountLbl.Size = new System.Drawing.Size(84, 25);
            this.rSAmountLbl.TabIndex = 37;
            this.rSAmountLbl.Text = "Amount:";
            // 
            // rSSpecTb
            // 
            this.rSSpecTb.Location = new System.Drawing.Point(776, 371);
            this.rSSpecTb.Name = "rSSpecTb";
            this.rSSpecTb.Size = new System.Drawing.Size(177, 31);
            this.rSSpecTb.TabIndex = 36;
            // 
            // rSSpecLbl
            // 
            this.rSSpecLbl.AutoSize = true;
            this.rSSpecLbl.Location = new System.Drawing.Point(776, 327);
            this.rSSpecLbl.Name = "rSSpecLbl";
            this.rSSpecLbl.Size = new System.Drawing.Size(130, 25);
            this.rSSpecLbl.TabIndex = 33;
            this.rSSpecLbl.Text = "Specifications:";
            // 
            // ProductPage
            // 
            this.ProductPage.BackColor = System.Drawing.Color.Moccasin;
            this.ProductPage.Controls.Add(this.btnProductHistory);
            this.ProductPage.Controls.Add(this.gbIncreaseDecreaseStock);
            this.ProductPage.Controls.Add(this.productFIlterTb);
            this.ProductPage.Controls.Add(this.btnAddNewPrdct);
            this.ProductPage.Controls.Add(this.btnDeletePrdct);
            this.ProductPage.Controls.Add(this.dgvProducts);
            this.ProductPage.Controls.Add(this.btnEditPrdct);
            this.ProductPage.Controls.Add(this.btnRefreshPrdct);
            this.ProductPage.Location = new System.Drawing.Point(4, 34);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Size = new System.Drawing.Size(1104, 686);
            this.ProductPage.TabIndex = 6;
            this.ProductPage.Text = "Product";
            // 
            // btnProductHistory
            // 
            this.btnProductHistory.Location = new System.Drawing.Point(861, 22);
            this.btnProductHistory.Name = "btnProductHistory";
            this.btnProductHistory.Size = new System.Drawing.Size(100, 46);
            this.btnProductHistory.TabIndex = 47;
            this.btnProductHistory.Text = "History";
            this.btnProductHistory.UseVisualStyleBackColor = true;
            this.btnProductHistory.Click += new System.EventHandler(this.btnProductHistory_Click);
            // 
            // gbIncreaseDecreaseStock
            // 
            this.gbIncreaseDecreaseStock.Controls.Add(this.btnIncPrdct);
            this.gbIncreaseDecreaseStock.Controls.Add(this.btnDecPrdct);
            this.gbIncreaseDecreaseStock.Controls.Add(this.tbIncDecPrdctAmount);
            this.gbIncreaseDecreaseStock.Controls.Add(this.lblIncDecPrdctAmount);
            this.gbIncreaseDecreaseStock.Location = new System.Drawing.Point(839, 465);
            this.gbIncreaseDecreaseStock.Name = "gbIncreaseDecreaseStock";
            this.gbIncreaseDecreaseStock.Size = new System.Drawing.Size(228, 145);
            this.gbIncreaseDecreaseStock.TabIndex = 46;
            this.gbIncreaseDecreaseStock.TabStop = false;
            this.gbIncreaseDecreaseStock.Text = "Increase-Decrease Stock";
            // 
            // btnIncPrdct
            // 
            this.btnIncPrdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncPrdct.Location = new System.Drawing.Point(112, 94);
            this.btnIncPrdct.Name = "btnIncPrdct";
            this.btnIncPrdct.Size = new System.Drawing.Size(44, 39);
            this.btnIncPrdct.TabIndex = 28;
            this.btnIncPrdct.Text = "+";
            this.btnIncPrdct.UseVisualStyleBackColor = true;
            this.btnIncPrdct.Click += new System.EventHandler(this.btnIncPrdct_Click);
            // 
            // btnDecPrdct
            // 
            this.btnDecPrdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecPrdct.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDecPrdct.Location = new System.Drawing.Point(162, 94);
            this.btnDecPrdct.Name = "btnDecPrdct";
            this.btnDecPrdct.Size = new System.Drawing.Size(43, 39);
            this.btnDecPrdct.TabIndex = 29;
            this.btnDecPrdct.Text = "-";
            this.btnDecPrdct.UseVisualStyleBackColor = true;
            this.btnDecPrdct.Click += new System.EventHandler(this.btnDecPrdct_Click);
            // 
            // tbIncDecPrdctAmount
            // 
            this.tbIncDecPrdctAmount.Location = new System.Drawing.Point(112, 57);
            this.tbIncDecPrdctAmount.Name = "tbIncDecPrdctAmount";
            this.tbIncDecPrdctAmount.Size = new System.Drawing.Size(93, 31);
            this.tbIncDecPrdctAmount.TabIndex = 23;
            // 
            // lblIncDecPrdctAmount
            // 
            this.lblIncDecPrdctAmount.AutoSize = true;
            this.lblIncDecPrdctAmount.Location = new System.Drawing.Point(22, 63);
            this.lblIncDecPrdctAmount.Name = "lblIncDecPrdctAmount";
            this.lblIncDecPrdctAmount.Size = new System.Drawing.Size(84, 25);
            this.lblIncDecPrdctAmount.TabIndex = 27;
            this.lblIncDecPrdctAmount.Text = "Amount:";
            // 
            // productFIlterTb
            // 
            this.productFIlterTb.Location = new System.Drawing.Point(12, 35);
            this.productFIlterTb.Name = "productFIlterTb";
            this.productFIlterTb.PlaceholderText = "Type to filter items";
            this.productFIlterTb.Size = new System.Drawing.Size(308, 31);
            this.productFIlterTb.TabIndex = 45;
            this.productFIlterTb.TextChanged += new System.EventHandler(this.productFilterBtn_Click);
            // 
            // btnAddNewPrdct
            // 
            this.btnAddNewPrdct.Location = new System.Drawing.Point(72, 516);
            this.btnAddNewPrdct.Name = "btnAddNewPrdct";
            this.btnAddNewPrdct.Size = new System.Drawing.Size(147, 64);
            this.btnAddNewPrdct.TabIndex = 32;
            this.btnAddNewPrdct.Text = "Add New Product";
            this.btnAddNewPrdct.UseVisualStyleBackColor = true;
            this.btnAddNewPrdct.Click += new System.EventHandler(this.btnAddNewPrdct_Click);
            // 
            // btnDeletePrdct
            // 
            this.btnDeletePrdct.Location = new System.Drawing.Point(465, 516);
            this.btnDeletePrdct.Name = "btnDeletePrdct";
            this.btnDeletePrdct.Size = new System.Drawing.Size(147, 63);
            this.btnDeletePrdct.TabIndex = 31;
            this.btnDeletePrdct.Text = "Delete";
            this.btnDeletePrdct.UseVisualStyleBackColor = true;
            this.btnDeletePrdct.Click += new System.EventHandler(this.btnDeletePrdct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.purchasePrice,
            this.sellPrice,
            this.dataGridViewTextBoxColumn6,
            this.manufacturer,
            this.location,
            this.description});
            this.dgvProducts.Location = new System.Drawing.Point(12, 72);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1074, 387);
            this.dgvProducts.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 8;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // sellPrice
            // 
            this.sellPrice.HeaderText = "Sell Price";
            this.sellPrice.MinimumWidth = 8;
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 8;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 8;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // btnEditPrdct
            // 
            this.btnEditPrdct.Location = new System.Drawing.Point(284, 514);
            this.btnEditPrdct.Name = "btnEditPrdct";
            this.btnEditPrdct.Size = new System.Drawing.Size(147, 64);
            this.btnEditPrdct.TabIndex = 24;
            this.btnEditPrdct.Text = "Edit";
            this.btnEditPrdct.UseVisualStyleBackColor = true;
            this.btnEditPrdct.Click += new System.EventHandler(this.btnEditPrdct_Click);
            // 
            // btnRefreshPrdct
            // 
            this.btnRefreshPrdct.Location = new System.Drawing.Point(986, 22);
            this.btnRefreshPrdct.Name = "btnRefreshPrdct";
            this.btnRefreshPrdct.Size = new System.Drawing.Size(100, 46);
            this.btnRefreshPrdct.TabIndex = 20;
            this.btnRefreshPrdct.Text = "Refresh";
            this.btnRefreshPrdct.UseVisualStyleBackColor = true;
            this.btnRefreshPrdct.Click += new System.EventHandler(this.btnRefreshPrdct_Click);
            // 
            // EmployeeManagement
            // 
            this.EmployeeManagement.BackColor = System.Drawing.Color.Moccasin;
            this.EmployeeManagement.Controls.Add(this.btnSeeEmployeeInfo);
            this.EmployeeManagement.Controls.Add(this.btnRemoveEmployee);
            this.EmployeeManagement.Controls.Add(this.btnEditEmployee);
            this.EmployeeManagement.Controls.Add(this.btnAddEmployee);
            this.EmployeeManagement.Controls.Add(this.tbxSearchEmployeeBar);
            this.EmployeeManagement.Controls.Add(this.dgvEmployeeDetails);
            this.EmployeeManagement.Location = new System.Drawing.Point(4, 34);
            this.EmployeeManagement.Name = "EmployeeManagement";
            this.EmployeeManagement.Size = new System.Drawing.Size(1104, 686);
            this.EmployeeManagement.TabIndex = 7;
            this.EmployeeManagement.Text = "Employee Management";
            // 
            // btnSeeEmployeeInfo
            // 
            this.btnSeeEmployeeInfo.BackColor = System.Drawing.Color.LightGray;
            this.btnSeeEmployeeInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeeEmployeeInfo.BackgroundImage")));
            this.btnSeeEmployeeInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeeEmployeeInfo.Location = new System.Drawing.Point(979, 49);
            this.btnSeeEmployeeInfo.Name = "btnSeeEmployeeInfo";
            this.btnSeeEmployeeInfo.Size = new System.Drawing.Size(62, 47);
            this.btnSeeEmployeeInfo.TabIndex = 33;
            this.btnSeeEmployeeInfo.UseVisualStyleBackColor = false;
            this.btnSeeEmployeeInfo.Click += new System.EventHandler(this.btnSeeEmployeeInfo_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.LightGray;
            this.btnRemoveEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveEmployee.BackgroundImage")));
            this.btnRemoveEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(893, 49);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(62, 47);
            this.btnRemoveEmployee.TabIndex = 32;
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.LightGray;
            this.btnEditEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.BackgroundImage")));
            this.btnEditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditEmployee.Location = new System.Drawing.Point(807, 49);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(62, 47);
            this.btnEditEmployee.TabIndex = 31;
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightGray;
            this.btnAddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.BackgroundImage")));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Location = new System.Drawing.Point(721, 49);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(62, 47);
            this.btnAddEmployee.TabIndex = 30;
            this.btnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbxSearchEmployeeBar
            // 
            this.tbxSearchEmployeeBar.Location = new System.Drawing.Point(56, 57);
            this.tbxSearchEmployeeBar.Name = "tbxSearchEmployeeBar";
            this.tbxSearchEmployeeBar.PlaceholderText = "Type employee name to search";
            this.tbxSearchEmployeeBar.Size = new System.Drawing.Size(322, 31);
            this.tbxSearchEmployeeBar.TabIndex = 29;
            this.tbxSearchEmployeeBar.TextChanged += new System.EventHandler(this.tbxSearchEmployeeBar_TextChanged);
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.AllowUserToResizeColumns = false;
            this.dgvEmployeeDetails.AllowUserToResizeRows = false;
            this.dgvEmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployeeDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpMngName,
            this.colEmpMngLastName,
            this.colEmpMngPosition,
            this.colEmpMngDepartment,
            this.colEmpMngFTEs,
            this.colEmpMngPhone,
            this.colEmpMngEmail});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployeeDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmployeeDetails.GridColor = System.Drawing.Color.White;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(46, 116);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            this.dgvEmployeeDetails.RowHeadersWidth = 51;
            this.dgvEmployeeDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvEmployeeDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployeeDetails.RowTemplate.Height = 29;
            this.dgvEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDetails.ShowEditingIcon = false;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(1006, 401);
            this.dgvEmployeeDetails.TabIndex = 28;
            // 
            // colEmpMngName
            // 
            this.colEmpMngName.FillWeight = 101.6958F;
            this.colEmpMngName.HeaderText = "Name";
            this.colEmpMngName.MinimumWidth = 6;
            this.colEmpMngName.Name = "colEmpMngName";
            // 
            // colEmpMngLastName
            // 
            this.colEmpMngLastName.FillWeight = 101.6958F;
            this.colEmpMngLastName.HeaderText = "Last name";
            this.colEmpMngLastName.MinimumWidth = 6;
            this.colEmpMngLastName.Name = "colEmpMngLastName";
            // 
            // colEmpMngPosition
            // 
            this.colEmpMngPosition.FillWeight = 101.6958F;
            this.colEmpMngPosition.HeaderText = "Position";
            this.colEmpMngPosition.MinimumWidth = 6;
            this.colEmpMngPosition.Name = "colEmpMngPosition";
            // 
            // colEmpMngDepartment
            // 
            this.colEmpMngDepartment.FillWeight = 101.6958F;
            this.colEmpMngDepartment.HeaderText = "Department";
            this.colEmpMngDepartment.MinimumWidth = 6;
            this.colEmpMngDepartment.Name = "colEmpMngDepartment";
            // 
            // colEmpMngFTEs
            // 
            this.colEmpMngFTEs.FillWeight = 41.7885F;
            this.colEmpMngFTEs.HeaderText = "FTEs";
            this.colEmpMngFTEs.MinimumWidth = 6;
            this.colEmpMngFTEs.Name = "colEmpMngFTEs";
            // 
            // colEmpMngPhone
            // 
            this.colEmpMngPhone.FillWeight = 101.6958F;
            this.colEmpMngPhone.HeaderText = "Phone Number";
            this.colEmpMngPhone.MinimumWidth = 6;
            this.colEmpMngPhone.Name = "colEmpMngPhone";
            // 
            // colEmpMngEmail
            // 
            this.colEmpMngEmail.FillWeight = 149.7326F;
            this.colEmpMngEmail.HeaderText = "email";
            this.colEmpMngEmail.MinimumWidth = 6;
            this.colEmpMngEmail.Name = "colEmpMngEmail";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Moccasin;
            this.Settings.Controls.Add(this.gbxChangePassword);
            this.Settings.Location = new System.Drawing.Point(4, 34);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1104, 686);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            // 
            // gbxChangePassword
            // 
            this.gbxChangePassword.Controls.Add(this.lblConfirmNewPassword);
            this.gbxChangePassword.Controls.Add(this.lblNewPassword);
            this.gbxChangePassword.Controls.Add(this.lblOldPassword);
            this.gbxChangePassword.Controls.Add(this.tbxConfirmNewPassword);
            this.gbxChangePassword.Controls.Add(this.tbxNewPassword);
            this.gbxChangePassword.Controls.Add(this.tbxOldPassword);
            this.gbxChangePassword.Controls.Add(this.btnChangePassword);
            this.gbxChangePassword.Location = new System.Drawing.Point(33, 38);
            this.gbxChangePassword.Name = "gbxChangePassword";
            this.gbxChangePassword.Size = new System.Drawing.Size(245, 442);
            this.gbxChangePassword.TabIndex = 20;
            this.gbxChangePassword.TabStop = false;
            this.gbxChangePassword.Text = "Change password";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(20, 264);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(207, 25);
            this.lblConfirmNewPassword.TabIndex = 25;
            this.lblConfirmNewPassword.Text = "Confirm new password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(20, 154);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(138, 25);
            this.lblNewPassword.TabIndex = 24;
            this.lblNewPassword.Text = "New password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(20, 47);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(130, 25);
            this.lblOldPassword.TabIndex = 23;
            this.lblOldPassword.Text = "Old password:";
            // 
            // tbxConfirmNewPassword
            // 
            this.tbxConfirmNewPassword.Location = new System.Drawing.Point(35, 307);
            this.tbxConfirmNewPassword.Name = "tbxConfirmNewPassword";
            this.tbxConfirmNewPassword.PasswordChar = '*';
            this.tbxConfirmNewPassword.Size = new System.Drawing.Size(189, 31);
            this.tbxConfirmNewPassword.TabIndex = 22;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(35, 198);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '*';
            this.tbxNewPassword.Size = new System.Drawing.Size(189, 31);
            this.tbxNewPassword.TabIndex = 21;
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Location = new System.Drawing.Point(35, 89);
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.PasswordChar = '*';
            this.tbxOldPassword.Size = new System.Drawing.Size(189, 31);
            this.tbxOldPassword.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangePassword.Location = new System.Drawing.Point(35, 380);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(165, 39);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedUser.Location = new System.Drawing.Point(930, 13);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 41);
            this.lblLoggedUser.TabIndex = 1;
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateSchedule.Location = new System.Drawing.Point(597, 553);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(171, 48);
            this.btnGenerateSchedule.TabIndex = 38;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1136, 774);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Media Bazaar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoInLogin)).EndInit();
            this.ScheduleEmployee.ResumeLayout(false);
            this.ScheduleEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ScheduleManager.ResumeLayout(false);
            this.ScheduleManager.PerformLayout();
            this.gbScheduleEmployeeInfo.ResumeLayout(false);
            this.gbScheduleEmployeeInfo.PerformLayout();
            this.gbChangeShift.ResumeLayout(false);
            this.gbChangeShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleM)).EndInit();
            this.Reshelving.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReShelving)).EndInit();
            this.ReshelvingRequest.ResumeLayout(false);
            this.ReshelvingRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reshelvingRequestDGV)).EndInit();
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            this.gbIncreaseDecreaseStock.ResumeLayout(false);
            this.gbIncreaseDecreaseStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.EmployeeManagement.ResumeLayout(false);
            this.EmployeeManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.Settings.ResumeLayout(false);
            this.gbxChangePassword.ResumeLayout(false);
            this.gbxChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLogoInLogin;
        private System.Windows.Forms.TabPage ScheduleEmployee;
        private ComboBox cbScheduleDep;
        private Label lblScheduleDep;
        private System.Windows.Forms.TabPage Reshelving;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage ScheduleManager;
        private Button btnLoadWeekset;
        private Button btnSaveWeek;
        private Button btnRemoveShift;
        private Button btnAddWeekset;
        private ComboBox cbScheduleDepM;
        private Label lblScheduleDepM;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.TabPage EmployeeManagement;
        private System.Windows.Forms.GroupBox gbxChangePassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox tbxConfirmNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSeeEmployeeInfo;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private Label lblRequests;
        private DataGridView dgvScheduleM;
        private GroupBox gbChangeShift;
        private Label lblScheduleWeekM;
        private ComboBox cbScheduleWeekM;
        private ComboBox cbAddShiftEmployee;
        private Label lblAddShiftEmployee;
        private Button btnConfirmRequestManager;
        private Button btnRejectRequestManager;
        private DataGridView dgvProducts;
        private Button btnDecPrdct;
        private Button btnIncPrdct;
        private Label lblIncDecPrdctAmount;
        private Button btnEditPrdct;
        private TextBox tbIncDecPrdctAmount;
        private Button btnRefreshPrdct;
        private Button btnDeletePrdct;
        private Button btnAddNewPrdct;
        private DataGridViewTextBoxColumn colEmpMngName;
        private DataGridViewTextBoxColumn colEmpMngLastName;
        private DataGridViewTextBoxColumn colEmpMngPosition;
        private DataGridViewTextBoxColumn colEmpMngDepartment;
        private DataGridViewTextBoxColumn colEmpMngFTEs;
        private DataGridViewTextBoxColumn colEmpMngPhone;
        private DataGridViewTextBoxColumn colEmpMngEmail;
        public TextBox tbxSearchEmployeeBar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn purchasePrice;
        private DataGridViewTextBoxColumn sellPrice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn manufacturer;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn description;
        private DataGridView dgvSchedule;
        private Button btnScheduleEditShift;
        private TabPage ReshelvingRequest;
        private TextBox rSItemName;
        private Button rSRequestReject;
        private Button rSRequestConfirm;
        private TextBox rSDepTb;
        private Label rSDepLbl;
        private TextBox rSAmountTb;
        private Label rSAmountLbl;
        private TextBox rSSpecTb;
        private Label rSSpecLbl;
        public TextBox productFIlterTb;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private GroupBox gbIncreaseDecreaseStock;
        private Label lblLoggedUser;
        private Button btnReShelvingHistory;
        private DataGridView dgvReShelving;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private GroupBox gbScheduleEmployeeInfo;
        private Label lblHoursToAssign;
        private Button btnScheduleMPreferences;
        private DataGridView reshelvingRequestDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Label lblScheduleMYear;
        private ComboBox cbScheduleMYear;
        private Label lblScheduleMToday;
        private Label lblScheduleToday;
        private ComboBox cbScheduleYear;
        private Label lblScheduleYear;
        private ComboBox cbScheduleWeek;
        private Label lblScheduleWeek;
        private Button btnProductHistory;
        private DataGridViewTextBoxColumn ColShift;
        private DataGridViewTextBoxColumn ColMonday;
        private DataGridViewTextBoxColumn ColTuesday;
        private DataGridViewTextBoxColumn ColWednesday;
        private DataGridViewTextBoxColumn ColThursday;
        private DataGridViewTextBoxColumn ColFriday;
        private DataGridViewTextBoxColumn ColSaturday;
        private DataGridViewTextBoxColumn ColSunday;
        private DataGridViewTextBoxColumn colID;
        private Button btnGenerateSchedule;
    }
}

