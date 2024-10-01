using RenomeadorDeArquivos.Constantes;
using RenomeadorDeArquivos.Enums;

namespace RenomeadorDeArquivos
{
    public partial class FrmRenomeador : Form
    {
        public FrmRenomeador() => InitializeComponent();

        private void FrmRenomeador_Load(object sender, EventArgs e)
        {            
            LimparCampos();
            CarregarMascaras();            
        }

        private void LimparCampos()
        {
            lstArquivos.Items.Clear();
            btnRenomear.Enabled = false;
            cbxMascara.Enabled = false;
        }

        private void AtivaMascara()
        {
            btnRenomear.Enabled = true;
            cbxMascara.Enabled = true;
        }

        private void CarregarMascaras()
        {
            cbxMascara.Items.Clear();
            cbxMascara.DataSource = Enum.GetValues(typeof(Mascara));
            if (cbxMascara.Items.Count > 0)
                cbxMascara.SelectedIndex = 0;
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
                    MessageBox.Show("Nenhum arquivo encontrado!", Aplicacao.NomeCompleto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("O diretório não existe!", Aplicacao.NomeCompleto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RenomearArquivos(string diretorioCompleto, Mascara mascara)
        {
            try
            {
                string arquivoOrigem = GerarMascara(Path.GetFileName(diretorioCompleto), mascara);
                string diretorioOrigem = Path.GetDirectoryName(diretorioCompleto);
                string diretorioPai = Directory.GetParent(diretorioOrigem).ToString();
                string diretorioSaida = Path.Combine(diretorioPai, String.Concat(Path.GetFileName(diretorioOrigem), "_RENOMEADO"));
                string arquivoSaida = Path.Combine(diretorioSaida, arquivoOrigem);

                if (!Directory.Exists(diretorioSaida))
                    Directory.CreateDirectory(diretorioSaida);

                File.Copy(diretorioCompleto, arquivoSaida, true);
            }
            catch
            {
                throw new Exception();
            }
        }

        private string GerarMascara(string arquivo, Mascara mascara)
        {
            string result = "";
            switch (mascara)
            {
                case Mascara.Numerica:
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
            try
            {
                var entrada = cbxMascara.SelectedItem.ToString();

                if (Enum.TryParse<Mascara>(entrada, out var mascara))
                {
                    foreach (var item in lstArquivos.Items)
                    {
                        RenomearArquivos(item.ToString(), mascara);
                    }
                    MessageBox.Show("Arquivos renomeados com sucesso!", Aplicacao.NomeCompleto, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na seleção da máscara de renomeação!",
                        Aplicacao.NomeCompleto, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao renomear arquivos!\n{ex}", Aplicacao.NomeCompleto, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair da aplicação?", Aplicacao.NomeCompleto, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
