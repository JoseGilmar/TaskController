# TaskController

Uma aplicação para gerenciar tarefas e pessoas, permitindo a criação, leitura, atualização e exclusão de registros de pessoas e tarefas.

## Índice

1. [Pré-requisitos](#pré-requisitos)
2. [Instalação](#instalação)
3. [Uso da API](#uso-da-api)
   - [Criar Pessoa](*criar-pessoa)
   - [Criar Tarefa](*criar-tarefa)
   - [Listar Pessoas](*listar-pessoas)
   - [Listar Tarefas](*listar-tarefas)
   - [Obter Pessoa por ID](*obter-pessoa-por-id)
   - [Obter Tarefa por ID](*obter-tarefa-por-id)
   - [Atualizar Pessoa](*atualizar-pessoa)
   - [Atualizar Tarefa](*atualizar-tarefa)
   - [Deletar Pessoa](*deletar-pessoa)
   - [Deletar Tarefa](*deletar-tarefa)
4. [Contribuição](#contribuição)
5. [Licença](#licença)

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
2. **Restaurar as dependências:**
   dotnet restore
3. **Configurar o banco de dados: Execute as migrations para criar o banco de dados:**
   dotnet ef database update
4. **Executando a Aplicação inicie a aplicação com o comando:**
   dotnet run
   Você pode acessar a interface do Swagger para testar os endpoints

## Uso da API

**Criar Pessoa**
Endpoint: POST /api/Pessoas
Request Body:
{
  "nome": "João",
  "email": "joao@example.com",
  "dataNascimento": "1990-01-01T00:00:00Z"
}

**Criar Tarefa**
Endpoint: POST /api/Tarefas
Request Body:
{
  "titulo": "Tarefa 1",
  "descricao": "Descrição da tarefa 1",
  "dataCriacao": "2024-10-31T00:00:00Z",
  "pessoaId": 1
}

**Listar Pessoas**
Endpoint: GET /api/Pessoas

**Listar Tarefas**
Endpoint: GET /api/Tarefas

**Obter Pessoa por ID**
Endpoint: GET /api/Pessoas/{id}

**Obter Tarefa por ID**
Endpoint: GET /api/Tarefas/{id}

**Atualizar Pessoa**
Endpoint: PUT /api/Pessoas/{id}
Request Body:
{
  "nome": "João Atualizado",
  "email": "joao_atualizado@example.com",
  "dataNascimento": "1990-01-01T00:00:00Z"
}

**Atualizar Tarefa**
Endpoint: PUT /api/Tarefas/{id}
Request Body:
{
  "titulo": "Tarefa Atualizada",
  "descricao": "Descrição da tarefa atualizada",
  "dataCriacao": "2024-10-31T00:00:00Z",
  "pessoaId": 1
}

**Deletar Pessoa**
Endpoint: DELETE /api/Pessoas/{id}
Deletar Tarefa
Endpoint: DELETE /api/Tarefas/{id}


## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues para melhorias.

## Licença
Este projeto não possui uma licença formal. Todos os direitos reservados a José Gilmar Raymundo Junior. Qualquer uso, modificação ou distribuição do código requer permissão explícita.
