
using Class;

var todos = new List<Todo>
{
 new Todo(name: "Klappa katten", desc: "På rygg och huvud"),
 new Todo(name: "Diska", desc: "Använd vasken i köket och inte i badrummet"),
 new Todo(name: "Boesta tänderna", desc: "Morgon och kväll"),
};

Menu menu = new();
ConsoleUi console = new();
TodoContent content = new(menu, console, todos);

List<(string id, string value, Action? action)> options = new()
{
  (id: "1", value: "Lägg till ny todo", action: menu.Logging),
  (id: "2", value: "Visa alla todos", action: menu.Logging),
  (id: "E", value: "Avsluta", action: null),
};

content.MainPage();