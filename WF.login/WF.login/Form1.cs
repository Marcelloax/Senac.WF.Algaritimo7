namespace WF.login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Você realmente quer fechar este programa?",
                "Titulo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nome")
                textBox1.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.Text = "Nome";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            // if (textBox2.Text == "Senha")
            //    textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // if (textBox2.Text == string.Empty)
            //     textBox2.Text = "Senha";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
