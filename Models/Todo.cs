namespace Todo.Models;
public class Todo
{
    //Creator, author
    //title | lable
    //content | main
    //time
    //isDone

    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime Time { get; set; }

    public bool isDone { get; set; }

    public int Id { get; set; }

}