using System;

namespace Prova4b
{
    class Cliente
    {

        private string nome;
        private string rg;
        private string cpf;
        private DateTime data_nasc;
        private decimal salario;

        public Cliente(string nome, string rg, string cpf, DateTime data_nasc, decimal salario)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.data_nasc = data_nasc;
            this.salario = salario;
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public DateTime getDataNasc()
        {
            return this.data_nasc;
        }
        public void setDataNasc(DateTime datanasc)
        {
            this.data_nasc = datanasc;
        }

        public Decimal getSalario()
        {
            return this.salario;
        }

        public void setSalario(decimal salario)
        {
            this.salario = salario;
        }

        public decimal avaliaCredito()
        {
            DateTime hoje = DateTime.Now;
            DateTime nasc = this.data_nasc;

            int ano = DateTime.Today.Year - nasc.Year;
            if(nasc.Month > DateTime.Today.Month || nasc.Month == DateTime.Today.Month && nasc.Day > DateTime.Today.Day)
            {
                ano--;
            }
            decimal idade = Convert.ToDecimal(ano);
     
            idade = (idade / 100) * 10;
            decimal salario = (this.salario / 100) * 30;
        
            decimal limite = salario * idade;

            return limite;
        }

       
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Paulo", "1243504840", "10670250902", new DateTime(2002,01,04,00,00,00), 1350);
            Console.WriteLine(c1.getNome() + c1.getCpf() + c1.getRg() + c1.getDataNasc() + c1.getSalario());
            Console.WriteLine(c1.avaliaCredito());
            c1.setNome("Teste");
            c1.setCpf("0000000");
            c1.setRg("12345");
            c1.setDataNasc(new DateTime(2005, 04, 01, 00, 00, 00));
            c1.setSalario(1500);
            Console.WriteLine(c1.getNome() + c1.getCpf() + c1.getRg() + c1.getDataNasc() + c1.getSalario());

            Console.WriteLine(c1.avaliaCredito());
        }
    }
}
