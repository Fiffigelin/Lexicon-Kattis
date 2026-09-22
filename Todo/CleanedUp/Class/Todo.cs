namespace Class;

public class Todo
{
  public string Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public bool IsDone { get; set; }

  public Todo(string name, string desc)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Description = desc;
    IsDone = false;
  }

  public void ChangeName(string name)
  {
    Name = name;
  }

  public void ChangeIsDoneStatus()
  {
    IsDone = !IsDone;
  }
}