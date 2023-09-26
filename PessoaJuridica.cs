using System;

class PessoaJuridica : Padrao
{
  //metodo obrigatorio
  public override void TaxaEmprestimo(double valor){
    Console.WriteLine("Taxa de emprestimo pessoa jurídica R$ " + (valor * 0.2));
  }
}