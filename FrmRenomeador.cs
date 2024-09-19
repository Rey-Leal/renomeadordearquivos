using RenomeadorDeArquivos.Constantes;
using RenomeadorDeArquivos.Enum;
using System.Linq.Expressions;

namespace RenomeadorDeArquivos
{
    public partial class FrmRenomeador : Form
    {
        public FrmRenomeador() => InitializeComponent();

        private void FrmRenomeador_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lstArquivos.Items.Clear();
            btnRenomear.Enabled = false;
            txtMascara.Enabled = false;
        }

        private void AtivaMascara()
        {
            btnRenomear.Enabled = true;
            txtMascara.Enabled = true;
        }

        private void CarregarDados(string diretorio)
        {
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

        private void RenomearArquivos(string diretorioCompleto, Mascara mascara)
        {
            string arquivoOrigem = AplicarMascara(Path.GetFileName(diretorioCompleto), mascara);
            string diretorioOrigem = Path.GetDirectoryName(diretorioCompleto);
            string diretorioPai = Directory.GetParent(diretorioOrigem).ToString();
            string diretorioSaida = Path.Combine(diretorioPai, String.Concat(Path.GetFileName(diretorioOrigem), "_RENOMEADO"));
            string arquivoSaida = Path.Combine(diretorioSaida, arquivoOrigem);

            if (!Directory.Exists(diretorioSaida))
                Directory.CreateDirectory(diretorioSaida);

            File.Copy(diretorioCompleto, arquivoSaida, true);
        }

        private string AplicarMascara(string arquivo, Mascara mascara)
        {
            string result = "";
            switch (mascara)
            {
                case Mascara.Numerico:
                    string parteNumerica = new string(arquivo.Where(char.IsDigit).ToArray());
                    result = String.Concat("Edital", parteNumerica, ".PDF");
                    break;
            }
            return result;
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            if (fbdDiretorio.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbdDiretorio.SelectedPath;
                CarregarDados(txtDiretorio.Text);
            }
            else
            {
                LimparCampos();
            }
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            foreach (var item in lstArquivos.Items)
            {
                RenomearArquivos(item.ToString(), Mascara.Numerico);
            }
        }
    }
}
