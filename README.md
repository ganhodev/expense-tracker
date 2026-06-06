💸 Controle de Gastos — Gerenciador Financeiro em C#
Aplicação de console desenvolvida em C# como projeto de aprendizado, evoluindo os conceitos do projeto anterior (TodoList) com novos tipos de dados, LINQ e lógica financeira.

💡 Sobre o projeto
O Controle de Gastos permite registrar despesas com nome, valor e categoria, acompanhar o estado de pagamento de cada uma e visualizar o total gasto. Tudo rodando no terminal com um menu interativo.
Este projeto foi desenvolvido como segunda etapa da jornada de aprendizado em .NET — a próxima versão terá persistência em banco de dados com Entity Framework Core.

⚙️ Funcionalidades

➕ Adicionar despesa com nome, valor e categoria
📋 Listar despesas com estado de pagamento
✔️ Marcar despesa como paga
🗑️ Remover despesa por ID
💰 Calcular total gasto
🔍 Filtrar despesas por categoria


🛠️ Tecnologias utilizadas

C#
.NET 10
Console Application
LINQ (Where, Sum)


🏗️ Estrutura do projeto
ControleDeGastos/
├── Despesa.cs           # Modelo da despesa com ID automático e DateTime
├── DespesaService.cs    # Lógica de negócio (CRUD + filtros com LINQ)
└── Program.cs           # Menu interativo no terminal

▶️ Como rodar
Pré-requisitos: .NET 10 SDK instalado.
bash# Clone o repositório
git clone https://github.com/ganhodev/controle-de-gastos.git

# Entre na pasta
cd controle-de-gastos

# Rode o projeto
dotnet run

📚 O que aprendi neste projeto

Uso do tipo decimal para valores monetários
Uso do DateTime.Now para registro automático de data
Filtros com LINQ usando Where() e ToLower() para comparação sem distinção de maiúsculas
Cálculo de totais com Sum()
Escopo de variáveis dentro do switch com chaves {}
Uso de TryParse para evitar travamento por entrada inválida


🔜 Próximas versões
VersãoDescriçãov2.0Persistência com banco de dados usando Entity Framework Corev3.0API REST com ASP.NET Core e Swagger

👨‍💻 Autor
Desenvolvido como parte da jornada de aprendizado em .NET — rumo ao projeto Zona Vermelha.