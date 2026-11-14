using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_4_DB
{
    internal class LabDatabase
    {
        public static void Main()
        {

            while (true)
            {
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Select");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                string connectionString = "datasource=localhost;port=3306;username=root;password=1234;database=Library";
                MySqlConnection connection = new MySqlConnection(connectionString);

                switch (choice)
                {
                    case 1:


                        Console.Write("Enter Book ID: ");
                        int bookidInsert = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Book Title: ");
                        string titleInsert = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string authorInsert = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        decimal priceInsert = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter Publish Date (yyyy-MM-dd): ");
                        string dateInsert = Console.ReadLine();

                        connection.Open();

                        string insertQuery =
                            "INSERT INTO Books (BookId, BookTitle, Author, Price, PublishDate) VALUES (" +
                            bookidInsert + ", '" +
                            titleInsert + "', '" +
                            authorInsert + "', " +
                            priceInsert + ", '" +
                            dateInsert + "')";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                        cmd.ExecuteNonQuery();


                        Console.WriteLine("Book inserted successfully.");
                        connection.Close();

                        break;



                    case 2:
                        Console.Write("Enter Book ID: ");
                        int bookidUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New Book Title: ");
                        string titleUpdate = Console.ReadLine();

                        Console.Write("Enter New Author: ");
                        string authorUpdate = Console.ReadLine();

                        Console.Write("Enter New Price: ");
                        decimal priceUpdate = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Enter New Publish Date (yyyy-MM-dd): ");
                        string dateUpdate = Console.ReadLine();

                        connection.Open();

                        string updateQuery =
                            "UPDATE Books SET " +
                            "BookTitle='" + titleUpdate + "', " +
                            "Author='" + authorUpdate + "', " +
                            "Price=" + priceUpdate + ", " +
                            "PublishDate='" + dateUpdate + "' " +
                            "WHERE BookId=" + bookidUpdate;

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.ExecuteNonQuery();

                        Console.WriteLine("Book Updated Successfully.");

                        connection.Close();
                        break;

                    case 3:
                        Console.Write("Enter Book ID: ");
                        int bookidDelete = Convert.ToInt32(Console.ReadLine());

                        connection.Open();

                        string deleteQuery =
                            "DELETE FROM Books WHERE BookId=" + bookidDelete;

                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                        deleteCmd.ExecuteNonQuery();

                        Console.WriteLine("Book Deleted Successfully.");

                        connection.Close();
                        break;



                    case 4:

                        connection.Open();

                        string selectQuery = "SELECT * FROM Books";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
                        MySqlDataReader dr = selectCmd.ExecuteReader();

                        Console.WriteLine("\nBook ID\tBook Title\tAuthor\tPrice\tPublish Date");

                        while (dr.Read())
                        {
                            Console.WriteLine(
                                dr["BookId"] + "\t" +
                                dr["BookTitle"] + "\t" +
                                dr["Author"] + "\t" +
                                dr["Price"] + "\t" +
                                dr["PublishDate"]
                            );
                        }

                        dr.Close();
                        connection.Close();
                        break;




                    case 5:

                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();

                        connection.Open();

                        string searchQuery =
                            "SELECT * FROM Books WHERE BookTitle LIKE '%" + searchTitle + "%'";

                        MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection);
                        MySqlDataReader searchDr = searchCmd.ExecuteReader();

                        Console.WriteLine("\nBook ID\tBook Title\tAuthor\tPrice\tPublish Date");

                        while (searchDr.Read())
                        {
                            Console.WriteLine(
                                searchDr["BookId"] + "\t" +
                                searchDr["BookTitle"] + "\t" +
                                searchDr["Author"] + "\t" +
                                searchDr["Price"] + "\t" +
                                searchDr["PublishDate"]
                            );
                        }

                        searchDr.Close();
                        connection.Close();
                        break;

                    case 6:
                        Console.WriteLine("Program Exited.");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}