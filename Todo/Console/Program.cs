

using TodoClass;

var todos = new List<Todo>
{
 new Todo(name: "Klappa katten", desc: "På rygg och huvud"),
 new Todo(name: "Diska", desc: "Använd vasken i köket och inte i badrummet"),
 new Todo(name: "Boesta tänderna", desc: "Morgon och kväll"),
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

  while (true)
  {
    switch (menuPick)
    {
      case "1":
        AddTodo();
        return;
      case "2":
        PickTodo();
        return;
      case "3":
        Environment.Exit(0);
        return;
      default:
        Console.WriteLine("Ogiltigt val");
        Console.Write("Välj: ");
        menuPick = Console.ReadLine();
        break;

    }
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

void ShowTodoItem(Todo todo)
{
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

void PickTodo()
{
  Header();
  var pickTodo = new List<(string id, string menuPick, string name)>();

  for (int i = 0; i < todos.Count; i++)
  {
    var pick = (i + 1).ToString();
    pickTodo.Add((id: todos[i].Id, pick, name: todos[i].Name));

    Console.WriteLine($"[{i + 1}] {todos[i].Name}");
  }

  var exitNumber = (todos.Count + 1).ToString();
  Console.ForegroundColor = ConsoleColor.DarkGray;
  Console.WriteLine($"[{exitNumber}] Backa");
  Console.ResetColor();

  Console.WriteLine();
  Console.Write("Välj: ");
  var val = Console.ReadLine();

  while (true)
  {

    if (pickTodo.Any(t => t.menuPick == val))
    {
      Todo todo = todos.Find(t => t.Id == pickTodo.Find(t => t.menuPick == val).id);
      ShowSingleTodo(todo);
      return;
    }
    else if (exitNumber == val)
    {
      MainMenu();
      return;
    }
    else
    {
      Console.WriteLine("Ogiltigt val");
    }

    Console.Write("Välj: ");
    val = Console.ReadLine();
  }
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

void ShowSingleTodo(Todo todo)
{
  Header();
  Console.WriteLine();

  ShowTodoItem(todo);

  var options = new[]
  {
    ("[1] Ändra namn", ConsoleColor.White),
    ("[2] Ändra status", ConsoleColor.White),
    ("[3] Radera todo", ConsoleColor.Red),
    ("[4] Backa", ConsoleColor.DarkGray),
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
        ChangeTodoName(todo);
        return;
      case "2":
        todo.ChangeIsDone();
        ShowSingleTodo(todo);
        return;
      case "3":
        todos.Remove(todo);
        PickTodo();
        return;
      default:
        Console.WriteLine("Ogiltigt val");
        Console.Write("Välj: ");
        val = Console.ReadLine();
        break;
    }
  }
}

void ChangeTodoName(Todo todo)
{
  var options = new[]
  {
    ("[1] Spara ändringar", ConsoleColor.Green),
    ("[2] Avbryt", ConsoleColor.DarkGray),
  };

  Header();
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.DarkGray;
  Console.WriteLine($"Gammalt namn: {todo.Name}");
  Console.ResetColor();
  Console.Write("Ändra namn: ");
  var name = Console.ReadLine();

  Console.WriteLine();
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
        if (name.Length > 0)
        {
          todo.ChangeName(name);
        }
        ShowSingleTodo(todo);
        return;
      case "2":
        ShowSingleTodo(todo);
        return;
      default:
        Console.WriteLine("Ogiltigt val");
        Console.Write("Välj: ");
        val = Console.ReadLine();
        break;
    }
  }
}