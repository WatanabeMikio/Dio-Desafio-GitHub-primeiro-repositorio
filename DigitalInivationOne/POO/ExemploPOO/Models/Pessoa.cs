using System;

namespace ExemploPOO.Models
{
  public class Pessoa
  {
    public string Name { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Olá Meu nome é {Name} e tenho {Idade} anos");

    }
  }
}