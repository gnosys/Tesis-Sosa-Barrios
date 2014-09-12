using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataBaseSQL
{
    public class DataBase : IDisposable
    {
        public string connectionString;
        protected string queryString;
        protected SqlConnection connection = null;
        protected SqlCommand command = null;
        protected SqlDataReader reader = null;

        public DataBase(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                this.connectionString = connectionString;
            	CuantitativeAnalysis();
            }
            catch
            {
            }
            
        }

        public void Dispose()
        {
            if (connection != null)
                connection.Dispose();
            if (command != null)
                command.Dispose();
            if (reader != null)
                reader.Dispose();
        }

        public bool CheckConnection()
        {
            if (connection != null)
                return true;
            return false;
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
                    list.Add(dato);
                }
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            command.Dispose();
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
            command.Dispose();
            return list;
        }

        public List<string> Texts(int cantTuplas)
        {
            List<string> list = new List<string>();
            queryString = string.Format(@"SELECT TOP {0} [Text] FROM [Tweets].[dbo].[Tweet]", cantTuplas);
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
            command.Dispose();
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
            command.Dispose();
            return list;
        }

        public int GetAmountNiveles()
        {
            int result = -1;
            int resultCategoria = 0;
            List<string> list = AllCategories();
            foreach (string c in list)
            {
                string[] parts = c.Split('/');
                resultCategoria = parts.Length;
                if (result < 0 || resultCategoria < result)
                    result = resultCategoria;
            }
            return result;
        }

        public List<string> CategoriesSelected(int nivel)
        {
            List<string> list = AllCategories();
            List<string> categories = new List<string>();
            foreach (string c in list)
            {
                string[] parts = c.Split('/');
                if (parts.Length >= nivel)
                {
                    if (!categories.Contains(parts[nivel - 1]))
                        categories.Add(parts[nivel - 1]);
                }
            }
            return categories;
        }

        public void CreateCategories(List<string> newCategories)
        {
            int id = 1;
            connection.Open();
            queryString = "";
            foreach (string nc in newCategories)
            {
                queryString += string.Format(@"INSERT INTO [dbo].[Category]([Id],[Name]) VALUES ({0}, '{1}'); ", id++, nc);
            }
            command = new SqlCommand(queryString, connection);
            command.ExecuteReader();
            command.Dispose();
            connection.Close();
        }

        public void ClearTableCategories()
        {
            connection.Open();
            queryString = string.Format(@"DELETE FROM [dbo].[Category]");
            command = new SqlCommand(queryString, connection);
            command.ExecuteReader();
            command.Dispose();
            connection.Close();
        }

        public List<string> AllNewCategories()
        {
            List<string> list = new List<string>();
            queryString = string.Format(@"SELECT [Name] FROM [dbo].[Category]");
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
            command.Dispose();
            return list;
        }

        void CuantitativeAnalysis()
        {
            List<string> list = new List<string>();
            queryString = @"SELECT Text FROM [Tweets].[dbo].[Tweet]";

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
            if (list.Count > 0)
            {
                string pattern = @"(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]";
                Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                
                var numerototaldetweets = list.Count;
                var numerotoaldetweetsConHipervinculos = list.Where(x => reg.IsMatch(x)).Count();
            }
        }
    }
}
