using RenomeadorDeArquivos.Constantes;

namespace RenomeadorDeArquivos
{
    public partial class FrmRenomeador : Form
    {
        public FrmRenomeador() => InitializeComponent();

        private void LimparCampos()
        {
            lstArquivos.Items.Clear();
            btnAlterar.Enabled = false;
            txtMascara.Enabled = false;
        }

        private void AtivaMascara()
        {
            btnAlterar.Enabled = true;
            txtMascara.Enabled = true;
        }

        private void FrmRenomeador_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            if (fbdDiretorio.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbdDiretorio.SelectedPath;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string diretorio = txtDiretorio.Text;

            LimparCampos();

            if (Directory.Exists(diretorio))
            {
                string[] arquivos = Directory.GetFiles(diretorio, "*.PDF", SearchOption.AllDirectories);

                foreach (string arquivo in arquivos)
                {
                    lstArquivos.Items.Add(arquivo);
                }

                if (arquivos.Length > 0)
                { 
                   AtivaMascara();
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo encontrado!", Aplicacao.NomeCompleto);
                }
            }
            else
            {
                MessageBox.Show("O diretório não existe!", Aplicacao.NomeCompleto);
            }
        }
    }
}
