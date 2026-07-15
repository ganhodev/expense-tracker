# 💸 Controle de Gastos — Gerenciador Financeiro em C#

Projeto de aprendizado em .NET, evoluindo de uma aplicação console simples para uma **API REST** com arquitetura em camadas e validação de regras de negócio.

## 💡 Sobre o projeto

O Controle de Gastos permite registrar despesas com descrição, valor, categoria e data, além de listar, filtrar e remover gastos. A versão atual (v3) expõe essas operações via API REST, com validação automática das regras de negócio usando FluentValidation.

## 🏗️ Arquitetura

O projeto segue uma separação em camadas:

```
ControleDeGastos/
├── Domain/         # Entidades (Gasto)
├── Repository/      # Persistência em memória
├── Services/        # Regras de negócio e orquestração
├── Validator/       # Regras de validação com FluentValidation
└── Controllers/     # Endpoints HTTP (API REST)
```

## ⚙️ Funcionalidades

- ➕ Adicionar gasto com descrição, valor, categoria e data
- ✅ Validação automática (valor positivo, descrição mínima, categoria válida, data não futura)
- 📋 Listar todos os gastos
- 🗑️ Remover gasto por ID
- 🔍 Totais agrupados por categoria (LINQ)

## 🛠️ Tecnologias utilizadas

- C# / .NET 10
- ASP.NET Core Web API
- FluentValidation
- LINQ
- Swagger (documentação automática de endpoints)

## ▶️ Como rodar

Pré-requisitos: .NET 10 SDK instalado.

```bash
git clone https://github.com/ganhodev/expense-tracker.git
cd expense-tracker
dotnet restore
dotnet run
```

A documentação dos endpoints fica disponível via Swagger ao rodar o projeto localmente.

## 📚 Histórico de versões

| Versão | Descrição | Status |
|--------|-----------|--------|
| v1.0 | Aplicação console com CRUD em memória e LINQ | ✅ Concluído |
| v2.0 | Persistência com Entity Framework Core | 🔜 Planejado |
| v3.0 | API REST com ASP.NET Core, arquitetura em camadas e FluentValidation | ✅ Concluído |

## 📚 O que aprendi neste projeto

- Migração de aplicação console para API REST
- Separação de responsabilidades em camadas (Domain, Repository, Service, Controller)
- Validação de regras de negócio com FluentValidation
- Injeção de dependência via construtor (primary constructors do C# 12)
- Tratamento de exceções e retorno de status HTTP apropriados
- Fluxo de branches no Git para evoluir um projeto existente sem quebrar a versão estável

## 🔜 Próximos passos

- Persistência com Entity Framework Core + SQLite
- Testes unitários com xUnit
- Frontend em Angular consumindo a API

## 👨‍💻 Autor

Desenvolvido como parte da jornada de aprendizado em .NET