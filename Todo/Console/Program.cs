

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

static void MainMenu()
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
      Console.WriteLine("Visar todos");
      break;
    case "3":
      Environment.Exit(0);
      return;
  }
}

static void AddTodo()
{
  Header();
  Console.Write("Namn: ");
  var name = Console.ReadLine();
  Console.WriteLine();
  Console.Write("Beskrivning: ");
  var desc = Console.ReadLine();

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
        Console.WriteLine("En todo har skapats");
        Console.Write("Tryck ENTER för att komma tillbaka till startsidan");
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