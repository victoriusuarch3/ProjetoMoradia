namespace ProjetoMoradia.Models
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }

        public Casa(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos,
                    bool comQuintal) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            SetComQuintal(comQuintal);
        }

        public void SetComQuintal(bool comQuintal)
        {
            ComQuintal = comQuintal;
        }

        public bool GetComQuintal()
        {
            return ComQuintal;
        }

        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = (GetTamanhoEmMetros() * 35) + (GetQuantidadeDeQuartos() * 10) + (GetQuantidadeDeBanheiros() * 5);
            if (GetComQuintal() == true)
                valor = valor * 1.1;
            return valor;
        }
    }
}