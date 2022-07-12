using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Media_Bazaar
{
    public partial class FormEmployeeManagement : Form
    {
        EmployeeAdmin mediaBazarEmployees;
        Form1 f1;
        ContractAdmin contractAdmin = new ContractAdmin();

        public FormEmployeeManagement(Form1 form, EmployeeAdmin mediaBazarEmployees)
        {
            InitializeComponent();
            PopulateEmployeeManagementComboBoxes();
            this.f1 = form;

            this.mediaBazarEmployees = mediaBazarEmployees;

        }


        // populates the form fields with values from employee
        public void SetValuesOnForm(string name, string lastName, Gender gender, string dateOfBirth, string bsnNumber, string email, string phoneNumber, string emergencyName,
                                    string emergencyLastName, string emergencyPhoneNumber, Position position, string department, double fte, double hourlyWage, string startDate, string endDate, string contractType)
        {

            tbxEmployeeName.Text = name;
            tbxLastName.Text = lastName;
            cmbGender.SelectedItem = gender;
            tbxDateOfBirth.Text = dateOfBirth;
            tbxBSN.Text = bsnNumber;
            tbxEmail.Text = email;
            tbxPhoneNumber.Text = phoneNumber;
            tbxEmergencyName.Text = emergencyName;
            tbxEmergencyLastName.Text = emergencyLastName;
            tbxEmergencyPhoneNumber.Text = emergencyPhoneNumber;
            cmbPosition.SelectedItem = position;
            cmbEmployeeDepartment.SelectedItem = department;
            tbxFTEAmount.Value = Convert.ToDecimal(fte);
            tbxHourlyWage.Text = hourlyWage.ToString();
            tbxStartDate.Text = startDate;
            tbxEndDate.Text = endDate;
            cmbContractType.SelectedItem = contractType;


        }
        //clear the fields in the employee_Management form
        private void ClearEmployeeDetailsTextBoxes()
        {
            tbxEmployeeName.Clear();
            tbxLastName.Clear();
            cmbGender.SelectedIndex = -1;
            tbxDateOfBirth.Clear();
            tbxBSN.Clear();
            tbxEmail.Clear();
            tbxPhoneNumber.Clear();
            tbxEmergencyName.Clear();
            tbxEmergencyLastName.Clear();
            tbxEmergencyPhoneNumber.Clear();
            cmbPosition.SelectedIndex = -1;
            cmbEmployeeDepartment.SelectedIndex = -1;
            tbxFTEAmount.Value = 1;
            tbxHourlyWage.Clear();
            tbxStartDate.Clear();
            tbxEndDate.Clear();

        }
        // adds all the positions en enum Position, the departments and Gender types to the combobox in the form on Employee Management Tab
        private void PopulateEmployeeManagementComboBoxes()
        {
            
            foreach (var item in Enum.GetValues(typeof(Position)))
            {
                cmbPosition.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cmbGender.Items.Add(item);
            }

            // Gets enum description (Departments have two words) and populates Department cmb with description instead of values
            foreach (Department department in Enum.GetValues(typeof(Department)))
            {
                cmbEmployeeDepartment.Items.Add(department.GetEnumDescription());
            }
        }
        //makes employees fields in the combobox read only
        public void MakeEmployeeDetailsFieldsReadOnly()
        {
            tbxEmployeeName.Enabled = false;
            tbxLastName.Enabled = false;
            cmbGender.Enabled = false;
            tbxDateOfBirth.Enabled = false;
            tbxBSN.Enabled = false;
            tbxEmail.Enabled = false;
            tbxPhoneNumber.Enabled = false;
            tbxEmergencyName.Enabled = false;
            tbxEmergencyLastName.Enabled = false;
            tbxEmergencyPhoneNumber.Enabled = false;
            cmbPosition.Enabled = false;
            cmbEmployeeDepartment.Enabled = false;
            cmbContractType.Enabled = false;
            tbxFTEAmount.Enabled = false;
            tbxHourlyWage.Enabled = false;
            tbxStartDate.Enabled = false;
            tbxEndDate.Enabled = false;


        }
        //makes employees fields in the combobox enabled
        private void EnableEmployeeDetailsFields()
        {
            tbxEmployeeName.Enabled = true;
            tbxLastName.Enabled = true;
            cmbGender.Enabled = true;
            tbxDateOfBirth.Enabled = true;
            tbxBSN.Enabled = true;
            tbxEmail.Enabled = true;
            tbxPhoneNumber.Enabled = true;
            tbxEmergencyName.Enabled = true;
            tbxEmergencyLastName.Enabled = true;
            tbxEmergencyPhoneNumber.Enabled = true;
            cmbPosition.Enabled = true;
            cmbEmployeeDepartment.Enabled = true;
            cmbContractType.Enabled = true;
            tbxFTEAmount.Enabled = true;
            tbxHourlyWage.Enabled = true;
            tbxStartDate.Enabled = true;
            tbxEndDate.Enabled = true;
        }
        //hides button save
        public void HideBtnSaveEmployeeDetails()
        {
            btnSaveEmployeeDetails.Hide();
        }
        public void HideBtnSeeConttractHistory()
        {
            btnViewContractHistory.Hide();
            
        }
        public void HidecbxNewContract()
        {
            cbxNewContract.Hide();
        }
        // grabs the information from the Employee Management form and creates/edits an employee
        private void btnSaveEmployeeDetails_Click(object sender, EventArgs e)
        {
            contractAdmin.UpdateContractsLists();
            
            if (ValidateMandatoryFieldsOnFormAreFilled())
            {
                Position employeePosition = (Position)cmbPosition.SelectedIndex;
                Gender gender = (Gender)cmbGender.SelectedIndex;

                if (f1.addEmployeeButtonWasClicked == true)
                {
                    if (cmbContractType.Text == "Temporary")
                    {
                        if (contractAdmin.CheckIfFisrtContractDurationIsValid(tbxStartDate.Text, tbxEndDate.Text))
                        {
                            mediaBazarEmployees.AddEmployee(new Employee(tbxEmployeeName.Text, tbxLastName.Text, gender, tbxDateOfBirth.Text, tbxBSN.Text, tbxEmail.Text, tbxPhoneNumber.Text,
                                                       tbxEmergencyName.Text, tbxEmergencyLastName.Text, tbxEmergencyPhoneNumber.Text, employeePosition, cmbEmployeeDepartment.Text,
                                                       Convert.ToDouble(tbxFTEAmount.Value), Convert.ToDouble(tbxHourlyWage.Text), tbxStartDate.Text, tbxEndDate.Text));

                            ActionsAfterSavedEmployeesIsTriguered();
                        }
                        else
                        {
                            MessageBox.Show($"The latest end date of the contract must be { contractAdmin.GetLatestEndDateOfFistContractBeforePermanentContract(tbxStartDate.Text).Date.ToShortDateString()}");
                        }
                    }
                    else if(cmbContractType.Text == "Permanent")
                    {
                        mediaBazarEmployees.AddEmployee(new Employee(tbxEmployeeName.Text, tbxLastName.Text, gender, tbxDateOfBirth.Text, tbxBSN.Text, tbxEmail.Text, tbxPhoneNumber.Text,
                                                       tbxEmergencyName.Text, tbxEmergencyLastName.Text, tbxEmergencyPhoneNumber.Text, employeePosition, cmbEmployeeDepartment.Text,
                                                       Convert.ToDouble(tbxFTEAmount.Value), Convert.ToDouble(tbxHourlyWage.Text), tbxStartDate.Text, tbxEndDate.Text));

                        ActionsAfterSavedEmployeesIsTriguered();
                    }


                }
                else if (f1.editEmployeeButtonWasClicked == true)
                {
                    Employee currentSelectedEmployee = mediaBazarEmployees.ReturnEmployee(f1.selectedEmployeeEmail);
                    Contract currentContract = contractAdmin.FindCurrentContract(currentSelectedEmployee.UserName, currentSelectedEmployee.StartDate, currentSelectedEmployee.EndDate, currentSelectedEmployee.Position.ToString());



                    if (cbxNewContract.Checked)
                    {
                        if (contractAdmin.CheckIfContractCanBeRenewed(tbxStartDate.Text, tbxEndDate.Text, currentSelectedEmployee.UserName))
                        {
                            mediaBazarEmployees.EditEmployeeDetails(currentSelectedEmployee.UserName, tbxEmployeeName.Text, tbxLastName.Text, gender, tbxDateOfBirth.Text, tbxBSN.Text, tbxEmail.Text, tbxPhoneNumber.Text,
                                                   tbxEmergencyName.Text, tbxEmergencyLastName.Text, tbxEmergencyPhoneNumber.Text, employeePosition, cmbEmployeeDepartment.Text,
                                                   Convert.ToDouble(tbxFTEAmount.Value), Convert.ToDouble(tbxHourlyWage.Text), tbxStartDate.Text, tbxEndDate.Text);
                            contractAdmin.AddContract(new Contract(currentSelectedEmployee.UserName, tbxStartDate.Text, tbxEndDate.Text, employeePosition.ToString(), cmbEmployeeDepartment.Text));
                           
                            ActionsAfterSavedEmployeesIsTriguered();

                        }
                        else
                        {


                            if (contractAdmin.GetTimesContractRenewed(currentSelectedEmployee.UserName) >= 3)
                            {
                                MessageBox.Show($"This contract has already been renewed 3 times");
                            }
                            else if (contractAdmin.CheckIfFisrtContractDurationIsValid(tbxStartDate.Text, tbxEndDate.Text) == false)
                            {
                                MessageBox.Show($"The latest end date of the contract must be {contractAdmin.GetLatestEndDateBeforePermanentContract(currentSelectedEmployee.UserName).Date.ToShortDateString()}");
                            }
                        }
                    }
                    else
                    {
                        if (cmbContractType.Text == "Temporary")
                        {


                            if (contractAdmin.CheckIfTempContractDurationIsValid(tbxStartDate.Text, tbxEndDate.Text, currentSelectedEmployee.UserName))
                            {


                                mediaBazarEmployees.EditEmployeeDetails(currentSelectedEmployee.UserName, tbxEmployeeName.Text, tbxLastName.Text, gender, tbxDateOfBirth.Text, tbxBSN.Text, tbxEmail.Text, tbxPhoneNumber.Text,
                                                       tbxEmergencyName.Text, tbxEmergencyLastName.Text, tbxEmergencyPhoneNumber.Text, employeePosition, cmbEmployeeDepartment.Text,
                                                       Convert.ToDouble(tbxFTEAmount.Value), Convert.ToDouble(tbxHourlyWage.Text), tbxStartDate.Text, tbxEndDate.Text);


                                contractAdmin.EditContractDetails(currentContract.ContractId, currentContract.UserName, tbxStartDate.Text, tbxEndDate.Text, cmbPosition.Text, cmbEmployeeDepartment.Text);

                                ActionsAfterSavedEmployeesIsTriguered();


                            }
                            else
                            {
                                MessageBox.Show($"The latest end date of the contract must be {contractAdmin.GetLatestEndDateBeforePermanentContract(currentSelectedEmployee.UserName).Date.ToShortDateString()}");
                            }
                        }
                        else if (cmbContractType.Text =="Permanent")
                        {
                            mediaBazarEmployees.EditEmployeeDetails(currentSelectedEmployee.UserName, tbxEmployeeName.Text, tbxLastName.Text, gender, tbxDateOfBirth.Text, tbxBSN.Text, tbxEmail.Text, tbxPhoneNumber.Text,
                                                      tbxEmergencyName.Text, tbxEmergencyLastName.Text, tbxEmergencyPhoneNumber.Text, employeePosition, cmbEmployeeDepartment.Text,
                                                      Convert.ToDouble(tbxFTEAmount.Value), Convert.ToDouble(tbxHourlyWage.Text), tbxStartDate.Text, tbxEndDate.Text);
                            contractAdmin.EditContractDetails(currentContract.ContractId, currentContract.UserName, tbxStartDate.Text, tbxEndDate.Text, cmbPosition.Text, cmbEmployeeDepartment.Text);

                            ActionsAfterSavedEmployeesIsTriguered();
                        }
                    }

                }
             
            }
            else
            { MessageBox.Show($"Please fill all the manatory fields"); }



        }

        private void ActionsAfterSavedEmployeesIsTriguered()
        {
            ClearEmployeeDetailsTextBoxes();
            f1.addEmployeeButtonWasClicked = false;
            f1.editEmployeeButtonWasClicked = false;
            f1.UpdateEmployeeDGV();
            ClearEmployeeDetailsTextBoxes();
            f1.EnableEmployeeManagementButtons();
            btnSaveEmployeeDetails.Show();
            dgvContractHistory.Hide();
            this.Close();

        }

        // Closes Employee_Management form, Clears and enables its fields, enables buttons in form1 and deselects selected rows on dgv.

        private void btnCancelEmployeeDetails_Click_1(object sender, EventArgs e)
        {
            ClearEmployeeDetailsTextBoxes();
            btnSaveEmployeeDetails.Show();
            btnViewContractHistory.Show();
            cbxNewContract.Show();
            EnableEmployeeDetailsFields();
            f1.DgvEmployeeDetailsClearSelection();
            f1.EnableEmployeeManagementButtons();
            dgvContractHistory.Hide();
            this.Close();

        }

        // enables Employee_Management form fields, clears its fields and enables buttons in form1 and deselects selected rows on dgv.
        private void FormEmployeeManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearEmployeeDetailsTextBoxes();
            btnSaveEmployeeDetails.Show();
            btnViewContractHistory.Show();
            cbxNewContract.Show();
            EnableEmployeeDetailsFields();
            f1.DgvEmployeeDetailsClearSelection();
            f1.EnableEmployeeManagementButtons();
            dgvContractHistory.Hide();

        }

        private void btnViewContractHistory_Click(object sender, EventArgs e)
        {
            dgvContractHistory.Show();
            UpdateContractHistpryDGV();

        }

        public void UpdateContractHistpryDGV()
        {
            
            contractAdmin.UpdateContractsLists();
            dgvContractHistory.Rows.Clear();
            

            for (int i = 0; i < contractAdmin.ReturnEmployeeContractHistory(f1.selectedEmployeeEmail).Count; i++)
            {
                dgvContractHistory.Rows.Add(
                    contractAdmin.ReturnEmployeeContractHistory(f1.selectedEmployeeEmail)[i].StartDate,
                    contractAdmin.ReturnEmployeeContractHistory(f1.selectedEmployeeEmail)[i].EndDate,
                    contractAdmin.ReturnEmployeeContractHistory(f1.selectedEmployeeEmail)[i].Position,
                    contractAdmin.ReturnEmployeeContractHistory(f1.selectedEmployeeEmail)[i].Department);
            }
           
        }

        public bool ValidateMandatoryFieldsOnFormAreFilled()
        {
            if (string.IsNullOrEmpty(tbxEmployeeName.Text) || string.IsNullOrEmpty(tbxLastName.Text) || string.IsNullOrEmpty(cmbGender.Text)|| string.IsNullOrEmpty(tbxDateOfBirth.Text)||
                string.IsNullOrEmpty(tbxBSN.Text)|| string.IsNullOrEmpty(tbxEmail.Text)|| string.IsNullOrEmpty(tbxPhoneNumber.Text)|| string.IsNullOrEmpty(tbxEmergencyName.Text)|| 
                string.IsNullOrEmpty(tbxEmergencyLastName.Text)|| string.IsNullOrEmpty(tbxEmergencyPhoneNumber.Text)|| string.IsNullOrEmpty(cmbPosition.Text) || 
                string.IsNullOrEmpty(Convert.ToDouble(tbxFTEAmount.Value).ToString()) || string.IsNullOrEmpty(tbxHourlyWage.Text) || string.IsNullOrEmpty(cmbContractType.Text)|| string.IsNullOrEmpty(tbxStartDate.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            
    }
}
