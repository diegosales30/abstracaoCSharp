using System;

abstract class Padrao
{
  //com classe abstrata criamos um padrão para projeto
  //pode ter metodos obrigatorios ou opcionais.
  //obrigatorio pode ser public ou protected
  public abstract void TaxaEmprestimo(double valor);

  //opcional
  //qulquer classe pode usar esse método se quiser, porém é opcional
  public void CalculoPoupanca(double valor, double taxa)
  {
    Console.WriteLine("Ganhos obtidos em poupança R$ "+(valor * taxa));
  }
}