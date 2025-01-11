# Array Manipulation Project

This project demonstrates basic operations on arrays in C# as part of a practice task. The application performs the following steps:

## Features
1. **Array Initialization**: 
   - A fixed-size array is initialized with 10 integer elements using a `for` loop.

2. **Displaying Array Elements**:
   - The elements of the array are displayed on the console using a `foreach` loop.

3. **Adding a New Element**:
   - A new integer value is taken from the user and added as the 11th element to the array. 
   - The existing array is expanded by creating a new array that includes the new element.

4. **Sorting the Array**:
   - The updated array is sorted in descending order and displayed on the console.

## How It Works
1. The program initializes an array of 10 integers with default values or sequential numbers.
2. The program prompts the user to input a new integer value.
3. A new array is created with a size larger than the original array by one, and all elements from the original array are copied into the new array.
4. The user's input is added as the last element of the new array.
5. The program sorts the array in descending order and displays the result.

## Example Usage
### Input:
- Initial array: `[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]`
- User input: `20`

### Output:
Current array elements: 1 2 3 4 5 6 7 8 9 10

Enter a new integer to add to the array: 20

Updated array: 1 2 3 4 5 6 7 8 9 10 20

Array sorted in descending order: 20 10 9 8 7 6 5 4 3 2 1


## Technologies Used
- Programming Language: C#
- IDE: Visual Studio or any other C# development environment

## Learning Outcomes
- Understanding of basic array operations in C#.
- Usage of `for` and `foreach` loops for array manipulation.
- Array resizing without using built-in methods like `Array.Resize`.
- Sorting arrays and reversing their order.

## How to Run
1. Clone the repository to your local machine.
2. Open the project in your preferred C# IDE.
3. Compile and run the program.
4. Follow the instructions displayed on the console to interact with the program.

## Contributing
Feel free to fork this repository and contribute by adding more features or improving the code.

## License
This project is licensed under the MIT License.
