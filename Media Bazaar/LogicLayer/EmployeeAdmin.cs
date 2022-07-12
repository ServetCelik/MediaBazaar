using DatabaseLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using LogicLayer;

namespace Media_Bazaar
{
    public class EmployeeAdmin
    {

        List<Employee> employees = new List<Employee>();
        List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
        EmployeeDatabase employeeDB = new EmployeeDatabase();
        EmailSender emailSender = new EmailSender();
        ContractAdmin contractAdmin = new ContractAdmin();
        List<ShiftPreference> shiftPreference = new List<ShiftPreference>();
        ShiftPreference preference;


        //Add employees to the list employees local and database
        public void AddEmployee(Employee employee)
        {
            try
            {
                string salt = Guid.NewGuid().ToString();
                string passwordHashed = PasswordHasher(employee.Password + salt);
               
                employees.Add(employee);

                employeeDB.AddEmployeeToDB(employee.UserName, salt, passwordHashed, employee.Name, employee.LastName, employee.Gender.ToString(), employee.DateOfBirth,
                                            employee.BsnNumber, employee.Email, employee.PhoneNumber, employee.EmergencyName, employee.EmergencyLastName, employee.EmergencyPhoneNumber,
                                            employee.Position.ToString(), employee.Department, employee.Fte, employee.HourlyWage, employee.StartDate, employee.EndDate);


                emailSender.SendEmailWithNewUserPassword(employee.Name, employee.LastName, employee.Email, employee.Password);

                contractAdmin.AddContract(new Contract(employee.UserName, employee.StartDate, employee.EndDate, employee.Position.ToString(), employee.Department));
/*                employeeDB.AddUserAndPasswordToDB(employee.UserName, employee.Password, employee.Position.ToString());*/ // for test users, delete in final version

            }
            catch (Exception contract)
            {

                throw new Exception("The contract end date is more than 2 years");
            }

        }

        // removees employees from a list and database based on employee userName
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            employeeDB.DeleteEmployeeFromDB(employee.UserName);
        }
        //returns a list with all the employees
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public List<ShiftPreference> GetAllPreferences()
        {
            return shiftPreference;
        }

