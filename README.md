# Levge.Exceptions

[![Publish NuGet Package](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml/badge.svg)](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml)
[![NuGet](https://img.shields.io/nuget/v/Levge.Exceptions.svg)](https://www.nuget.org/packages/Levge.Exceptions)

A centralized exception library for use across the Levge .NET ecosystem. Provides structured, semantic exception types like `LevgeException`, `LevgeValidationException`, and `LevgeNotFoundException`.

---

## 📦 Installation

```bash
dotnet add package Levge.Exceptions
```

---

## ⚙️ Exception Types

### 🔸 `LevgeException`
Base exception class for all custom exceptions.

### 🔸 `LevgeNotFoundException`

```csharp
throw new LevgeNotFoundException("User", 42);
```

### 🔸 `LevgeValidationException`

```csharp
throw new LevgeValidationException("Email", "Invalid email format.");
```

Or with multiple fields:

```csharp
throw new LevgeValidationException(new Dictionary<string, string[]>
{
    ["Email"] = new[] { "Required" },
    ["Password"] = new[] { "Too short" }
});
```

### 🔸 `LevgeUnauthorizedException`

```csharp
throw new LevgeUnauthorizedException();
```

### 🔸 `LevgeConflictException`

```csharp
throw LevgeConflictException.ForField("Email", "test@example.com");
```

---

## 📛 Why Use It?

- Standardized exception handling across APIs, services, and libraries
- Helps map to consistent HTTP status codes (`400`, `401`, `404`, `409`)
- Promotes clean architecture separation of concerns

---

## 🛡️ License

MIT © [Levge](https://github.com/levge-projects)
