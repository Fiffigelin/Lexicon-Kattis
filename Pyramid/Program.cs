// Jag har alltid kämpat med den klassiska Pyramiden med * och for-loop.
// Det som var så öppenbart för alla andra kämpade jag med... varför vet jag inte... 

//Ok jag ska skriva en pyramid:
//*
//**
//***
//****
//*****

// jag vill ha den centrerad:
//____*____
//___***___
//__*****__
//_*******_
//*********

// _ = ett mellanslag.
// Mitten är tecken nr 5 dvs höjden. Om höjden är 3 kommer mitten vara 3:
//__*__
//_***_
//*****

// I terminalen skrivs det ned uppifrån och ned.
// Så jag kommer behöva mellanslag 4 ggr och * 1 gång
// sedan ökas * med x2 efter varje rad.

Cat();

void Cat()
{
  Console.Write("Skriv antal rader: ");
  var ans = int.Parse(Console.ReadLine());
  Console.WriteLine();

  var random = new Random();
  string[] cats = [
    "🐱", "😻", "😻", "😻", "😻", "😻"
    ];

  for(int i = 1; i <= ans; i++)
  {
    for(int J = 0; J < ans - i; J++)
    {
      Console.Write("  ");
    }
  
    for(int J = 0; J < 2 * i - 1; J++)
    {
      int index = random.Next(cats.Length);
      Console.Write(cats[index]);
    }
  
    Console.WriteLine();
  }

  Console.ReadLine();
}

