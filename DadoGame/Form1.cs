using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadoGame
{
    public partial class Form1 : Form
    {
        int resultado1 = 0, resultado2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int b;
            bool empate;
            pictureBox1.Visible = true;
            do
            {
                empate = false;

                b = a.Next(1, 6);
                label3.Text = Convert.ToString(b);

                b = a.Next(1, 6);
                label4.Text = Convert.ToString(b);

                if (int.Parse(label3.Text) > int.Parse(label4.Text))
                {
                    resultado1++;
                    label5.Text = Convert.ToString(resultado1);
                    label7.Text = "Parabéns Jogador 1 \nGanhou a Rodada!";                    
                    if (int.Parse(label5.Text) == 2)
                    {
                        MessageBox.Show("Parabéns! \nJogador 1 Ganhou!");
                        pictureBox1.Visible = false;
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        resultado1 = 0;
                        resultado2 = 0;
                    }
                }
                else if (int.Parse(label3.Text) < int.Parse(label4.Text))
                {
                    resultado2++;
                    label6.Text = Convert.ToString(resultado2);
                    label7.Text = "Parabéns Jogador 2 \nGanhou a Rodada!";
                    if (int.Parse(label6.Text) == 2)
                    {
                        pictureBox1.Visible = false;
                        MessageBox.Show("Parabéns! \nJogador 2 Ganhou!");
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        resultado2 = 0;
                        resultado1 = 0;
                    }
                }
                else
                {
                    label7.Text = ("Empate \n Jogar Novamente");
                    empate = true;
                }
            } while(empate);
            
                

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
