using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using PublishingApp.Models;

namespace PublishingApp
{
    public class DatabaseHelper : IDisposable
    {
        private string connectionString = @"Data Source=IDEAPADS145\SQLEXPRESS;Initial Catalog=publishing;Integrated Security=True;Connect Timeout=30";

        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT p.ID, p.Name, p.AuthorID, 
                           a.Name + ' ' + a.Surname as AuthorName,
                           p.ReleaseYear, p.VolumeOfSheets, p.Circulation
                    FROM Publications p
                    LEFT JOIN Authors a ON p.AuthorID = a.ID
                    ORDER BY p.Name";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            AuthorId = reader["AuthorID"] != DBNull.Value ? (int)reader["AuthorID"] : 0,
                            AuthorName = reader["AuthorName"].ToString(),
                            ReleaseYear = (int)reader["ReleaseYear"],
                            VolumeOfSheets = (int)reader["VolumeOfSheets"],
                            Circulation = (int)reader["Circulation"]
                        });
                    }
                }
            }

            return books;
        }

        public List<Office> GetOffices()
        {
            var offices = new List<Office>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Name, Address, PhoneNumber FROM Offices ORDER BY Name";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        offices.Add(new Office
                        {
                            Id = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phone = reader["PhoneNumber"].ToString()
                        });
                    }
                }
            }

            return offices;
        }

        public int CreateOrder(Order order)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO Orders (ProductTypeID, PublicationID, OfficeID, CustomerID, 
                                        AdmissionDate, CompletionDate, Price)
                    VALUES (1, @Publication, @Office, @Customer, 
                            @DateOfAdmission, @DateOfCompletion, @Price);
                    SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Publication", order.BookId);
                    command.Parameters.AddWithValue("@Office", order.OfficeId);
                    command.Parameters.AddWithValue("@Customer", order.CustomerId);
                    command.Parameters.AddWithValue("@DateOfAdmission", order.OrderDate);

                    if (order.CompletionDate != string.Empty)
                        command.Parameters.AddWithValue("@DateOfCompletion", order.CompletionDate);
                    else
                        command.Parameters.AddWithValue("@DateOfCompletion", DBNull.Value);

                    command.Parameters.AddWithValue("@Price", order.Price);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public int CreateCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO Customers (Name, CustomerTypeID, Address, PhoneNumber)
                    VALUES (@Name, 1, @Address, @Phone);
                    SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Address",
                        string.IsNullOrEmpty(customer.Address) ? (object)DBNull.Value : customer.Address);
                    command.Parameters.AddWithValue("@Phone",
                        string.IsNullOrEmpty(customer.Phone) ? (object)DBNull.Value : customer.Phone);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public Order GetOrderDetails(int orderId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT o.ID, o.AdmissionDate, 
                           o.Price, p.Name as BookTitle, c.Name as CustomerName,
                           ofc.Name as OfficeName
                    FROM Orders o
                    LEFT JOIN Publications p ON o.PublicationID = p.ID
                    LEFT JOIN Customers c ON o.CustomerID = c.ID
                    LEFT JOIN Offices ofc ON o.OfficeID = ofc.ID
                    WHERE o.ID = @OrderId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Order
                            {
                                Id = (int)reader["ID"],
                                BookTitle = reader["BookTitle"].ToString(),
                                CustomerName = reader["CustomerName"].ToString(),
                                OfficeName = reader["OfficeName"].ToString(),
                                OrderDate = (DateTime)reader["AdmissionDate"],
                                Price = (decimal)reader["Price"]
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection test failed: {ex.Message}");
                return false;
            }
        }

        public void Dispose()
        {
        }
    }
}
