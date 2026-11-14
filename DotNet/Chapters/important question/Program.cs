using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connStr = "server=localhost;database=company;uid=root;pwd=1234;";

        MySqlConnection con = new MySqlConnection(connStr);

        try
        {
            con.Open();

            string selectQuery = "SELECT * FROM product WHERE UnitPrice > 1000";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Products with Unit Price > 1000");
            Console.WriteLine("--------------------------------");

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["ProductId"] + "\t" +
                    reader["ProductName"] + "\t" +
                    reader["UnitPrice"]);
            }

            reader.Close();

            string updateQuery = "UPDATE product SET UnitPrice = 4500 WHERE ProductId   = 50";
            MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

            int rows = updateCmd.ExecuteNonQuery();

            Console.WriteLine("\nRows Updated: " + rows);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
}