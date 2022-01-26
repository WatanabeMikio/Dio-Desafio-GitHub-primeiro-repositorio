namespace ExemploPOO.Models
{
  public class retangulo
  {
    private double comprimento;
    private double largura;
    private bool valido;

    public void DefinirMedidas(double comprimento, double largura)
    {
      if (comprimento > 0 && largura > 0)
      {
        this.comprimento = comprimento;
        this.largura = largura;
        valido = true;
      }

      else
      {
        System.Console.WriteLine("Valores Invalidos");

      }
    }

    public double obterarea()
    {
      if (valido)
      {
        return comprimento * largura;
      }
      else
      {
        System.Console.WriteLine("Digite um Valor Valido");
        return 0;
      }
    }
  }
}