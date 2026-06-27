# Technology Stack

| Library               | Purpose                                                         |
| --------------------- | --------------------------------------------------------------- |
| Avalonia              | Cross-platform desktop UI                                       |
| CommunityToolkit.Mvvm | MVVM infrastructure (ObservableObject, RelayCommand, Messenger) |
| EF Core               | ORM for SQLite persistence                                      |
| SQLite                | Embedded local database                                         |
| DependencyInjection   | Service container                                               |
| CSharpier             | Automatic code formatting                                       |

## Avalonia

Purpose

> Cross-platform desktop UI framework.

Responsibilities

* Windows
* Linux
* macOS
* XAML UI
* Data Binding
* MVVM integration

Reason for selection

* Native desktop experience
* Mature MVVM support
* Cross-platform
* Active development

## Entity Framework Core

Purpose

> Persist application data in SQLite, Object-relational mapper.

Responsibilities

* Maps domain models to relational tables.
* Executes LINQ queries.
* Generates database migrations.
* Tracks entity changes.

Reason

* Zero configuration
* Portable
* Single-user desktop application

Not Used For

* Business logic
* Validation
* DTO mapping

## CommunityToolkit.Mvvm

Purpose

> Reduce MVVM boilerplate.

Used features

* ObservableObject
* ObservableProperty
* RelayCommand
* WeakReferenceMessenger (future)

Reason

Avoid manually implementing:

```csharp
INotifyPropertyChanged
```

## CSharpier

Purpose

> Opinionated code formatter.

Reason

Guarantees consistent formatting across contributors.

## Microsoft.Extensions.DependencyInjection

Purpose

> Dependency Injection container.

Responsibilities

* Construct ViewModels
* Construct repositories
* Construct DbContext

Reason

Official Microsoft DI library.
