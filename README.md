# 📚 GerenciadorDeLivraria

API REST desenvolvida em **.NET** para gerenciar livros de uma livraria, permitindo **CRUD completo**, validações de regras de negócio, documentação via **Swagger** e organização do domínio utilizando **herança**.

Projeto desenvolvido como parte de um desafio prático de aprendizado.

---

## 🚀 Funcionalidades

- Criar um livro
- Listar todos os livros
- Buscar livro por ID
- Atualizar informações de um livro
- Excluir um livro

---

## 📋 Regras de Negócio

- `title` e `author` não podem estar duplicados
- `price` não pode ser negativo
- `stock` não pode ser negativo
- `genre` deve ser um valor válido
- `CreatedAt` é preenchido na criação
- `UpdatedAt` é atualizado em alterações

---

## 🛠️ Tecnologias Utilizadas

- .NET (ASP.NET Core)
- C#
- Swagger (OpenAPI)
- Programação Orientada a Objetos

---

## ▶️ Como rodar o projeto

### 🔧 Pré-requisitos

Antes de iniciar, certifique-se de ter instalado:

- [.NET SDK 7 ou superior](https://dotnet.microsoft.com/download)
- Visual Studio ou Visual Studio Code

Verifique se o .NET está instalado executando:

```bash
dotnet --version
```

---

### ▶️ Executando a aplicação

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/GerenciadorDeLivraria.git
```

2. Acesse a pasta do projeto:

```bash
cd GerenciadorDeLivraria
```

3. Restaure as dependências do projeto:

```bash
dotnet restore
```

4. Compile a aplicação para garantir que está tudo correto:

```bash
dotnet build
```

5. Execute a aplicação:

```bash
dotnet run
```

Caso esteja utilizando o **Visual Studio**:

- Abra o projeto
- Aguarde a restauração automática dos pacotes
- Pressione **F5** ou **Ctrl + F5** para executar

---

## 📑 Como acessar e testar a API (Swagger)

Com a aplicação em execução, abra o navegador e acesse:

```text
https://localhost:7200/swagger
```

> ⚠️ A porta pode variar conforme sua configuração.  
> Verifique a URL exibida no console ao executar o projeto.

No Swagger, você poderá:

- Visualizar todos os endpoints disponíveis
- Testar requisições `GET`, `POST`, `PUT` e `DELETE`
- Enviar dados e visualizar respostas da API em tempo real

---

## 📌 Endpoints Disponíveis

| Método | Endpoint | Descrição |
| ------ | -------- | --------- |
| POST | `/api/books` | Criar um novo livro |
| GET | `/api/books` | Listar todos os livros |
| GET | `/api/books/{id}` | Buscar livro por ID |
| PUT | `/api/books/{id}` | Atualizar um livro |
| DELETE | `/api/books/{id}` | Excluir um livro |

---

## 📬 Exemplo de Payload (POST)

```json
{
  "title": "Clean Code",
  "author": "Robert C. Martin",
  "genre": "Científico",
  "price": 99.90,
  "stock": 10
}
```

---

## 🧪 Observações Importantes

- O projeto utiliza armazenamento em memória para simular um banco de dados
- Os dados são perdidos ao reiniciar a aplicação
- O enum de gêneros permitidos é:
```
public enum BookGenre
{
    Ficção,
    Romance,
    Mistério,
    Fantasia,
    Terror,
    Suspense,
    Ação,
    Biografia,
    Histórico,
    Autoajuda,
    Infantil,
    Científico,
    Poesia,
    Drama,
    Aventura
}
```

---
Projeto desenvolvido como exercício prático de aprendizado em .NET.
