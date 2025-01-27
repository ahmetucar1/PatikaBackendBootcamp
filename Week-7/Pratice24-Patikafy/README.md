
# Patikafy Artist Management Console Application

This is a C# console application that manages a list of artists and provides various functionalities such as filtering, sorting, and grouping based on specific criteria. The program demonstrates object-oriented programming and LINQ (Language Integrated Query) capabilities in C#.

## Features

- **Artist List Management**: Represents a list of artists with their details such as name, music genre, debut year, and album sales.
- **Filter and Search**:
  - Artists whose names start with "S".
  - Artists with album sales exceeding 10 million.
- **Sort and Group**:
  - Artists who debuted before the year 2000 and perform pop music, sorted alphabetically and grouped by debut year.
- **Statistics**:
  - Identify the artist with the highest album sales.
  - Determine the most recent and the earliest debuting artists.

## How It Works

### Artist Data
The application uses a list of `Artists` objects, each containing:
- `Name`: The artist's name.
- `MusicGenre`: The genre(s) of music the artist performs.
- `Year`: The year the artist debuted.
- `AlbumSales`: The approximate number of albums sold.

### Functionalities
1. **Filter Artists by Name**:
   - Displays artists whose names start with the letter "S".
2. **Filter by Album Sales**:
   - Displays artists with album sales greater than 10 million.
3. **Group and Sort Artists**:
   - Lists pop artists who debuted before 2000, sorted alphabetically and grouped by debut year.
4. **Find Top-Selling Artist**:
   - Displays the artist with the highest album sales.
5. **Find Newest and Oldest Artists**:
   - Identifies the artist with the most recent and the earliest debut year.

## Code Overview

### Core Classes and Methods
- **Class**: `Artists`
  - Represents an artist with properties: `Name`, `MusicGenre`, `Year`, and `AlbumSales`.
- **LINQ Queries**:
  - Used for filtering, sorting, grouping, and finding specific artists.
- **`Console.WriteLine`**:
  - Displays the results in the console.

### Example Output
#### Artists Whose Names Start with "S":
```
Adı S ile başlayan sanatçılar
Sezen Aksu
Sertab Erener
Sıla
Serdar Ortaç
```

#### Artists with Album Sales > 10 Million:
```
Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:
Ajda Pekkan - 20000000
Serdar Ortaç - 10000000
Tarkan - 40000000
Gülben Ergen - 10000000
```

#### Pop Artists Before 2000:
```
2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.( Çıkış yılı - Alfabetik Sıra)
1968 - Ajda Pekkan
1971 - Sezen Aksu
1994 - Sertab Erener
1994 - Serdar Ortaç
1992 - Tarkan
```

#### Top-Selling Artist:
```
En çok albüm satan şarkıcı:
Tarkan Yaklaşık 40000000
```

#### Newest and Oldest Artists:
```
En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
En yeni çıkış yapan şarkıcı: Sıla - 2009
En eski çıkış yapan şarkıcı : Neşet Ertaş - 2009
```

## How to Run

1. Compile the code using a C# compiler or an IDE such as Visual Studio.
2. Run the compiled executable in a terminal or console.
3. View the results displayed in the console.

## Requirements

- .NET Framework or .NET Core SDK installed on your system.

## License

This project is free to use and modify. No specific license applies.
```

Bu README dosyasını, projenizle birlikte paylaşabilirsiniz. Eğer eklemek veya değiştirmek istediğiniz bir şey varsa, lütfen belirtin!
