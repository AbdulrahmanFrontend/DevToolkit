# DevToolkit

A set of reusable .NET Framework libraries designed to share common infrastructure and UI components across Windows desktop applications.

**Target Framework:** .NET Framework 4.8

## Modules

- **DevToolkit.Core:** Shared result types, validation helpers, guard clauses, and utilities.
- **DevToolkit.Data:** ADO.NET data-access abstractions, query execution, object mapping, and SQL Server / SQLite providers.
- **DevToolkit.Logging:** Reusable logging components.
- **DevToolkit.Infrastructure:** Database initialization, backup, configuration, and application-folder utilities.
- **DevToolkit.Security:** Password-hashing utilities.
- **DevToolkit.BaseWinForms:** Reusable Windows Forms controls and UI components.
- **DevToolkit.BaseWPF:** Shared WPF controls and supporting UI components.

## Technology Stack

- C#
- .NET Framework 4.8
- ADO.NET
- SQL Server
- SQLite
- Windows Forms
- WPF

## Purpose

DevToolkit was created to reduce duplicated code and centralize common functionality used by .NET Framework desktop applications.

It is intended for existing desktop projects rather than as a general-purpose modern .NET or ASP.NET Core framework.

## Project Status

The library has evolved alongside the desktop applications that use it. Changes to shared components may require compatibility updates in older dependent projects.
