using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ItemSelect = comboOption.Text;
            double capital = Convert.ToDouble(txtCapital.Text);
            int interes = Convert.ToInt32(txtInteres.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);
            double resultado;
            switch (ItemSelect)
            {
                case "Anual":
                    resultado = capital * interes * tiempo;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "Mensual":
                    resultado = capital * interes * tiempo / 2;
                        txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "Diario":
                    resultado = capital * interes * tiempo / 360;
                        txtresultado.Text = Convert.ToString(resultado);
                    break;
            }


        }
    }
}
