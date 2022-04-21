namespace ProjetoMoradia.Models
{
    public class Morador
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        public Morador(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        public DateTime GetDataDeNascimento()
        {
            return DataNascimento;
        }
    }
}