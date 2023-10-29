using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ToDoList
{
    public class Task
    {
        [BsonId]
        private ObjectId Id { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime DueDate { get; set; }
        private int Status { get; set; }

        public Task(string title, string description, DateTime dueDate, int status)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;
        }

        public void MarkAsCompleted()
        {
            Status = 2;
        }

        public void MarkAsTodo()
        {
            Status = 0;
        }

        public void MarkAsInProgress()
        {
            Status = 1;
        }
    }
}
