using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;
using System.Security.Cryptography;



namespace DatabaseLayer
{
    public class EmployeeDatabase
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();

        // adds employee to the table employee in dababase
        public void AddEmployeeToDB(string userName, string salt, string passwordHashed, string name, string lastName, string gender, string dateOfBirth,
                                   string bsnNumber, string email, string phoneNumber, string emergencyName, string emergencyLastName, string emergencyPhoneNumber,
                                   string position, string department, double fte, double hourlyWage, string startDate, string endDate)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO employee (userName, salt, password, name, lastName, gender, dateOfBirth, bsnNumber, email, phoneNumber, emergencyName, emergencyLastName, emergencyPhoneNumber, position, department, fte, hourlyWage,startDate, endDate, status) " +
                        "VALUES(@userName, @salt, @password, @name, @lastName, @gender, @dateOfBirth,@bsnNumber, @email, @phoneNumber, @emergencyName, @emergencyLastName, @emergencyPhoneNumber, @position, @department, @fte, @hourlyWage, @startDate, @endDate, @status)";


                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@salt", salt);
                    cmd.Parameters.AddWithValue("@password", passwordHashed);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@bsnNumber", bsnNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@emergencyName", emergencyName);
                    cmd.Parameters.AddWithValue("@emergencyLastName", emergencyLastName);
                    cmd.Parameters.AddWithValue("@emergencyPhoneNumber", emergencyPhoneNumber);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@fte", fte);
                    cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@status", "ACTIVE");




                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }
        // changes employee status to inactive in database to hide employee from local data lists.
        public void DeleteEmployeeFromDB(string userName)
        {

            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE employee SET status = @status WHERE userName= @userName";


                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@status", "INACTIVE");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }
        //// deletes employee to the table employee in dababase
        //public void DeleteEmployeeFromDB(string userName)
        //{
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "DELETE FROM employee WHERE username =@userName ";

        //            cmd.Parameters.AddWithValue("@userName", userName);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Convert.ToString(ex));

        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        // edits employee details in the table employee in dababase
        public void EditEmployeeInDB(string userName, string name, string lastName, string gender, string dateOfBirth, string bsnNumber, string email, string phoneNumber,
                                     string emergencyName, string emergencyLastName, string emergencyPhoneNumber, string position, string department, double fte,
                                     double hourlyWage, string startDate, string endDate)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE employee SET name = @name, lastName = @lastName, gender = @gender, dateOfBirth = @dateOfBirth, bsnNumber = @bsnNumber, email = @email, phoneNumber = @phoneNumber, emergencyName = @emergencyName, emergencyLastName = @emergencyLastName, emergencyPhoneNumber = @emergencyPhoneNumber, position = @position, department = @department, fte = @fte, hourlyWage = @hourlyWage, startDate = @startDate, endDate = @endDate, status = @status WHERE userName= @userName";


                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@bsnNumber", bsnNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@emergencyName", emergencyName);
                    cmd.Parameters.AddWithValue("@emergencyLastName", emergencyLastName);
                    cmd.Parameters.AddWithValue("@emergencyPhoneNumber", emergencyPhoneNumber);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@fte", fte);
                    cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@status", "ACTIVE");



                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }

        public void EditEmployeePasswordInDB(string userName, string password)
        {
            try
            {
                con.Open();

                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE employee SET password = @password WHERE userName= @userName";

                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));
            }
            finally
            {
                con.Close();
            }
        }


        // gets all the employees from the table employee in database
        public void GetAllEmployeesFromDB(List<EmployeeDTO> employeeDTOs)
        {
            employeeDTOs.Clear();


            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM employee WHERE status = @status";
            cmd.Parameters.AddWithValue("@status", "ACTIVE");

            try
            {
                con.Open();

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    using (reader)
                    {
                        while (reader.Read())

                        {   string salt = Convert.ToString(reader["salt"]);
                            string password = Convert.ToString(reader["password"]);
                            string name = Convert.ToString(reader["name"]);
                            string lastName = Convert.ToString(reader["lastName"]);
                            string gender = Convert.ToString(reader["gender"]);
                            string dateOfBirth = Convert.ToString(reader["dateOfBirth"]);
                            string bsnNumber = Convert.ToString(reader["bsnNumber"]);
                            string email = Convert.ToString(reader["email"]);
                            string phoneNumber = Convert.ToString(reader["phoneNumber"]);
                            string emergencyName = Convert.ToString(reader["emergencyName"]);
                            string emergencyLastName = Convert.ToString(reader["emergencyLastName"]);
                            string emergencyPhoneNumber = Convert.ToString(reader["emergencyPhoneNumber"]);
                            string position = Convert.ToString(reader["position"]);
                            string department = Convert.ToString(reader["department"]);
                            double fte = Convert.ToDouble(reader["fte"]);
                            double hourlyWage = Convert.ToDouble(reader["hourlyWage"]);
                            string startDate = Convert.ToString(reader["startDate"]);
                            string endDate = Convert.ToString(reader["endDate"]);



                            employeeDTOs.Add(new EmployeeDTO(salt, password,name, lastName, gender, dateOfBirth, bsnNumber, email, phoneNumber, emergencyName, emergencyLastName,
                                                              emergencyPhoneNumber, position, department, fte, hourlyWage, startDate, endDate));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(Convert.ToString(ex));
            }
            finally
            {
                con.Close();
            }
        }

            // hashes password to store it on table employee in dababase
            public static String PasswordHasher(string passwordAndSalt)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(passwordAndSalt));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        //Add dummy employee userName, position and password at the test users table in DB, delete in final version
        public void AddUserAndPasswordToDB(string userName, string passwordNotHashed, string position)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO `test user names & password data` (userName, passwordNotHashed, position ) " +
                        "VALUES(@userName, @passwordNotHashed, @position)";


                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@passwordNotHashed", passwordNotHashed);
                    cmd.Parameters.AddWithValue("@position", position);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }

        public void AddShiftPreferencesToDB(string userName, string shift)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO `shiftpreference` (userName, shift) VALUES(@userName, @shift)";


                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@shift", shift);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }

        public string GetPreferences(string userName)
        {
            string shift = "";

            try
            {   
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT shift FROM shiftpreference WHERE userName = @userName";
                cmd.Parameters.AddWithValue("@userName",userName);
                shift = Convert.ToString(cmd.ExecuteScalar());
                
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }

            return shift;
        }

        public void UpdateShift(string userName, string shift)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE shiftpreference SET shift=@shift WHERE userName = @userName";
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@shift",shift);
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));

            }
            finally
            {
                con.Close();
            }
        }
    }
}