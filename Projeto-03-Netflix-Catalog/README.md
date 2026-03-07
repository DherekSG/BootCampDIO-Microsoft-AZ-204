# Gerenciador de Catálogo de Filmes - Azure Functions

Este projeto foi desenvolvido como parte do **Bootcamp Microsoft AZ-204** da DIO e demonstra a criação de um sistema serverless para gerenciamento de um catálogo de filmes inspirado em plataformas de streaming como a Netflix.

A aplicação utiliza **Azure Functions** para processar requisições HTTP e integra serviços de armazenamento e banco de dados na nuvem para persistência de dados.

---

# Arquitetura da Solução

A aplicação segue uma arquitetura baseada em serviços gerenciados da Azure:

Cliente → Azure Functions → Cosmos DB
↘ Blob Storage

* **Azure Functions** → execução da lógica da aplicação
* **Azure Cosmos DB** → armazenamento dos dados dos filmes
* **Azure Blob Storage** → armazenamento de arquivos e conteúdos relacionados

---

# Funcionalidades

O sistema permite:

* Upload de arquivos para o armazenamento na nuvem
* Cadastro de filmes no catálogo
* Consulta de registros armazenados
* Listagem de filmes cadastrados

Essas funcionalidades são implementadas através de funções serverless expostas por endpoints HTTP.

---

# Tecnologias Utilizadas

* Azure Functions
* Azure Cosmos DB
* Azure Blob Storage
* .NET / Azure SDK
* REST API

---

# Estrutura do Projeto

```
src/
 ├── SaveMovieFunction
 ├── ListMoviesFunction
 ├── GetMovieFunction
 └── UploadMovieFunction
```

Cada função representa uma operação da API responsável por interagir com os serviços da Azure.

---

# Objetivo do Projeto

O objetivo deste laboratório é demonstrar na prática conceitos importantes da computação em nuvem:

* Arquitetura serverless
* Integração entre serviços da Azure
* Persistência de dados em bancos distribuídos
* Construção de APIs escaláveis

---

# Observação

Este projeto foi desenvolvido como exercício educacional durante o bootcamp e tem como finalidade demonstrar a integração entre **Azure Functions, Cosmos DB e armazenamento em nuvem**.

---