        //returns an employee based on an employee email
        public Employee ReturnEmployee(string searchEmployeeEmail)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Email == searchEmployeeEmail)
                {
                    return employees[i];
                }
            }
            return null;
        }
        // saves new details on an existing employee
        public void EditEmployeeDetails(string searchedEmail, string name, string lastName, Gender gender, string dateOfBirth, string bsnNumber, string email, string phoneNumber,
                                        string emergencyName, string emergencyLastName, string emergencyPhoneNumber, Position position, string department, double fte, double hourlyWage,
                                        string startDate, string endDate)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Email == searchedEmail)
                {
                    employees[i].Name = name;
                    employees[i].LastName = lastName;
                    employees[i].Gender = gender;
                    employees[i].DateOfBirth = dateOfBirth;
                    employees[i].BsnNumber = bsnNumber;
                    employees[i].Email = email;
                    employees[i].PhoneNumber = phoneNumber;
                    employees[i].EmergencyName = emergencyName;
                    employees[i].EmergencyLastName = emergencyLastName;
                    employees[i].EmergencyPhoneNumber = emergencyPhoneNumber;
                    employees[i].Position = position;
                    employees[i].Department = department;
                    employees[i].Fte = fte;
                    employees[i].HourlyWage = hourlyWage;
                    employees[i].StartDate = startDate;
                    employees[i].EndDate = endDate;
                }
            }

            employeeDB.EditEmployeeInDB(searchedEmail, name, lastName, gender.ToString(), dateOfBirth, bsnNumber, email, phoneNumber, emergencyName, emergencyLastName,
                                        emergencyPhoneNumber, position.ToString(), department, fte, hourlyWage, startDate, endDate);
            
        }

        public void EditEmployeePassword(string searchedEmail, string password)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Email == searchedEmail)
                {
                    employees[i].Password = password;
                    employees[i].Email = searchedEmail;
                }
            }

            employeeDB.EditEmployeePasswordInDB(searchedEmail, password);
        }

        // adds employee DTO to employee list
        public Employee MapperEmployeeObject(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee(employeeDTO.Salt, employeeDTO.Password, employeeDTO.Name, employeeDTO.LastName, (Gender)Enum.Parse(typeof(Gender), employeeDTO.Gender), employeeDTO.DateOfBirth,
                                               employeeDTO.BsnNumber, employeeDTO.Email, employeeDTO.PhoneNumber, employeeDTO.EmergencyName, employeeDTO.EmergencyLastName,
                                               employeeDTO.EmergencyPhoneNumber, (Position)Enum.Parse(typeof(Position), employeeDTO.Position), employeeDTO.Department,
                                               employeeDTO.Fte, employeeDTO.HourlyWage, employeeDTO.StartDate, employeeDTO.EndDate);
            return employee;
        }

        // adds employee dtos list to employees list
        public void MapperEmployeeList(List<EmployeeDTO> dTOs)
        {
            employees.Clear();
            foreach (var item in dTOs)
            {
                employees.Add(MapperEmployeeObject(item));
            }
        }

        // update employees list in database and local memory using the dtos list.
        public void UpdateEmployeeLists()
        {
            employeeDB.GetAllEmployeesFromDB(employeeDTOs);
            MapperEmployeeList(employeeDTOs);
            updatePreferences();
        }

        private void updatePreferences()
        {
            foreach (var item in employees)
            {
                string a = employeeDB.GetPreferences(item.UserName);
                if(string.IsNullOrEmpty(a))
                {
                    shiftPreference.Add(new ShiftPreference(item.UserName, falseArray()));
                }
                else
                {
                    preference = new ShiftPreference(item.UserName, ConvertToArray(a));
                    shiftPreference.Add(preference);
                    preference.ConvertToEnum(a);
                }
            }
        }

        public bool[,] ConvertToArray(string data)
        {
            string[] read;
            char[] seperators = { ',' };

            read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            bool a = Convert.ToBoolean(read[0]);
            bool b = Convert.ToBoolean(read[1]);
            bool c = Convert.ToBoolean(read[2]);
            bool d = Convert.ToBoolean(read[3]);
            bool e = Convert.ToBoolean(read[4]);
            bool f = Convert.ToBoolean(read[5]);
            bool g = Convert.ToBoolean(read[6]);
            bool h = Convert.ToBoolean(read[7]);
            bool i = Convert.ToBoolean(read[8]);
            bool j = Convert.ToBoolean(read[9]);
            bool k = Convert.ToBoolean(read[10]);
            bool l = Convert.ToBoolean(read[11]);
            bool m = Convert.ToBoolean(read[12]);
            bool n = Convert.ToBoolean(read[13]);
            bool o = Convert.ToBoolean(read[14]);
            bool p = Convert.ToBoolean(read[15]);
            bool q = Convert.ToBoolean(read[16]);
            bool r = Convert.ToBoolean(read[17]);
            bool s = Convert.ToBoolean(read[18]);
            bool t = Convert.ToBoolean(read[19]);
            bool u = Convert.ToBoolean(read[20]);

            bool[,] pref = new bool[7, 3] { { a, b, c }, { d, e, f }, { g, h, i }, { j, k, l }, { m, n, o }, { p, q, r }, { s, t, u } };

            return pref;
        }

        private bool[,] falseArray()
        {
            bool[,] pref = new bool[7, 3];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pref[i, j] = false;
                }
            }

            return pref;
        }

        // hashes password to store it on table employee in dababase

        public static String PasswordHasher(string passwordAndSalt)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA512.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(passwordAndSalt));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        //public static String PasswordHasher(string passwordAndSalt)
        //{
        //    StringBuilder Sb = new StringBuilder();

        //    using (var hash = SHA256.Create())
        //    {
        //        Encoding enc = Encoding.UTF8;
        //        byte[] result = hash.ComputeHash(enc.GetBytes(passwordAndSalt));

        //        foreach (byte b in result)
        //            Sb.Append(b.ToString("x2"));
        //    }

        //    return Sb.ToString();
        //}

        //Gets contract hours for schedule
        public double GetCurrentContractHours(string name)
        {
            double returnFte = 0;
            foreach(Employee e in employees)
            {
                if($"{e.Name} {e.LastName}" == name)
                {
                    returnFte = e.Fte * 40;
                }
            }
            return returnFte;
        }

        //for schedule, to get preference username
        public string getUsernameByName(string name)
        {
            for(int i = 0; i < employees.Count; i++)
            {
                if($"{employees[i].Name} {employees[i].LastName}" == name)
                {
                    return employees[i].UserName;
                    i = employees.Count;
                }
            }
            return "";
        }
        //for schedule autoSched
        public string getNameByUsername(string username)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].UserName == username)
                {
                    return $"{employees[i].Name} {employees[i].LastName}";
                    i = employees.Count;
                }
            }
            return "";
        }
    }
}

