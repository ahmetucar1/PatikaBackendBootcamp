# Practice15-Inheritance

This repository contains a C# project demonstrating the concept of inheritance using abstract classes. The project showcases how base classes and derived classes can be used to structure and organize code effectively.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [How to Run](#how-to-run)
- [Example Usage](#example-usage)
- [License](#license)

## Overview

The project consists of two main classes, `Student` and `Teacher`, which inherit from an abstract base class `BasePerson`. Each derived class provides its own implementation of the `Introduction` method, showcasing polymorphism in action.

## Features

- Demonstrates the use of abstract classes and methods.
- Shows how to override methods in derived classes.
- Provides examples of creating and using objects of derived classes.

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/ahmetucar1/Pratice15-Inheritance.git
   ```

2. Navigate to the project directory:
   ```bash
   cd Pratice15-Inheritance
   ```

3. Open the project in Visual Studio or any C# IDE of your choice.

4. Build and run the project.

## Example Usage

The project includes two main files:

### `Program.cs`

This file contains the entry point of the application, where `Student` and `Teacher` objects are created and their `Introduction` methods are called.

```csharp
using System;
using System.Collections;
using Person;

namespace Pratik15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Object
            Student student = new Student()
            {
                Name = "Ali",
                Surname = "Umur",
                StudentNumber = 123
            }; 

            // Teacher Object
            Teacher teacher = new Teacher()
            {
                Name = "Mustafa",
                Surname = "Azer",
                Salary = 20000
            };

            student.Introduction();
            teacher.Introduction();
        }
    }
}
```

### `BaseKisi.cs`

This file defines the abstract base class `BasePerson` and its derived classes `Student` and `Teacher`.

```csharp
namespace Person
{
    public abstract class BasePerson
    {
        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }

        // Abstract Method
        public abstract void Introduction();
    }

    // Student Class
    public class Student : BasePerson
    {
        public int StudentNumber { get; set; }

        // Override Method
        public override void Introduction() 
        {
            Console.WriteLine($"Öğrenci Adı: {Name}\nÖğrenci Soyadı: {Surname}\nÖğrenci Numarası: {StudentNumber}");
        }
    }

    // Teacher Class
    public class Teacher : BasePerson
    {
        public decimal Salary { get; set; }

        // Override Method
        public override void Introduction()
        {
            Console.WriteLine($"Öğretmen Adı: {Name}\nÖğretmen Soyadı: {Surname}\nMaaş Bilgisi: {Salary}");
        }
    }
}
```

### Sample Output

When you run the program, you will see the following output:

```
Öğrenci Adı: Ali
Öğrenci Soyadı: Umur
Öğrenci Numarası: 123
Öğretmen Adı: Mustafa
Öğretmen Soyadı: Azer
Maaş Bilgisi: 20000
```

## License

This project is open-source and available under the MIT License. Feel free to use, modify, and distribute it as needed.

---

For any questions or feedback, please open an issue or contact the repository owner.
