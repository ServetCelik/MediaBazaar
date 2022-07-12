using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using LogicLayer;

namespace Media_Bazaar
{
    public class Employee
    {
        private string userName;
        private string salt;
        private string password;
        private string name;
        private string lastName;
        private Gender gender;
        private string dateOfBirth;
        private string bsnNumber;
        private string email;
        private string phoneNumber;
        private string emergencyName;
        private string emergencyLastName;
        private string emergencyPhoneNumber;
        private Position position;
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
        public Gender Gender { get { return gender; } set { gender = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string BsnNumber { get { return bsnNumber; } set { bsnNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string EmergencyName { get { return emergencyName; } set { emergencyName = value; } }
        public string EmergencyLastName { get { return emergencyLastName; } set { emergencyLastName = value; } }
        public string EmergencyPhoneNumber { get { return emergencyPhoneNumber; } set { emergencyPhoneNumber = value; } }
        public Position Position { get { return position; } set { position = value; } }
        public string Department { get { return department; } set { department = value; } }
        public double Fte { get { return fte; } set { fte = value; } }
        public double HourlyWage { get { return hourlyWage; } set { hourlyWage = value; } }
        public string StartDate { get { return startDate; } set { startDate = value; } }
        public string EndDate { get { return endDate; } set { endDate = value; } }

        public Employee(string name, string lastName, Gender gender, string dateOfBirth,
                      string bsnNumber, string email, string phoneNumber, string emergencyName, string emergencyLastName,
                      string emergencyPhoneNumber, Position position, string department, double fte, double hourlyWage,
                      string startDate, string endDate)
        {

            this.UserName = GenerateUserName(email);
            this.Salt = ""; 
            this.Password = GeneratePassword();
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

        public Employee(string salt, string password,string name, string lastName, Gender gender, string dateOfBirth,
                      string bsnNumber, string email, string phoneNumber, string emergencyName, string emergencyLastName,
                      string emergencyPhoneNumber, Position position, string department, double fte, double hourlyWage,
                      string startDate, string endDate)
        {

            this.UserName = GenerateUserName(email);
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
        //Generates a cryptographically strong random password. Code source https://www.techiedelight.com/
        public string GeneratePassword()
        {
            int passwordLenght = 10;
            byte[] password = new byte[passwordLenght]; //Initializes a new instance of the RNGCryptoServiceProvider class.
            RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider();
            rngCrypt.GetBytes(password);
            return Convert.ToBase64String(password);

        }

        //Uses email as userName
        public string GenerateUserName(string email)
        {
            return email;

        }

    }
}


