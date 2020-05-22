using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;
        

        public string Nome
        {
            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("o nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }
        public double Altura
        {
            set
            {
                if(value >= 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura tem que ser um número positivo.");
                }
            }
            get { return this.altura; }
        }
        public double Peso
        {
            set
            {
                if (value >= 0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso tem que ser um número positivo.");
                }
            }
            get { return this.peso; }
        }
        public int Idade
        {
            set
            {
                if (value >= 0)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade tem que ser um número positivo.");
                }
            }
            get { return this.idade; }
        }

        public string ImprimeDados()
        {
            return "Dados do atleta: \n\nNome: " +
                    this.nome  +
                    "\nAltura: " + this.altura.ToString("0.00") + "m." +
                    "\nPeso: " + this.peso+ "kg"+
                    "\nIdade: " + this.idade;
        }
        public double CalcularIMC()
        {
            double alt = this.altura * this.altura;
            return this.peso/ alt;
        }
    }
}
