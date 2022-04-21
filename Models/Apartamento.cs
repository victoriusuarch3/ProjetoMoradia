namespace ProjetoMoradia.Models
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos,
                           int andar, double valorCondominio) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros,
                           quantidadeDeQuartos)
        {
            SetAndar(andar);
            SetValorCondominio(valorCondominio);
        }

        public void SetAndar(int andar)
        {
            Andar = andar;
        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetValorCondominio(double valorCondominio)
        {
            ValorCondominio = valorCondominio;
        }

        public double GetValorCondominio()
        {
            return ValorCondominio;
        }

        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = (GetTamanhoEmMetros() * 40) + (GetQuantidadeDeQuartos() * 10) + (GetQuantidadeDeBanheiros() * 5) + GetValorCondominio();
            return valor;
        }
    }
}