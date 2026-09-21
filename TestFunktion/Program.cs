// Det fanns en funktion där man skulle svara vilken input man skulle ha på en funktion för att få output 4.
// Nu kommer jag inte ihåg funktionen helt hundra så detta kan ju gå som det går:

int FunctionThatGotMeStuck(int num)
{
  if (num == 0)
  {
    return 0;
  }

  // return FunctionThatGotMeStuck(num - 1 + 2); <== inte denna!
  return FunctionThatGotMeStuck(num - 1) + 2;
}

Console.WriteLine(FunctionThatGotMeStuck(1));
Console.WriteLine(FunctionThatGotMeStuck(2)); // <== denna var rätt. Men hur?
Console.WriteLine(FunctionThatGotMeStuck(3));
Console.WriteLine(FunctionThatGotMeStuck(4));
Console.WriteLine(FunctionThatGotMeStuck(5));

// ok...
// för jag får ut:
// 2
// 4
// 6
// 8
// 10

// f(n) = 2 * 2 ??
// f(1) = 1 * 2 = 2
// f(2) = 2 * 2 = 4
// f(3) = 3 * 2 = 6
// f(4) = 4 * 2 = 8
// f(5) = 5 * 2 = 10

// OMG Listade jag precis ut det? 
// Förstår men ändå inte 🤷‍♀️
