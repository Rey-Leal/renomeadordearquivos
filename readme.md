# Renomeador de Arquivos
![Badge em Desenvolvimento](https://img.shields.io/static/v1?label=STATUS&message=FINALIZADO&color=GREEN&style=for-the-badge)

## Introdução
Projeto Windows Forms que possibilita a renomeação de arquivos utilizando máscaras personalizadas para manter partes do nome antigo.

**Exemplos de uso da aplicação:**<br/>
**Entrada:** 0001TextoAnterior.PDF, 0002TextoAnterior.PDF ... 9999TextoAnterior.PDF...

**Máscara:** [NovoTexto]%[Mascara.Numerica]%.PDF *(%[Mascara.Numerica]% preserva apenas a parte númerica da entrada)*

**Retorno:** NovoTexto0001.PDF, NovoTexto0002.PDF ... NovoTexto9999.PDF

### Tecnologias Utilizadas:
* .NET
* Windows Forms

### Máscaras a serem desenvolvidas futuramente:
* %[Mascara.Textual]%
* Trabalho conjunto de várias máscaras

## Configuração e Execução
Para executar este projeto localmente, siga os passos abaixo:

1. **Clone o repositório**:
   ```bash
   git clone <URL-do-repositorio>
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd nome-do-projeto
   ```

3. **Instale as dependências**:
   Certifique-se de que você tenha o .NET SDK instalado em sua máquina. Instale as dependências com:
   ```bash
   dotnet restore
   ```

4. **Atualize as configurações da API**:
   Configure as definições necessárias no arquivo `appsettings.json`.

5. **Execute o projeto**:
   ```bash
   dotnet run
   ```