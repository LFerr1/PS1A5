using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DateTime dateNascimento = new DateTime();
            dateNascimento = Convert.ToDateTime(dtNascimento.Text);
            if (dateNascimento.AddYears(18).Date < DateTime.Today.Date)
            {
                response.Text = "Resultado: Pode possuir CNH";
            }
            else
            {
                response.Text = "Resultado: Não pode possuir CNH";
            }
        }
    }
}
