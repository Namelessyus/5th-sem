    /*
     * ADO: Activex Data Object programming interface to access data in database. 
     * ADO.NET: set of classes that expose daa access services for .NET framework, providing access to relational, xml4 application data.
     * 
     * ADO vs ADO.NET
     * both are technology used to access database but they belong to different generation of microsoft development
     * 
     * 
     * features:    	Ado                     ado.Net
     * introuuced	classic ASP, vb6 era    .Net framework
     * support		VB6, ASP		.Net languages
     * architecture	Connected		disconnected
     * data storage	Record set		data set
     * xml support	liited			built in
     *
     * ADO
     * - Connected Architecture
     * Main Objects:
     * - Connection
     * - Command
     * - Record set
     * - Parameter
     *
     * ADO.NET Architecture
     * 1. Connected Architecture
     * - SQL Connection
     * - SQL Command
     * - SQL Data REader
     * 
     * 2. Disconnected Architecture
     * - SQL DataAdapter
     * - Data SEt
     * - Data Table
     * - SQLConnection -> establish connection to db
     * - SQL Command -> Used to execute SQL queries
     * - Data Reader (Connected Arch) -> Reads data one row at a time while connection remains open
     * - Data ADapter (Disconnected Arch) -> Acts as a bridge between the Database & dataset | datatable
     * 
     * Execute Method: (v.v.IMP)
     * 
     * * execute NanQuery: execute SQL  Command that do not return rows of data such as insert, update, delete
     * * ExecuteReader: execute SQL command that returns a set of row from DB
     * * ExecuteScalar: execute a SQL Command that return a single value
     *
     */


using System;

using MySql.Data.MySqlClient;

namespace Chapter4
{
    class ReadExample
    {
        public static void Main()
        {
            string connectionString = "location=localhost;port=3306;database=bca;uid=root;pwd=password;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = "SELECT * FROM students";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            Console.WriteLine("Database objects created successfully.");
        }
    }
}
