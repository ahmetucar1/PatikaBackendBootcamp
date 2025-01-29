LINQ Join Example

This example demonstrates how to use LINQ to join two collections of objects. In this case, we are joining a list of authors and a list of books based on the AuthorId property. The result will display the book titles along with the corresponding author names.

Overview

The code creates two lists:

authors: A list of authors with their AuthorId and Name.

books: A list of books with their BookId, Title, and AuthorId.

Then, using LINQ's Join method, we combine the two lists based on the AuthorId property, and select the book title and author name to display in the console.

Code Explanation

using LinqJoin;

List<Authors> authors = new List<Authors>
{
    new Authors { AuthorId = 1, Name = "Dostoyevski" },
    new Authors { AuthorId = 2, Name = "Kafka" },
    new Authors { AuthorId = 3, Name = "Yaşar Kemal" }
};

List<Books> books = new List<Books>
{
    new Books { BookId = 1, Title = "Yeraltından Notlar", AuthorId = 1 },
    new Books { BookId = 2, Title = "Davam", AuthorId = 1 },
    new Books { BookId = 3, Title = "İnce Memed", AuthorId = 2 },
    new Books { BookId = 4, Title = "Çirkin Ördek Yavruları", AuthorId = 3 }
};

var bookAndAuthor = books.Join(authors,
                    book => book.AuthorId,
                    author => author.AuthorId,
                    (book, author) => new
                    {
                        Title = book.Title,
                        AuthorName = author.Name
                    });

foreach (var book in bookAndAuthor)
{
    Console.WriteLine($"{book.Title} - {book.AuthorName}");
}

Steps:

Create Lists: We define two lists, authors and books, each containing objects with specific properties.

Join Operation: The Join method is used to combine the books and authors lists based on the AuthorId property. The Join method takes:

The second collection (authors).

A key selector for the first collection (book => book.AuthorId).

A key selector for the second collection (author => author.AuthorId).

A result selector that defines what data to include in the final result (new { Title = book.Title, AuthorName = author.Name }).

Output: The foreach loop iterates over the joined result and prints the book titles along with the corresponding author names.

Output:

Yeraltından Notlar - Dostoyevski
Davam - Dostoyevski
İnce Memed - Kafka
Çirkin Ördek Yavruları - Yaşar Kemal

Prerequisites

.NET environment (C#).

Basic understanding of LINQ and how to use Join.

How to Run

Copy the code into a new C# console application.

Compile and run the application.

The result will be displayed in the console window, showing the book titles along with their authors.
