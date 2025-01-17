# Car Production Program

This project simulates car production in a factory. Based on user input, car objects are created and added to a list. At the end of the program, the details of all produced cars are displayed.

## Features

- **Car Properties:**
  - Production Date (automatically assigned)
  - Serial Number
  - Brand
  - Model
  - Color
  - Number of Doors
- Creating car objects based on user input.
- Error handling for invalid inputs.
- Listing all produced cars.

## Program Flow

1. The user is asked whether they want to produce a car.
   - `e`: Yes
   - `h`: No
2. If the user responds "no," the program terminates.
3. If the user responds "yes":
   - Serial number, brand, model, and color information are collected.
   - The number of doors is requested, and error handling is implemented for non-numeric inputs.
   - The created car object is added to a list.
4. The user is asked if they want to produce another car.
   - If "yes," the process restarts at step 3.
   - If "no," all produced cars are listed.

## Usage

1. Compile and run the project.
2. Follow the console prompts to produce cars.
3. View the details of all produced cars at the end of the program.

## Example Output

```
Do you want to produce a car? (e/h)
e
Enter a serial number:
12345
Enter the car brand:
Toyota
Enter the car model:
Corolla
Enter the car color:
Red
Enter the number of doors:
4
The car has been successfully produced!

Do you want to produce another car? (e/h)
h

Produced Cars:
Serial Number: 12345
Brand: Toyota
Model: Corolla
Color: Red
Number of Doors: 4
Production Date: 17.01.2025 14:30:00
```

