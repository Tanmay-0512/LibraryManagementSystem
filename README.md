Installation and Running Instructions

To install and run the program, follow these steps:

Install .NET SDK (latest version) and Visual Studio Code with the C# extension.

Clone the repository using the command:

git clone https://github.com/your-repo/library-management-system.git
cd library-management-system

Open the project in Visual Studio Code:

code .

Restore dependencies:

dotnet restore

Compile the project:

dotnet build

Run the program:

dotnet run

Follow the on-screen menu to manage books.

## Features

### Part 1: Basic Library Management System

1. **Book Class:**
    1. Attributes:
        - Title
        - Author
        - ISBN
        - Available
    2. Methods:
        - Getters and setters
        - `ToString()` override

2. **Library Class:**
    1. Methods to:
        - Add a book to the library
        - Remove a book by ISBN
        - Search for a book by title
        - List all books in the library
    2. Uses a `List<Book>` to store book objects

3. **LibraryManager Class:**
    1. Provides a menu-driven console interface to manage the library

### Part 2: Enhancing with OOP Principles and Inheritance

4. **EBook Subclass:**
    1. Inherits from `Book`
    2. Adds `FileSize` attribute
    3. Overrides `ToString()` method to include file size

5. **Improved LibraryManager:**
    1. Provides user-friendly input/output operations
    2. Separates responsibilities effectively

### Part 3: Applying SOLID Principles and Design Patterns

6. **Singleton Pattern:**
    1. Ensures only one instance of `LibraryManager` exists throughout the application

7. **Factory Pattern:**
    1. `BookFactory` class to create instances of `Book` or `EBook` dynamically

---
## Applying SOLID Principles

1. **Single Responsibility Principle (SRP):**
    - Each class has a distinct responsibility (e.g., `Library` manages books, `LibraryManager` handles UI).

2. **Open/Closed Principle (OCP):**
    - New book types can be added via inheritance without modifying the existing code.

3. **Liskov Substitution Principle (LSP):**
    - `EBook` can replace `Book` in the library system without issues.

4. **Interface Segregation Principle (ISP):**
    - Focused responsibilities for classes without unnecessary dependencies.

5. **Dependency Inversion Principle (DIP):**
    - `LibraryManager` depends on abstraction (factory and library), promoting flexibility.

---

## Applying Design Patterns

1. **Singleton Pattern:**
    - Ensures a single instance of `LibraryManager`.

2. **Factory Pattern:**
    - Centralized book creation logic in `BookFactory` for scalability.

---
