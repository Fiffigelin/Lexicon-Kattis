

using TodoClass;

var todos = new List<Todo>
{
 new Todo(name: "Klappa katten", desc: "På rygg och huvud"),
 new Todo(name: "Diska", desc: "Använd vasken i köket och inte i badrummet"),
 new Todo(name: "Diska", desc: "Använd vasken i köket och inte i badrummet"),
};
MainMenu();
Console.ReadLine();

static void Header()
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

void MainMenu()
{
  Header();
  var options = new[]
  {
     ("[1] Lägg till todo", ConsoleColor.White),
     ("[2] Visa todos", ConsoleColor.White),
     ("[3] Avsluta", ConsoleColor.Red)
  };

  foreach (var (op, color) in options)
  {
    Console.ForegroundColor = color;
    Console.WriteLine(op);
    Console.ResetColor();
  }

  Console.WriteLine();
  Console.Write("Välj: ");
  var menuPick = Console.ReadLine();

  switch (menuPick)
  {
    case "1":
      AddTodo();
      break;
    case "2":
      ShowTodos();
      break;
    case "3":
      Environment.Exit(0);
      return;
  }
}

void AddTodo()
{
  Header();
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.DarkGray;
  Console.WriteLine(" Skapa ny todo");
  Console.ResetColor();

  Console.Write("Namn: ");
  var name = Console.ReadLine();
  Console.Write("Beskrivning: ");
  var desc = Console.ReadLine();
  Console.WriteLine();

  var options = new[]
  {
   ("[1] Spara", ConsoleColor.Green),
  ("[2] Backa", ConsoleColor.DarkGray),
  };

  foreach (var (op, color) in options)
  {
    Console.ForegroundColor = color;
    Console.WriteLine(op);
    Console.ResetColor();
  }
  Console.WriteLine();

  Console.Write("Välj: ");
  var val = Console.ReadLine();

  while (true)
  {
    switch (val)
    {
      case "1":
        var todo = new Todo(name: name, desc: desc);
        todos.Add(todo);
        Console.WriteLine("En todo har skapats");
        Console.Write("Tryck ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("ENTER ");
        Console.ResetColor();
        Console.Write("för att komma tillbaka till startsidan");
        Console.ReadLine();
        MainMenu();
        return;
      case "2":
        MainMenu();
        return;
      default:
        Console.WriteLine("Ogiltigt val");
        Console.Write("Välj: ");
        val = Console.ReadLine();
        break;
    }
  }
}

void ShowTodos()
{
  Header();

  foreach (Todo todo in todos)
  {
    BorderLine();
    Console.WriteLine(todo.Name);
    Console.WriteLine(todo.Description);
    ShowTaskStatus(todo.IsDone);
    BorderLine();
  }

  var options = new[]
  {
    ("[1] Öppna todo", ConsoleColor.White),
    ("[2] Backa", ConsoleColor.DarkGray),
  };

  foreach (var (op, color) in options)
  {
    Console.ForegroundColor = color;
    Console.WriteLine(op);
    Console.ResetColor();
  }

  Console.WriteLine();
  Console.Write("Välj: ");
  var val = Console.ReadLine();

  while (true)
  {
    switch (val)
    {
      case "1":
        // Skapa en funktion som visar alla val.
        break;
      case "2":
        MainMenu();
        return;
      default:
        Console.WriteLine("Ogiltigt val");
        Console.Write("Välj: ");
        val = Console.ReadLine();
        break;
    }
  }
}

void BorderLine()
{
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