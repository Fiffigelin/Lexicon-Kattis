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

int rader = 5;

for(int i = 1; i <= rader; i++)
{
  for(int J = 0; J < rader - i; J++)
  {
    Console.Write(" ");
  }

  for(int J = 0; J < 2 * i - 1; J++)
  {
    Console.Write("*");
  }

  Console.WriteLine();
}

Console.ReadLine();