using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //Evento do botao - ao clicar ira executar o algoritmo
        private void button1_Click(object sender, EventArgs e)
        {
            //Convertendo o texto do TextBox para double
            double N = Convert.ToDouble(txtBoxNumero.Text);
            //variavel i para incremento em +1
            int i = 0;
            //variavel soma, que ira somar os valors de 0 ate N
            int soma = 0;
            //laco de repeticao: enquanto i for menor ou igual a N, ele ira executar o que esta dentro
            while (i <= N)
            {
                //soma recebera soma + i;
                soma = soma + i;
                //a variavel i sera incrementando em +1
                i++;
            }
            //declarando a variave media
            double media = 0;
            //se N divisel por 2 o resto é igual a zero
            //significa que é par, ou seja verdadeiro
            if (N % 2 == 0)
            {
                //media recebe n + 1, dividido por 2
                media = (N + 1) / 2;
                //se for falso, ele é impar
            }
            else
            {
                //media recebe n dividido por 2 + 0.5
                media = (N / 2) + 0.5;
            }
            
            MessageBox.Show($"Resultado: {soma}\nMédia: {media}");

            //Remove o número da textbox
            txtBoxNumero.Clear();
        }
    }
}
