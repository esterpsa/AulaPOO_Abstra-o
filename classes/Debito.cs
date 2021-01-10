using System;

namespace AulaPOO_Abstração.classes
{
    public  class Debito : Cartao
    {
        private float saldo
        = 600;

        public void Pagar(float valor){
             if(valor <= 600){
                Console.WriteLine("Finalizando compra....");
                
            }else{
                Console.WriteLine("Você não tem saldo suficiente! ");
                
            }

            
        }
    }
}