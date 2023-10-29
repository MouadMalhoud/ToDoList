using System;

public class Task
{
    private string title { get; set; }
    private string description { get; set; }
    private DateTime dueDate { get; set; }
    private int status { get; set; }

    public Task(string _title, string _description, DateTime _dueDate, int _status)
    {
        title = _title;
        description = _description;
        dueDate = _dueDate;
        status = _status;
    }

    public void MarkAsCompleted()
    {
        status = 2;
    }

    public void MarkAsTodo()
    {
        status = 0;
    }

    public void MarkAsInProgress()
    {
        status = 1; 
    }


}