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

        public List<Tweet> SearchTweets(int cantTuplas)
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

        public List<Tweet> SearchTweetsUpdates(int cantTuplas)
        {
            List<Tweet> list = new List<Tweet>();
            queryString = string.Format(@"SELECT {0} {1} * FROM [Tweets].[dbo].[Tweet] WHERE [Id_Category] is not null", cantTuplas == 0 ? String.Empty : "TOP", cantTuplas == 0 ? String.Empty : cantTuplas.ToString());
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
            command.Dispose();
            return list;
        }

        public List<string> CategoriesTableTweet(int cantTuplas)
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

        public List<string> TextsTableTweet(int cantTuplas)
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

        public List<string> CategoriesTableTweet()
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

        public int GetAmountNivelesTableTweet()
        {
            int result = -1;
            int resultCategoria = 0;
            List<string> list = CategoriesTableTweet();
            string[] parts;
            foreach (string c in list)
            {
                parts = c.Split('/');
                resultCategoria = parts.Length;
                if (result < 0 || resultCategoria > result)
                    result = resultCategoria;
            }
            return result;
        }

        public List<string> CategoriesSelectedTableTweet(int nivel, ref int amountTweets, ref int amountTweetWithNivels)
        {
            List<string> list = CategoriesTableTweet();
            amountTweets = list.Count;
            List<string> categories = new List<string>();
            foreach (string c in list)
            {
                string[] parts = c.Split('/');
                if (parts.Length >= nivel)
                {
                    amountTweetWithNivels++;
                    if (!categories.Contains(parts[nivel - 1]))
                        categories.Add(parts[nivel - 1]);
                }
            }
            return categories;
        }

        public void CreateCategoriesTableCategory(List<string> newCategories)
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

        public void ClearTableCategory()
        {
            connection.Open();
            queryString = string.Format(@"DELETE FROM [dbo].[Category]");
            command = new SqlCommand(queryString, connection);
            command.ExecuteReader();
            command.Dispose();
            connection.Close();
        }

        public List<Category> CategoriesTableCategory()
        {
            List<Category> list = new List<Category>();
            queryString = string.Format(@"SELECT [Id],[Name] FROM [dbo].[Category]");
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Category dato = new Category();
                    dato.Id = reader.GetValue(0).ToString();
                    dato.Name = reader.GetValue(1).ToString();
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

        public List<string> GetIdAndCategoryTableTweet(int nivel)
        {
            List<string> list = new List<string>();
            queryString = string.Format(@"SELECT [Id],[Category] FROM [dbo].[Tweet]");
            command = new SqlCommand(queryString, connection);
            connection.Open();
            string[] parts;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    parts = reader[1].ToString().Split('/');
                    if (parts.Length >= nivel)
                    {
                        list.Add(reader[0].ToString());
                        list.Add(reader[1].ToString());
                    }
                    
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

        protected string GetIdCorresponding(List<Category> categoriesC, string category)
        {
            string[] parts = category.Split('/');
            foreach (Category c in categoriesC)
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Equals(c.Name))
                        return c.Id;
                }
            }
            return "NULL";
        }

        public void ClearIdCategoryTableTweet()
        {
            connection.Open();
            queryString = string.Format(@"UPDATE [dbo].[Tweet] SET [Id_Category] = NULL");
            command = new SqlCommand(queryString, connection);
            command.ExecuteReader();
            command.Dispose();
            connection.Close();
        }

        public void AddIdCategoriesTableTweets(int nivel)
        {
            List<Category> categoriesC = CategoriesTableCategory();
            List<string> idAndCategoriesT = GetIdAndCategoryTableTweet(nivel);
            int querysInString = 0;
            for (int i = 0; i < idAndCategoriesT.Count; i = i + 2)
            {
                if (querysInString < 10000)
                {
                    queryString += string.Format(@"UPDATE [dbo].[Tweet] SET [Id_Category] = {0} WHERE [Id] = {1}; ", GetIdCorresponding(categoriesC, idAndCategoriesT.ElementAt(i + 1)), idAndCategoriesT.ElementAt(i));
                    querysInString++;
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand(queryString, connection);
                    command.ExecuteReader();
                    command.Dispose();
                    connection.Close();
                    queryString = string.Format(@"UPDATE [dbo].[Tweet] SET [Id_Category] = {0} WHERE [Id] = {1}; ", GetIdCorresponding(categoriesC, idAndCategoriesT.ElementAt(i + 1)), idAndCategoriesT.ElementAt(i));
                    querysInString = 1;
                }
            }
            connection.Open();
            command = new SqlCommand(queryString, connection);
            command.ExecuteReader();
            command.Dispose();
            connection.Close();
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

        public List<string[]> GetCurrentTokens()
        {
            throw new NotImplementedException();
        }
    
    }
}
