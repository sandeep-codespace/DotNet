# Design Patterns

We group design patterns into three categories: Creational, Structural, and Behavioral.

## Creational Patterns (Object Creation)
- Purpose: Control how objects are instantiated to avoid tight coupling and to encapsulate
  creation logic.

### Common Creational Patterns
- **Singleton**: Ensure a class has only one instance and provide a global access point. Use for
  logging, configuration, or resource pools.
- **Factory Method**: Define an interface for creating an object, but let subclasses decide which
  class to instantiate. Use when a class cannot anticipate the class of objects it must create.
- **Abstract Factory**: Provide an interface for creating families of related or dependent objects
  without specifying their concrete classes (e.g., cross-platform UI widgets).
- **Builder**: Separate the construction of a complex object from its representation so the same
  construction process can create different representations (e.g., constructing complex reports).
- **Prototype**: Create new objects by copying an existing instance (clone), useful for
  performance or when object setup is expensive.

### When to Use Creational Patterns
- Use when object creation logic is complex, needs to vary at runtime, requires reuse of setup
  logic, or when you want to decouple clients from concrete implementations.

## Structural Patterns (Object Composition)
- Purpose: Compose classes and objects into larger structures while keeping them flexible and
  maintainable. Structural patterns focus on how classes and objects are composed to form
  larger structures.

### Common Structural Patterns
- **Adapter**: Convert the interface of a class into another interface clients expect. Use to
  make incompatible interfaces work together.
- **Bridge**: Decouple an abstraction from its implementation so the two can vary independently
  (used in this repo as `Notification` + `INotification`).
- **Composite**: Compose objects into tree structures to represent part–whole hierarchies. Treat
  individual objects and compositions uniformly.
- **Decorator**: Attach additional responsibilities to an object dynamically. Use for adding
  features without subclassing.
- **Facade**: Provide a simplified interface to a complex subsystem.
- **Flyweight**: Share common state between many fine-grained objects to reduce memory usage.
- **Proxy**: Provide a surrogate or placeholder for another object to control access, lazy
  initialization, or logging.

### When to Use Structural Patterns
- Use when you need to change class relationships, reduce coupling, create lightweight object
  representations, or offer simplified interfaces over complex subsystems.

## Behavioral Patterns (Object Communication)
- Purpose: Manage communication, responsibilities, and algorithms between objects. These patterns
  describe how objects interact and distribute responsibility.

### When to Use Behavioral Patterns
- Use when object interactions are complex, when responsibilities need to be distributed, or
  when you want to define clear protocols for communication among objects.

--
This document covers the core creational and structural patterns. Ask if you want examples or
sample implementations added for any specific pattern.


