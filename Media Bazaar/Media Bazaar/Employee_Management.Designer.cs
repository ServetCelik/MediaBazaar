namespace Media_Bazaar
{
    partial class FormEmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblddmmyy = new System.Windows.Forms.Label();
            this.tbxDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBSN = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbxHourlyWage = new System.Windows.Forms.TextBox();
            this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.lblFTEAmount = new System.Windows.Forms.Label();
            this.lblEmployeeDepartment = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.gbxContractInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbContractType = new System.Windows.Forms.ComboBox();
            this.tbxFTEAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxNewContract = new System.Windows.Forms.CheckBox();
            this.lblddmmyy2 = new System.Windows.Forms.Label();
            this.tbxEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblddmmyy1 = new System.Windows.Forms.Label();
            this.tbxStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCancelEmployeeDetails = new System.Windows.Forms.Button();
            this.btnSaveEmployeeDetails = new System.Windows.Forms.Button();
            this.gbxEmergencyContact = new System.Windows.Forms.GroupBox();
            this.lblEmergencyPhoneNumber = new System.Windows.Forms.Label();
            this.tbxEmergencyPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmergencyLastName = new System.Windows.Forms.TextBox();
            this.tbxEmergencyName = new System.Windows.Forms.TextBox();
            this.lblEmergencyLastName = new System.Windows.Forms.Label();
            this.lblEmergencyName = new System.Windows.Forms.Label();
            this.dgvContractHistory = new System.Windows.Forms.DataGridView();
            this.colEmpMngStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpMngTimesRenewed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewContractHistory = new System.Windows.Forms.Button();
            this.gbxPersonalInfo.SuspendLayout();
            this.gbxContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxFTEAmount)).BeginInit();
            this.gbxEmergencyContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonalInfo
            // 
            this.gbxPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPersonalInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.gbxPersonalInfo.Controls.Add(this.tbxPhoneNumber);
            this.gbxPersonalInfo.Controls.Add(this.lblPhoneNumber);
            this.gbxPersonalInfo.Controls.Add(this.tbxBSN);
            this.gbxPersonalInfo.Controls.Add(this.cmbGender);
            this.gbxPersonalInfo.Controls.Add(this.label3);
            this.gbxPersonalInfo.Controls.Add(this.lblddmmyy);
            this.gbxPersonalInfo.Controls.Add(this.tbxDateOfBirth);
            this.gbxPersonalInfo.Controls.Add(this.lblDateOfBirth);
            this.gbxPersonalInfo.Controls.Add(this.tbxEmail);
            this.gbxPersonalInfo.Controls.Add(this.tbxLastName);
            this.gbxPersonalInfo.Controls.Add(this.tbxEmployeeName);
            this.gbxPersonalInfo.Controls.Add(this.lblEmail);
            this.gbxPersonalInfo.Controls.Add(this.lblBSN);
            this.gbxPersonalInfo.Controls.Add(this.lblLastName);
            this.gbxPersonalInfo.Controls.Add(this.lblEmployeeName);
            this.gbxPersonalInfo.Location = new System.Drawing.Point(39, 1);
            this.gbxPersonalInfo.Name = "gbxPersonalInfo";
            this.gbxPersonalInfo.Size = new System.Drawing.Size(468, 364);
            this.gbxPersonalInfo.TabIndex = 0;
            this.gbxPersonalInfo.TabStop = false;
            this.gbxPersonalInfo.Text = "Personal Information";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(189, 305);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(202, 27);
            this.tbxPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 308);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(116, 20);
            this.lblPhoneNumber.TabIndex = 48;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(189, 209);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(202, 27);
            this.tbxBSN.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(189, 120);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(202, 28);
            this.cmbGender.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Gender:";
            // 
            // lblddmmyy
            // 
            this.lblddmmyy.AutoSize = true;
            this.lblddmmyy.Location = new System.Drawing.Point(24, 178);
            this.lblddmmyy.Name = "lblddmmyy";
            this.lblddmmyy.Size = new System.Drawing.Size(107, 20);
            this.lblddmmyy.TabIndex = 43;
            this.lblddmmyy.Text = "(dd-mm-yyyy)";
            // 
            // tbxDateOfBirth
            // 
            this.tbxDateOfBirth.Location = new System.Drawing.Point(189, 165);
            this.tbxDateOfBirth.Name = "tbxDateOfBirth";
            this.tbxDateOfBirth.Size = new System.Drawing.Size(202, 27);
            this.tbxDateOfBirth.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(25, 162);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(104, 20);
            this.lblDateOfBirth.TabIndex = 41;
            this.lblDateOfBirth.Text = "Date of Birth: ";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(189, 253);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(202, 27);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(189, 76);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(202, 27);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(189, 32);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(202, 27);
            this.tbxEmployeeName.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Location = new System.Drawing.Point(25, 216);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(101, 20);
            this.lblBSN.TabIndex = 7;
            this.lblBSN.Text = "BSN number:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(25, 33);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(54, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Name:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(212, 42);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(202, 28);
            this.cmbPosition.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(16, 42);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 20);
            this.lblPosition.TabIndex = 42;
            this.lblPosition.Text = "Position:";
            // 
            // tbxHourlyWage
            // 
            this.tbxHourlyWage.Location = new System.Drawing.Point(212, 158);
            this.tbxHourlyWage.Name = "tbxHourlyWage";
            this.tbxHourlyWage.Size = new System.Drawing.Size(67, 27);
            this.tbxHourlyWage.TabIndex = 3;
            // 
            // cmbEmployeeDepartment
            // 
            this.cmbEmployeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeDepartment.FormattingEnabled = true;
            this.cmbEmployeeDepartment.Location = new System.Drawing.Point(212, 80);
            this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
            this.cmbEmployeeDepartment.Size = new System.Drawing.Size(202, 28);
            this.cmbEmployeeDepartment.TabIndex = 1;
            // 
            // lblFTEAmount
            // 
            this.lblFTEAmount.AutoSize = true;
            this.lblFTEAmount.Location = new System.Drawing.Point(16, 121);
            this.lblFTEAmount.Name = "lblFTEAmount";
            this.lblFTEAmount.Size = new System.Drawing.Size(96, 20);
            this.lblFTEAmount.TabIndex = 6;
            this.lblFTEAmount.Text = "FTE Amount:";
            // 
            // lblEmployeeDepartment
            // 
            this.lblEmployeeDepartment.AutoSize = true;
            this.lblEmployeeDepartment.Location = new System.Drawing.Point(16, 81);
            this.lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            this.lblEmployeeDepartment.Size = new System.Drawing.Size(95, 20);
            this.lblEmployeeDepartment.TabIndex = 4;
            this.lblEmployeeDepartment.Text = "Department:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(16, 156);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(100, 20);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Hourly wage:";
            // 
            // gbxContractInfo
            // 
            this.gbxContractInfo.Controls.Add(this.label1);
            this.gbxContractInfo.Controls.Add(this.cmbContractType);
            this.gbxContractInfo.Controls.Add(this.tbxFTEAmount);
            this.gbxContractInfo.Controls.Add(this.cbxNewContract);
            this.gbxContractInfo.Controls.Add(this.lblddmmyy2);
            this.gbxContractInfo.Controls.Add(this.tbxEndDate);
            this.gbxContractInfo.Controls.Add(this.lblEndDate);
            this.gbxContractInfo.Controls.Add(this.lblddmmyy1);
            this.gbxContractInfo.Controls.Add(this.tbxStartDate);
            this.gbxContractInfo.Controls.Add(this.lblStartDate);
            this.gbxContractInfo.Controls.Add(this.tbxHourlyWage);
            this.gbxContractInfo.Controls.Add(this.cmbPosition);
            this.gbxContractInfo.Controls.Add(this.lblPosition);
            this.gbxContractInfo.Controls.Add(this.lblEmployeeDepartment);
            this.gbxContractInfo.Controls.Add(this.cmbEmployeeDepartment);
            this.gbxContractInfo.Controls.Add(this.lblSalary);
            this.gbxContractInfo.Controls.Add(this.lblFTEAmount);
            this.gbxContractInfo.Location = new System.Drawing.Point(543, -1);
            this.gbxContractInfo.Name = "gbxContractInfo";
            this.gbxContractInfo.Size = new System.Drawing.Size(595, 357);
            this.gbxContractInfo.TabIndex = 2;
            this.gbxContractInfo.TabStop = false;
            this.gbxContractInfo.Text = "Contract Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Contract Type:";
            // 
            // cmbContractType
            // 
            this.cmbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractType.FormattingEnabled = true;
            this.cmbContractType.Items.AddRange(new object[] {
            "Temporary",
            "Permanent"});
            this.cmbContractType.Location = new System.Drawing.Point(212, 192);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(202, 28);
            this.cmbContractType.TabIndex = 4;
            // 
            // tbxFTEAmount
            // 
            this.tbxFTEAmount.DecimalPlaces = 1;
            this.tbxFTEAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbxFTEAmount.Location = new System.Drawing.Point(212, 119);
            this.tbxFTEAmount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxFTEAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbxFTEAmount.Name = "tbxFTEAmount";
            this.tbxFTEAmount.Size = new System.Drawing.Size(169, 27);
            this.tbxFTEAmount.TabIndex = 2;
            this.tbxFTEAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // cbxNewContract
            // 
            this.cbxNewContract.AutoSize = true;
            this.cbxNewContract.Location = new System.Drawing.Point(212, 316);
            this.cbxNewContract.Name = "cbxNewContract";
            this.cbxNewContract.Size = new System.Drawing.Size(124, 24);
            this.cbxNewContract.TabIndex = 7;
            this.cbxNewContract.Text = "New Contract";
            this.cbxNewContract.UseVisualStyleBackColor = true;
            // 
            // lblddmmyy2
            // 
            this.lblddmmyy2.AutoSize = true;
            this.lblddmmyy2.Location = new System.Drawing.Point(16, 295);
            this.lblddmmyy2.Name = "lblddmmyy2";
            this.lblddmmyy2.Size = new System.Drawing.Size(107, 20);
            this.lblddmmyy2.TabIndex = 49;
            this.lblddmmyy2.Text = "(dd-mm-yyyy)";
            // 
            // tbxEndDate
            // 
            this.tbxEndDate.Location = new System.Drawing.Point(212, 276);
            this.tbxEndDate.Name = "tbxEndDate";
            this.tbxEndDate.Size = new System.Drawing.Size(202, 27);
            this.tbxEndDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(16, 275);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(165, 20);
            this.lblEndDate.TabIndex = 47;
            this.lblEndDate.Text = "End date (if aplicable): ";
            // 
            // lblddmmyy1
            // 
            this.lblddmmyy1.AutoSize = true;
            this.lblddmmyy1.Location = new System.Drawing.Point(16, 251);
            this.lblddmmyy1.Name = "lblddmmyy1";
            this.lblddmmyy1.Size = new System.Drawing.Size(107, 20);
            this.lblddmmyy1.TabIndex = 46;
            this.lblddmmyy1.Text = "(dd-mm-yyyy)";
            // 
            // tbxStartDate
            // 
            this.tbxStartDate.Location = new System.Drawing.Point(212, 239);
            this.tbxStartDate.Name = "tbxStartDate";
            this.tbxStartDate.Size = new System.Drawing.Size(202, 27);
            this.tbxStartDate.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(16, 231);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(85, 20);
            this.lblStartDate.TabIndex = 44;
            this.lblStartDate.Text = "Start Date: ";
            // 
            // btnCancelEmployeeDetails
            // 
            this.btnCancelEmployeeDetails.Location = new System.Drawing.Point(950, 372);
            this.btnCancelEmployeeDetails.Name = "btnCancelEmployeeDetails";
            this.btnCancelEmployeeDetails.Size = new System.Drawing.Size(106, 29);
            this.btnCancelEmployeeDetails.TabIndex = 5;
            this.btnCancelEmployeeDetails.Text = "Cancel";
            this.btnCancelEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnCancelEmployeeDetails.Click += new System.EventHandler(this.btnCancelEmployeeDetails_Click_1);
            // 
            // btnSaveEmployeeDetails
            // 
            this.btnSaveEmployeeDetails.Location = new System.Drawing.Point(815, 372);
            this.btnSaveEmployeeDetails.Name = "btnSaveEmployeeDetails";
            this.btnSaveEmployeeDetails.Size = new System.Drawing.Size(106, 29);
            this.btnSaveEmployeeDetails.TabIndex = 4;
            this.btnSaveEmployeeDetails.Text = "Save";
            this.btnSaveEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnSaveEmployeeDetails.Click += new System.EventHandler(this.btnSaveEmployeeDetails_Click);
            // 
            // gbxEmergencyContact
            // 
            this.gbxEmergencyContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEmergencyContact.BackColor = System.Drawing.SystemColors.Menu;
            this.gbxEmergencyContact.Controls.Add(this.lblEmergencyPhoneNumber);
            this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyPhoneNumber);
            this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyLastName);
            this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyName);
            this.gbxEmergencyContact.Controls.Add(this.lblEmergencyLastName);
            this.gbxEmergencyContact.Controls.Add(this.lblEmergencyName);
            this.gbxEmergencyContact.Location = new System.Drawing.Point(39, 378);
            this.gbxEmergencyContact.Name = "gbxEmergencyContact";
            this.gbxEmergencyContact.Size = new System.Drawing.Size(468, 239);
            this.gbxEmergencyContact.TabIndex = 1;
            this.gbxEmergencyContact.TabStop = false;
            this.gbxEmergencyContact.Text = "Emergency Contact";
            // 
            // lblEmergencyPhoneNumber
            // 
            this.lblEmergencyPhoneNumber.AutoSize = true;
            this.lblEmergencyPhoneNumber.Location = new System.Drawing.Point(25, 136);
            this.lblEmergencyPhoneNumber.Name = "lblEmergencyPhoneNumber";
            this.lblEmergencyPhoneNumber.Size = new System.Drawing.Size(116, 20);
            this.lblEmergencyPhoneNumber.TabIndex = 48;
            this.lblEmergencyPhoneNumber.Text = "Phone number:";
            // 
            // tbxEmergencyPhoneNumber
            // 
            this.tbxEmergencyPhoneNumber.Location = new System.Drawing.Point(189, 128);
            this.tbxEmergencyPhoneNumber.Name = "tbxEmergencyPhoneNumber";
            this.tbxEmergencyPhoneNumber.Size = new System.Drawing.Size(202, 27);
            this.tbxEmergencyPhoneNumber.TabIndex = 2;
            // 
            // tbxEmergencyLastName
            // 
            this.tbxEmergencyLastName.Location = new System.Drawing.Point(189, 79);
            this.tbxEmergencyLastName.Name = "tbxEmergencyLastName";
            this.tbxEmergencyLastName.Size = new System.Drawing.Size(202, 27);
            this.tbxEmergencyLastName.TabIndex = 1;
            // 
            // tbxEmergencyName
            // 
            this.tbxEmergencyName.Location = new System.Drawing.Point(189, 30);
            this.tbxEmergencyName.Name = "tbxEmergencyName";
            this.tbxEmergencyName.Size = new System.Drawing.Size(202, 27);
            this.tbxEmergencyName.TabIndex = 0;
            // 
            // lblEmergencyLastName
            // 
            this.lblEmergencyLastName.AutoSize = true;
            this.lblEmergencyLastName.Location = new System.Drawing.Point(25, 83);
            this.lblEmergencyLastName.Name = "lblEmergencyLastName";
            this.lblEmergencyLastName.Size = new System.Drawing.Size(81, 20);
            this.lblEmergencyLastName.TabIndex = 2;
            this.lblEmergencyLastName.Text = "Last name:";
            // 
            // lblEmergencyName
            // 
            this.lblEmergencyName.AutoSize = true;
            this.lblEmergencyName.Location = new System.Drawing.Point(25, 30);
            this.lblEmergencyName.Name = "lblEmergencyName";
            this.lblEmergencyName.Size = new System.Drawing.Size(54, 20);
            this.lblEmergencyName.TabIndex = 0;
            this.lblEmergencyName.Text = "Name:";
            // 
            // dgvContractHistory
            // 
            this.dgvContractHistory.AllowUserToAddRows = false;
            this.dgvContractHistory.AllowUserToDeleteRows = false;
            this.dgvContractHistory.AllowUserToResizeColumns = false;
            this.dgvContractHistory.AllowUserToResizeRows = false;
            this.dgvContractHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContractHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContractHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpMngStartDate,
            this.colEmpMngEndDate,
            this.colEmpMngPosition,
            this.colEmpMngDepartment,
            this.colEmpMngTimesRenewed});
            this.dgvContractHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContractHistory.GridColor = System.Drawing.Color.White;
            this.dgvContractHistory.Location = new System.Drawing.Point(543, 420);
            this.dgvContractHistory.Name = "dgvContractHistory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContractHistory.RowHeadersVisible = false;
            this.dgvContractHistory.RowHeadersWidth = 51;
            this.dgvContractHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvContractHistory.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContractHistory.RowTemplate.Height = 29;
            this.dgvContractHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractHistory.ShowEditingIcon = false;
            this.dgvContractHistory.Size = new System.Drawing.Size(595, 197);
            this.dgvContractHistory.TabIndex = 29;
            this.dgvContractHistory.Visible = false;
            // 
            // colEmpMngStartDate
            // 
            this.colEmpMngStartDate.FillWeight = 109.8248F;
            this.colEmpMngStartDate.HeaderText = "Start Date";
            this.colEmpMngStartDate.MinimumWidth = 6;
            this.colEmpMngStartDate.Name = "colEmpMngStartDate";
            // 
            // colEmpMngEndDate
            // 
            this.colEmpMngEndDate.FillWeight = 102.9154F;
            this.colEmpMngEndDate.HeaderText = "End Date";
            this.colEmpMngEndDate.MinimumWidth = 6;
            this.colEmpMngEndDate.Name = "colEmpMngEndDate";
            // 
            // colEmpMngPosition
            // 
            this.colEmpMngPosition.FillWeight = 94.41501F;
            this.colEmpMngPosition.HeaderText = "Position";
            this.colEmpMngPosition.MinimumWidth = 6;
            this.colEmpMngPosition.Name = "colEmpMngPosition";
            // 
            // colEmpMngDepartment
            // 
            this.colEmpMngDepartment.FillWeight = 83.95726F;
            this.colEmpMngDepartment.HeaderText = "Department";
            this.colEmpMngDepartment.MinimumWidth = 6;
            this.colEmpMngDepartment.Name = "colEmpMngDepartment";
            // 
            // colEmpMngTimesRenewed
            // 
            this.colEmpMngTimesRenewed.FillWeight = 57.4591F;
            this.colEmpMngTimesRenewed.HeaderText = "Times Renewed";
            this.colEmpMngTimesRenewed.MinimumWidth = 6;
            this.colEmpMngTimesRenewed.Name = "colEmpMngTimesRenewed";
            this.colEmpMngTimesRenewed.Visible = false;
            // 
            // btnViewContractHistory
            // 
            this.btnViewContractHistory.Location = new System.Drawing.Point(656, 372);
            this.btnViewContractHistory.Name = "btnViewContractHistory";
            this.btnViewContractHistory.Size = new System.Drawing.Size(130, 29);
            this.btnViewContractHistory.TabIndex = 3;
            this.btnViewContractHistory.Text = "Contract History";
            this.btnViewContractHistory.UseVisualStyleBackColor = true;
            this.btnViewContractHistory.Click += new System.EventHandler(this.btnViewContractHistory_Click);
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 629);
            this.Controls.Add(this.btnViewContractHistory);
            this.Controls.Add(this.dgvContractHistory);
            this.Controls.Add(this.btnCancelEmployeeDetails);
            this.Controls.Add(this.btnSaveEmployeeDetails);
            this.Controls.Add(this.gbxEmergencyContact);
            this.Controls.Add(this.gbxContractInfo);
            this.Controls.Add(this.gbxPersonalInfo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormEmployeeManagement";
            this.Text = "Employee Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeeManagement_FormClosed);
            this.gbxPersonalInfo.ResumeLayout(false);
            this.gbxPersonalInfo.PerformLayout();
            this.gbxContractInfo.ResumeLayout(false);
            this.gbxContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxFTEAmount)).EndInit();
            this.gbxEmergencyContact.ResumeLayout(false);
            this.gbxEmergencyContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonalInfo;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbxHourlyWage;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.Label lblFTEAmount;
        private System.Windows.Forms.Label lblEmployeeDepartment;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxBSN;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblddmmyy;
        private System.Windows.Forms.TextBox tbxDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.GroupBox gbxContractInfo;
        private System.Windows.Forms.Button btnCancelEmployeeDetails;
        private System.Windows.Forms.Button btnSaveEmployeeDetails;
        private System.Windows.Forms.GroupBox gbxEmergencyContact;
        private System.Windows.Forms.Label lblEmergencyPhoneNumber;
        private System.Windows.Forms.TextBox tbxEmergencyPhoneNumber;
        private System.Windows.Forms.TextBox tbxEmergencyLastName;
        private System.Windows.Forms.TextBox tbxEmergencyName;
        private System.Windows.Forms.Label lblEmergencyLastName;
        private System.Windows.Forms.Label lblEmergencyName;
        private System.Windows.Forms.Label lblddmmyy2;
        private System.Windows.Forms.TextBox tbxEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblddmmyy1;
        private System.Windows.Forms.TextBox tbxStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.NumericUpDown tbxFTEAmount;
        private System.Windows.Forms.CheckBox cbxNewContract;
        private System.Windows.Forms.DataGridView dgvContractHistory;
        private System.Windows.Forms.Button btnViewContractHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpMngStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpMngEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpMngPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpMngDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpMngTimesRenewed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbContractType;
    }
    //partial class FormEmployeeManagement
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    /// Required method for Designer support - do not modify
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeManagement));
    //        this.gbxPersonalInfo = new System.Windows.Forms.GroupBox();
    //        this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
    //        this.lblPhoneNumber = new System.Windows.Forms.Label();
    //        this.tbxBSN = new System.Windows.Forms.TextBox();
    //        this.cmbGender = new System.Windows.Forms.ComboBox();
    //        this.label3 = new System.Windows.Forms.Label();
    //        this.lblddmmyy = new System.Windows.Forms.Label();
    //        this.tbxDateOfBirth = new System.Windows.Forms.TextBox();
    //        this.lblDateOfBirth = new System.Windows.Forms.Label();
    //        this.tbxEmail = new System.Windows.Forms.TextBox();
    //        this.tbxLastName = new System.Windows.Forms.TextBox();
    //        this.tbxEmployeeName = new System.Windows.Forms.TextBox();
    //        this.lblEmail = new System.Windows.Forms.Label();
    //        this.lblBSN = new System.Windows.Forms.Label();
    //        this.lblLastName = new System.Windows.Forms.Label();
    //        this.lblEmployeeName = new System.Windows.Forms.Label();
    //        this.cmbPosition = new System.Windows.Forms.ComboBox();
    //        this.lblPosition = new System.Windows.Forms.Label();
    //        this.tbxHourlyWage = new System.Windows.Forms.TextBox();
    //        this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
    //        this.lblFTEAmount = new System.Windows.Forms.Label();
    //        this.lblEmployeeDepartment = new System.Windows.Forms.Label();
    //        this.lblSalary = new System.Windows.Forms.Label();
    //        this.gbxContractInfo = new System.Windows.Forms.GroupBox();
    //        this.tbxFTEAmount = new System.Windows.Forms.NumericUpDown();
    //        this.lblddmmyy2 = new System.Windows.Forms.Label();
    //        this.tbxEndDate = new System.Windows.Forms.TextBox();
    //        this.lblEndDate = new System.Windows.Forms.Label();
    //        this.lblddmmyy1 = new System.Windows.Forms.Label();
    //        this.tbxStartDate = new System.Windows.Forms.TextBox();
    //        this.lblStartDate = new System.Windows.Forms.Label();
    //        this.btnCancelEmployeeDetails = new System.Windows.Forms.Button();
    //        this.btnSaveEmployeeDetails = new System.Windows.Forms.Button();
    //        this.gbxEmergencyContact = new System.Windows.Forms.GroupBox();
    //        this.lblEmergencyPhoneNumber = new System.Windows.Forms.Label();
    //        this.tbxEmergencyPhoneNumber = new System.Windows.Forms.TextBox();
    //        this.tbxEmergencyLastName = new System.Windows.Forms.TextBox();
    //        this.tbxEmergencyName = new System.Windows.Forms.TextBox();
    //        this.lblEmergencyLastName = new System.Windows.Forms.Label();
    //        this.lblEmergencyName = new System.Windows.Forms.Label();
    //        this.pbMediaBazaarLogo = new System.Windows.Forms.PictureBox();
    //        this.gbxPersonalInfo.SuspendLayout();
    //        this.gbxContractInfo.SuspendLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.tbxFTEAmount)).BeginInit();
    //        this.gbxEmergencyContact.SuspendLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pbMediaBazaarLogo)).BeginInit();
    //        this.SuspendLayout();
    //        // 
    //        // gbxPersonalInfo
    //        // 
    //        this.gbxPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    //        | System.Windows.Forms.AnchorStyles.Left) 
    //        | System.Windows.Forms.AnchorStyles.Right)));
    //        this.gbxPersonalInfo.BackColor = System.Drawing.SystemColors.Menu;
    //        this.gbxPersonalInfo.Controls.Add(this.tbxPhoneNumber);
    //        this.gbxPersonalInfo.Controls.Add(this.lblPhoneNumber);
    //        this.gbxPersonalInfo.Controls.Add(this.tbxBSN);
    //        this.gbxPersonalInfo.Controls.Add(this.cmbGender);
    //        this.gbxPersonalInfo.Controls.Add(this.label3);
    //        this.gbxPersonalInfo.Controls.Add(this.lblddmmyy);
    //        this.gbxPersonalInfo.Controls.Add(this.tbxDateOfBirth);
    //        this.gbxPersonalInfo.Controls.Add(this.lblDateOfBirth);
    //        this.gbxPersonalInfo.Controls.Add(this.tbxEmail);
    //        this.gbxPersonalInfo.Controls.Add(this.tbxLastName);
    //        this.gbxPersonalInfo.Controls.Add(this.tbxEmployeeName);
    //        this.gbxPersonalInfo.Controls.Add(this.lblEmail);
    //        this.gbxPersonalInfo.Controls.Add(this.lblBSN);
    //        this.gbxPersonalInfo.Controls.Add(this.lblLastName);
    //        this.gbxPersonalInfo.Controls.Add(this.lblEmployeeName);
    //        this.gbxPersonalInfo.Location = new System.Drawing.Point(39, 1);
    //        this.gbxPersonalInfo.Name = "gbxPersonalInfo";
    //        this.gbxPersonalInfo.Size = new System.Drawing.Size(655, 364);
    //        this.gbxPersonalInfo.TabIndex = 36;
    //        this.gbxPersonalInfo.TabStop = false;
    //        this.gbxPersonalInfo.Text = "Personal Information";
    //        // 
    //        // tbxPhoneNumber
    //        // 
    //        this.tbxPhoneNumber.Location = new System.Drawing.Point(189, 305);
    //        this.tbxPhoneNumber.Name = "tbxPhoneNumber";
    //        this.tbxPhoneNumber.Size = new System.Drawing.Size(202, 27);
    //        this.tbxPhoneNumber.TabIndex = 49;
    //        // 
    //        // lblPhoneNumber
    //        // 
    //        this.lblPhoneNumber.AutoSize = true;
    //        this.lblPhoneNumber.Location = new System.Drawing.Point(25, 308);
    //        this.lblPhoneNumber.Name = "lblPhoneNumber";
    //        this.lblPhoneNumber.Size = new System.Drawing.Size(116, 20);
    //        this.lblPhoneNumber.TabIndex = 48;
    //        this.lblPhoneNumber.Text = "Phone number:";
    //        // 
    //        // tbxBSN
    //        // 
    //        this.tbxBSN.Location = new System.Drawing.Point(189, 209);
    //        this.tbxBSN.Name = "tbxBSN";
    //        this.tbxBSN.Size = new System.Drawing.Size(202, 27);
    //        this.tbxBSN.TabIndex = 47;
    //        // 
    //        // cmbGender
    //        // 
    //        this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    //        this.cmbGender.FormattingEnabled = true;
    //        this.cmbGender.Location = new System.Drawing.Point(189, 120);
    //        this.cmbGender.Name = "cmbGender";
    //        this.cmbGender.Size = new System.Drawing.Size(202, 28);
    //        this.cmbGender.TabIndex = 45;
    //        // 
    //        // label3
    //        // 
    //        this.label3.AutoSize = true;
    //        this.label3.Location = new System.Drawing.Point(25, 124);
    //        this.label3.Name = "label3";
    //        this.label3.Size = new System.Drawing.Size(64, 20);
    //        this.label3.TabIndex = 44;
    //        this.label3.Text = "Gender:";
    //        // 
    //        // lblddmmyy
    //        // 
    //        this.lblddmmyy.AutoSize = true;
    //        this.lblddmmyy.Location = new System.Drawing.Point(24, 178);
    //        this.lblddmmyy.Name = "lblddmmyy";
    //        this.lblddmmyy.Size = new System.Drawing.Size(107, 20);
    //        this.lblddmmyy.TabIndex = 43;
    //        this.lblddmmyy.Text = "(dd-mm-yyyy)";
    //        // 
    //        // tbxDateOfBirth
    //        // 
    //        this.tbxDateOfBirth.Location = new System.Drawing.Point(189, 165);
    //        this.tbxDateOfBirth.Name = "tbxDateOfBirth";
    //        this.tbxDateOfBirth.Size = new System.Drawing.Size(202, 27);
    //        this.tbxDateOfBirth.TabIndex = 42;
    //        // 
    //        // lblDateOfBirth
    //        // 
    //        this.lblDateOfBirth.AutoSize = true;
    //        this.lblDateOfBirth.Location = new System.Drawing.Point(25, 162);
    //        this.lblDateOfBirth.Name = "lblDateOfBirth";
    //        this.lblDateOfBirth.Size = new System.Drawing.Size(104, 20);
    //        this.lblDateOfBirth.TabIndex = 41;
    //        this.lblDateOfBirth.Text = "Date of Birth: ";
    //        // 
    //        // tbxEmail
    //        // 
    //        this.tbxEmail.Location = new System.Drawing.Point(189, 253);
    //        this.tbxEmail.Name = "tbxEmail";
    //        this.tbxEmail.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEmail.TabIndex = 39;
    //        // 
    //        // tbxLastName
    //        // 
    //        this.tbxLastName.Location = new System.Drawing.Point(189, 76);
    //        this.tbxLastName.Name = "tbxLastName";
    //        this.tbxLastName.Size = new System.Drawing.Size(202, 27);
    //        this.tbxLastName.TabIndex = 33;
    //        // 
    //        // tbxEmployeeName
    //        // 
    //        this.tbxEmployeeName.Location = new System.Drawing.Point(189, 32);
    //        this.tbxEmployeeName.Name = "tbxEmployeeName";
    //        this.tbxEmployeeName.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEmployeeName.TabIndex = 31;
    //        // 
    //        // lblEmail
    //        // 
    //        this.lblEmail.AutoSize = true;
    //        this.lblEmail.Location = new System.Drawing.Point(25, 262);
    //        this.lblEmail.Name = "lblEmail";
    //        this.lblEmail.Size = new System.Drawing.Size(50, 20);
    //        this.lblEmail.TabIndex = 8;
    //        this.lblEmail.Text = "Email:";
    //        // 
    //        // lblBSN
    //        // 
    //        this.lblBSN.AutoSize = true;
    //        this.lblBSN.Location = new System.Drawing.Point(25, 216);
    //        this.lblBSN.Name = "lblBSN";
    //        this.lblBSN.Size = new System.Drawing.Size(101, 20);
    //        this.lblBSN.TabIndex = 7;
    //        this.lblBSN.Text = "BSN number:";
    //        // 
    //        // lblLastName
    //        // 
    //        this.lblLastName.AutoSize = true;
    //        this.lblLastName.Location = new System.Drawing.Point(25, 78);
    //        this.lblLastName.Name = "lblLastName";
    //        this.lblLastName.Size = new System.Drawing.Size(81, 20);
    //        this.lblLastName.TabIndex = 2;
    //        this.lblLastName.Text = "Last name:";
    //        // 
    //        // lblEmployeeName
    //        // 
    //        this.lblEmployeeName.AutoSize = true;
    //        this.lblEmployeeName.Location = new System.Drawing.Point(25, 33);
    //        this.lblEmployeeName.Name = "lblEmployeeName";
    //        this.lblEmployeeName.Size = new System.Drawing.Size(54, 20);
    //        this.lblEmployeeName.TabIndex = 0;
    //        this.lblEmployeeName.Text = "Name:";
    //        // 
    //        // cmbPosition
    //        // 
    //        this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    //        this.cmbPosition.FormattingEnabled = true;
    //        this.cmbPosition.Location = new System.Drawing.Point(212, 42);
    //        this.cmbPosition.Name = "cmbPosition";
    //        this.cmbPosition.Size = new System.Drawing.Size(202, 28);
    //        this.cmbPosition.TabIndex = 43;
    //        // 
    //        // lblPosition
    //        // 
    //        this.lblPosition.AutoSize = true;
    //        this.lblPosition.Location = new System.Drawing.Point(16, 42);
    //        this.lblPosition.Name = "lblPosition";
    //        this.lblPosition.Size = new System.Drawing.Size(67, 20);
    //        this.lblPosition.TabIndex = 42;
    //        this.lblPosition.Text = "Position:";
    //        // 
    //        // tbxHourlyWage
    //        // 
    //        this.tbxHourlyWage.Location = new System.Drawing.Point(212, 182);
    //        this.tbxHourlyWage.Name = "tbxHourlyWage";
    //        this.tbxHourlyWage.Size = new System.Drawing.Size(67, 27);
    //        this.tbxHourlyWage.TabIndex = 41;
    //        // 
    //        // cmbEmployeeDepartment
    //        // 
    //        this.cmbEmployeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    //        this.cmbEmployeeDepartment.FormattingEnabled = true;
    //        this.cmbEmployeeDepartment.Location = new System.Drawing.Point(212, 86);
    //        this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
    //        this.cmbEmployeeDepartment.Size = new System.Drawing.Size(202, 28);
    //        this.cmbEmployeeDepartment.TabIndex = 35;
    //        // 
    //        // lblFTEAmount
    //        // 
    //        this.lblFTEAmount.AutoSize = true;
    //        this.lblFTEAmount.Location = new System.Drawing.Point(16, 135);
    //        this.lblFTEAmount.Name = "lblFTEAmount";
    //        this.lblFTEAmount.Size = new System.Drawing.Size(96, 20);
    //        this.lblFTEAmount.TabIndex = 6;
    //        this.lblFTEAmount.Text = "FTE Amount:";
    //        // 
    //        // lblEmployeeDepartment
    //        // 
    //        this.lblEmployeeDepartment.AutoSize = true;
    //        this.lblEmployeeDepartment.Location = new System.Drawing.Point(16, 87);
    //        this.lblEmployeeDepartment.Name = "lblEmployeeDepartment";
    //        this.lblEmployeeDepartment.Size = new System.Drawing.Size(95, 20);
    //        this.lblEmployeeDepartment.TabIndex = 4;
    //        this.lblEmployeeDepartment.Text = "Department:";
    //        // 
    //        // lblSalary
    //        // 
    //        this.lblSalary.AutoSize = true;
    //        this.lblSalary.Location = new System.Drawing.Point(16, 180);
    //        this.lblSalary.Name = "lblSalary";
    //        this.lblSalary.Size = new System.Drawing.Size(100, 20);
    //        this.lblSalary.TabIndex = 3;
    //        this.lblSalary.Text = "Hourly wage:";
    //        // 
    //        // gbxContractInfo
    //        // 
    //        this.gbxContractInfo.Controls.Add(this.tbxFTEAmount);
    //        this.gbxContractInfo.Controls.Add(this.lblddmmyy2);
    //        this.gbxContractInfo.Controls.Add(this.tbxEndDate);
    //        this.gbxContractInfo.Controls.Add(this.lblEndDate);
    //        this.gbxContractInfo.Controls.Add(this.lblddmmyy1);
    //        this.gbxContractInfo.Controls.Add(this.tbxStartDate);
    //        this.gbxContractInfo.Controls.Add(this.lblStartDate);
    //        this.gbxContractInfo.Controls.Add(this.tbxHourlyWage);
    //        this.gbxContractInfo.Controls.Add(this.cmbPosition);
    //        this.gbxContractInfo.Controls.Add(this.lblPosition);
    //        this.gbxContractInfo.Controls.Add(this.lblEmployeeDepartment);
    //        this.gbxContractInfo.Controls.Add(this.cmbEmployeeDepartment);
    //        this.gbxContractInfo.Controls.Add(this.lblSalary);
    //        this.gbxContractInfo.Controls.Add(this.lblFTEAmount);
    //        this.gbxContractInfo.Location = new System.Drawing.Point(703, -1);
    //        this.gbxContractInfo.Name = "gbxContractInfo";
    //        this.gbxContractInfo.Size = new System.Drawing.Size(435, 344);
    //        this.gbxContractInfo.TabIndex = 44;
    //        this.gbxContractInfo.TabStop = false;
    //        this.gbxContractInfo.Text = "Contract Information";
    //        // 
    //        // tbxFTEAmount
    //        // 
    //        this.tbxFTEAmount.Increment = new decimal(new int[] {
    //        1,
    //        0,
    //        0,
    //        65536});
    //        this.tbxFTEAmount.Location = new System.Drawing.Point(212, 133);
    //        this.tbxFTEAmount.Maximum = new decimal(new int[] {
    //        1,
    //        0,
    //        0,
    //        0});
    //        this.tbxFTEAmount.Name = "tbxFTEAmount";
    //        this.tbxFTEAmount.Size = new System.Drawing.Size(169, 27);
    //        this.tbxFTEAmount.TabIndex = 50;
    //        // 
    //        // lblddmmyy2
    //        // 
    //        this.lblddmmyy2.AutoSize = true;
    //        this.lblddmmyy2.Location = new System.Drawing.Point(45, 291);
    //        this.lblddmmyy2.Name = "lblddmmyy2";
    //        this.lblddmmyy2.Size = new System.Drawing.Size(107, 20);
    //        this.lblddmmyy2.TabIndex = 49;
    //        this.lblddmmyy2.Text = "(dd-mm-yyyy)";
    //        // 
    //        // tbxEndDate
    //        // 
    //        this.tbxEndDate.Location = new System.Drawing.Point(212, 268);
    //        this.tbxEndDate.Name = "tbxEndDate";
    //        this.tbxEndDate.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEndDate.TabIndex = 48;
    //        // 
    //        // lblEndDate
    //        // 
    //        this.lblEndDate.AutoSize = true;
    //        this.lblEndDate.Location = new System.Drawing.Point(16, 270);
    //        this.lblEndDate.Name = "lblEndDate";
    //        this.lblEndDate.Size = new System.Drawing.Size(165, 20);
    //        this.lblEndDate.TabIndex = 47;
    //        this.lblEndDate.Text = "End date (if aplicable): ";
    //        // 
    //        // lblddmmyy1
    //        // 
    //        this.lblddmmyy1.AutoSize = true;
    //        this.lblddmmyy1.Location = new System.Drawing.Point(5, 239);
    //        this.lblddmmyy1.Name = "lblddmmyy1";
    //        this.lblddmmyy1.Size = new System.Drawing.Size(107, 20);
    //        this.lblddmmyy1.TabIndex = 46;
    //        this.lblddmmyy1.Text = "(dd-mm-yyyy)";
    //        // 
    //        // tbxStartDate
    //        // 
    //        this.tbxStartDate.Location = new System.Drawing.Point(212, 225);
    //        this.tbxStartDate.Name = "tbxStartDate";
    //        this.tbxStartDate.Size = new System.Drawing.Size(202, 27);
    //        this.tbxStartDate.TabIndex = 45;
    //        // 
    //        // lblStartDate
    //        // 
    //        this.lblStartDate.AutoSize = true;
    //        this.lblStartDate.Location = new System.Drawing.Point(16, 220);
    //        this.lblStartDate.Name = "lblStartDate";
    //        this.lblStartDate.Size = new System.Drawing.Size(85, 20);
    //        this.lblStartDate.TabIndex = 44;
    //        this.lblStartDate.Text = "Start Date: ";
    //        // 
    //        // btnCancelEmployeeDetails
    //        // 
    //        this.btnCancelEmployeeDetails.Location = new System.Drawing.Point(968, 404);
    //        this.btnCancelEmployeeDetails.Name = "btnCancelEmployeeDetails";
    //        this.btnCancelEmployeeDetails.Size = new System.Drawing.Size(106, 29);
    //        this.btnCancelEmployeeDetails.TabIndex = 46;
    //        this.btnCancelEmployeeDetails.Text = "Cancel";
    //        this.btnCancelEmployeeDetails.UseVisualStyleBackColor = true;
    //        this.btnCancelEmployeeDetails.Click += new System.EventHandler(this.btnCancelEmployeeDetails_Click_1);
    //        // 
    //        // btnSaveEmployeeDetails
    //        // 
    //        this.btnSaveEmployeeDetails.Location = new System.Drawing.Point(738, 404);
    //        this.btnSaveEmployeeDetails.Name = "btnSaveEmployeeDetails";
    //        this.btnSaveEmployeeDetails.Size = new System.Drawing.Size(106, 29);
    //        this.btnSaveEmployeeDetails.TabIndex = 45;
    //        this.btnSaveEmployeeDetails.Text = "Save";
    //        this.btnSaveEmployeeDetails.UseVisualStyleBackColor = true;
    //        this.btnSaveEmployeeDetails.Click += new System.EventHandler(this.btnSaveEmployeeDetails_Click);
    //        // 
    //        // gbxEmergencyContact
    //        // 
    //        this.gbxEmergencyContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    //        | System.Windows.Forms.AnchorStyles.Left) 
    //        | System.Windows.Forms.AnchorStyles.Right)));
    //        this.gbxEmergencyContact.BackColor = System.Drawing.SystemColors.Menu;
    //        this.gbxEmergencyContact.Controls.Add(this.lblEmergencyPhoneNumber);
    //        this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyPhoneNumber);
    //        this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyLastName);
    //        this.gbxEmergencyContact.Controls.Add(this.tbxEmergencyName);
    //        this.gbxEmergencyContact.Controls.Add(this.lblEmergencyLastName);
    //        this.gbxEmergencyContact.Controls.Add(this.lblEmergencyName);
    //        this.gbxEmergencyContact.Location = new System.Drawing.Point(39, 378);
    //        this.gbxEmergencyContact.Name = "gbxEmergencyContact";
    //        this.gbxEmergencyContact.Size = new System.Drawing.Size(655, 188);
    //        this.gbxEmergencyContact.TabIndex = 48;
    //        this.gbxEmergencyContact.TabStop = false;
    //        this.gbxEmergencyContact.Text = "Emergency Contact";
    //        // 
    //        // lblEmergencyPhoneNumber
    //        // 
    //        this.lblEmergencyPhoneNumber.AutoSize = true;
    //        this.lblEmergencyPhoneNumber.Location = new System.Drawing.Point(25, 136);
    //        this.lblEmergencyPhoneNumber.Name = "lblEmergencyPhoneNumber";
    //        this.lblEmergencyPhoneNumber.Size = new System.Drawing.Size(116, 20);
    //        this.lblEmergencyPhoneNumber.TabIndex = 48;
    //        this.lblEmergencyPhoneNumber.Text = "Phone number:";
    //        // 
    //        // tbxEmergencyPhoneNumber
    //        // 
    //        this.tbxEmergencyPhoneNumber.Location = new System.Drawing.Point(189, 128);
    //        this.tbxEmergencyPhoneNumber.Name = "tbxEmergencyPhoneNumber";
    //        this.tbxEmergencyPhoneNumber.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEmergencyPhoneNumber.TabIndex = 47;
    //        // 
    //        // tbxEmergencyLastName
    //        // 
    //        this.tbxEmergencyLastName.Location = new System.Drawing.Point(189, 79);
    //        this.tbxEmergencyLastName.Name = "tbxEmergencyLastName";
    //        this.tbxEmergencyLastName.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEmergencyLastName.TabIndex = 33;
    //        // 
    //        // tbxEmergencyName
    //        // 
    //        this.tbxEmergencyName.Location = new System.Drawing.Point(189, 30);
    //        this.tbxEmergencyName.Name = "tbxEmergencyName";
    //        this.tbxEmergencyName.Size = new System.Drawing.Size(202, 27);
    //        this.tbxEmergencyName.TabIndex = 31;
    //        // 
    //        // lblEmergencyLastName
    //        // 
    //        this.lblEmergencyLastName.AutoSize = true;
    //        this.lblEmergencyLastName.Location = new System.Drawing.Point(25, 83);
    //        this.lblEmergencyLastName.Name = "lblEmergencyLastName";
    //        this.lblEmergencyLastName.Size = new System.Drawing.Size(81, 20);
    //        this.lblEmergencyLastName.TabIndex = 2;
    //        this.lblEmergencyLastName.Text = "Last name:";
    //        // 
    //        // lblEmergencyName
    //        // 
    //        this.lblEmergencyName.AutoSize = true;
    //        this.lblEmergencyName.Location = new System.Drawing.Point(25, 30);
    //        this.lblEmergencyName.Name = "lblEmergencyName";
    //        this.lblEmergencyName.Size = new System.Drawing.Size(54, 20);
    //        this.lblEmergencyName.TabIndex = 0;
    //        this.lblEmergencyName.Text = "Name:";
    //        // 
    //        // pbMediaBazaarLogo
    //        // 
    //        this.pbMediaBazaarLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMediaBazaarLogo.Image")));
    //        this.pbMediaBazaarLogo.Location = new System.Drawing.Point(1145, 1);
    //        this.pbMediaBazaarLogo.Name = "pbMediaBazaarLogo";
    //        this.pbMediaBazaarLogo.Size = new System.Drawing.Size(124, 98);
    //        this.pbMediaBazaarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    //        this.pbMediaBazaarLogo.TabIndex = 49;
    //        this.pbMediaBazaarLogo.TabStop = false;
    //        // 
    //        // FormEmployeeManagement
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(1269, 578);
    //        this.Controls.Add(this.pbMediaBazaarLogo);
    //        this.Controls.Add(this.gbxEmergencyContact);
    //        this.Controls.Add(this.btnCancelEmployeeDetails);
    //        this.Controls.Add(this.btnSaveEmployeeDetails);
    //        this.Controls.Add(this.gbxContractInfo);
    //        this.Controls.Add(this.gbxPersonalInfo);
    //        this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
    //        this.Name = "FormEmployeeManagement";
    //        this.Text = "Employee Details";
    //        this.gbxPersonalInfo.ResumeLayout(false);
    //        this.gbxPersonalInfo.PerformLayout();
    //        this.gbxContractInfo.ResumeLayout(false);
    //        this.gbxContractInfo.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.tbxFTEAmount)).EndInit();
    //        this.gbxEmergencyContact.ResumeLayout(false);
    //        this.gbxEmergencyContact.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pbMediaBazaarLogo)).EndInit();
    //        this.ResumeLayout(false);

    //    }

    //    #endregion

    //    private System.Windows.Forms.GroupBox gbxPersonalInfo;
    //    private System.Windows.Forms.ComboBox cmbPosition;
    //    private System.Windows.Forms.Label lblPosition;
    //    private System.Windows.Forms.TextBox tbxHourlyWage;
    //    private System.Windows.Forms.TextBox tbxEmail;
    //    private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
    //    private System.Windows.Forms.TextBox tbxLastName;
    //    private System.Windows.Forms.TextBox tbxEmployeeName;
    //    private System.Windows.Forms.Label lblEmail;
    //    private System.Windows.Forms.Label lblBSN;
    //    private System.Windows.Forms.Label lblFTEAmount;
    //    private System.Windows.Forms.Label lblEmployeeDepartment;
    //    private System.Windows.Forms.Label lblSalary;
    //    private System.Windows.Forms.Label lblLastName;
    //    private System.Windows.Forms.Label lblEmployeeName;
    //    private System.Windows.Forms.Label lblPhoneNumber;
    //    private System.Windows.Forms.TextBox tbxBSN;
    //    private System.Windows.Forms.ComboBox cmbGender;
    //    private System.Windows.Forms.Label label3;
    //    private System.Windows.Forms.Label lblddmmyy;
    //    private System.Windows.Forms.TextBox tbxDateOfBirth;
    //    private System.Windows.Forms.Label lblDateOfBirth;
    //    private System.Windows.Forms.GroupBox gbxContractInfo;
    //    private System.Windows.Forms.Button btnCancelEmployeeDetails;
    //    private System.Windows.Forms.Button btnSaveEmployeeDetails;
    //    private System.Windows.Forms.GroupBox gbxEmergencyContact;
    //    private System.Windows.Forms.Label lblEmergencyPhoneNumber;
    //    private System.Windows.Forms.TextBox tbxEmergencyPhoneNumber;
    //    private System.Windows.Forms.TextBox tbxEmergencyLastName;
    //    private System.Windows.Forms.TextBox tbxEmergencyName;
    //    private System.Windows.Forms.Label lblEmergencyLastName;
    //    private System.Windows.Forms.Label lblEmergencyName;
    //    private System.Windows.Forms.Label lblddmmyy2;
    //    private System.Windows.Forms.TextBox tbxEndDate;
    //    private System.Windows.Forms.Label lblEndDate;
    //    private System.Windows.Forms.Label lblddmmyy1;
    //    private System.Windows.Forms.TextBox tbxStartDate;
    //    private System.Windows.Forms.Label lblStartDate;
    //    private System.Windows.Forms.TextBox tbxPhoneNumber;
    //    private System.Windows.Forms.NumericUpDown tbxFTEAmount;
    //    private System.Windows.Forms.PictureBox pbMediaBazaarLogo;
    //}
}