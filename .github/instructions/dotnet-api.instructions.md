---
description: "Use when implementing or refactoring C# API logic, Azure Functions handlers, value objects, entities, or tests in api/ and api.Tests/."
name: "Dotnet API and Testing Guidance"
applyTo: "api/**/*.cs, api.Tests/**/*.cs"
---
# Dotnet API and Testing Guidance

- Keep domain invariants inside value objects and entities instead of controller or handler glue code.
- Prefer explicit validation and predictable error handling in function entry points.
- Keep function handlers thin; move business logic into testable methods or domain classes.
- Add or update tests in api.Tests/ for behavior changes, including invalid input paths.
- Maintain consistency with existing naming and test organization by unit vs integration scope.
