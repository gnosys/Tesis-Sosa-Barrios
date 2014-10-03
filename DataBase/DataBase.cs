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
        public static string connectionString;
        protected string queryString;
        protected SqlConnection connection = null;
        protected SqlCommand command = null;
        protected SqlDataReader reader = null;

        public static DataBase Instance 
        {
            get {
                if (_instance == null)
                    _instance = new DataBase(connectionString);
                return _instance;
            }
        }

        private static DataBase _instance = null;

        private DataBase(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
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
                    dato.Id = reader.GetInt32(0);
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
            queryString = string.Format(@"SELECT {0} {1} * FROM [Tweets].[dbo].[Tweet]", cantTuplas == 0 ? String.Empty : "TOP", cantTuplas == 0 ? String.Empty : cantTuplas.ToString());
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Tweet dato = new Tweet();
                    //dato.Id = reader.GetValue(0).ToString();
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
                    dato.Id = reader.GetInt32(0);
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
            queryString = @"SELECT [Id],[Category] FROM [dbo].[Tweet]";
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
    

        ////////////////////////////////////
        public List<Tweet> GetTweetsForClassify(int level)
        {
            List<Tweet> ret = new List<Tweet>();
            queryString = string.Format(@"SELECT t.Id,t.[Text],tc.IdCategory FROM
                                            (SELECT Id,[text] FROM [dbo].[Tweet]) t
                                            JOIN
                                            (SELECT [IdCategory],[IdTweet] FROM .[dbo].[TweetLevelCategory]) tc
                                            ON t.Id = tc.IdTweet
                                            JOIN
                                            (SELECT ID FROM [dbo].[Category] WHERE [Level] = {0}) c
                                            ON c.Id = tc.IdCategory", level);

            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    ret.Add(new Tweet()
                    {
                        Id = reader.GetInt32(0),
                        Text = reader.GetValue(1).ToString(),
                        Id_Category = reader.GetValue(2).ToString()
                    });
                }
            }
            finally
            {
                reader.Close();
                connection.Close();
                command.Dispose();
            }
            return ret;
        }


        public void RePopulateCategories()
        {
            var d1 = DateTime.Now;
            command = new SqlCommand(queryString, connection);
            connection.Open();
            try
            {
                //repopulate categories
                queryString = @"SELECT Id,Category FROM [dbo].[Tweet]";
                command = new SqlCommand(queryString, connection);
                reader = command.ExecuteReader();
                List<Tweet> tweets = new List<Tweet>();
                while (reader.Read())
                {
                    tweets.Add(new Tweet()
                    {
                        Id = reader.GetInt32(0),
                        Category = reader.GetString(1)
                    });
                }
                reader.Close();

                int countCategories = 0;
                List<Category> categories = new List<Category>();
                List<TweetLevelCategory> tweetLevelCategories = new List<TweetLevelCategory>();
                foreach (var tweet in tweets)
                {
                    int level = 1;
                    string[] splittedCategories = tweet.Category.Split('/');
                    foreach (string category in splittedCategories)
                    {
                        Category cat = categories.FirstOrDefault(c => c.Name == category && c.Level == level);
                        if (cat == null)
                        {
                            countCategories++;
                            cat = new Category()
                            {
                                Id = countCategories,
                                Name = category,
                                Level = level
                            };
                            categories.Add(cat);
                        }
                        tweetLevelCategories.Add(new TweetLevelCategory()
                        {
                            IdTweet = tweet.Id,
                            IdCategory=cat.Id
                        });
                        level++;
                    }
                }

                //delete previous data
                queryString = @"DELETE FROM [dbo].[TweetLevelCategory]";
                command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
                queryString = @"DELETE FROM [dbo].[Category]";
                command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();

                //insert new data
                int mod = 0;
                StringBuilder queryBuilder = new StringBuilder();
                foreach (var category in categories)
                {
                    queryBuilder.AppendLine(String.Format(@"INSERT INTO [Tweets].[dbo].[Category] ([Id],[Name],[Level]) VALUES ({0},'{1}',{2})", category.Id, category.Name, category.Level));
                    mod++;
                    if (mod == 100)
                    {
                        mod = ExecuteBatch(mod, queryBuilder);
                    }
                }

                mod = ExecuteBatch(mod, queryBuilder);

                int i = 1;
                foreach (var tweetLevelCategory in tweetLevelCategories)
                {
                    queryBuilder.AppendLine(String.Format(@"INSERT INTO [Tweets].[dbo].[TweetLevelCategory] ([Id], [IdTweet],[IdCategory]) VALUES ({0},{1},{2})", i, tweetLevelCategory.IdTweet, tweetLevelCategory.IdCategory));
                    i++;
                    mod++;
                    if (mod == 2000)
                    {
                        mod = ExecuteBatch(mod, queryBuilder);
                    }
                    
                }
                mod = ExecuteBatch(mod, queryBuilder);
            }
            finally
            {
                reader.Close();
                connection.Close();
                command.Dispose();
            }

        }

        private int ExecuteBatch(int mod, StringBuilder queryBuilder)
        {
            command = new SqlCommand(queryBuilder.ToString(), connection);
            command.ExecuteNonQuery();
            mod = 0;
            queryBuilder.Clear();
            return mod;
        }


        protected string GetIdCorresponding(List<Category> categoriesC, string category)
        {
            string[] parts = category.Split('/');
            foreach (Category c in categoriesC)
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Equals(c.Name))
                        return c.Id.ToString();
                }
            }
            return "NULL";
        }

    }
}
