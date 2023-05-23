# Single Responsibility Principle (SRP)
A module (class, method/function) should have one reason to change.

This principle is about cohesion, or how closely related the responsibilities of a module are. A module should have a single responsibility, and all of its services should be aligned with that responsibility.

By keeping the responsibilities of a module aligned, we can reduce the impact of change. If a module has multiple responsibilities, then a change to one of those responsibilities may affect the other responsibilities. This can lead to bugs and unexpected behavior.

## Example Types of Responsibilities

- Datastore Operations
  - Persistence, the action of saving data to a datastore (database, json, xml etc.)
  - Read/Retrieval, the action of reading data from a datastore or source (database, json, xml etc.)
- Logging
- Validation
- Business Logic / Use Case execution 
