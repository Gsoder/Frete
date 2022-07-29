using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparFrete();

        }
        public void CalcularFrete()
        {
            int valor = int.Parse(textBox2.Text);

            if (valor >= 1000)
            {

                label10.Text = Convert.ToString(0);

            }
            else if (comboBox1.SelectedItem.ToString() == "RJ")
            {
                label10.Text = Convert.ToString(10);
            }
            else if (comboBox1.SelectedItem.ToString() == "SP")
            {
                label10.Text = Convert.ToString(5);
            }
            else if (comboBox1.SelectedItem.ToString() == "AM")
            {
                label10.Text = Convert.ToString(15);
            }
            else if (comboBox1.SelectedItem.ToString() == "Outros")
            {
                label10.Text = Convert.ToString(10);
            }
            else
            {
                MessageBox.Show("Nn é possivel calcular por que as strings estão vazias");
            }
            /*switch (comboBox1.SelectedItem.ToString())
            {
                case "RJ":
                    label10.Text = Convert.ToString(10);
                    break;
                case "AM":
                    label10.Text = Convert.ToString(15);
                    break;
                case "SP":
                    label10.Text = Convert.ToString(5);
                    break;
                case "Outros":
                    label10.Text = Convert.ToString(10);
                    break;*/
            label7.Text = Convert.ToString(valor);
            label12.Text = Convert.ToString(valor + Convert.ToInt32(label10.Text));

        }
        public void LimparFrete()
        {
            comboBox1.Text = string.Empty;
            label7.Text = "-----";
            label12.Text = "-----";
            label10.Text = "-----";
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
        
    }
    }

