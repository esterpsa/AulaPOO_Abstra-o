using System;

namespace AulaPOO_Abstração.classes
{
    public class Boleto : Pagamento
    {
        //Argumento
        private string codigodebarras
        = "0333445666.45464675.5646757.46756757567";
        
        public string CodigodeBarras{
            get{return codigodebarras;}
        }

        public string datadeVencimento
        ;

        public string orgaoemissor
        = "Santander";

        public int cpf
        ;

        //Métodos
        public void Registrar(float valor, DateTime dataEmissao, string codigodeBarras)
        {
            Console.WriteLine($"O Valor da compra fica em: {this.valor * 0.88f} com desconto de 12%");
            Console.WriteLine($"Data de Emissão: {dataEmissao}");
            Console.WriteLine($"Data de vencimento: {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de barras = {codigodebarras}");
            Console.WriteLine("Orgão emissor: "+orgaoemissor);
        



        }
    }
}