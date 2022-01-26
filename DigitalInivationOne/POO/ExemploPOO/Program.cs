
using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      //valores validos
      retangulo r = new retangulo();
      r.DefinirMedidas(30, 30);

      System.Console.WriteLine($'Area: (r.obterarea())');


      //valores Invalidos
      retangulo r2 = new retangulo();
      r.DefinirMedidas(0, 0);
      System.Console.WriteLine($'Area: (r2.obterarea())');




      // Pessoa p1 = new Pessoa { };
      // p1.Name = "Bob";
      // p1.Idade = 20;

      // p1.Apresentar();
    }
  }
}
