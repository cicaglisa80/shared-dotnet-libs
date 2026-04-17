# Milos.Shared.Core

Shared core utilities for internal .NET services.

---

## Installation

```xml
<PackageReference Include="Milos.Shared.Core" Version="0.2.0" />
```

Or via CLI:

```bash
dotnet add package Milos.Shared.Core --version 0.2.0
```

---

## Result\<T\>

Represents the outcome of an operation without throwing exceptions.
Use instead of try/catch for expected failure paths.

### Basic usage

```csharp
using Milos.Shared.Core;

// Success case
var result = Result<int>.Success(42);

if (result.IsSuccess)
    Console.WriteLine(result.Value); // 42

// Failure case
var failed = Result<int>.Failure("user not found");

if (failed.IsFailure)
    Console.WriteLine(failed.Error); // user not found
```

### Non-generic Result (no return value)

```csharp
Result DoSomething(bool fail)
{
    if (fail) return Result.Failure("it broke");
    return Result.Success();
}
```

---

## Changelog

See [CHANGELOG.md](./CHANGELOG.md).

---

## Owner

Milos Kirjakovic — ping on Slack or raise a repo issue.