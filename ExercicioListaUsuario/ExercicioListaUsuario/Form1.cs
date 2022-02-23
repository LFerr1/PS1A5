namespace ExercicioListaUsuario
{
    public partial class Form1 : Form
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            usuarios.Add(form3.usuario);
            
        }
    }
}