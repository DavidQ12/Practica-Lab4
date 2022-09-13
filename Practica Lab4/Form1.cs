using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            string ItemSelect = comboOpciones.Text;
            double resultado;

            switch (ItemSelect)
               
            {
                case "Suma":
                    
                    resultado = num + num2;
                    txtresultado.Text = Convert.ToString(resultado);

                    break;
                case "Resta":
                    
                    
                        resultado = num - num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;

                case "Multiplicación":
                    
                    resultado = num * num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "División":
                    
                    resultado= num / num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;



            }
            {
                
            }

        }
    }
}
