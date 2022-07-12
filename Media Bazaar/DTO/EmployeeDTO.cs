using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class EmployeeDTO
    {
        private string userName;
        private string salt;
        private string password;
        private string name;
        private string lastName;
        private string gender;
        private string dateOfBirth;
        private string bsnNumber;
        private string email;
        private string phoneNumber;
        private string emergencyName;
        private string emergencyLastName;
        private string emergencyPhoneNumber;
        private string position;
        private string department;
        private double fte;
        private double hourlyWage;
        private string startDate;
        private string endDate;

        public string UserName { get => userName; private set => userName = value; }
        public string Salt { get => salt; private set => salt = value; }
        public string Password { get { return password; } set { password = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string BsnNumber { get { return bsnNumber; } set { bsnNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string EmergencyName { get { return emergencyName; } set { emergencyName = value; } }
        public string EmergencyLastName { get { return emergencyLastName; } set { emergencyLastName = value; } }
        public string EmergencyPhoneNumber { get { return emergencyPhoneNumber; } set { emergencyPhoneNumber = value; } }
        public string Position { get { return position; } set { position = value; } }
        public string Department { get { return department; } set { department = value; } }
        public double Fte { get { return fte; } set { fte = value; } }
        public double HourlyWage { get { return hourlyWage; } set { hourlyWage = value; } }
        public string StartDate { get { return startDate; } set { startDate = value; } }
        public string EndDate { get { return endDate; } set { endDate = value; } }

        public EmployeeDTO(string name, string lastName, string gender, string dateOfBirth,
                       string bsnNumber, string email, string phoneNumber, string emergencyName, string emergencyLastName,
                       string emergencyPhoneNumber, string position, string department, double fte, double hourlyWage,
                       string startDate, string endDate)
        {

            this.UserName = email;
            this.Salt = "";
            this.Password = "";
            this.Name = name;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.BsnNumber = bsnNumber;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.EmergencyName = emergencyName;
            this.EmergencyLastName = emergencyLastName;
            this.EmergencyPhoneNumber = emergencyPhoneNumber;
            this.Position = position;
            this.Department = department;
            this.Fte = fte;
            this.HourlyWage = hourlyWage;
            this.StartDate = startDate;
            if (endDate == "")
            {
                this.EndDate = "";
            }
            else
            {
                this.EndDate = endDate;
            }

        }

        public EmployeeDTO(string salt, string password,string name, string lastName, string gender, string dateOfBirth,
                       string bsnNumber, string email, string phoneNumber, string emergencyName, string emergencyLastName,
                       string emergencyPhoneNumber, string position, string department, double fte, double hourlyWage,
                       string startDate, string endDate)
        {

            this.UserName = email;
            this.Salt = salt;
            this.Password = password;
            this.Name = name;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.BsnNumber = bsnNumber;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.EmergencyName = emergencyName;
            this.EmergencyLastName = emergencyLastName;
            this.EmergencyPhoneNumber = emergencyPhoneNumber;
            this.Position = position;
            this.Department = department;
            this.Fte = fte;
            this.HourlyWage = hourlyWage;
            this.StartDate = startDate;
            if (endDate == "")
            {
                this.EndDate = "";
            }
            else
            {
                this.EndDate = endDate;
            }




        }

    }

}