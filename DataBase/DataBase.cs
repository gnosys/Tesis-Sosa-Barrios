using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQL
{
    public class DataBase
    {
        public string connectionString;
        protected string queryString;
        protected SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataReader reader;

        public DataBase()
        {
            connectionString = (@"Data Source=MATI-PC\SQLEXPRESS;Initial Catalog=Tweets;Integrated Security=True");
            connection = new SqlConnection(connectionString);
        }

        public List<Tweet> Search(int cantTuplas)
        {
            List<Tweet> list = new List<Tweet>();
            queryString = string.Format(@"SELECT TOP {0} * FROM [Tweets].[dbo].[Tweet]", cantTuplas);
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Tweet dato = new Tweet();
                    dato.Id = reader.GetValue(0).ToString();
                    dato.Tweet_Id = reader.GetValue(1).ToString();
                    dato.Author = reader.GetValue(2).ToString();
                    dato.Entity_Id = reader.GetValue(3).ToString();
                    dato.Category = reader.GetValue(4).ToString();
                    dato.Text = reader.GetValue(5).ToString();
                    dato.Id_Category = reader.GetValue(6).ToString();
                    list.Add(dato);
                }
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            return list;
        }

        public List<string> Categories(int cantTuplas)
        {
            List<string> list = new List<string>();
            queryString = string.Format(@"SELECT TOP {0} [Category] FROM [Tweets].[dbo].[Tweet]", cantTuplas);
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            return list;
        }

        public List<string> AllCategories()
        {
            List<string> list = new List<string>();
            queryString = string.Format(@"SELECT [Category] FROM [Tweets].[dbo].[Tweet]");
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            return list;
        }
    }
}
