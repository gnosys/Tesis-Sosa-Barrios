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


        public List<string[]> GetTokens(string guid)
        {
            queryString = string.Format(@"SELECT [IdTweet],[Text] FROM [Tweets].[dbo].[Token] WHERE [idPipe] = '{0}'",guid);
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<string[]> result = new List<string[]>();
            int currentTweet = 0;
            List<string> currentTweetTokens = new List<string>();
            try
            {
                while (reader.Read())
                {
                    int processingTweet = reader.GetInt32(0);
                    if (currentTweet == 0)
                    {
                        currentTweet = processingTweet;
                    }
                    if(processingTweet != currentTweet)
                    {
                        result.Add(currentTweetTokens.ToArray());
                        currentTweetTokens.Clear();
                        currentTweet = processingTweet;
                    }
                    currentTweetTokens.Add(reader.GetString(1));
                }
                result.Add(currentTweetTokens.ToArray());
            }
            finally
            {
                reader.Close();
                connection.Close();
                command.Dispose();
            }
            return result;
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
            try
            {
                if (connection != null)
                {

                    connection.Dispose();
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    if (connection.State.Equals(ConnectionState.Open))
                    {
                        connection.Close();
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ExistDataTableCategory()
        {
            queryString = string.Format(@"SELECT count(Id) FROM [Tweets].[dbo].[Category]");
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool result = false;
            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) > 0)
                        result = true;
                }
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            command.Dispose();
            return result;
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
                    dato.Id = reader.GetInt32(0);
                    dato.Tweet_Id = reader.GetValue(1).ToString();
                    dato.Author = reader.GetValue(2).ToString();
                    dato.Entity_Id = reader.GetValue(3).ToString();
                    dato.Category = reader.GetValue(4).ToString();
                    dato.Text = reader.GetValue(5).ToString();
                    dato.Id_Category = reader.GetInt32(6);
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
            queryString = string.Format(@"SELECT Max([Level]) FROM [dbo].[Category]");
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            int ret = 0;
            try
            {
                reader.Read();
                ret = reader.GetInt16(0);
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            command.Dispose();
            return ret;
        }

        public List<string> CategoriesSelectedTableTweet(int nivel, ref int amountTweets, ref int amountTweetWithNivels)
        {
            List<string> ret = new List<string>();
            queryString = string.Format(@"SELECT COUNT(t.Id) FROM
                                            (SELECT Id FROM [dbo].[Tweet]) t
                                            JOIN
                                            (SELECT [IdCategory],[IdTweet] FROM .[dbo].[TweetLevelCategory]) tc
                                            ON t.Id = tc.IdTweet
                                            JOIN
                                            (SELECT ID FROM [dbo].[Category] WHERE [Level] = {0}) c
                                            ON c.Id = tc.IdCategory", nivel);

            command = new SqlCommand(queryString, connection);
            connection.Open();
            
            try
            {
                amountTweetWithNivels = int.Parse(command.ExecuteScalar().ToString());
                queryString = @"SELECT COUNT(Id) FROM [dbo].[Tweet]";
                command = new SqlCommand(queryString, connection);
                amountTweets = int.Parse(command.ExecuteScalar().ToString());
                queryString = String.Format(@"SELECT Name from [dbo].[Category] WHERE [Level] = {0}", nivel);
                command = new SqlCommand(queryString, connection);
                
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ret.Add(reader.GetString(0));
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

        public List<Category> CategoriesTableCategory(string nivel)
        {
            List<Category> list = new List<Category>();
            queryString = @"SELECT [Id],[Name] FROM [dbo].[Category] WHERE [Level] = " + nivel;
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
                                            ON c.Id = tc.IdCategory ORDER BY IdCategory", level);

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
                        Id_Category = reader.GetInt32(2)
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


        public string SavePreprocessingTokens(List<Tweet> tweets, List<string[]> TFIDFInput)
        {
            try
            {
                connection.Open();
                string guid = Guid.NewGuid().ToString();
                StringBuilder builder = new StringBuilder();
                int mod = 0;
                int tweetIndex = 0;
                foreach (var tweet in tweets)
                {
                    foreach (string token in TFIDFInput.ElementAt(tweetIndex))
                    {
                        builder.AppendLine(String.Format(@"INSERT INTO [dbo].[Token]([Text],[idPipe],[idTweet]) VALUES ('{0}','{1}','{2}')", token, guid, tweet.Id));
                        ++mod;
                        if (mod == 2000)
                        {
                            mod = ExecuteBatch(mod, builder);
                        }
                    }
                    ++tweetIndex;
                }
                mod = ExecuteBatch(mod, builder);
                return guid;
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
            
        }

        public bool ExistTokens(string guid)
        {
            queryString = string.Format(@"SELECT Count(Id) FROM [dbo].[Token] WHERE IdPipe = '{0}'", guid);
            command = new SqlCommand(queryString, connection);
            connection.Open();
            reader = command.ExecuteReader();
            int count = 0;
            try
            {
                reader.Read();
                count = reader.GetInt32(0);
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
            command.Dispose();
            return count > 0;
        }
    }
}
