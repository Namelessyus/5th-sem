using System;
using MySql.Data.MySqlClient;

class LinqStudent
{  
    public string Name { get; set; }
    public string Address { get; set; }
    public float balance { get; set; }

    public LinqStudent( string name, string address, float balance)
    {
        this.Name = name;
        this.Address = address;
        this.balance = balance;
    }

}

class q1
{
    static void Main()
    {
        List<LinqStudent> students = new List<LinqStudent>
        {
            new LinqStudent( "nihal", "ktm", 1500.0f),
            new LinqStudent( "nilam", "pok", 800.0f),
            new LinqStudent( "nonna", "bir", 1200.0f),
            new LinqStudent( "nischal", "janakpur", 500.0f)
        };

        string connStr = "server=localhost;database=bank;uid=root;pwd=1234;";

        MySqlConnection con = new MySqlConnection(connStr);

        try
        {
            con.Open();

            foreach(LinqStudent student in students)
            {
                string query = $"INSERT INTO customer_record( Name, Address, balance) VALUES ('{student.Name}', '{student.Address}', {student.balance})";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Data inserted Sucessfully");
            con.Close();
        }
    }
}