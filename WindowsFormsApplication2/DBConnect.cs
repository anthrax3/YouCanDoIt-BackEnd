using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private static DBConnect instance;
        private string database;
        private string uid;
        private string password;

            //Constructor
            public DBConnect()
            {
                Initialize();
            }

            public static DBConnect getInstance()
            {
                if (instance == null)
                    instance = new DBConnect();
                return instance;
            }

            //Initialize values
            private void Initialize()
            {
                //server = "10.0.1.153";
                server = "localhost";
                //port = "8889";
                database = "youcandoit";
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "Server=" + server + ";" + //"Port=" + port + ";" +
                    "Database=" + database + ";" + "Uid=" + uid + ";" + "Password=" + password + ";";
                try
                {
                    this.connection = new MySqlConnection(connectionString);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }

                //this.OpenConnection();
            }

            private bool OpenConnection()
            {
                try
                {
                    this.connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            System.Windows.Forms.MessageBox.Show("Cannot connect to server. Contact administrator");
                            break;
                        case 1045:
                            System.Windows.Forms.MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }
            private bool CloseConnection()
            {
                try
                {
                    this.connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }

            //Insert statement
            public bool Insert(string table, Hashtable elements)
            {
                if (this.OpenConnection() == true)
                {
                    string fields = "";
                    string fieldsPreVal = "";

                    foreach (DictionaryEntry entry in elements)
                    {
                        fields += entry.Key + ",";
                        fieldsPreVal += "@" + entry.Key + ",";
                    }
                    fields = fields.Remove(fields.Length - 1); // suppression de la virgule de fin
                    fieldsPreVal = fieldsPreVal.Remove(fieldsPreVal.Length - 1); // suppression de la virgule de fin

                    string insertQuery = "INSERT INTO " + table + "(" + fields + ") VALUES (" + fieldsPreVal + ");";
                    MySqlCommand command = new MySqlCommand(insertQuery, this.connection);
                    foreach (DictionaryEntry entry in elements)
                    {
                        command.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                    }
                    command.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                return false;
            }

            //Update statement
            public bool Update(string query)
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, this.connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                return false;
            }

            //Update statement
            public bool Update(string table, Hashtable elements, string condition)
            {
                if (this.OpenConnection() == true)
                {
                    string setQuery = "";

                    foreach (DictionaryEntry entry in elements)
                    {
                        string value = entry.Value.ToString().Replace("'", "\\'");
                        value = value.Replace("\"", "\\\"");
                        setQuery += "`" + entry.Key + "` = '" + value + "',";
                    }
                    setQuery = setQuery.Remove(setQuery.Length - 1); // suppression de la virgule de fin

                    string updateQuery = "UPDATE " + table + " SET " + setQuery + " WHERE " + condition;
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    foreach (DictionaryEntry entry in elements)
                    {
                        command.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                    }
                    command.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                return false;
            }

            //Delete statement
            public bool Delete(string query)
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, this.connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                return false;
            }

            //Select statement
            public List<Hashtable> Select(string query)
            {
                if (this.OpenConnection() == true)
                {
                    List<Hashtable> rows = new List<Hashtable>();
                    MySqlDataReader reader = null;
                    MySqlCommand cmd = new MySqlCommand(query, this.connection);
                    cmd.ExecuteNonQuery(); //Execute the command
                    reader = cmd.ExecuteReader(); //execure the reader
                    /*The Read() method points to the next record It return false if there are no more records else returns true.*/
                    while (reader.Read())
                    {
                        Hashtable columns = new Hashtable();
                        for (int i = 0; i < reader.FieldCount; i++)
                            columns.Add(reader.GetName(i), reader.GetString(i));
                        rows.Add(columns);
                    }
                    reader.Close();
                    this.CloseConnection();
                    return rows;
                }
                return null;
            }
    }
}