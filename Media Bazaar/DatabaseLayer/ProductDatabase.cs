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
    public class ProductDatabase
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();

        public void CreateProduct(string name, double purchasePrice, double sellPrice,string manufacturer, string storageLocation, string description)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    //int id, string name, double purchasePrice, double sellPrice, int quantity, string manufacturer, string storageLocation, string description
                    cmd.CommandText = "INSERT INTO product (name,purchasePrice,sellPrice,manufacturer,storageLocation,description) VALUES(@name,@purchasePrice,@sellPrice,@manufacturer,@storageLocation,@description)";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("@sellPrice", sellPrice);
                    cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                    cmd.Parameters.AddWithValue("@storageLocation", storageLocation);
                    cmd.Parameters.AddWithValue("@description", description);                  


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

        public void getAllProducts(List<ProductDTO> productDTOs)
        {
            productDTOs.Clear();

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM product";

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
                            string name = Convert.ToString(reader["name"]);
                            double purchasePrice = Convert.ToDouble(reader["purchasePrice"]);
                            double sellPrice = Convert.ToDouble(reader["sellPrice"]);
                            int quantity = Convert.ToInt32(reader["quantity"]);
                            string manufacturer = Convert.ToString(reader["manufacturer"]);
                            string storageLocation = Convert.ToString(reader["storageLocation"]);
                            string description = Convert.ToString(reader["description"]);
                            bool isDeleted = Convert.ToBoolean(reader["isDeleted"]);


                            productDTOs.Add(new ProductDTO(id, name, purchasePrice,sellPrice, quantity,manufacturer,storageLocation,description,isDeleted));
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

        public void UpdateProduct(int id, string name, double purchasePrice, double sellPrice, string manufacturer, string storageLocation, string description)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE product SET name = @name, purchasePrice = @purchasePrice, sellPrice = @sellPrice, manufacturer = @manufacturer, storageLocation = @storageLocation, description = @description WHERE id =@id ";

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("@sellPrice", sellPrice);
                    cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                    cmd.Parameters.AddWithValue("@storageLocation", storageLocation);
                    cmd.Parameters.AddWithValue("@description", description);

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

        public void IncreaseProduct(int id, int quantity)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE product SET quantity = quantity + @quantity  WHERE id =@id ";

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

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

        public void DecreaseProduct(int id, int quantity)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE product SET quantity = quantity - @quantity  WHERE id =@id ";

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

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


        public void DeleteProduct(int id)
        {
            try
            {
                con.Open();
                using (con)
                {
                    //cmd = con.CreateCommand();

                    //cmd.CommandText = "DELETE FROM product WHERE id =@id ";

                    //cmd.Parameters.AddWithValue("@id", id);

                    //cmd.ExecuteNonQuery();

                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE product SET isDeleted = 1 WHERE id =@id ";

                    cmd.Parameters.AddWithValue("@id", id);

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

    }
}
