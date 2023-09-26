using System;

class PessoaFisica : Padrao
{
  //metodo obrigatorio
  public override void TaxaEmprestimo(double valor){
    Console.WriteLine("Taxa de emprestimo pessoa fisica R$ " + (valor * 0.1));
  }
}