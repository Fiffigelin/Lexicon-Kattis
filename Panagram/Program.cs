// Jag blev så osäker på funktionen för panagram så jag var tvungen att återskapa den
// Tacka gudarna att jag har gjort denna övning för bara ett tag sedan XD

// Och så kan jag inte döpa det rätt! Pangram inte Panagram! XD

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

List<char> FindASwedishPanagram(string text)
{
  string swedishAlphabet = "abcdefghijklmnopqrstuvwxyzåäö";
  var missingLetters = new List<char>();
  var lowercaseText = text.ToLower();

  foreach (char letter in swedishAlphabet)
  {
    if (!lowercaseText.Contains(letter))
    {
      missingLetters.Add(letter);
    }
  }

  return missingLetters;
}

bool IsPanagramSwedish(string text)
{
  string swedishAlphabet = "abcdefghijklmnopqrstuvwxyzåäö";
  var lowercaseText = text.ToLower();

  foreach (char letter in swedishAlphabet)
  {
    if (!lowercaseText.Contains(letter))
    {
      return false;
    }
  }

  return true;
}

foreach (char character in FindASwedishPanagram("Yxmördaren blåste på en hård frusen säckpipa"))
{
  Console.Write(character);
}

Console.WriteLine();
Console.WriteLine(IsPanagramSwedish("Yxmördaren blåste på en hård frusen säckpipa gjoqvwz")); // <=== HAHAHAHAHAHAHA!