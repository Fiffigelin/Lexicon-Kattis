
using Class;

public class ConsoleUi
{
  public void Header()
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(" ꧁⎝ 𓆩༺");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("TODO");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("༻𓆪 ⎠꧂");
    Console.WriteLine();
    Console.WriteLine("✩₊˚.⋆☾⋆⁺₊✧ .⋆☾₊✩");
    Console.ResetColor();
  }

  public void ShowTodo(Todo todo)
  {
    if (todo.Id != null)
    {
      Console.WriteLine("Kunde inte visa några todos");
      return;
    }

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("----------------------------");
    Console.ResetColor();
    Console.WriteLine(todo.Name);
    Console.WriteLine(todo.Description);
    ShowTaskStatus(todo.IsDone);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("----------------------------");
    Console.ResetColor();


  }

  void ShowTaskStatus(bool taskStatus)
  {
    if (taskStatus)
    {
      Console.WriteLine("🗹");
    }
    else
    {
      Console.WriteLine("◻");
    }
  }
}