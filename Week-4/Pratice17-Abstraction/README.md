# Employee Management Program

This program demonstrates the concept of **Abstraction** in C# by modeling employees in a company. Each employee has common attributes like `Name`, `Surname`, and `Department`. Their specific responsibilities are implemented through an abstract method called `Position()`, which is overridden by derived classes.

## Features

- Models employees with common properties: `Name`, `Surname`, and `Department`.
- Uses an abstract class (`Person`) to define shared behavior.
- Implements specific roles:
  - Software Developer (`YazilimGelistirici`)
  - Project Manager (`ProjeYoneticisi`)
  - Sales Representative (`SatisTemsilcisi`)
- Prints personalized messages for each employee's role and department.

## Example Output

```
Merhaba, Ben Ahmet Yılmaz, Yazılım departmanındayım. Yazılım geliştirici olarak çalışıyorum.
Merhaba, Ben Hasan Çıldırmış, Proje Yönetimi departmanındayım. Proje yöneticisi olarak çalışıyorum.
Merhaba, Ben Ayşe Kara, Satış departmanındayım. Satış temsilcisi olarak çalışıyorum.
```

## Project Structure

### 1. `Person` Abstract Class

Defines common properties and an abstract method:

```csharp
public abstract class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public abstract void Position();
}
```

### 2. Derived Classes

Each derived class overrides the `Position()` method to print a specific message.

#### Example: `YazilimGelistirici`

```csharp
public class YazilimGelistirici : Person
{
    public override void Position()
    {
        Console.WriteLine($"Merhaba, Ben {Name} {Surname}, {Department} departmanındayım. Yazılım geliştirici olarak çalışıyorum.");
    }
}
```

### 3. `Program` Class

Creates instances of employees and invokes the `Position()` method for each:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        YazilimGelistirici yazilimci = new YazilimGelistirici
        {
            Name = "Ahmet",
            Surname = "Yılmaz",
            Department = "Yazılım"
        };

        ProjeYoneticisi yonetici = new ProjeYoneticisi
        {
            Name = "Hasan",
            Surname = "Çıldırmış",
            Department = "Proje Yönetimi"
        };

        SatisTemsilcisi temsilci = new SatisTemsilcisi
        {
            Name = "Ayşe",
            Surname = "Kara",
            Department = "Satış"
        };

        yazilimci.Position();
        yonetici.Position();
        temsilci.Position();
    }
}
```

## How to Run

1. Clone the repository or copy the source code.
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build and run the project.

## Key Concepts

- **Abstraction**: The `Person` class abstracts common properties and behaviors of employees.
- **Polymorphism**: The `Position()` method is overridden in derived classes to provide specific functionality.

## Future Enhancements

- Add more employee roles.
- Include additional properties like `Salary` or `HireDate`.
- Implement input functionality to dynamically create employees.

---

This project serves as a simple yet effective demonstration of abstraction and polymorphism in object-oriented programming.

