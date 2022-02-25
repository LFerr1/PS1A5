using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioListaUsuario
{
    public partial class Form2 : Form
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public Form2(List<Usuario> cachedUsuarios)
        {
            usuarios = cachedUsuarios;
            InitializeComponent();
            comboBox1.Text = "Todos Usuários";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Todos Usuários")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < usuarios.Count; i++)
                {
                    listBox1.Items.Add($"Usuario: {usuarios[i].Login}");
                }
            }else if (comboBox1.Text == "Usuários Inativos")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < usuarios.Where(user => !user.Status).Count(); i++)
                {
                    listBox1.Items.Add($"Usuario: {usuarios.Where(user => !user.Status).ToList()[i].Login}");
                }
            }
            else if (comboBox1.Text == "Usuários Ativos")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < usuarios.Where(user => user.Status).Count(); i++)
                {
                    listBox1.Items.Add($"Usuario: {usuarios.Where(user => user.Status).ToList()[i].Login}");
                }
            }
        }
    }
}
