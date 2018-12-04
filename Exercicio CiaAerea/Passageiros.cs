using System;
using System.Collections;

namespace CompanhiaAerea

{
    class Passageiros
    {

        private string cpf;
        private string nome;
        private string sobrenome;
        private string endereco;
        private int telefone;
        private int numeropassagem;
        private int numerovoo;
        private string horario;
        private int poltrona;
        ArrayList Passageiro = new ArrayList();


        public Passageiros()
        {
            cpf = null;
            nome = null;
            sobrenome = null;
            endereco = null;
            telefone = 0;
            numeropassagem = 0;
            numerovoo = 0;
            horario = null;
            poltrona = 0;
        }


        public Passageiros(string cpf, string nome, string sobrenome, string endereco, int telefone, int numeropassagem, int numerovoo, string horario, int poltrona)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.numeropassagem = numeropassagem;
            this.numerovoo = numerovoo;
            this.horario = horario;
            this.poltrona = poltrona;



        }

        public void Cadastrar()
        {
            Passageiro.Add(cpf);
            Passageiro.Add(nome);
            Passageiro.Add(sobrenome);
            Passageiro.Add(endereco);
            Passageiro.Add(telefone);
            Passageiro.Add(numeropassagem);
            Passageiro.Add(numerovoo);
            Passageiro.Add(horario);
            Passageiro.Add(poltrona);
        }

        public string MostrarDados()
        {
            string mostrar = null;
            mostrar = " CPF: " + Passageiro[0] + " \n Nome: " + Passageiro[1] + "\n Numero da Passagem: " + Passageiro[5] + " \n Poltrona: " + Passageiro[8];
            return mostrar;
        }


        public string DadosCompleto()
        {
            string mostrar = null;
            mostrar = " CPF: " + Passageiro[0] + " \n Nome: " + Passageiro[1] + "\n Sobrenome: " + Passageiro[2] + " \n Endereço: " + Passageiro[3]
                + " \n Telefone: " + Passageiro[4] + " \n Número da passagem: " + Passageiro[5] + " \n Número do Voo: " + Passageiro[6]
                + " \n Horário: " + Passageiro[7] + " \n Poltrona: " + Passageiro[8];
            return mostrar;
        }


        internal string Contem(string solicitaCpf)
        {
            solicitaCpf = Convert.ToString(Passageiro[0]);
            return solicitaCpf;
        }


    }
}