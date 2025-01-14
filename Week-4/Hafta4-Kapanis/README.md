# Week4-FinalProject

This project is a C# application demonstrating object-oriented programming principles such as inheritance, interfaces, and abstraction. The program allows users to add and manage objects representing computers and phones, showcasing the use of abstract base classes and interfaces.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [How to Run](#how-to-run)
- [Example Usage](#example-usage)
- [License](#license)

## Overview

The application allows users to:

- Add new computer and phone objects.
- Input specific details for each object.
- Display the stored information for all objects.

The project uses an abstract base class `BaseMakine` and interfaces `IBilgisayar` and `ITelefon` to enforce structure and functionality for derived classes `Bilgisayar` and `Telefon`.

## Features

- Demonstrates the use of abstract classes and interfaces.
- Implements polymorphism with overridden methods.
- Includes input validation for specific properties (e.g., USB port count).
- Supports functionality unique to computers and phones, such as connecting to the internet or making calls.

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET

## How to Run

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```bash
   cd Week4-FinalProject
   ```

3. Open the project in Visual Studio or any C# IDE of your choice.

4. Build and run the project.

## Example Usage

### Adding a Computer

1. Choose to add a computer by pressing `1`.
2. Enter the computer's name, operating system, and USB port count.
3. The computer object will be created and added to the list.

### Adding a Phone

1. Choose to add a phone by pressing `2`.
2. Enter the phone's name, operating system, and whether it is licensed (`e` for yes, `h` for no).
3. The phone object will be created and added to the list.

### Displaying Objects

After adding objects, the program will display their details, including specific properties and features.

#### Sample Output

```
---------BİLGİSAYARLAR----------
Id :1
Üretim Tarihi :2025-01-08
Ad :My Computer
İşletim Sistemi :Windows 10
Usb Giriş Sayısı: 4
Bluetooth Var
---------
----------TELEFONLAR-------------
Id :2
Üretim Tarihi :2025-01-08
Ad :My Phone
İşletim Sistemi :Android
Lisanslı
-------
```

## Class Structure

### `BaseMakine`

An abstract base class that defines common properties and methods for all machines.

### `Bilgisayar` (Computer)

Derived from `BaseMakine` and implements the `IBilgisayar` interface. Includes:
- `UsbGirisSayisi` with validation.
- Methods for connecting to the internet, playing games, and generating tokens.

### `Telefon` (Phone)

Derived from `BaseMakine` and implements the `ITelefon` interface. Includes:
- `LisansliMi` property.
- Methods for making calls, sending messages, and playing music.

## License

This project is open-source and available under the MIT License. Feel free to use, modify, and distribute it as needed.

---

For any questions or feedback, please open an issue or contact the repository owner.
