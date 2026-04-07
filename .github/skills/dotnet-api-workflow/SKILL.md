---
name: dotnet-api-workflow
description: 'Implement and validate C# Azure Functions API updates with consistent domain validation, handler design, and tests.'
argument-hint: 'Endpoint behavior, inputs, constraints, and expected outputs'
user-invocable: true
---
# Dotnet API Workflow

## When to Use
- Adding or modifying Azure Functions endpoints.
- Updating entities/value objects and validation paths.
- Planning test coverage for API behavior changes.

## Procedure
1. Inspect relevant files under api/ and api.Tests/.
2. Apply behavior changes with minimal surface area.
3. Add/update unit and integration tests.
4. Run through the [API checklist](./references/checklist.md).

## Deliverable
- Code and tests aligned with project architecture and validation patterns.
