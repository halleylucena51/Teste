using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo de referência
            // -> endereços de dados
            // var pagamentoBoleto = new PagamentoBoleto();
            // pagamentoBoleto.Pagar();
            // pagamentoBoleto.Vencimento=DateTime.Now;
            // pagamentoBoleto.NumeroBoleto = "123";

            Console.WriteLine("Hello World!");
        }
    }

    public class Pagamento  // Tipo de referência, classe Pai
    {
        // propriedades (variáveis)
        // métodos (funções)
        /* eventos (procedures, quando da ocorrência 
        de determinado evento)*/
        /* conceito de encapsulamento da
        orientação a objetos */
        /* Modificadores de acesso : private, protected,
        internal e public
        Modificadores de Acesso se extendem à: classes,
        propriedades e métodos */
        /* - private -> não dá acesso aos filhos
           - protected -> usa o base. para dar acessar
           aos filhos
           - internal -> fica disponível dentro do
           mesmo namespace
           - public -> disponível a todos
           - mais usados: private, protected e public */
        
        public int MyProperty { get; set; }
           
    }


}
