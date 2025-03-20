Desafio Engenheiro de Software - BTG Pactual

Introdução

Este repositório contém a implementação do desafio técnico para Engenheiro de Software proposto pelo BTG Pactual. O objetivo é processar pedidos, armazená-los em uma base de dados e fornecer uma API REST para consulta das informações processadas.

Tecnologias Utilizadas

Linguagem: C# (.NET 7)

Banco de Dados: PostgreSQL

Mensageria: RabbitMQ

Containerização: Docker

Ferramentas: Visual Studio, Postman, GitHub Actions

Estrutura do Projeto

Funcionalidades Implementadas

Processamento de mensagens de pedidos via RabbitMQ.

Persistência dos pedidos em um banco de dados PostgreSQL.

API REST para consulta de:

Valor total de um pedido

Quantidade de pedidos por cliente

Lista de pedidos por cliente

Documentação da API utilizando Swagger.

Execução do ambiente via Docker.

Como Executar

Requisitos:

Docker e Docker Compose instalados.

Git instalado.

Passos:

Clone este repositório:

Inicie os containers com Docker Compose:

Acesse a API através do navegador ou Postman:

Exemplo de Requisição

Criar Pedido

Consultar Valor Total do Pedido
