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
    public class ContractDatabase
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();

        public void AddContractToDB(string userName, string startDate, string endDate, string position, string department)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO contract (userName, startDate, endDate, position, department) " +
                        "VALUES(@userName, @startDate, @endDate, @position, @department)";

                    cmd.Parameters.AddWithValue("@contractId","");
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@department", department);



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


        public void EditContractInDB(int contractId,string userName, string startDate, string endDate, string position, string department)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    //cmd.CommandText = "Update contract SET userName = @userName, startDate = @startDate, endDate = @endDate, position = @position, department= @department";
                    cmd.CommandText = "Update contract SET userName = @userName, startDate = @startDate, endDate = @endDate, position = @position, department= @department WHERE contractId = @contractId";

                    cmd.Parameters.AddWithValue("@contractId",contractId);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@department", department);



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
        public void GetAllContractsFromDB(List<ContractDTO> contractDTOs)
        {
            contractDTOs.Clear();

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM contract";

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
                            int contractId = Convert.ToInt32(reader["contractId"]);
                            string userName = Convert.ToString(reader["userName"]);
                            string startDate = Convert.ToString(reader["startDate"]);
                            string endDate = Convert.ToString(reader["endDate"]);
                            string position = Convert.ToString(reader["position"]);
                            string department = Convert.ToString(reader["department"]);


                            contractDTOs.Add(new ContractDTO(contractId, userName, startDate, endDate, position, department));
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

    }
}
