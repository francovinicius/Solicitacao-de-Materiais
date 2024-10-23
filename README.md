# Solicitacao-de-Materiais

Este projeto é uma aplicação desenvolvida em **C#** com **ASP.NET Core** para gestão de solicitações de materiais. Ele utiliza **SQL Server** para gerenciamento do banco de dados e foi configurado para rodar localmente com suporte ao **Visual Studio** e **NuGet**.

---

## ⚙️ Requisitos

- **Visual Studio** (com suporte para projetos em C# e .NET)
- **SQL Server** (para o banco de dados)
- **Git** (para clonar o repositório)
- **Pacotes NuGet** (gerenciados automaticamente pelo Visual Studio)

---

## 🚀 Como Rodar o Projeto Localmente

### Passo 1: Clonar o Repositório
Abra o **Git Bash** ou **Prompt de Comando** e execute:

git clone https://github.com/francovinicius/Solicitacao-de-Materiais.git

cd Solicitacao-de-Materiais


### Passo 2: Abrir o Projeto no Visual Studio
1. Abra o **Visual Studio**.
2. Clique em **"Abrir um Projeto ou Solução"**.
3. Navegue até a pasta onde você baixou o repositório e selecione o arquivo `Solicitacao-de-Materiais.sln`.

### Passo 3: Restaurar Pacotes NuGet
1. No Visual Studio, vá em **Ferramentas** > **Gerenciador de Pacotes NuGet** > **Gerenciar Pacotes para a Solução**.
2. Clique em **Restaurar** para instalar os pacotes necessários.

### Passo 4: Configurar o Banco de Dados
1. Abra o **SQL Server Management Studio (SSMS)**.
2. Crie um banco de dados chamado `SolicitacaoMateriaisDB`.
3. No Visual Studio, abra o arquivo **`appsettings.json`** e atualize a string de conexão (segue exemplo):
   
json
"ConnectionStrings": {
  "DefaultConnection": "server=SARTON-TI\\SQLEXPRESSS; DataBase=Teste_DTI; trusted_connection=true; TrustServerCertificate=True;"
}

### Passo 5: Aplicar Migrations
1. No Visual Studio, vá em Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes.
2. Execute o seguinte comando para criar as tabelas no banco de dados

Update-Database

###  Passo 6: Compilar e Executar o Projeto
1. No Visual Studio, clique em Compilar > Compilar Solução.
2. Se a compilação for bem-sucedida, pressione F5 ou clique em Iniciar para rodar a aplicação.

### Passo 7: Acessar no Navegador
1. Se o projeto for uma aplicação web, ele abrirá automaticamente no navegador. Acesse a URL:

http://localhost:5000 ou https://localhost:5001


## 🛠️ Problemas Comuns e Soluções
1. Erro de Conexão com Banco de Dados: Verifique se o SQL Server está em execução e se a string de conexão está correta.
2. Falha na Restauração dos Pacotes NuGet: Certifique-se de restaurar todos os pacotes conforme descrito no Passo 3.
3. Erros nas Migrations: Verifique a compatibilidade do Entity Framework e, se necessário, atualize as migrations.


