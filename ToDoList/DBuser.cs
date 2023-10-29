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
            client = new MongoClient("mongodb+srv://admo:admo123@cluster0.xsbj1aa.mongodb.net/Todolist?retryWrites=true&w=majority");//Put your mongodbString
            database = client.GetDatabase("Todolist");
            collection = database.GetCollection<User>("Users");
        }
        public void AddTask(string userId, Task task)
        {
            IMongoCollection<Task> taskCollection = database.GetCollection<Task>("Tasks");

            taskCollection.InsertOne(task);

            var filter = Builders<User>.Filter.Eq(u => u.Id, userId);
            var update = Builders<User>.Update.Push(u => u.Tasks, task);
            collection.UpdateOne(filter, update);
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
        public User GetUserByUsername(string username)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Username, username);
            return collection.Find(filter).FirstOrDefault();
        }
    }
    
   
}
