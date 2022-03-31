namespace Exercicio01.Classes
{
    public class Pessoa
    {

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
        }

        private string _dataNasc;
        public string DataNasc
        {
            get
            {
                return _dataNasc;
            }
            set
            {
                if (ValidarDataNascimento(value))
                    _dataNasc = value;

            }
        }

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime resultado;

            if (DateTime.TryParse(dataNasc, out resultado) == true)
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - resultado).TotalDays / 365;

                if (anos > 0 && anos < 150)
                {
                    _idade = Convert.ToInt32(anos);
                    return true;
                }

                return false;
            }
            return false;
        }


        private float _altura;
        public float Altura
        {
            get
            {
                return _altura;
            }

            set
            {
                if (value > 0 && value < 3)
                    _altura = value;
            }
        }


        public void ImprimirDados()
        {
            Console.WriteLine(@$"
Nome: {Nome}
Data Nascimento: {DataNasc}
Idade: {Idade}
Altura: {Altura}
");
        }

    }
}