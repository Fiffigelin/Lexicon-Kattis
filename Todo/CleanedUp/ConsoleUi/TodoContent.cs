using Class;

public class TodoContent(Menu menu, ConsoleUi console, List<Todo> todos)
{
  public void MainPage()
  {
    List<(string id, string value, Action action)> options = new()
      {
        (id: "1", value: "Lägg till ny todo", action: CreateTodo),
        (id: "2", value: "Visa alla todos", action: () => ShowTodos(todos)),
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

  public void ShowTodos(List<Todo> todos)
  {
    console.Header();
    Console.WriteLine();

    var options = new List<(string id, string value, Action action)>();

    for (int i = 0; i < todos.Count; i++)
    {
      var todo = todos[i];
      options.Add((id: (i + 1).ToString(), value: todo.Name, action: () => ShowSingleTodo(todo)));
    }

    options.Add((id: "B", value: "Backa", action: MainPage));

    menu.MenuHandler(options);
  }

  public void ShowSingleTodo(Todo todo)
  {
    var options = new List<(string id, string value, Action action)>()
    {
      (id: "1", value: "Ändra namn", action: () => ChangeName(todo)),
      (id: "2", value: "Ändra status", action: () => ChangeTodoStatus(todo)),
      (id: "R", value: "Radera", action: () => RemoveTodo(todo)),
      (id: "B", value: "Backa", action: () => ShowTodos(todos))

    };
    console.Header();
    Console.WriteLine();

    console.ShowTodo(todo);
    menu.MenuHandler(options);
  }

  public void ChangeName(Todo todo)
  {
    var name = string.Empty;

    console.Header();
    console.ChangeTodoName(todo);

    name = Console.ReadLine();

    var options = new List<(string id, string value, Action action)>()
    {
      (id: "S", value: "Spara", action: () => SaveNameChange(todo, name)),
      (id: "A", value: "Avbryt", action: () => ShowSingleTodo(todo))
    };

    menu.MenuHandler(options);
  }

  public void RemoveTodo(Todo todo)
  {
    todos.Remove(todo);
    ShowTodos(todos);
  }

  public void ChangeTodoStatus(Todo todo)
  {
    todo.ChangeIsDoneStatus();
    ShowSingleTodo(todo);
  }

  public void SaveNameChange(Todo todo, string name)
  {
    todo.ChangeName(name);
    ShowSingleTodo(todo);
  }
}