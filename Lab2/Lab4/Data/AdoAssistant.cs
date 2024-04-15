using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Lab4.Data;

public class AdoAssistant
{
    private string connectionString = ConfigurationManager.ConnectionStrings["connectionString_ADO"].ConnectionString;

    public DataTable TableLoad()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM products";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
        }

        return dt;
    }

    // Метод для виконання SQL-запита, що не повертає результат
    private void ExecuteNonQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Відкриваємо з'єднання
            connection.Open();

            // Створюємо команду SQL
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Виконуємо команду
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                catch (Exception ex)
                {
                    // Обробка помилки, наприклад, виведення її на консоль або логування
                    MessageBox.Show($"Error : {ex.Message}");
                }
                finally
                {
                    // Закриваємо підключення у блоку finally, щоб гарантувати його виконання
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }
    }

    // Метод для додавання запису в базу даних
    public void AddRecord(string article, string name, string unitOfMeasure, int quantity, float price)
    {
        string query =
            $"INSERT INTO products (article, name, unit_of_measure, quantity, price) VALUES ('{article}', '{name}', '{unitOfMeasure}', {quantity}, {price})";
        ExecuteNonQuery(query);
    }

    // Метод для оновлення запису в базі даних
    public void UpdateRecord(string article, string name, string unitOfMeasure, int quantity, float price)
    {
        string query =
            $"UPDATE products SET name = '{name}', unit_of_measure = '{unitOfMeasure}', quantity = {quantity}, price = {price.ToString().Replace(',','.')} WHERE article = '{article}'";
        ExecuteNonQuery(query);
    }

    // Метод для видалення запису з бази даних
    public void DeleteRecord(string article)
    {
        string query = $"DELETE FROM products WHERE article = '{article}'";
        ExecuteNonQuery(query);
    }
}