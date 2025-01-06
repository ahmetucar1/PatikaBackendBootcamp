Book Registration Application

This project is a simple C# application that defines a Book class and demonstrates its usage. The Book class stores information about books, such as their title, author, page count, publisher, and registration date. It also displays this information in the console.

Project Contents

1. Book Class (Book)

Purpose: To store book details and display them.

Properties:

Title: The book's title.

AuthorFirstName: The author's first name.

AuthorLastName: The author's last name.

PageCount: The number of pages in the book.

Publisher: The book's publisher.

RegistrationDate: The date the book was registered (automatically assigned).

Constructor Methods

Default Constructor:

Takes no parameters.

Automatically assigns RegistrationDate.

Parameterized Constructor:

Takes the book's title, author's first and last names, page count, and publisher as parameters.

Assigns these values during object creation.

Automatically assigns RegistrationDate.

Methods

DisplayDetails(): Prints the book's details to the console.

2. Console Application (Program)

Creates two different Book objects:

One using the default constructor.

Another using the parameterized constructor.

Displays the details of both objects using the DisplayDetails() method.

Key Concepts in the Project

Class: Book and Program are classes. Book defines the structure of a book object, while Program contains the main application logic.

Property: Attributes like Title, AuthorFirstName, and PageCount store information about a book.

Constructor: Book() and Book(string title, ...) initialize Book objects with specific values.

Method: DisplayDetails() prints the book's information to the console.

New: new Book() creates a new instance of the Book class.
