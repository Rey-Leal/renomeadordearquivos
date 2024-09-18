namespace RenomeadorDeArquivos.Constantes
{
    public static class Aplicacao
    {
        private const string _NomeDaAplicacao = "Renomeador de Arquivos";
        private const string _VersaoDaAplicacao = "1.0";

        public static string NomeCompleto
        {
            get => String.Concat(_NomeDaAplicacao, " ", _VersaoDaAplicacao);
        }

    }
}
