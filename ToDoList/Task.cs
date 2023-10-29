using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ToDoList
{
    public class Task
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public string UserId { get; set; } 

        public Task(string title, string description, DateTime dueDate, int status, string userId)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;
            UserId = userId; 
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
