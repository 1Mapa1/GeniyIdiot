using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiotClassLibrary
{
    public class UsersResultStorage
    {
        static readonly string fileName = "userResult3.json";
        public static void Append(User user)
        {
            var userResults = Get();

            userResults.Add(user);

            Save(userResults);
        }

        public static List<User> Get()
        {
            if (!FileWork.Exists(fileName))
            {
                return new List<User>();
            }
            else
            {
                var value = FileWork.GetData(fileName);

                var userResults = JsonConvert.DeserializeObject<List<User>>(value);

                return userResults;
            }
        }

        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileWork.Replace(jsonData, fileName);
        }
    }
}
