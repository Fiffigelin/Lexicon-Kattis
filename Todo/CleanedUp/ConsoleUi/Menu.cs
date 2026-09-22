using Class;

public class Menu()
{
  public void MenuHandler(List<(string id, string value, Action action)> options)
  {
    foreach (var op in options)
    {
      if (op.id == "E")
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[{op.id}] {op.value}");
        Console.ResetColor();
      }
      else if (op.id == "S")
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[{op.id}] {op.value}");
        Console.ResetColor();
      }
      else if (op.id == "B" || op.id == "A")
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"[{op.id}] {op.value}");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"[{op.id}] {op.value}");
      }
    }

    PickChoice(options);
  }

  public void PickChoice(List<(string id, string value, Action action)> options)
  {
    Console.WriteLine();
    Console.Write("Välj: ");
    var pick = Console.ReadLine();

    var option = options.FirstOrDefault(o => o.id == pick?.ToUpper());
    while (true)
    {
      if (option.id != null)
      {
        option.action();
        return;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Något gick fel");
        Console.ResetColor();
        Console.Write("Välj :");
        pick = Console.ReadLine();
        break;
      }
    }
  }

  public void Logging()
  {
    Console.WriteLine("Gör något");
  }
}