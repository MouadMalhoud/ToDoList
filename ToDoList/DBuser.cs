using System;
using MongoDB.Driver;

namespace ToDoList
{
    public class DBuser
    {
        private IMongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<User> collection;

        public DBuser()
        {
            client = new MongoClient();//Put your mongodbString
            database = client.GetDatabase("Todolist");
            collection = database.GetCollection<User>("Users");
        }

        public void CreateUser(User user)
        {
            collection.InsertOne(user);
        }

        public User GetUserById(string userId)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Id, userId); 
            return collection.Find(filter).FirstOrDefault();
        }
        public string GetLastUserId()
        {
            var sortDefinition = Builders<User>.Sort.Descending(u => u.Id);
            var lastUser = collection.Find(u => true).Sort(sortDefinition).FirstOrDefault();

            if (lastUser != null)
            {
                return lastUser.Id;
            }
            else
            {
                return "0"; 
            }
        }
    }
}
