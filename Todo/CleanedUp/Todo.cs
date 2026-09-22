public class Todo
{
  private string Name { get; set; }
  private string Description { get; set; }
  private bool IsDone { get; set; }

  public Todo(string name, string desc)
  {
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