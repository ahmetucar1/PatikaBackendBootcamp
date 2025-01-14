# Guest List Program

This project is a simple C# console application designed to demonstrate the creation and manipulation of a list of guest names. The program allows predefined guests to be added to a list, displays the list, and enables user interaction by allowing a new guest to be added dynamically.

## Features

1. **Predefined Guest List**: The program initializes a list of famous guests.
2. **Dynamic Guest Addition**: Users can add their own guest to the list during runtime.
3. **Display Guest List**: The program prints the list of guests before and after the user adds a new guest.

## How It Works

1. The program creates a `List<string>` object named `davetliler` to store guest names.
2. Several guest names are added to the list using the `Add` method.
3. The list of guests is displayed using a `foreach` loop.
4. The program prompts the user to input a new guest name, which is then added to the list.
5. The updated guest list is displayed.

## Code Example

```csharp
using System;
using System.Collections.Generic;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new list
            List<string> davetliler = new List<string>();

            // Add predefined guests
            davetliler.Add("Bülent Ersoy");
            davetliler.Add("Ajda Pekkan");
            davetliler.Add("Ebru Gündeş");
            davetliler.Add("Hadise");
            davetliler.Add("Hande Yener");
            davetliler.Add("Tarkan");
            davetliler.Add("Funda Arar");
            davetliler.Add("Demet Akalın");

            // Display the guest list
            foreach (var davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }

            // Prompt the user to add a guest
            Console.WriteLine("Sen de bir tane ekle");
            string yeniDavetli = Console.ReadLine();

            // Add the user's guest to the list
            davetliler.Add(yeniDavetli);

            // Display the updated guest list
            Console.WriteLine("Yeni Davetli Listesi");
            foreach (var davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }
        }
    }
}
```

## Requirements

- .NET SDK installed on your system.
- A code editor or IDE such as Visual Studio or Visual Studio Code.

## How to Run

1. Clone or download this project to your local machine.
2. Open the project in your preferred C# IDE.
3. Compile and run the program.
4. Follow the instructions in the console to view and update the guest list.

## Author

This program was created as a simple demonstration of C# list manipulation and user interaction in console applications.

