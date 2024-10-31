# TaskController

Uma aplicação para gerenciar tarefas e pessoas, permitindo a criação, leitura, atualização e exclusão de registros de pessoas e tarefas.

## Pré-requisitos

Antes de executar a aplicação, verifique se você possui os seguintes pré-requisitos instalados em sua máquina:

- [.NET 8.0 ou superior](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/get-started/?tabs=netcore-cli)

## Instalação

Siga os passos abaixo para instalar e configurar a aplicação:

1. **Clone o repositório:**
   ```bash
   git clone <URL do repositório>
   cd <diretório do projeto>
Restaurar as dependências:

bash

dotnet restore
Configurar o banco de dados: Execute as migrations para criar o banco de dados:

bash

dotnet ef database update
Executando a Aplicação
Inicie a aplicação com o comando:

bash

dotnet run
A API estará disponível em http://localhost:5000. Você pode acessar a interface do Swagger em http://localhost:5000/swagger para testar as endpoints.

Uso da API
Criar Pessoa
Endpoint: POST /api/Pessoas

Request Body:

json

{
  "nome": "João",
  "email": "joao@example.com",
  "dataNascimento": "1990-01-01T00:00:00Z"
}
Criar Tarefa
Endpoint: POST /api/Tarefas

Request Body:

json

{
  "titulo": "Tarefa 1",
  "descricao": "Descrição da tarefa 1",
  "dataCriacao": "2024-10-31T00:00:00Z",
  "pessoaId": 1
}
Listar Pessoas
Endpoint: GET /api/Pessoas

Listar Tarefas
Endpoint: GET /api/Tarefas

Obter Pessoa por ID
Endpoint: GET /api/Pessoas/{id}

Obter Tarefa por ID
Endpoint: GET /api/Tarefas/{id}

Atualizar Pessoa
Endpoint: PUT /api/Pessoas/{id}

Request Body:

json

{
  "nome": "João Atualizado",
  "email": "joao_atualizado@example.com",
  "dataNascimento": "1990-01-01T00:00:00Z"
}
Atualizar Tarefa
Endpoint: PUT /api/Tarefas/{id}

Request Body:

json

{
  "titulo": "Tarefa Atualizada",
  "descricao": "Descrição da tarefa atualizada",
  "dataCriacao": "2024-10-31T00:00:00Z",
  "pessoaId": 1
}
Deletar Pessoa
Endpoint: DELETE /api/Pessoas/{id}

Deletar Tarefa
Endpoint: DELETE /api/Tarefas/{id}

Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues para melhorias.

Licença
Este projeto é licenciado sob a MIT License - veja o arquivo LICENSE para mais detalhes.

Instruções para Uso
Substitua <URL do repositório> pela URL real do seu repositório.
Adapte quaisquer outras seções de acordo com as necessidades específicas do seu projeto.
css
