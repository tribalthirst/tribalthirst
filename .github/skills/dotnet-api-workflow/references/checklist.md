# Dotnet API Checklist

- Function route and input contract are explicit.
- Validation rules cover null, malformed, and boundary cases.
- Domain objects keep invariant checks in constructors/factories.
- Unit tests cover business behavior and invalid inputs.
- Integration tests verify HTTP behavior and status codes.
- Build and test commands succeed before merge.
