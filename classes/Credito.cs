using System;

namespace AulaPOO_Abstração.classes
{
    public  class Credito : Cartao
    {
        private int limite 
        = 3000;

        public int parcelas
        ;

        public void Pagar(float valor){
            this.valor = valor;
            int parcela;
            float juros;

            if(valor <= this.limite){
                do{
                Console.WriteLine("Digite a quantidade de parcelas de a 12: ");
                parcela = int.Parse(Console.ReadLine());

                }while (parcela >12);

                if(parcela <= 6){

                    juros = 0.05f;
                }else{
                    juros = 0.08f;
                }

                float total = this.valor - (this.valor * juros);

                ExibirNota(this.titular, total);

            }else{
                Console.WriteLine("Limite excedido!");
                
            }
        }
    }
}