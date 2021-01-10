using System;

namespace AulaPOO_Abstração.classes
{
    public class Cartao : Pagamento
    {
        //Atributos
        public string bandeira 
        ;

        public string numerodoCarato
        ;

        public string titular
        ;

        public string cvv
        ;

        //Métodos
        public void SalvarCartao()
        {
            Console.WriteLine("Digite o nome do titular do cartão: ");
            titular = Console.ReadLine();

            Console.WriteLine("Digite a numeração do cartão: ");
            numerodoCarato = Console.ReadLine();

            Console.WriteLine("Digite a bandeira do cartão: ");
            bandeira = Console.ReadLine();

            Console.WriteLine("Digite o CVV do cartão: ");
            cvv = Console.ReadLine();
        }
        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titular: {titular} - valor da compra = {total}");
            
        }
    }
}