using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar
{
    public class DatabaseHelper
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();


        //public void ApplyHolidaySick(int empNumber, DateTime startDate, DateTime endDate, string employeeMessage, AppType type)
        //{
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();
        //            cmd.CommandText = "INSERT INTO holidaysick (empNumber,startDate,endDate,employeeMessage,appType) VALUES(@empnumber,@startDate,@endDate,@employeeMessage,@type)";
        //            cmd.Parameters.AddWithValue("@empnumber", empNumber);
        //            cmd.Parameters.AddWithValue("@startDate", startDate);
        //            cmd.Parameters.AddWithValue("@endDate", endDate);
        //            cmd.Parameters.AddWithValue("@employeeMessage", employeeMessage);
        //            cmd.Parameters.AddWithValue("@type", type);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
            
            

        //}

        //public void RespondHolidaySick(int appNumber, string managerResponse, AppStatus status)
        //{
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();
        //            cmd.CommandText = "UPDATE holidaysick SET managerResponse = @managerResponse, appStatus = @status WHERE applicationNumber=@appNumber";
        //            cmd.Parameters.AddWithValue("@managerResponse", managerResponse);
        //            cmd.Parameters.AddWithValue("@status", status);
        //            cmd.Parameters.AddWithValue("@appNumber", appNumber);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally  
        //    {
        //        con.Close();
        //    }

            
            
        //}
        //public List<HolidaySick> GetHolidaySick()
        //{
        //    List<HolidaySick> holidays = new List<HolidaySick>();
        //    cmd = con.CreateCommand();
        //    cmd.CommandText = "SELECT * FROM holidaysick";

        //    try
        //    {
        //        con.Open();

        //        using (con)
        //        {
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            using (reader)
        //            {
        //                while (reader.Read())
        //                {
        //                    int appNumber = Convert.ToInt32(reader["applicationNumber"]);
        //                    int empNumber = Convert.ToInt32(reader["empNumber"]);
        //                    DateTime startDate = Convert.ToDateTime(reader["startDate"]);
        //                    DateTime endDate = Convert.ToDateTime(reader["endDate"]);
        //                    string employeeMessage = Convert.ToString(reader["employeeMessage"]);
        //                    string managerResponse = Convert.ToString(reader["managerResponse"]);
        //                    AppStatus appStatus = (AppStatus)Enum.Parse(typeof(AppStatus), reader["appStatus"].ToString());
        //                    AppType appType = (AppType)Enum.Parse(typeof(AppType), reader["appType"].ToString());

        //                    HolidaySick holidaySick = new HolidaySick(appNumber, empNumber, startDate, endDate, employeeMessage, managerResponse, appStatus, appType);

        //                    holidays.Add(holidaySick);
        //                }                       
                        
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return holidays;


        //}

        public void RequestReshelving(string itemname, int amount, string department, string specifications)
        {
            con.Open();
            using (con)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO reshelving (Name, Amount, Department, Specifications) VALUES(@itemname, @amount, @department, @specifications)";
                cmd.Parameters.AddWithValue("@itemname", itemname);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@specifications", specifications);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void RespondReshelving(int id, AppStatusDTO status)
        {
            con.Open();
            using (con)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE reshelving SET RequestStatus = @status WHERE Id=@id";
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public void ChangeAndAcceptReshelving(int id, int amount, AppStatusDTO status)
        {
            con.Open();
            using (con)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE reshelving SET Amount = @amount, RequestStatus = @status WHERE Id=@id";
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public List<ReshelvingDTO> GetReshelvingRequests()
        {
            List<ReshelvingDTO> reshelvings = new List<ReshelvingDTO>();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM reshelving";

            con.Open();

            using (con)
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string itemname = Convert.ToString(reader["Name"]);
                        int amount = Convert.ToInt32(reader["Amount"]);
                        string department = Convert.ToString(reader["Department"]);
                        string specifications = Convert.ToString(reader["Specifications"]);
                        AppStatusDTO status = (AppStatusDTO)Enum.Parse(typeof(AppStatusDTO), reader["RequestStatus"].ToString());

                        ReshelvingDTO reshelving = new ReshelvingDTO(id, itemname, amount, department, specifications, status);

                        reshelvings.Add(reshelving);
                    }
                    con.Close();
                    return reshelvings;
                }
            }
            
        }
    }
}
