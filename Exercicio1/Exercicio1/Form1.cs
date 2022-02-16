using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputNome_TextChanged(object sender, EventArgs e)
        {
            if (upper.Checked)
            {
                result.Text = "Resultado: " +  inputNome.Text.ToUpper();
            }
            else if(lower.Checked)
            {
                result.Text = "Resultado: " + inputNome.Text.ToLower();
            }
        }

        private void Lower_CheckedChanged(object sender, EventArgs e)
        {
            result.Text = "Resultado: " + inputNome.Text.ToLower();
        }

        private void Upper_CheckedChanged(object sender, EventArgs e)
        {
            result.Text = "Resultado: " + inputNome.Text.ToUpper();

        }
    }
}
