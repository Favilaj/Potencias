using System;

namespace potenciasC
{
    public partial class Form1 : Form
    {
        private object textBox1;
        private object textBox2;
        private object label3;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, potencia, resultado;

            valor = Convert.ToDouble(textBox1.Text);
            potencia = Convert.ToDouble(textBox2.Text);

            resultado = Math.Pow(valor, potencia);

            label3.Text = resultado.ToString();
        }
    }
}