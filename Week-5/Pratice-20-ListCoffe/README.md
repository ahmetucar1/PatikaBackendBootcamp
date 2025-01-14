Coffee Lists Project
This project demonstrates the use of C# List to store and manage a collection of coffee names entered by the user. The program allows the user to input five coffee names and then displays them in a formatted list.

Features
Accepts user input for five coffee names.
Stores the coffee names in a List<string> for dynamic management.
Displays the list of coffee names with their corresponding numbers.
How It Works
Initialization:
A List<string> named Coffee is created to store coffee names.

Input Collection:
The program uses a for loop to prompt the user to enter five coffee names. Each name is added to the Coffee list using the Add method.

Output Display:
Another for loop iterates through the Coffee list to display the entered coffee names along with their order numbers (1 to 5).

Code Overview
Main Components
List Initialization:

csharp
Kodu kopyala
List<string> Coffee = new List<string>();
Input Collection:

csharp
Kodu kopyala
for (int i = 0; i < 5; i++)  
{  
    coffes = Console.ReadLine();  
    Coffee.Add(coffes);  
}  
Output Display:

csharp
Kodu kopyala
for (int i = 0; i < 5; i++)  
{  
    Console.WriteLine(i + 1 + "-" + Coffee[i]);  
}  
How to Run
Open the project in your preferred C# IDE (e.g., Visual Studio).
Build and run the program.
Follow the on-screen instructions to enter five coffee names.
View the formatted list of coffee names in the console output.
Example Usage
Input
Kodu kopyala
Latte  
Espresso  
Cappuccino  
Americano  
Mocha  
Output
markdown
Kodu kopyala
**Kahveleriniz**  
1-Latte  
2-Espresso  
3-Cappuccino  
4-Americano  
5-Mocha  
Learning Objectives
Understand how to use the List class in C#.
Practice iterating over lists with for loops.
Gain experience with user input and console output in C#.
