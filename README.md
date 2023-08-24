# Projeto CRUD ASP.NET Core MVC

Este é um projeto de exemplo que demonstra a criação de um CRUD (Create, Read, Update, Delete) usando ASP.NET Core MVC. O projeto utiliza Entity Framework Core e SQL Server como banco de dados, realiza requisições à API ViaCep usando jQuery e AJAX, e aplica estilização com Bootstrap.

## Funcionalidades

- Criação, leitura, atualização e exclusão de registros no banco de dados.
- Integração com a API ViaCep para obter informações de endereços.
- Interface amigável e responsiva usando Bootstrap.

## Pré-requisitos

- ASP.NET Core SDK [Link](https://dotnet.microsoft.com/download)
- SQL Server [Link](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Visual Studio ou Visual Studio Code (opcional)

## Instruções de Uso

1. Clone este repositório para o seu ambiente local.
2. Abra o projeto em sua IDE preferida (Visual Studio recomendado).
3. Configure a conexão com o banco de dados SQL Server no arquivo `appsettings.json`.
4. No Package Manager Console, execute as migrações para criar o banco de dados:
5. Compile e execute o aplicativo.
6. Acesse a aplicação em seu navegador e explore as funcionalidades CRUD.

## Estrutura do Projeto

- `Controllers/`: Contém os controladores MVC para gerenciar as requisições HTTP.
- `Models/`: Define as classes de modelo que representam as entidades no banco de dados.
- `Views/`: Armazena os arquivos de visualização em formato Razor (cshtml).
- `wwwroot/`: Contém arquivos estáticos como scripts JavaScript, folhas de estilo e imagens.
- `Services/`: Lógica de serviço adicional, como integração com a API ViaCep.

## Tecnologias Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- jQuery
- AJAX
- Bootstrap

## Contribuição

Contribuições são bem-vindas! Se você quiser melhorar este projeto, siga estas etapas:

1. Fork o repositório.
2. Crie um branch para suas alterações: `git checkout -b feature/nova-feature`.
3. Faça as alterações e realize commits: `git commit -m 'Adiciona nova feature'`.
4. Push para o branch: `git push origin feature/nova-feature`.
5. Abra um Pull Request.


Desenvolvido por Guilherme Moitinho.
