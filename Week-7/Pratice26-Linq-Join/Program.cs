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
                    (book,author) => new
                    {
                    Title = book.Title,
                    AuthorName =author.Name,
                    }
                    );

foreach ( var book in bookAndAuthor)
{
    Console.WriteLine($"{book.Title} - {book.AuthorName}");

}