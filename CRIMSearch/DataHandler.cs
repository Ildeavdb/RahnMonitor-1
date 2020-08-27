using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace RahnMonitor
{
    public class DataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder(); //Creates a new Connection to SQL Database

        //Declare the datahandler
        public DataHandler()
        {
            connection.DataSource = @"RAMBOPC\SQL2016";
            connection.InitialCatalog = "RahnDb";
            connection.IntegratedSecurity = true;
        }

        public DataSet ReadData(string tableName) //Represents an in memory cache of the data
        {
            DataSet dataSet = new DataSet(tableName.ToString());

            using (SqlConnection con = new SqlConnection(connection.ToString()))
            {
                //Initializez a new instance of the SQL Adapter Class
                SqlDataAdapter adapter = new SqlDataAdapter();
                //Gets a collection that provides the master mapping between the source table and the DataTable
                adapter.TableMappings.Add("Table", tableName.ToString());
                //Opens a connection to the database
                con.Open();
                //Initializes a new SQLCommand with the Text of the query that selects all the data from the table puts it into string value.
                SqlCommand command = new SqlCommand(string.Format("SELECT * FROM {0}", tableName.ToString()), con);
                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;
                //Add the rows of data to a table
                adapter.Fill(dataSet);
                //Closes the connection to the database
                con.Close();
            }
            //returns with the dataset
            return dataSet;
        }
    }
}
