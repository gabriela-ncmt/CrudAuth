## CrudAuth API

Este projeto é uma aplicação simples de CRUD com autenticação e autorização, utilizando tokens JWT para acesso seguro. A aplicação permite que os usuários se registrem, façam login e gerenciem produtos com controle de acesso baseado em papéis. Apenas usuários com o papel de "Admin" podem realizar operações CRUD nos produtos, enquanto usuários comuns podem apenas acessar os dados dos produtos.

## Funcionalidades
- Autenticação de Usuário: Permite que os usuários se registrem e façam login utilizando tokens JWT.
- Autorização com Base em Papéis: Somente usuários com o papel "Admin" podem realizar operações CRUD nos produtos.
- Gestão de Produtos: Usuários administradores podem criar, atualizar, excluir e recuperar produtos.

## Tecnologias Utilizadas
ASP.NET Core 6: Framework web para construção da API.
- Entity Framework Core: ORM para interação com o banco de dados.
- SQL Server: Banco de dados utilizado para armazenar os dados dos usuários e produtos.
- JWT: Tokens JWT para autenticação.
- ASP.NET Identity: Para gerenciamento de usuários (registro, login, etc.).

## Fluxo de Autenticação
- Login: Os usuários precisam fazer login com suas credenciais (nome de usuário e senha) para receber um token JWT.
- Autorização: Após o login, o token JWT deve ser enviado no cabeçalho Authorization como Bearer <token> para acessar os endpoints protegidos.
- Acesso Admin: Apenas usuários com o papel "Admin" estão autorizados a criar, atualizar ou excluir produtos.

## Variáveis de Ambiente
- Jwt:SecretKey: A chave secreta usada para assinar os tokens JWT.
- Jwt:Issuer: O emissor dos tokens JWT.
- Jwt:Audience: O público para o qual os tokens JWT são destinados.
