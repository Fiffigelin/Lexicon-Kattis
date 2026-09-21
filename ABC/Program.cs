// OK ELIN! INTE GÖRA DETTA SVÅRARE ÄN VAD DET ÄR!

// Input av int samt sträng
// Console.ReadLine() gör dock allt till strängar!!

// A < B < C
// Vilket innebär att A alltid är minst och C är alltid störst

// UPPGIFT ABC:
// You will be given three integers A, B and C.
// The numbers will not be given in that exact order, but we do know that A
// is less than B and B less than C. In order to make for a more pleasant viewing, we want to rearrange them in a given order.

// Input
// The first line contains the three positive integers A, B and C,
// not necessarily in that order. The three numbers will be less than or equal to 100.

// The second line contains three uppercase letters ’A’, ’B’ and ’C’ (with no spaces between them) representing the desired order.

// Output
// Output A, B and C in the desired order on a single line, separated by single spaces.

using System;

var numberInput = Console.ReadLine();
string[] parts = numberInput.Split();

int[] numbers = new int[3];

for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = int.Parse(parts[i]);
}

Array.Sort(numbers);

var stringInput = Console.ReadLine();
string result = string.Empty;

for (int i = 0; i < numbers.Length; i++)
{
  char letter = stringInput[i];

  if (letter == 'A')
  {
    result += numbers[0].ToString();
  }
  else if (letter == 'B')
  {
    result += numbers[1].ToString();
  }
  else if (letter == 'C')
  {
    result += numbers[2].ToString();
  }

  if (i < 2)
  {
    result += " ";
  }
}

Console.WriteLine(result);
