# ✨ Desenvolvido por Mateus Teni Pierro - RM555125
Heitor Romero da Rocha - RM558301
Caroline Souza do Amaral - RM558012

# Patio API - Sistema de Gestão de Pátio

Bem-vindo ao projeto **Patio API**, desenvolvido como parte da Sprint 4. Esta API gerencia o fluxo de motos, operadores e movimentações dentro de um sistema de pátio. O projeto foi desenvolvido utilizando **.NET 9**, **EF Core**, **Swagger**, **Health Check**, Oracle Database e boas práticas de arquitetura.

---

# ✅ Objetivo do Projeto

Fornecer uma API REST completa para gerenciar:

* **Motos**
* **Operadores**
* **Movimentações no pátio**
* **Health check**
* **Endpoint de Machine Learning (Stub)**

---

# ✅ Tecnologias Utilizadas

* **.NET 9**
* **C#**
* **Entity Framework Core**
* **Oracle Provider for EF Core**
* **Swagger (Swashbuckle)**
* **API Versioning**
* **Health Checks**

---

# ✅ Estrutura do Projeto

```
PatioApi/
 ├── Controllers/
 │    ├── MotosController.cs
 │    ├── OperadoresController.cs
 │    ├── MovimentacoesController.cs
 │    └── MLController.cs
 │
 ├── DTOs/
 │    ├── MotoDTO.cs
 │    ├── MovimentacaoDTO.cs
 │    └── OperadorDTO.cs
 │
 ├── Models/
 │    ├── Moto.cs
 │    ├── Movimentacao.cs
 │    └── Operador.cs
 │
 ├── Repositories/
 │    ├── MotoRepository.cs
 │    ├── OperadorRepository.cs
 │    └── MovimentacaoRepository.cs
 │
 ├── Services/
 │    ├── MotoService.cs
 │    ├── OperadorService.cs
 │    └── MovimentacaoService.cs
 │
 ├── Data/
 │    └── PatioContext.cs
 │
 └── Program.cs
```

---

# ✅ Endpoints

## ✅ **Root**

### `GET /`

Retorna mensagem "API do Pátio funcionando!".

## ✅ **Health Check**

### `GET /health`

Verifica se a API está funcionando corretamente.

---

# ✅ Módulo: Motos

Base URL: `/api/Motos`

### **GET /api/Motos** — Lista todas as motos

### **POST /api/Motos** — Cadastra nova moto

### **GET /api/Motos/{id}`** — Obtém moto por ID

### **PUT /api/Motos/{id}`** — Atualiza moto

### **DELETE /api/Motos/{id}`** — Remove moto

---

# ✅ Módulo: Operadores

Base URL: `/api/Operadores`

### **GET /api/Operadores**

### **POST /api/Operadores**

### **GET /api/Operadores/{id}`**

### **PUT /api/Operadores/{id}`**

### **DELETE /api/Operadores/{id}`**

---

# ✅ Módulo: Movimentações

Base URL: `/api/Movimentacoes`

### **GET /api/Movimentacoes**

### **POST /api/Movimentacoes**

### **GET /api/Movimentacoes/{id}`**

### **PUT /api/Movimentacoes/{id}`**

### **DELETE /api/Movimentacoes/{id}`**

---

# ✅ Módulo ML (Machine Learning)

Base URL: `/v1/ml/predict`

### **POST /v1/ml/predict**

Endpoint preparado para integrar futuramente com ML.NET.

Entrada:

```json
{
  "entrada": 123
}
```

Saída:

```json
{
  "resultado": "Predição gerada (stub)"
}
```

---

# ✅ Configuração de Ambiente

É necessário configurar o banco Oracle em:

```
appsettings.json
```

Exemplo:

```json
"ConnectionStrings": {
  "OracleConnection": "User Id=admin;Password=1234;Data Source=localhost:1521/xepdb1"
}
```

---

# ✅ Como executar o projeto

### 1. Restaurar dependências

```
dotnet restore
```

### 2. Compilar

```
dotnet build
```

### 3. Rodar

```
dotnet run
```

O console exibirá:

```
Now listening on: http://localhost:5204
```

### 4. Acessar Swagger

👉 [http://localhost:5204/swagger](http://localhost:5204/swagger)

---

# ✅ API Versioning

A API utiliza versão padrão **v1**:

```
builder.Services.AddApiVersioning(...)
```

O MLController já está versionado como:

```
/v1/ml/predict
```

---

# ✅ Health Check

Implementado com:

```
builder.Services.AddHealthChecks();
```

Teste em:
👉 `/health`

---

# ✅ Status Final

✅ Projeto rodando sem erros
✅ Swagger configurado
✅ Versionamento ativo
✅ Repositórios + Services funcionando
✅ Root endpoint corrigido
✅ Documentação concluída

---




