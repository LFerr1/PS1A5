using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlusOne_Click(object sender, EventArgs e)
        {
            txtCount.Text = (Convert.ToDouble(txtCount.Text) + 1).ToString();
        }

        private void BtnLess_Click(object sender, EventArgs e)
        {
            txtCount.Text = (Convert.ToDouble(txtCount.Text) - 1).ToString();

        }

        private void BtnPlusThree_Click(object sender, EventArgs e)
        {
            txtCount.Text = (Convert.ToDouble(txtCount.Text) + 3).ToString();

        }

        private void BtnPlusTwo_Click(object sender, EventArgs e)
        {
            txtCount.Text = (Convert.ToDouble(txtCount.Text) + 2).ToString();

        }

        private void TxtCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = "0";
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (rdoAdd.Checked)
            {
                result.Text = "Resultado: " + (Convert.ToInt32(inputOne.Text) + Convert.ToInt32(inputTwo.Text)).ToString();
            }else if (rdoSub.Checked)
            {
                result.Text = "Resultado: " + (Convert.ToInt32(inputOne.Text) - Convert.ToInt32(inputTwo.Text)).ToString();

            }else if (rdoMlt.Checked)
            {
                result.Text = "Resultado: " + (Convert.ToInt32(inputOne.Text) * Convert.ToInt32(inputTwo.Text)).ToString();

            }else if (rdoDiv.Checked)
            {
                result.Text = "Resultado: " + (Convert.ToInt32(inputOne.Text) / Convert.ToInt32(inputTwo.Text)).ToString();

            }
        }

        
    }
}
