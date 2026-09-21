// Jag blev så osäker på funktionen för panagram så jag var tvungen att återskapa den
// Tacka gudarna att jag har gjort denna övning för bara ett tag sedan XD

var text1 = "The quick brown fox jumps over the lazy dog";
var text2 = "Hello, World!";

bool IsPanagram(string text)
{
  var lowercaseText = text.ToLower();
  for (char letter = 'a'; letter <= 'z'; letter++)
  {
    if (!lowercaseText.Contains(letter))
    {
      return false;
    }
  }

  return true;
}

Console.WriteLine(IsPanagram(text1));
Console.WriteLine(IsPanagram(text2));