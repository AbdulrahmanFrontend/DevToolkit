# DevToolkit

A lightweight collection of reusable .NET libraries designed to simplify common application development tasks such as data access, validation, logging, configuration, and shared infrastructure.

> **Status:** Active personal project (under continuous development)

---

## Overview

DevToolkit is a modular toolkit created to reduce boilerplate code and improve code organization across multiple desktop and backend projects.

It was originally developed while building real-world business applications, including inventory management and sales systems, to eliminate repetitive code and provide reusable building blocks for future projects.

The project is **not intended to replace Entity Framework Core or Dapper**. Instead, it focuses on providing a clean, extensible foundation that can work alongside different data access technologies.

---

## Goals

- Reduce repetitive code
- Improve maintainability
- Encourage clean architecture
- Provide reusable infrastructure
- Support multiple database providers
- Keep dependencies lightweight
- Serve as a learning project for advanced .NET concepts

---

# Current Modules

## DevToolkit.Core

Common shared functionality including:

- Result Pattern
- Validation
- Guard Clauses
- Shared Helpers
- Common Utilities

---

## DevToolkit.Data

Data access abstraction built on top of ADO.NET.

Current features include:

- Provider-independent database access
- Generic query execution
- Object mapping
- Scalar queries
- DataTable support
- Parameter abstraction
- Connection management

Supported providers include:

- SQL Server
- SQLite

---

## DevToolkit.Logging

Simple logging infrastructure.

Current features:

- File logging
- Event logging
- Log manager

---

## Planned Modules

The following modules are planned for future development:

- Security
- Caching
- Background Jobs
- Dependency Injection Extensions
- Configuration
- Reporting
- Dapper Integration
- Entity Framework Core Integration

---

# Design Principles

The project follows several software engineering principles including:

- Separation of Concerns
- Single Responsibility Principle
- Reusability
- Extensibility
- Dependency Abstraction
- Minimal External Dependencies

---

# Example

```csharp
var result = DataQueryService.FirstOrDefault<PersonModel>(
    CommandType.Text,
    sql,
    parameters);

if (result.IsSuccess)
{
    Console.WriteLine(result.Data.FullName);
}
```

---

# Why This Project Exists

While working on multiple desktop business applications, many common patterns were repeatedly implemented.

DevToolkit was created to centralize those shared components instead of duplicating them across projects.

The toolkit is intended to improve productivity while also serving as a practical learning project for software architecture and framework design.

---

# Technologies

- C#
- .NET Framework
- ADO.NET
- SQL Server
- SQLite
- Generic Programming
- Reflection
- Object Mapping

---

# Roadmap

Future work includes:

- Async APIs
- Dapper support
- Entity Framework Core support
- Dependency Injection integration
- Unit tests
- NuGet packaging
- Improved documentation
- Performance benchmarking

---

# License

This project is currently released for portfolio and educational purposes.

---

# Author

Abdelrahman Nasser

GitHub:
(Your GitHub Profile)

LinkedIn:
(Your LinkedIn Profile)
