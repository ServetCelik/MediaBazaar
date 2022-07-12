using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;


namespace DatabaseLayer
{
    public class scheduleDB
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();



        public void GetSchedule(string date, string department, List<weekScheduleDTO> schedules)
        {
            schedules.Clear();

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM weekschedule WHERE startDate = @date having department = @department order by shift";

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@department", department);
            try
            {
                con.Open();

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string shift = Convert.ToString(reader["shift"]);
                            string dateFor = Convert.ToString(reader["startDate"]);

                            string mon = Convert.ToString(reader["monday"]);
                            string tue = Convert.ToString(reader["tuesday"]);
                            string wed = Convert.ToString(reader["wednesday"]);
                            string thu = Convert.ToString(reader["thursday"]);
                            string fri = Convert.ToString(reader["friday"]);
                            string sat = Convert.ToString(reader["saturday"]);
                            string sun = Convert.ToString(reader["sunday"]);

                            schedules.Add(new weekScheduleDTO(id, shift, department, dateFor, mon, tue, wed, thu, fri, sat, sun));
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

        public void uploadShift(List<weekScheduleDTO> schedules)
        {

            try
            {
                con.Open();
                using (con)
                {
                    foreach (weekScheduleDTO w in schedules)
                    {
                        cmd = con.CreateCommand();

                        //cmd.CommandText = "UPDATE weekschedule SET @day = '@name' WHERE `weekschedule`.`id` = @id;";
                        cmd.CommandText = "UPDATE weekschedule SET monday = @mon, tuesday = @tue, wednesday = @wed, " +
                            "thursday = @thu, friday = @fri, saturday = @sat, sunday = @sun WHERE weekschedule.id = @id;";

                        cmd.Parameters.AddWithValue("@mon", w.Monday);
                        cmd.Parameters.AddWithValue("@tue", w.Tuesday);
                        cmd.Parameters.AddWithValue("@wed", w.Wednesday);
                        cmd.Parameters.AddWithValue("@thu", w.Thursday);
                        cmd.Parameters.AddWithValue("@fri", w.Friday);
                        cmd.Parameters.AddWithValue("@sat", w.Saturday);
                        cmd.Parameters.AddWithValue("@sun", w.Sunday);
                        cmd.Parameters.AddWithValue("@id", w.id);

                        cmd.ExecuteNonQuery();
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

        public void uploadEmptySchedule(List<weekScheduleDTO> schedules)
        {
            try
            {
                con.Open();

                using (con)
                {
                    foreach (weekScheduleDTO w in schedules)
                    {
                        cmd = con.CreateCommand();

                        cmd.CommandText = "INSERT INTO `weekschedule` (`startDate`, `shift`, `department`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`) " +
                            "VALUES (@date, @shift, @department, '', '', '', '', '', '', '');";

                        cmd.Parameters.AddWithValue("@date", w.date);
                        cmd.Parameters.AddWithValue("@shift", w.shift);
                        cmd.Parameters.AddWithValue("@department", w.department);

                        cmd.ExecuteNonQuery();
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

        public int checkConsecutiveShift(string name, string day, string date)
        {
            int shifts = 0;
            try
            {
                con.Open();

                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT count(@day) AS totalShift FROM weekschedule where @day = @name AND startDate = @date;";

                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);

                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            shifts = Convert.ToInt32(reader["totalShift"]);
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
            return shifts;
        }

    }
}
