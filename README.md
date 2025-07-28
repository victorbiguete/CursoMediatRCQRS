# 🧭 Projeto CQRS com MediatR

Este projeto é um exemplo de aplicação CRUD utilizando o padrão **CQRS (Command Query Responsibility Segregation)** em conjunto com a biblioteca oficial **MediatR**, promovendo desacoplamento entre as camadas da aplicação.

---

## ✅ Funcionalidades

- ✅ CRUD completo de entidades (Create, Read, Update, Delete)
- ✅ Separação clara entre comandos (escrita) e queries (leitura)
- ✅ Uso da biblioteca **MediatR** para mediação entre controller e camada de aplicação
- ✅ Organização em camadas (Domain, Application, Infrastructure, API)

---

## 🛠 Tecnologias Utilizadas

| Tecnologia        | Uso                                 |
|------------------|--------------------------------------|
| ASP.NET Core      | Web API backend                     |
| Entity Framework Core | ORM para banco de dados        |
| SQLite            | Banco de dados local leve           |
| MediatR           | Biblioteca para padrão mediator     |
| AutoMapper        | Mapeamento de DTOs                  |
| Swagger (Swashbuckle) | Documentação interativa da API |

---

## 📁 Estrutura do Projeto

```plaintext
CQRS-MediatR/
│
├── Application/
│   ├── Commands/
│   │   ├── CreateEntity/
│   │   ├── UpdateEntity/
│   │   └── DeleteEntity/
│   ├── Queries/
│   │   └── GetEntityById/
│   └── Handlers/
│
├── Domain/
│   └── Entities/
│
├── Infrastructure/
│   └── Repositories/
│
├── API/
│   └── Controllers/
│
└── Program.cs / Startup.cs
```

---

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/victorbiguete/CursoMediatRCQRS
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd CursoMediatRCQRS
   ```

3. Restaure os pacotes:
   ```bash
   dotnet restore
   ```

4. Rode as migrações e atualize o banco:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:
   ```bash
   dotnet run
   ```

---

## 📚 Conceitos Aplicados

- **CQRS**: Segregação de comandos e consultas para maior clareza e escalabilidade.
- **MediatR**: Encaminhamento das requisições via handlers, sem acoplamento direto entre controlador e lógica de negócio.
- **Boas práticas de arquitetura**: SOLID, separação de responsabilidades, injeção de dependência.

---

## 👨‍💻 Autor

Desenvolvido por [Seu Nome](https://www.linkedin.com/in/seu-perfil).
