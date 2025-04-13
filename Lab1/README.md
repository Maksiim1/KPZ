# Programming Principles in My Code

Here I want to describe how I tried to follow the programming principles that I learned in lectures.

## SOLID principles

### S - Single Responsibility Principle
In my code, each class is responsible for something specific. For example:
- The `Money` class (Money.cs file) deals only with money operations and nothing else
- The `Product` class (Product.cs file) describes only the product and its characteristics
- `Warehouse` (Warehouse.cs) only manages the list of products
- `Reporting` (Reporting.cs) only outputs reports

So the classes don't have mixed responsibilities, each deals with one thing.

### O - Open/Closed Principle
My classes can be extended without changing their code. For example, the `Warehouse` class can be extended with new methods or inherited from. In `Reporting`, you can add new types of reports without changing the existing code.

### L - Liskov Substitution Principle
I don't have much inheritance in my code, but the design allows this principle to be used. If we created a subclass of `Product`, it would work normally in `Warehouse`.

### I - Interface Segregation Principle
There are no explicitly defined interfaces in the code, but the class methods are grouped by function:
- `Warehouse` has only methods for working with products (adding, searching, etc.)
- `Reporting` has only methods for reporting

### D - Dependency Inversion Principle
In the `Reporting` class (lines 11-14), I use a dependency on `Warehouse`, which I pass through the constructor. This makes it easy to replace the `Warehouse` implementation if needed.

## Other principles

### DRY (Don't Repeat Yourself)
I tried not to repeat the code. For example:
- All money calculations are concentrated in the `Money` class
- Working with products - in the `Product` class

### KISS (Keep It Simple, Stupid)
My implementations are quite simple. For example:
- The `Money` constructor (lines 12-16) has simple logic
- `Warehouse` methods are simple and understandable

### YAGNI (You Aren't Gonna Need It)
I only added what was needed for the system to work:
- No extra methods or properties
- The `Product` class has only the necessary attributes and methods

### Fail Fast
The code checks for errors at the beginning:
- The `Money.Subtract` method (lines 24-25) checks that the amount won't be negative
- `Warehouse.AddProduct` (line 14) checks that the product is not null
- The `Reporting` constructor (line 14) checks the warehouse parameter

### Program to Interfaces not Implementations
Although I don't use explicit interfaces, I work through the public methods of classes, not with their internal implementation. For example, the `Reporting` class works with `Warehouse` only through its public methods.

### Encapsulation
I properly encapsulate the data:
- The `Money` class (lines 7-8) protects its state with private setters
- `Product` (line 12) protects `Price` with a private setter

### Composition Over Inheritance
I prefer composition over inheritance:
- `Product` (line 12) uses a `Money` object for the price
- `Reporting` (line 11) uses a `Warehouse` object
