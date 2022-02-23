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
    public partial class Form3 : Form
    {
        public Usuario usuario { get; set; } = new Usuario();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (inputLogin.Text.Trim() == "")
            {
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(inputLogin, "Inválido");
            }
            if (inputSenha.Text.Trim() == "")
            {
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(inputSenha, "Inválido");
            }
            if(inputSenha.Text.Trim() != "" && inputLogin.Text.Trim() != "")
            {
                usuario.Login = inputLogin.Text;
                usuario.Senha = inputSenha.Text;
                usuario.Status = checkSituacao.Checked;
                this.Close();
            }

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
