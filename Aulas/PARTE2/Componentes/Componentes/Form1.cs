namespace Componentes
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_adcionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Ve�culo");
                tb_veiculo.Focus();
                return;
            }

            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";
            //tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_veiculo.Text;

            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text);
            f_Veiculos.ShowDialog(); //show dialog n�o deixa acessar outra janela enquanto essa est� aberta
        }
    }
}