namespace aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            lb_texto.Text = tb_texto.Text;
        }
    }
}