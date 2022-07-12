using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLayer;
using LogicLayer;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar
{
    public partial class Form1 : Form
    {

        ProductAdministrator pAdmin = new ProductAdministrator();
        //DatabaseHelper db = new DatabaseHelper();
        EmployeeDatabase EmployeeDB = new EmployeeDatabase();
        ReshelvingAdministrator reshelvingAdmin = new ReshelvingAdministrator();

        List<Reshelving> allReshelvings = new List<Reshelving>();
        EmployeeAdmin mediaBazarEmployees = new EmployeeAdmin();
        Employee employeeLoggedIn;

        public bool addEmployeeButtonWasClicked = false;
        public bool editEmployeeButtonWasClicked = false;
        public string searchedEmployeeEmail = "";
        public int indexEmployeeToBeEdited = -1;
        public string selectedEmployeeEmail = "";

        private static scheduleManager scheduleManager = new scheduleManager();
        private static dateLogic dateLogic = new dateLogic();
        //private int weeksToLookAhead = 7;
        private int weeksToLookBack = 3;
        private int yearsToLookAhead = 2;
        private int yearsToLookBack = 2;

        private string currentLoggedinPosition;

        public Form1()
        {
            InitializeComponent();
            EmployeeDetailsDummyData();
            UpdateEmployeeDGV();
            //allReshelvings = db.GetReshelvingRequests();
            UpdateReshelving();
            TabHide(); // uncomment this in final version to show only login tab when initializing app
            dataScheduleFiller();
            RefreshProducts();
            RefreshReShelvingLisBox();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employeeLogin = mediaBazarEmployees.ReturnEmployee(tbxUserName.Text);

            string employeePassword = Hasher.PasswordHasher(tbxPassword.Text + employeeLogin.Salt);

            LoginCheck(employeeLogin, employeePassword);
            //TabShowManager();
        }

        // adds all the existing employees to the table in the Employee Management tab
        public void UpdateEmployeeDGV()
        {
            mediaBazarEmployees.UpdateEmployeeLists();
            dgvEmployeeDetails.Rows.Clear();

            for (int i = 0; i < mediaBazarEmployees.GetAllEmployees().Count; i++)
            {
                dgvEmployeeDetails.Rows.Add(
                    mediaBazarEmployees.GetAllEmployees()[i].Name,
                    mediaBazarEmployees.GetAllEmployees()[i].LastName,
                    mediaBazarEmployees.GetAllEmployees()[i].Position.ToString(),
                    mediaBazarEmployees.GetAllEmployees()[i].Department,
                    mediaBazarEmployees.GetAllEmployees()[i].Fte.ToString(),
                    mediaBazarEmployees.GetAllEmployees()[i].PhoneNumber,
                    mediaBazarEmployees.GetAllEmployees()[i].Email);
            }
            DgvEmployeeDetailsClearSelection();
            dgvEmployeeDetails.Sort(colEmpMngName, ListSortDirection.Ascending);

        }

        public void DgvEmployeeDetailsClearSelection()
        {
            dgvEmployeeDetails.ClearSelection();
        }


        //creates new employees for testing/demo (although commented out, please don't delete)
        private void EmployeeDetailsDummyData()
        {
            //mediaBazarEmployees.AddEmployee(new Employee("Paul", "Rod", Gender.Male, "20/01/1993",
            //           "5441234", "Paul@mediabazaar.com", "+31 1234567", "Eli", "Chase",
            //           "+31 3456789", Position.DepoWorker, "Media", 1, (double)10.5,
            //           "02/01/2021", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Melissa", "Rodriguez", Gender.Female, "20/01/1993",
            //           "5441234", "melissa@mediabazaar.com", "+31 1234567", "Tom", "Bass",
            //           "+31 3456789", Position.Manager, "Media", 1, (double)10.5,
            //           "22/01/2021", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Tom", "van de Buur", Gender.Male, "25/05/1983",
            //          "7451256", "Tom@mediabazaar.com", "+31 1234567", "Lila", "Chase",
            //          "+31 7451256", Position.FloorWorker, "Home Appliance", (double)0.5, 12,
            //          "23/11/2015", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Niko", "Amsterdam", Gender.Other, "12/11/1996",
            //          "7451236", "Niko@mediabazaar.com", "+31 7451236", "Max", "Steel",
            //          "+31 7451256", Position.DepoWorker, "Healt & Sports", (double)0.1, 9,
            //          "01/12/2019", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Tomi", "Cass", Gender.Other, "12/11/1996",
            //          "7451236", "T.Cass@mediabazaar.com", "+31 7451236", "Max", "Steel",
            //          "+31 7451256", Position.DepoWorker, "Healt & Sports", (double)0.1, 9,
            //          "01/12/2019", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Tom", "Lass", Gender.Other, "12/11/1996",
            //          "7451236", "T.Lass@mediabazaar.com", "+31 7451236", "Max", "Steel",
            //          "+31 7451256", Position.HR, "Healt & Sports", (double)0.1, 9,
            //          "01/12/2019", ""));
            //mediaBazarEmployees.AddEmployee(new Employee("Tom", "Bass", Gender.Other, "12/11/1996",
            //         "7451236", "T.Bass@mediabazaar.com", "+31 7451236", "Max", "Steel",
            //         "+31 7451256", Position.DepoWorker, "Healt & Sports", (double)0.1, 9,
            //         "01/12/2019", ""));

        }
        // shows new form to enter employee details and disables all the other buttoons while the Employee_Management form is open
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployeeButtonWasClicked = true;
            FormEmployeeManagement formEmployeeManagement = new FormEmployeeManagement(this, mediaBazarEmployees);
            formEmployeeManagement.Show();

            DgvEmployeeDetailsClearSelection();
            DisableEmployeeManagementButtons();
            formEmployeeManagement.HideBtnSeeConttractHistory();
            formEmployeeManagement.HidecbxNewContract();

        }

        //removes employee from list based on employee email input in search textbox or selected employee from DGV
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            int indexEmployeeToBeEdited = dgvEmployeeDetails.CurrentCell.RowIndex;
            selectedEmployeeEmail = Convert.ToString(dgvEmployeeDetails.CurrentRow.Cells["colEmpMngEmail"].Value);

            Employee selectedEmployee = mediaBazarEmployees.ReturnEmployee(selectedEmployeeEmail);

            if (indexEmployeeToBeEdited != -1)
            {
                mediaBazarEmployees.RemoveEmployee(selectedEmployee);

            }

            UpdateEmployeeDGV();
            tbxSearchEmployeeBar.Clear();
        }

        private void updateScheduleUI()
        {
            ///Manager tab
            if (cbScheduleDepM.Text != "" && cbScheduleWeekM.Text != "")
            {
                int week = Convert.ToInt32(cbScheduleWeekM.Text);

                scheduleManager.loadShiftDB(week, Convert.ToInt32(cbScheduleMYear.Text), cbScheduleDepM.Text);

                dgvScheduleM.Rows.Clear();
                cbAddShiftEmployee.Text = "";
                List<weekSchedule> w = scheduleManager.schedules;
                for (int i = 0; i < w.Count(); i++)
                {
                    //if (i == 0 || i == 5 || i == 10) { } else { w[i].shift = ""; }
                    dgvScheduleM.Rows.Add(w[i].shift, w[i].Monday, w[i].Tuesday, w[i].Wednesday, w[i].Thursday, w[i].Friday, w[i].Saturday, w[i].Sunday, w[i].id);
                }
            }

            ///Employee tab
            if (cbScheduleDep.Text != "" && cbScheduleWeek.Text != "")         //Maybe only filter on current logged employee?
            {
                int week = Convert.ToInt32(cbScheduleWeek.Text);

                scheduleManager.loadShiftDB(week, Convert.ToInt32(cbScheduleMYear.Text), cbScheduleDep.Text);

                dgvScheduleM.Rows.Clear();

                List<weekSchedule> w = scheduleManager.schedules;
                for (int i = 0; i < w.Count(); i++)
                {
                    if (i == 0 || i == 5 || i == 10) { } else { w[i].shift = ""; }
                    dgvSchedule.Rows.Add(w[i].shift, w[i].Monday, w[i].Tuesday, w[i].Wednesday, w[i].Thursday, w[i].Friday, w[i].Saturday, w[i].Sunday);
                }
            }

        }

        /// <summary>
        /// Got this code online, https://10tec.com/articles/datagridview-grouping-two-recipes.aspx
        /// Not sure where/how to implement
        /// </summary>
        //protected override void OnCellPainting(DataGridViewCellPaintingEventArgs args)

        //{
        //    base.OnCellPainting(args);

        //    args.AdvancedBorderStyle.Bottom =
        //      DataGridViewAdvancedCellBorderStyle.None;

        //    // Ignore column and row headers and first row
        //    if (args.RowIndex < 1 || args.ColumnIndex < 0)
        //        return;

        //    if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
        //    {
        //        args.AdvancedBorderStyle.Top =
        //          DataGridViewAdvancedCellBorderStyle.None;
        //    }
        //    else
        //    {
        //        args.AdvancedBorderStyle.Top = AdvancedCellBorderStyle.Top;
        //    }
        //}

        private void updateScheduleUILocal()
        {
            ///Manager tab
            dgvScheduleM.Rows.Clear();
            cbAddShiftEmployee.Text = "";
            List<weekSchedule> w = scheduleManager.schedules;
            for (int i = 0; i < w.Count(); i++)
            {
                //if (i == 0 || i == 5 || i == 10) { } else { w[i].shift = ""; }
                dgvScheduleM.Rows.Add(w[i].shift, w[i].Monday, w[i].Tuesday, w[i].Wednesday, w[i].Thursday, w[i].Friday, w[i].Saturday, w[i].Sunday, w[i].id);
            }

            lblHoursToAssign.Text = "Hours Left:";
        }

        private void dataScheduleFiller()              ///Initialize cb values
        {
            foreach (Employee a in mediaBazarEmployees.GetAllEmployees())              ///Populate comboboxes
            {
                cbAddShiftEmployee.Items.Add($"{a.Name} {a.LastName}"); ///Do department filtering?
            }

            foreach (Department department in Enum.GetValues(typeof(Department)))
            {
                cbScheduleDep.Items.Add(department.GetEnumDescription());
                cbScheduleDepM.Items.Add(department.GetEnumDescription());
            }


            int week = System.Globalization.ISOWeek.GetWeekOfYear(DateTime.Now);
            int loopweek = week - weeksToLookBack;


            for (int i = 1 /*loopweek*/; i <= 52/*week + weeksToLookAhead*/; i++)
            {
                //if (i > 52)
                //{
                //    cbScheduleWeekM.Items.Add(Convert.ToString(i - 52));
                //    cbScheduleWeek.Items.Add(Convert.ToString(i - 52));
                //}
                //else if (i < 1)
                //{
                //    cbScheduleWeekM.Items.Add(Convert.ToString(i + 52));
                //    cbScheduleWeek.Items.Add(Convert.ToString(i + 52));
                //}
                //else
                //{
                //    cbScheduleWeekM.Items.Add(Convert.ToString(i));
                //    cbScheduleWeek.Items.Add(Convert.ToString(i));
                //}
                cbScheduleWeekM.Items.Add(i);
                cbScheduleWeek.Items.Add(i);
            }

            int loopYear = DateTime.Now.Year - yearsToLookBack;
            for (int i = loopYear; i <= DateTime.Now.Year + yearsToLookAhead; i++)
            {
                cbScheduleMYear.Items.Add(i);
                cbScheduleYear.Items.Add(i);
            }


            string date = DateTime.Now.ToShortDateString();
            date = date.Replace('/', '-');
            lblScheduleMToday.Text = $"Today is: {date}  Week: {Convert.ToString(week)}";
            lblScheduleToday.Text = $"Today is: {date}  Week: {Convert.ToString(week)}";

            cbScheduleMYear.Text = DateTime.Now.Year.ToString();
            cbScheduleWeekM.Text = Convert.ToString(week);
            cbScheduleYear.Text = DateTime.Now.Year.ToString();
            cbScheduleWeek.Text = Convert.ToString(week);
        }

        private void cbScheduleDepM_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateScheduleUI();
        }

        private void cbScheduleDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateScheduleUI();
        }

        private void btnSaveWeek_Click(object sender, EventArgs e)
        {
            scheduleManager.saveWeekSetDB();
        }



        private void btnRemoveShift_Click(object sender, EventArgs e)
        {
            if (dgvScheduleM.SelectedCells.Count != 0)
            {
                try
                {
                    int id = dgvScheduleM.CurrentCell.RowIndex;
                    int colId = dgvScheduleM.CurrentCell.ColumnIndex;
                    int weekId = (int)dgvScheduleM["colID", id].Value;
                    string day = (string)dgvScheduleM.Columns[colId].HeaderText;
                    day = day.ToLower();

                    scheduleManager.changeShiftLocal(weekId, day, "");
                }
                catch (ArgumentOutOfRangeException ex)
                {

                }
                updateScheduleUILocal();
            }
            else
            {
                MessageBox.Show("Please select a shift");
            }
        }

        //populates the fields  with the employee details to edit based on employee number on either searchbar or selected row

        //populates the fields  with the employee details in form Employee_Management to edit based on employees email on selected row
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            editEmployeeButtonWasClicked = true;
            FormEmployeeManagement formEmployeeManagement = new FormEmployeeManagement(this, mediaBazarEmployees);
            formEmployeeManagement.Show();
            int indexEmployeeToBeEdited = dgvEmployeeDetails.CurrentCell.RowIndex;
            selectedEmployeeEmail = Convert.ToString(dgvEmployeeDetails.CurrentRow.Cells["colEmpMngEmail"].Value);
            Employee selectedEmployee = null;

            if (indexEmployeeToBeEdited != -1)
            {
                selectedEmployee = mediaBazarEmployees.ReturnEmployee(selectedEmployeeEmail);

            }
            string contractType = ContractTypeField(selectedEmployee.EndDate);


            formEmployeeManagement.SetValuesOnForm(selectedEmployee.Name, selectedEmployee.LastName, selectedEmployee.Gender, selectedEmployee.DateOfBirth,
                                                   selectedEmployee.BsnNumber, selectedEmployee.Email, selectedEmployee.PhoneNumber, selectedEmployee.EmergencyName,
                                                   selectedEmployee.EmergencyLastName, selectedEmployee.EmergencyPhoneNumber, selectedEmployee.Position, selectedEmployee.Department,
                                                   selectedEmployee.Fte, selectedEmployee.HourlyWage, selectedEmployee.StartDate, selectedEmployee.EndDate, contractType);

            tbxSearchEmployeeBar.Clear();
            DisableEmployeeManagementButtons();

        }

        // disables buttons, shows employee details in Employee_Management form, disables its fiels so they are only read, and populates the 
        //fields based on employees email on selected row
        private void btnSeeEmployeeInfo_Click(object sender, EventArgs e)
        {
            FormEmployeeManagement formEmployeeManagement = new FormEmployeeManagement(this, mediaBazarEmployees);
            formEmployeeManagement.Show();
            int indexEmployeeToBeEdited = dgvEmployeeDetails.CurrentCell.RowIndex;
            selectedEmployeeEmail = Convert.ToString(dgvEmployeeDetails.CurrentRow.Cells["colEmpMngEmail"].Value);
            Employee selectedEmployee = null;
            editEmployeeButtonWasClicked = true;


            if (indexEmployeeToBeEdited != -1)
            {
                selectedEmployee = mediaBazarEmployees.ReturnEmployee(selectedEmployeeEmail);

            }
            string contractType = ContractTypeField(selectedEmployee.EndDate);

            formEmployeeManagement.SetValuesOnForm(selectedEmployee.Name, selectedEmployee.LastName, selectedEmployee.Gender, selectedEmployee.DateOfBirth,
                                                   selectedEmployee.BsnNumber, selectedEmployee.Email, selectedEmployee.PhoneNumber, selectedEmployee.EmergencyName,
                                                   selectedEmployee.EmergencyLastName, selectedEmployee.EmergencyPhoneNumber, selectedEmployee.Position,
                                                   selectedEmployee.Department, selectedEmployee.Fte, selectedEmployee.HourlyWage, selectedEmployee.StartDate, selectedEmployee.EndDate, contractType);

            tbxSearchEmployeeBar.Clear();
            DisableEmployeeManagementButtons();
            formEmployeeManagement.MakeEmployeeDetailsFieldsReadOnly();
            formEmployeeManagement.HideBtnSaveEmployeeDetails();
            formEmployeeManagement.HidecbxNewContract();

        }

        //disables buttons add, remove, edit, change Pasword, see employee and Generate new pasword on employee Management tab
        private void DisableEmployeeManagementButtons()
        {
            btnAddEmployee.Enabled = false;
            btnRemoveEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
            btnSeeEmployeeInfo.Enabled = false;
        }
        //enables buttons add, remove, edit, change Pasword, see employee and Generate new pasword on 
        //employee Management tab
        public void EnableEmployeeManagementButtons()
        {
            btnAddEmployee.Enabled = true;
            btnRemoveEmployee.Enabled = true;
            btnEditEmployee.Enabled = true;
            btnSeeEmployeeInfo.Enabled = true;
        }


        private void UpdateReshelving()
        {
            //lbxRequests.Items.Clear();
            dgvReShelving.Rows.Clear();
            pAdmin.UpdateLists();
            var allProducts = pAdmin.GetListOfProducts();

            foreach (var item in ActiveReshelvingRequestes())
            {
                //lbxRequests.Items.Add(item.PendingRequestText());                
                var selectedProduct = allProducts.Find(x => x.Name == item.ItemName);
                dgvReShelving.Rows.Add(item.ItemName, item.Amount, selectedProduct.Quantity, item.Department, item.Specifications);
            }
        }
        private List<Reshelving> ActiveReshelvingRequestes()
        {
            //allReshelvings = db.GetReshelvingRequests();
            reshelvingAdmin.GetAllReshelvingRequests(allReshelvings);
            List<Reshelving> reshelvings = new List<Reshelving>();

            foreach (var item in allReshelvings)
            {
                if (item.Status == AppStatus.PENDING)
                {
                    reshelvings.Add(item);
                }
            }
            return reshelvings;
        }
        public List<Reshelving> ArchivedReshelvingRequestes()
        {
            //allReshelvings = db.GetReshelvingRequests();
            reshelvingAdmin.GetAllReshelvingRequests(allReshelvings);
            List<Reshelving> reshelvings = new List<Reshelving>();

            foreach (var item in allReshelvings)
            {
                if ((item.Status == AppStatus.ACCEPTED) || (item.Status == AppStatus.REJECTED))
                {
                    reshelvings.Add(item);
                }
            }
            return reshelvings;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string employeePassword = Hasher.PasswordHasher(tbxOldPassword.Text + employeeLoggedIn.Salt);

            if (employeePassword == employeeLoggedIn.Password && tbxNewPassword.Text == tbxConfirmNewPassword.Text)
            {
                mediaBazarEmployees.EditEmployeePassword(employeeLoggedIn.Email, Hasher.PasswordHasher(tbxNewPassword.Text + employeeLoggedIn.Salt));

                MessageBox.Show("Password changed succesfully");
                tbxNewPassword.Clear();
                tbxConfirmNewPassword.Clear();
                tbxOldPassword.Clear();
            }
            else
            {
                MessageBox.Show("At least one table is not correct");
                tbxNewPassword.Clear();
                tbxConfirmNewPassword.Clear();
                tbxOldPassword.Clear();
            }
        }
        //This method selects an request from datagridview and change its status as accepted
        private void btnConfirmRequestManager_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvReShelving.CurrentCell.RowIndex;
            var selectedRequest = ActiveReshelvingRequestes()[selectedIndex];
            int selectedRequestId = selectedRequest.Id;
            string selectedrequestName = selectedRequest.ItemName;
            var allProducts = pAdmin.GetListOfProducts();
            var selectedProduct = allProducts.Find(x => x.Name == selectedrequestName);
            if (selectedProduct.Quantity - selectedRequest.Amount >= 0)
            {
                reshelvingAdmin.RespondReshelving(selectedRequestId, AppStatus.ACCEPTED + 1);
                pAdmin.DecreaseQuantity(selectedProduct.Id, selectedRequest.Amount);
                UpdateReshelving();
                RefreshProducts();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("There is not enought products?", "Do you want to sent all the item left?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    reshelvingAdmin.ChangeAndAcceptReshelving(selectedRequestId, selectedProduct.Quantity, AppStatus.ACCEPTED + 1);
                    pAdmin.DecreaseQuantity(selectedProduct.Id, selectedProduct.Quantity);
                    UpdateReshelving();
                    RefreshProducts();
                }                
            }

        }
        //This method selects an request from datagridview and change its status to  "rejected"
        private void btnRejectRequestManager_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvReShelving.CurrentCell.RowIndex;
            int selectedItemId = ActiveReshelvingRequestes()[selectedIndex].Id;
            reshelvingAdmin.RespondReshelving(selectedItemId, AppStatus.REJECTED + 1);
            UpdateReshelving();
        }
        //this button clear filter and refresh the product page
        private void btnRefreshPrdct_Click(object sender, EventArgs e)
        {
            productFIlterTb.Clear();
            RefreshProducts();
        }

        public void RefreshProducts()
        {
            pAdmin.UpdateLists();
            dgvProducts.Rows.Clear();

            foreach (var item in partOfList(productFIlterTb.Text))
            {
                dgvProducts.Rows.Add(item.Name, item.PurchasePrice, item.SellPrice, item.Quantity, 
                                     item.Manufacturer, item.StorageLocation, item.Description);
            }

        }
        //Delete selected product and move it to history page
        private void btnDeletePrdct_Click(object sender, EventArgs e)
        {
            int selectedId = findId();
            pAdmin.DeleteProduct(selectedId);
            productFIlterTb.Clear();
            RefreshProducts();
        }
        //opens a new tab and fill it with the data of selected item
        private void btnEditPrdct_Click(object sender, EventArgs e)
        {
            int selectedId = findId();
            string name = dgvProducts.SelectedCells[0].Value.ToString();
            string purchasePrice = dgvProducts.SelectedCells[1].Value.ToString();
            string sellPrice = dgvProducts.SelectedCells[2].Value.ToString();
            string manufacturer = dgvProducts.SelectedCells[4].Value.ToString();
            string location = dgvProducts.SelectedCells[5].Value.ToString();
            string description = dgvProducts.SelectedCells[6].Value.ToString();
      

            EditProduct editProduct = new EditProduct(this, pAdmin, name, purchasePrice, sellPrice, 
                                                        manufacturer, location, description, selectedId);
            editProduct.Show();

        }
        //open a new tab to add a new product
        private void btnAddNewPrdct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this, pAdmin);
            addProduct.Show();
        }
        //This button increses the amount of selected product depend on given value
        private void btnIncPrdct_Click(object sender, EventArgs e)
        {
            int amount;
            if (dgvProducts.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pls select an item");
            }
            else if ((int.TryParse(tbIncDecPrdctAmount.Text, out amount)))
            {
                int selectedId = findId();

                pAdmin.IncreaseQuantity(selectedId, amount);
                productFIlterTb.Clear();
                RefreshProducts();
                UpdateReshelving();
                RefreshReShelvingLisBox();
            }
            else
            {
                MessageBox.Show("Pls enter an legit amount");
            }

        }
        //Find id of selected Product
        private int findId()
        {
            int selectedIndex = dgvProducts.CurrentCell.RowIndex;
            int selectedId = partOfList(productFIlterTb.Text)[selectedIndex].Id;
            return selectedId;
        }
        //This button decrease the amount of selected product depend on given value
        private void btnDecPrdct_Click(object sender, EventArgs e)
        {
            int amount;
            if (dgvProducts.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pls select an item");
            }
            else if ((int.TryParse(tbIncDecPrdctAmount.Text, out amount)))
            {
                int selectedId = findId();

                pAdmin.DecreaseQuantity(selectedId, amount);
                productFIlterTb.Clear();
                RefreshProducts();
                UpdateReshelving();
                RefreshReShelvingLisBox();
            }
            else
            {
                MessageBox.Show("Pls enter an legit amount");
            }
        }

        //search for employee name on local list of employees and displays results in employee's DGV
        private void tbxSearchEmployeeBar_TextChanged(object sender, EventArgs e)
        {
            mediaBazarEmployees.UpdateEmployeeLists();
            dgvEmployeeDetails.Rows.Clear();

            for (int i = 0; i < mediaBazarEmployees.GetAllEmployees().Count; i++)
            {
                if (mediaBazarEmployees.GetAllEmployees()[i].Name.Length >= tbxSearchEmployeeBar.TextLength)
                {

                    if (mediaBazarEmployees.GetAllEmployees()[i].Name.Substring(0, tbxSearchEmployeeBar.TextLength).ToLower()
                        == tbxSearchEmployeeBar.Text.Substring(0, tbxSearchEmployeeBar.TextLength).ToLower())
                    {

                        dgvEmployeeDetails.Rows.Add(
                        mediaBazarEmployees.GetAllEmployees()[i].Name,
                        mediaBazarEmployees.GetAllEmployees()[i].LastName,
                        mediaBazarEmployees.GetAllEmployees()[i].Position.ToString(),
                        mediaBazarEmployees.GetAllEmployees()[i].Department,
                        mediaBazarEmployees.GetAllEmployees()[i].Fte.ToString(),
                        mediaBazarEmployees.GetAllEmployees()[i].PhoneNumber,
                        mediaBazarEmployees.GetAllEmployees()[i].Email);
                    }
                }
            }

            DgvEmployeeDetailsClearSelection();

        }

        private void cbScheduleWeekM_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateScheduleUI();
        }

        private void btnScheduleEditShift_Click(object sender, EventArgs e)
        {
            if (dgvScheduleM.SelectedCells.Count != 0 && cbAddShiftEmployee.Text != "")
            {
                int id = dgvScheduleM.CurrentCell.RowIndex;
                int colId = dgvScheduleM.CurrentCell.ColumnIndex;
                int weekId = (int)dgvScheduleM["colID", id].Value;
                string day = (string)dgvScheduleM.Columns[colId].HeaderText;
                day = day.ToLower();

                string date = dateLogic.getStartDateWeek(Convert.ToInt32(cbScheduleWeekM.Text), Convert.ToInt32(cbScheduleMYear.Text));

                bool proceed = true;
                if (scheduleManager.checkSameShift(cbAddShiftEmployee.Text, day, id))
                {
                    proceed = false;
                    MessageBox.Show($"Can't assign shift. Employee '{cbAddShiftEmployee.Text}' is already assigned that shift.");
                }

                if (scheduleManager.checkConsecutiveShifts(cbAddShiftEmployee.Text, day) && proceed)
                {
                    DialogResult dialogResult = MessageBox.Show("This employee is already assigned 2 shifts today, proceed?", "Confirm Shift?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        proceed = true;
                    }
                    else
                    {
                        proceed = false;
                    }
                }

                if (!scheduleManager.checkFTE(cbAddShiftEmployee.Text, mediaBazarEmployees.GetCurrentContractHours(cbAddShiftEmployee.Text), id))
                {
                    DialogResult dialogResult = MessageBox.Show("Assigning this shift will exceed employee's working hours, assign anyways?", "Confirm Shift?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        proceed = true;
                    }
                    else
                    {
                        proceed = false;
                    }
                }

                if (proceed)
                {

                    try
                    {
                        scheduleManager.changeShiftLocal(weekId, day, cbAddShiftEmployee.Text);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {

                    }
                }

                updateScheduleUILocal();
            }
            else
            {
                MessageBox.Show("Please select a shift ánd an employee");
            }
        }

        private void btnAddWeekset_Click(object sender, EventArgs e)
        {
            scheduleManager.copyList.Clear();
            scheduleManager.copyList.AddRange(scheduleManager.schedules);
        }

        private void btnLoadWeekset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < scheduleManager.schedules.Count; i++)
            {
                scheduleManager.schedules[i].Monday = scheduleManager.copyList[i].Monday;
                scheduleManager.schedules[i].Tuesday = scheduleManager.copyList[i].Tuesday;
                scheduleManager.schedules[i].Wednesday = scheduleManager.copyList[i].Wednesday;
                scheduleManager.schedules[i].Thursday = scheduleManager.copyList[i].Thursday;
                scheduleManager.schedules[i].Friday = scheduleManager.copyList[i].Friday;
                scheduleManager.schedules[i].Saturday = scheduleManager.copyList[i].Saturday;
                scheduleManager.schedules[i].Sunday = scheduleManager.copyList[i].Sunday;
            }
            updateScheduleUILocal();
        }

        private void rSFilterButton_Click(object sender, EventArgs e)
        {
            RefreshReShelvingLisBox();
        }
        public void RefreshReShelvingLisBox()
        {
            reshelvingRequestDGV.Rows.Clear();

            foreach (var item in partOfList(rSItemName.Text))
            {
                reshelvingRequestDGV.Rows.Add(item.Name, item.Quantity);
            }
        }
        public List<Product> partOfList(string partOfName)
        {
            List<Product> partialList = new List<Product>();
            var fullList = pAdmin.GetListOfProducts();

            foreach (var item in fullList)
            {
                if (item.Name.Contains(partOfName))
                {
                    partialList.Add(item);
                }
            }
            return partialList;
        }

        private void rSRequestConfirm_Click(object sender, EventArgs e)
        {
            string itemname = findRsRequestId(); // it returns item name, not id
            int amount = Convert.ToInt32(rSAmountTb.Text);
            string department = rSDepTb.Text;
            string specifications = rSSpecTb.Text;
            reshelvingAdmin.RequestReshelving(itemname, amount, department, specifications);
            clearRsFields();
            RefreshReShelvingLisBox();
            MessageBox.Show("Request sent succesfully");
            UpdateReshelving();

        }

        private void rSRequestReject_Click(object sender, EventArgs e)
        {
            clearRsFields();
            RefreshReShelvingLisBox();
        }


        private string findRsRequestId()
        {
            //int selectedIndex = rsListBox.SelectedIndex;
            int selectedIndex = reshelvingRequestDGV.CurrentCell.RowIndex;
            string selectedId = partOfList(rSItemName.Text)[selectedIndex].Name;
            return selectedId;
        }
        private void clearRsFields()
        {
            rSAmountTb.Clear();
            rSDepTb.Clear();
            rSSpecTb.Clear();
            rSItemName.Clear();
        }

        private void productFilterBtn_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }
        //this button opens a new form which show all the replied requests
        private void btnReShelvingHistory_Click(object sender, EventArgs e)
        {
            ReshelvingHistory reshelvingHistory = new ReshelvingHistory(this);
            reshelvingHistory.Show();

        }
        //this method opens a for which shows all deleted items
        private void btnProductHistory_Click(object sender, EventArgs e)
        {
            DeletedItems deletedItems = new DeletedItems(pAdmin);
            deletedItems.Show();
        }

        private string ContractTypeField(string endDate)
        {
            if (string.IsNullOrEmpty(endDate))
            {
                return "Permanent";
            }
            else
            {
                return "Temporary";
            }
        }

        private void LoginCheck(Employee employeeLogin, string employeePassword)
        {
            if (employeeLogin.Password == employeePassword)
            {
                employeeLoggedIn = employeeLogin;

                if (employeeLogin.Position == Position.FloorWorker)
                {
                    TabHide();
                    TabShowEmployee();
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                    currentLoggedinPosition = Position.FloorWorker.ToString();
                }
                else if (employeeLogin.Position == Position.DepoWorker)
                {
                    TabHide();
                    TabShowDepot();
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                    currentLoggedinPosition = Position.DepoWorker.ToString();
                }
                else if (employeeLogin.Position == Position.Manager)
                {
                    TabHide();
                    TabShowManager();
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                    currentLoggedinPosition = Position.Manager.ToString();
                }
                else if (employeeLogin.Position == Position.HR)
                {
                    tabControl.TabPages.Remove(Login);
                    TabHide();
                    TabShowHR();
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                    currentLoggedinPosition = Position.HR.ToString();
                }
                else if (employeeLogin.Position == Position.Administrator)
                {
                    TabHide();
                    TabShowAdministrator();
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                    currentLoggedinPosition = Position.Administrator.ToString();
                }
                else
                {
                    TabHide();
                    MessageBox.Show("Wrong user name or password");
                    tbxUserName.Clear();
                    tbxPassword.Clear();
                }
                lblLoggedUser.Text = currentLoggedinPosition + " App";
            }
        }

        private void TabHide()
        {            
            tabControl.TabPages.Remove(ScheduleManager);
            tabControl.TabPages.Remove(ScheduleEmployee);
            tabControl.TabPages.Remove(Reshelving);
            tabControl.TabPages.Remove(ReshelvingRequest);
            tabControl.TabPages.Remove(ProductPage);
            tabControl.TabPages.Remove(EmployeeManagement);
            tabControl.TabPages.Remove(Settings);
            /*btnConfirmRequest.Hide()*/
            ;
            btnConfirmRequestManager.Hide();
            btnRejectRequestManager.Hide();

        }

        private void TabShowEmployee()
        {
            tabControl.TabPages.Remove(Login);
            tabControl.TabPages.Add(ScheduleEmployee);
            tabControl.TabPages.Add(ReshelvingRequest);
            tabControl.TabPages.Add(Settings);
            //btnConfirmRequest.Show();
        }

        private void TabShowManager()
        {
            tabControl.TabPages.Remove(Login);
            tabControl.TabPages.Add(ScheduleManager);
            tabControl.TabPages.Add(ReshelvingRequest);
            //tabControl.TabPages.Add(ProductPage);
            tabControl.TabPages.Add(EmployeeManagement);
            tabControl.TabPages.Add(Settings);
            btnAddEmployee.Hide();
            btnRemoveEmployee.Hide();
            btnEditEmployee.Hide();
            updateScheduleUI();
        }
        private void cbAddShiftEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHoursToAssign.Text = $"Hours left: {scheduleManager.getFTELeft(cbAddShiftEmployee.Text, mediaBazarEmployees.GetCurrentContractHours(cbAddShiftEmployee.Text))}";
        }

        private void dgvScheduleM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dgvScheduleM.CurrentCell.RowIndex;
            int col = dgvScheduleM.CurrentCell.ColumnIndex;
            
            double hours = scheduleManager.getFTELeft(dgvScheduleM.CurrentCell.Value.ToString(), 
                mediaBazarEmployees.GetCurrentContractHours(dgvScheduleM.CurrentCell.Value.ToString())); ;

            lblHoursToAssign.Text = $"Hours left: {hours}";
        }


        bool IsTheSameCellValueScheduleM(int row)
        {
            int column = 0;
            DataGridViewCell cell1 = dgvScheduleM[column, row];
            DataGridViewCell cell2 = dgvScheduleM[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgvScheduleM_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            
                if (IsTheSameCellValueScheduleM(e.RowIndex))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = dgvScheduleM.AdvancedCellBorderStyle.Top;
                }
            }
        }

        private void dgvScheduleM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (e.ColumnIndex == 0)
            {
                if (IsTheSameCellValueScheduleM(e.RowIndex))
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvScheduleM.AutoGenerateColumns = false;
        }

        



        private void TabShowDepot()
        {
            tabControl.TabPages.Remove(Login);
            tabControl.TabPages.Add(ScheduleEmployee);
            tabControl.TabPages.Add(Reshelving);
            tabControl.TabPages.Add(ProductPage);
            tabControl.TabPages.Add(Settings);
            btnConfirmRequestManager.Show();
            btnRejectRequestManager.Show();
            btnAddNewPrdct.Hide();
            btnEditPrdct.Hide();
            btnDeletePrdct.Hide();
        }

        private void TabShowHR()
        {
            tabControl.TabPages.Add(EmployeeManagement);
            tabControl.TabPages.Add(Settings);
            btnAddEmployee.Show();
            btnRemoveEmployee.Show();
            btnEditEmployee.Show();
            btnSeeEmployeeInfo.Show();
        }

        private void TabShowAdministrator()
        {
            tabControl.TabPages.Remove(Login);
            tabControl.TabPages.Add(ProductPage);
            tabControl.TabPages.Add(Settings);
            gbIncreaseDecreaseStock.Hide();
        }

        private void btnScheduleMPreferences_Click(object sender, EventArgs e)
        {
            string name;

            if(cbAddShiftEmployee.Text != "")
            {
                name = cbAddShiftEmployee.Text;
            } else
            {
                name = dgvScheduleM.CurrentCell.Value.ToString();
            }

            name = mediaBazarEmployees.getUsernameByName(name);

            foreach(ShiftPreference s in mediaBazarEmployees.GetAllPreferences())
            {
                if(s.UserName == name)
                {
                    MessageBox.Show($"Preferences for {name}: " + "\n" +
                        $"Monday: {s.monday.ToString().Replace("_", " ")}" + "\n" +
                        $"Tuesday: {s.tuesday.ToString().Replace("_", " ")}" + "\n" +
                        $"Wednesday: {s.wednesday.ToString().Replace("_", " ")}" + "\n" +
                        $"Thursday: {s.thursday.ToString().Replace("_", " ")}" + "\n" +
                        $"Friday: {s.friday.ToString().Replace("_", " ")}" + "\n" +
                        $"Saturday: {s.saturday.ToString().Replace("_", " ")}" + "\n" +
                        $"Sunday: {s.sunday.ToString().Replace("_", " ")}" + "\n");
                }
            }
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            scheduleManager.GenerateSchedule(mediaBazarEmployees.GetAllPreferences(),
                mediaBazarEmployees);

            updateScheduleUILocal();
        }

    }



}
