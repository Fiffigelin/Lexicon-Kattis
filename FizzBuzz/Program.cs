// According to Wikipedia, FizzBuzz is a group word game for children to teach them about division. 
// This may or may not be true, but this question is generally used to torture screen young computer science graduates during programming interviews. 
// Basically, this is how it works: you print the integers from 1 to 𝑁 , replacing any of them divisible by 𝑋 with Fizz or, if they are divisible by 𝑌 , with Buzz. 
// If the number is divisible by both 𝑋 and 𝑌 , you print FizzBuzz instead. Check the samples for further clarification. 

// Input
// Input contains a single test case. Each test case contains three integers on a single line, 𝑋 , 𝑌 and 𝑁 ( 1 ≤ 𝑋 < 𝑌 ≤ 𝑁 ≤ 100 ).

// Output 
// Print integers from 1 to 𝑁 in order, each on its own line, replacing the ones divisible by 𝑋 with Fizz, the ones divisible by 𝑌 with Buzz and ones divisible by both 𝑋 and 𝑌 with FizzBuzz.

static void FizzBuzz(int dividedX, int dividedY, int n)
{
  for (int i = 1; i <= n; i++)
  {
    if (i % dividedX == 0)
    {
      if (i % dividedY == 0)
      {
        Console.WriteLine("FizzBuzz");
      }
      else
      {
        Console.WriteLine("Fizz");
      }

    }
    else if (i % dividedY == 0)
    {
      Console.WriteLine("Buzz");
    }
    else
    {
      Console.WriteLine(i);
    }
  }
}

FizzBuzz(3, 5, 100);
FizzBuzz(6, 9, 100);