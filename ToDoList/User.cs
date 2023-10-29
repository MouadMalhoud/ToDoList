using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ToDoList
{
    public class User
    {
        [BsonId]
        private string _id;
        private string _username;
        private string _email;
        private DateTime _dateJoined;
        private string _password;
        public List<Task> Tasks { get; set; } 


        [BsonElement("Id")] 
        public string Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Username
        {
            get => _username;
            private set => _username = value;
        }

        public string Email
        {
            get => _email;
            private set => _email = value;
        }

        public DateTime DateJoined
        {
            get => _dateJoined;
            private set => _dateJoined = value;
        }

        public string Password
        {
            get => _password;
            private set => _password = value;
        }

        public User(string id, string username, string email, DateTime dateJoined, string password)
        {
            Id = id;
            Username = username;
            Email = email;
            DateJoined = dateJoined;
            Password = password;
            Tasks = new List<Task>(); 
        }
        public override string ToString()
        {
            return Id +" "+ Username +" "+ Email +" "+ DateJoined +" "+ Password;
        }
    }
}
