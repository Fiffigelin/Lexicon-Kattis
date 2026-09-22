using Class;

public class TodoContent(Menu menu, ConsoleUi console, List<Todo> todos)
{
  public void MainPage()
  {
    List<(string id, string value, Action action)> options = new()
      {
        (id: "1", value: "Lägg till ny todo", action: CreateTodo),
        (id: "2", value: "Visa alla todos", action: menu.Logging),
        (id: "E", value: "Avsluta", action: () =>  Environment.Exit(0)),
      };

    console.Header();
    menu.MenuHandler(options);
  }
  public void CreateTodo()
  {
    console.Header();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(" Skapa ny todo");
    Console.ResetColor();

    Console.Write("Namn: ");
    var name = Console.ReadLine();
    Console.Write("Beskrivning: ");
    var desc = Console.ReadLine();
    Console.WriteLine();

    var todo = new Todo(name: name, desc: desc);

    List<(string id, string value, Action action)> options = new()
      {
        (id: "S", value: "Spara", action: () => AddTodo(todo)),
        (id: "A", value: "Avbryt", action: MainPage),
      };

    menu.MenuHandler(options);
  }

  public void AddTodo(Todo todo)
  {
    todos.Add(todo);
    Console.WriteLine("En todo har skapats");
    Console.Write("Tryck ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("ENTER ");
    Console.ResetColor();
    Console.Write("för att komma tillbaka till startsidan");
    Console.ReadLine();
    MainPage();
  }
}