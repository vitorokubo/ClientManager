﻿# ClientManager


O seguinte projeto foi feito com base em um processo seletivo. Onde o desenvolvedor deveria:

Cenário: A empresa X precisa de um sistema para gerenciar seus clientes e produtos. O sistema deve permitir:

Cadastrar, editar e remover clientes, com informações como nome, endereço, telefone e email.
Cadastrar, editar e remover produtos, com informações como nome, descrição, preço e estoque.
Realizar a venda de produtos, registrando o cliente, os produtos e a quantidade de cada item.
Gerar relatórios de vendas, clientes e estoque.

O projeto não foi entregue por completo devido a limitação de tempo e tudo que foi produzido nele foi elaborado em 5 dias dado a minha disponibilidade de tempo.
Meu foco para o projeto foi elaborar um projeto escalavel com arquitetura DDD e testes.

A estrutura do projeto está:
```plaintext
.
├── Core/					# Camada de regras de negócio e contratos
│   ├── ClienteManager.Application/		# Lógica da aplicação e serviços
│   │   ├── DTOs				# Objetos de transferência de dados
│   │   ├── Interfaces			        # Interfaces de serviços
│   │   ├── Mappings				# Configuração de mapeamento (ex.: AutoMapper)
│   │   └── Services				# Implementações de serviços da aplicação
│   ├── ClienteManager.Domain/		        # Domínio da aplicação
│   │   ├── Entities				# Entidades de domínio
│   │   ├── Interfaces				# Interfaces do domínio (ex.: repositórios)
│   │   └── Validations				# Classes de validação de regras de negócio [Em Construção]
├── Infrastructure/				# Infraestrutura e persistência de dados
│   ├── ClienteManager.Infrastructure.Data/		
│   │   ├── Context				# Configuração do contexto do banco de dados
│   │   ├── EntitiesConfiguration		# Mapeamento de entidades
│   │   ├── Identity				# Configuração de autenticação e autorização
│   │   ├── Migrations				# Migrações do banco de dados
│   │   └── Repositories			# Implementações de repositórios
│   ├── ClienteManager.Infrastructure.IoC/	# Injeção de dependências
├── Presentation/				# Camada de apresentação
│   ├── ClienteManager.API/			# API RESTful  [Em Construção]
│   └── ClienteManager.BlazorServer/		# Interface web com Blazor Server [EmConstrução]
├── Test/					# Testes automatizados [Em Construção]
│   ├── ClienteManager.Domain.Tests/		# Unit Test do Domain [Em Construção]
```
Pontos em construção, são atividades pendentes de entrega mas em geral inicializadas.                

## Como Rodar

Foi criado para o projeto um arquivo docker-compose para que sejá criado uma container do Postgres com setup inicial do nosso banco.
Use o comando na raiz ./ 

`docker compose up -d`

Apos isso rode as migrações com o projeto padrão ClienteManager.Infrastructure.Data com

`update-database`

Após isso você pode rodar nossas camadas de Presentation com os projeto.

- API
- BlazorServer

## Requisitos Atendidos

Tarefas:

- **Criar o banco de dados:**   #Parcial
  - [x] Criar as tabelas para clientes, produtos e vendas no PostgreSQL.
  - [x] Definir as chaves primárias, estrangeiras e índices.
  - [x] Criar as queries para inserir, atualizar, remover e consultar dados.

- **Desenvolver a aplicação desktop:** #Parcial
  - [ ] Criar a interface gráfica do usuário (GUI) utilizando Windows Forms.
  - [x] Implementar a funcionalidade de cadastro, edição e remoção para as entidades criadas.
  - [ ] Implementar a funcionalidade de geração de relatórios utilizando o ReportViewer.
  - [x] Utilizar a biblioteca NPGSQL para acessar o banco de dados.

- **Testar a aplicação (Opcional - Será considerado um diferencial o desenvolvimento desta etapa):**
  - [x] Realizar testes unitários para verificar o funcionamento correto de cada módulo da aplicação.
  - [ ] Realizar testes de integração para verificar a interação entre os diferentes módulos.
  - [ ] Documentar os testes realizados e os resultados.

- **Criar o repositório Git:**
  - [x] Criar um repositório Git para armazenar o código da aplicação.
  - [x] Adicionar todos os arquivos do projeto ao repositório.
  - [x] Criar um commit com a mensagem "Implementação inicial do sistema de gerenciamento de clientes e produtos".
