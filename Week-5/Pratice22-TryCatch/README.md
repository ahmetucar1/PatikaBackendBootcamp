# Try Catch Pratice

This is a simple C# console application that calculates the square of a user-provided number. It ensures input validation and handles invalid inputs gracefully.

## Features

- Prompts the user to input a number.
- Calculates and displays the square of the input number.
- Handles invalid inputs (e.g., non-numeric entries) using a `try-catch` block.

## How It Works

1. The program enters a loop that continues until valid input is provided.
2. It prompts the user to enter a number.
3. If the input is valid, the program calculates the square of the number and displays it.
4. If the input is invalid (e.g., a non-numeric value), the program displays an error message and prompts the user again.

## Code Overview

The core logic is implemented in the `Main` method of the `Program` class:
- The `while` loop ensures the user gets multiple attempts to provide valid input.
- A `try-catch` block handles `FormatException` errors for invalid inputs.

### Key Methods and Classes
- `Console.WriteLine`: Used to display messages to the user.
- `Console.ReadLine`: Used to capture user input.
- `Convert.ToInt32`: Converts the user input to an integer.
- `FormatException`: Catches errors when the input cannot be converted to an integer.

## Example Usage

1. Run the application.
2. Enter a number when prompted.
3. View the square of the entered number.

### Example Output
Lütfen bir sayı girin! 5 Girdiğiniz sayının değeri: 25

shell
Kopyala
Düzenle

### Invalid Input Example
Lütfen bir sayı girin! abc Geçersiz giriş! Lütfen bir sayı giriniz.

css
Kopyala
Düzenle

## How to Run

1. Compile the code using a C# compiler or an IDE like Visual Studio.
2. Run the compiled executable in a terminal or console.
3. Follow the prompts to input a number.

## Requirements

- .NET Framework or .NET Core SDK installed on your system.

## License

This project is free to use and modify. No specific license applies.
