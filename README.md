# Object-Oriented Programming in C#

This repository contains examples and demonstrations of Object-Oriented Programming concepts implemented in C#.

## Project Structure

- `Basic/`: Core OOP concepts and basic implementations

  - Inheritance examples
  - Interface implementations
  - Abstract classes
  - Person and Student management system

- `ClassObject/`: Class and Object demonstrations

  - Person, Car, and Student examples
  - Property implementation
  - Constructor overloading

- `Inheritance/`: Advanced inheritance concepts

  - Base keyword usage
  - Multi-level inheritance
  - Animal hierarchy examples

- `MethodOverloading/`: Method overloading examples

  - Calculator with different parameter types
  - Function overloading demonstrations

- `ObjectParameter/`: Object passing and manipulation

  - Bank system example
  - Car and Engine relationship
  - Person and Greeting system

- `TypeOf/`: Type-related examples
  - Const vs Readonly demonstrations
  - Bank account implementations

## Key Features

- Comprehensive OOP concept demonstrations
- Real-world example implementations
- Clean and documented code
- Multiple inheritance patterns
- Interface implementations
- Property and field usage examples

## Usage Examples

```csharp
// Creating a student object
Student student = new Student("John Doe", 21, 3.42);
student.Display();

// Using inheritance
Dog dog = new Dog();
dog.Eat();    // From Animal class
dog.Bark();   // From Dog class

// Method overloading
Calculator calc = new Calculator();
int sum1 = calc.Add(5, 3);           // Returns 8
double sum2 = calc.Add(5.5, 3.3);    // Returns 8.8
```

## Getting Started

1. Clone the repository
2. Open in Visual Studio or your preferred C# IDE
3. Navigate to specific examples in their respective folders
4. Run the examples to see OOP concepts in action

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
