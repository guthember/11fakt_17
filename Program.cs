using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoveges
{
  class Program
  {
    static void Koszon(string n) 
    {
      Console.WriteLine("Hello {0}!",n);
    }

    static string KoszonSzoveg(string n)
    {
      string vissza = "Hello ";
      vissza += n;
      vissza += "!";
      
      return vissza;
    }

    static void Main(string[] args)
    {
      string nev = "";
      Console.Write("Hogy hívnak? ");
      nev = Console.ReadLine();
      Koszon(nev);
      Console.WriteLine(KoszonSzoveg(nev));

      Console.ReadKey();
    }
  }
}
