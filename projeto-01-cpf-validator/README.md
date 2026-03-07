# Microsserviço Serverless para Validação de CPF

Este projeto consiste na implementação de um **microsserviço serverless utilizando Azure Functions** para realizar a validação de números de CPF.

O projeto foi desenvolvido como parte do laboratório prático do **Bootcamp Microsoft AZ-204** da DIO.

---

# Objetivo

Criar uma função serverless capaz de receber um CPF via requisição HTTP e verificar se o número informado é válido de acordo com as regras de cálculo do CPF.

Esse tipo de abordagem é muito utilizado em arquiteturas modernas baseadas em **microsserviços e computação serverless**.

---

# Tecnologias Utilizadas

* Python
* Azure Functions
* HTTP Trigger
* Serverless Architecture

---

# Estrutura do Projeto

```
src/CpfValidator
│
├── __init__.py
├── function.json
└── cpf_validator.py
```

Descrição dos arquivos:

* **cpf_validator.py** → contém a lógica de validação do CPF
* **function.json** → define as configurações da Azure Function
* ****init**.py** → ponto de entrada da função

---

# Funcionamento

A função é acionada através de uma requisição HTTP.

Exemplo de chamada da API:

```
GET /api/validate-cpf?cpf=12345678909
```

A função processa o número informado e retorna se o CPF é válido ou inválido.

---

# Conceitos Aplicados

Este projeto demonstra conceitos importantes de computação em nuvem:

* Arquitetura serverless
* Microsserviços
* APIs HTTP
* Escalabilidade automática

---

# Possíveis Melhorias

Algumas melhorias que podem ser aplicadas ao projeto:

* Implementar tratamento de erros mais robusto
* Adicionar testes automatizados
* Criar documentação da API
* Integrar monitoramento com Azure Application Insights

---

