luxo de Caixa API

📌 Sobre o projeto

API para gerenciar fluxo de caixa, permitindo lançamentos de créditos e débitos.

🛠️ Tecnologias utilizadas

.NET Core 9.0

Entity Framework Core

SQL Server

Docker (Opcional)

Git

🚀 Como rodar o projeto

1️⃣ Clonar o repositório

git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio

2️⃣ Configurar a string de conexão no appsettings.json

Edite o arquivo appsettings.json e adicione a string de conexão ao banco de dados:

"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=FluxoCaixaDB;User Id=SEU_USUARIO;Password=SUA_SENHA;"
}

3️⃣ Instalar as dependências

dotnet restore

4️⃣ Criar o banco de dados e rodar as migrations

dotnet ef database update

Se precisar criar uma nova migration:

dotnet ef migrations add NomeDaMigration

5️⃣ Executar o projeto

dotnet run

A API estará rodando em http://localhost:5000 ou https://localhost:5001.

📚 Endpoints principais

POST /api/lancamentos → Adiciona um lançamento

GET /api/lancamentos → Lista os lançamentos

GET /api/saldoconsolidado/{data} → Obtém o saldo consolidado

📝 Licença

Este projeto é open-source e pode ser usado livremente.