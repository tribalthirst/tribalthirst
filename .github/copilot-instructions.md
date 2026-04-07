# Project Guidelines

## Architecture
- This repository contains two primary parts:
- Hugo site content and templates under src/.
- C# Azure Functions API under api/ with tests under api.Tests/.
- Prefer changes that keep these concerns separate and loosely coupled.

## Code Style
- Follow existing style and naming in nearby files before introducing new patterns.
- Keep edits minimal and avoid broad refactors unless requested.
- Add brief comments only when logic is non-obvious.

## Build and Test
- Build Functions API from repo root with the VS Code task build (functions), or run dotnet build in api/.
- Run API tests from api.Tests/ with dotnet test.
- For Hugo changes, prefer validating generated output and content links before finalizing.

## Conventions
- For content changes, preserve front matter shape used by files in src/content/.
- For C# domain models, keep value-object and validation patterns consistent with api/models/ and api/entities/.
- When adding tests, mirror existing folder intent: unit tests in api.Tests/models or api.Tests/entities and integration tests in api.Tests/integration.
