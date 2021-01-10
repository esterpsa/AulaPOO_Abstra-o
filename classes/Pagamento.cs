using System;

namespace AulaPOO_Abstração.classes
{
    public abstract class Pagamento
    {

        //Argumentos
        private DateTime data
        ;

        protected float valor 
        ;

        public float Valor{
            set{ valor = value;}
            get{return valor;}
        }
        private DateTime datadoPagamento
        ;

        public DateTime DatadoPagamento{
            get{return DateTime.Now;}
        }
        //Métodos 
        public string Cancelar()
        {
            return "";
        }

    }
}