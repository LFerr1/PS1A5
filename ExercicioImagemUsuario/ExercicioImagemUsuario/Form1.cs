namespace ExercicioImagemUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Arquivo BMP|*.bmp|Arquivo PNG|*.png|Arquivo JPEG|*.jpg";
            DialogResult dr = o.ShowDialog();
            if(dr == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(inputLogin.Text != "" && inputSenha.Text != "" && comboTipoUsuario.Text != "")
            {
                labelAuthUser.Text = $"Usuario Autenticado: {inputLogin.Text}";
                labelTipoUsuario.Text = $"Tipo de Usuario: {comboTipoUsuario.Text}";
            }
        }

    }
}