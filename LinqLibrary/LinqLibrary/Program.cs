using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new City() { Name = "Vologda" };

            var d1 = new District() { Name = "Center", CityId = c1.Id };
            var d2 = new District() { Name = "Leningradskaya", CityId = c1.Id };
            var d3 = new District() { Name = "Zarechie", CityId = c1.Id };
            var d4 = new District() { Name = "Koneva", CityId = c1.Id };
            var d5 = new District() { Name = "Baza", CityId = c1.Id };
            var d6 = new District() { Name = "Byvalovo", CityId = c1.Id };

            var districts = new List<District>() { d1, d2, d3, d4, d5, d6 };

            var l1 = new Library() { Name = "Babushkinskaya", Address = "Vologda, Ulyanovoi 17", DistrictId = d1.Id };
            var l2 = new Library() { Name = "Tendryakovka", Address = "Vologda, Pobedy 42", DistrictId = d1.Id };
            var l3 = new Library() { Name = "Leningradka lib", Address = "Vologda, Leningradskaya 62", DistrictId = d2.Id };
            var l4 = new Library() { Name = "Byvalovo lib", Address = "Vologda, Poshehonskoe 28", DistrictId = d6.Id };
            var l5 = new Library() { Name = "Baza lib", Address = "Vologda, Oktybrskaya 101", DistrictId = d5.Id };
            var l6 = new Library() { Name = "Zarechie lib", Address = "Vologda, Pugacheva 1", DistrictId = d3.Id };

            var libraries = new List<Library>() { l1, l2, l3, l4, l5, l6 };

            var v1 = new Visitor() { Name = "Evgeny", LastName = "Balanin", Address = "Vologda, Mira 90a" };
            var v2 = new Visitor() { Name = "Alexander", LastName = "Sablin", Address = "Vologda, Leningradskaya 98" };
            var v3 = new Visitor() { Name = "Nikita", LastName = "Nuzhin", Address = "Vologda, Gorkogo 115" };
            var v4 = new Visitor() { Name = "Andrey", LastName = "Baranov", Address = "Vologda, Mira 90a" };
            var v5 = new Visitor() { Name = "Evgeny", LastName = "Vushkov", Address = "Vologda, Leningradskaya 115" };
            var v6 = new Visitor() { Name = "Ilya", LastName = "Gryaznov", Address = "Vologda, Pushkinskaya 4" };
            var v7 = new Visitor() { Name = "Alexander", LastName = "Ekimov", Address = "Vologda, Ledencova 6" };
            var v8 = new Visitor() { Name = "Viktor", LastName = "Artamoshin", Address = "Vologda, Oktyabrskaya 56" };
            var v9 = new Visitor() { Name = "Evgeny", LastName = "Sidorov", Address = "Vologda, Shkolniy 5" };
            var v10 = new Visitor() { Name = "Sergey", LastName = "Platonov", Address = "Vologda, Vorovskogo 18" };

            var visitors = new List<Visitor>() { v1, v2, v3, v4, v5, v6, v7, v8, v9, v10 };

            var libraryVisitors = new List<LibraryVisitor>()
            {
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v1.Id },
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v2.Id },
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v4.Id },
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v6.Id },
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v7.Id },
                new LibraryVisitor(){ LibraryId = l1.Id, VisitorId = v8.Id },
                new LibraryVisitor(){ LibraryId = l2.Id, VisitorId = v1.Id },
                new LibraryVisitor(){ LibraryId = l2.Id, VisitorId = v2.Id },
                new LibraryVisitor(){ LibraryId = l2.Id, VisitorId = v6.Id },
                new LibraryVisitor(){ LibraryId = l2.Id, VisitorId = v8.Id },
                new LibraryVisitor(){ LibraryId = l3.Id, VisitorId = v2.Id },
                new LibraryVisitor(){ LibraryId = l3.Id, VisitorId = v5.Id },
                new LibraryVisitor(){ LibraryId = l4.Id, VisitorId = v9.Id },
                new LibraryVisitor(){ LibraryId = l5.Id, VisitorId = v8.Id },
                new LibraryVisitor(){ LibraryId = l5.Id, VisitorId = v10.Id },
                new LibraryVisitor(){ LibraryId = l6.Id, VisitorId = v3.Id }
            };

            var b1 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Philosopher's Stone", BookGenre = "Fantasy" };
            var b2 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Chamber of Secrets", BookGenre = "Fantasy" };
            var b3 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Prisoner of Azkaban", BookGenre = "Fantasy" };
            var b4 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Goblet of Fire", BookGenre = "Fantasy" };
            var b5 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Order of the Phoenix", BookGenre = "Fantasy" };
            var b6 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Half-Blood Prince", BookGenre = "Fantasy" };
            var b7 = new Book() { Author = "J. K. Rowling", Title = "Harry Potter: The Deathly Hallows", BookGenre = "Fantasy" };
            var b8 = new Book() { Author = "Chuck Palahniuk", Title = "Fight Club", BookGenre = "Fiction" };
            var b9 = new Book() { Author = "Chuck Palahniuk", Title = "Choke", BookGenre = "Fiction" };
            var b10 = new Book() { Author = "Ray Bradbury", Title = "Fahrenheit 451", BookGenre = "Classic" };
            var b11 = new Book() { Author = "Ray Bradbury", Title = "Dandelion Wine", BookGenre = "Classic" };
            var b12 = new Book() { Author = "Питер Тиль", Title = "От нуля к единице", BookGenre = "Business" };
            var b13 = new Book() { Author = "Мэг Джей", Title = "Важные годы", BookGenre = "Саморазвитие" };
            var b14 = new Book() { Author = "Лес Хьюитт", Title = "Цельная жизнь", BookGenre = "Саморазвитие" };
            var b15 = new Book() { Author = "Бретт Блюменталь", Title = "Одна привычка в неделю", BookGenre = "Саморазвитие" };

            var books = new List<Book>() { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15 };

            var ed1 = new Edition() { NumberEdition = 1001, NumberPages = 315 };
            var ed2 = new Edition() { NumberEdition = 1002, NumberPages = 320 };
            var ed3 = new Edition() { NumberEdition = 1003, NumberPages = 318 };
            var ed4 = new Edition() { NumberEdition = 2001, NumberPages = 380 };
            var ed5 = new Edition() { NumberEdition = 2002, NumberPages = 382 };
            var ed6 = new Edition() { NumberEdition = 3001, NumberPages = 421 };
            var ed7 = new Edition() { NumberEdition = 4001, NumberPages = 555 };
            var ed8 = new Edition() { NumberEdition = 5001, NumberPages = 761 };
            var ed9 = new Edition() { NumberEdition = 6001, NumberPages = 472 };
            var ed10 = new Edition() { NumberEdition = 7001, NumberPages = 410 };
            var ed11 = new Edition() { NumberEdition = 8001, NumberPages = 501 };
            var ed12 = new Edition() { NumberEdition = 9001, NumberPages = 601 };
            var ed13 = new Edition() { NumberEdition = 10001, NumberPages = 242 };
            var ed14 = new Edition() { NumberEdition = 10002, NumberPages = 252 };
            var ed15 = new Edition() { NumberEdition = 11001, NumberPages = 379 };
            var ed16 = new Edition() { NumberEdition = 12001, NumberPages = 342 };
            var ed17 = new Edition() { NumberEdition = 13001, NumberPages = 444 };
            var ed18 = new Edition() { NumberEdition = 14001, NumberPages = 331 };
            var ed19 = new Edition() { NumberEdition = 15001, NumberPages = 399 };
            var ed20 = new Edition() { NumberEdition = 15002, NumberPages = 400 };

            // BookItem's in Library1
            var bi1 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l1.Id };
            var bi2 = new BookItem() { BookId = b1.Id, EditionId = ed2.Id, Format = "Soft", LibraryId = l1.Id };
            var bi3 = new BookItem() { BookId = b1.Id, EditionId = ed3.Id, Format = "Collection", LibraryId = l1.Id };
            var bi4 = new BookItem() { BookId = b2.Id, EditionId = ed4.Id, Format = "Hard", LibraryId = l1.Id };
            var bi5 = new BookItem() { BookId = b3.Id, EditionId = ed6.Id, Format = "Hard", LibraryId = l1.Id };
            var bi6 = new BookItem() { BookId = b4.Id, EditionId = ed7.Id, Format = "Hard", LibraryId = l1.Id };
            var bi7 = new BookItem() { BookId = b5.Id, EditionId = ed8.Id, Format = "Hard", LibraryId = l1.Id };
            var bi8 = new BookItem() { BookId = b6.Id, EditionId = ed9.Id, Format = "Hard", LibraryId = l1.Id };
            var bi9 = new BookItem() { BookId = b7.Id, EditionId = ed10.Id, Format = "Hard", LibraryId = l1.Id };
            var bi10 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l1.Id };
            var bi11 = new BookItem() { BookId = b9.Id, EditionId = ed12.Id, Format = "Hard", LibraryId = l1.Id };
            var bi12 = new BookItem() { BookId = b10.Id, EditionId = ed13.Id, Format = "Hard", LibraryId = l1.Id };
            var bi13 = new BookItem() { BookId = b11.Id, EditionId = ed15.Id, Format = "Hard", LibraryId = l1.Id };
            var bi14 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l1.Id };
            var bi15 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l1.Id };
            var bi16 = new BookItem() { BookId = b14.Id, EditionId = ed18.Id, Format = "Hard", LibraryId = l1.Id };
            var bi17 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l1.Id };
            var bi18 = new BookItem() { BookId = b15.Id, EditionId = ed20.Id, Format = "Soft", LibraryId = l1.Id };

            //BookItem's in Library2
            var bi19 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l2.Id };
            var bi20 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l2.Id };
            var bi21 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l2.Id };
            var bi22 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l2.Id };
            var bi23 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l2.Id };

            //BookItem's in Library3
            var bi24 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l3.Id };
            var bi25 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l3.Id };
            var bi26 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l3.Id };
            var bi27 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l3.Id };
            var bi28 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l3.Id };

            //BookItem's in Library4
            var bi29 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l4.Id };
            var bi30 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l4.Id };
            var bi31 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l4.Id };
            var bi32 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l4.Id };
            var bi33 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l4.Id };

            //BookItem's in Library5
            var bi34 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l5.Id };
            var bi35 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l5.Id };
            var bi36 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l5.Id };
            var bi37 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l5.Id };
            var bi38 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l5.Id };

            //BookItem's in Library6
            var bi39 = new BookItem() { BookId = b1.Id, EditionId = ed1.Id, Format = "Hard", LibraryId = l5.Id };
            var bi40 = new BookItem() { BookId = b8.Id, EditionId = ed11.Id, Format = "Hard", LibraryId = l5.Id };
            var bi41 = new BookItem() { BookId = b13.Id, EditionId = ed17.Id, Format = "Hard", LibraryId = l5.Id };
            var bi42 = new BookItem() { BookId = b15.Id, EditionId = ed19.Id, Format = "Hard", LibraryId = l5.Id };
            var bi43 = new BookItem() { BookId = b12.Id, EditionId = ed16.Id, Format = "Hard", LibraryId = l5.Id };

            //History Log
            var h1 = new History() { VisitorId = v1.Id, BookItemId = bi1.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 6) };
            var h2 = new History() { VisitorId = v1.Id, BookItemId = bi1.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 12) };
            var h3 = new History() { VisitorId = v1.Id, BookItemId = bi20.Id, LibraryId = l2.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 13) };
            var h4 = new History() { VisitorId = v1.Id, BookItemId = bi20.Id, LibraryId = l2.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 20) };
            var h5 = new History() { VisitorId = v1.Id, BookItemId = bi17.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 21) };
            var h6 = new History() { VisitorId = v2.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 1) };
            var h7 = new History() { VisitorId = v2.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 7) };
            var h8 = new History() { VisitorId = v2.Id, BookItemId = bi27.Id, LibraryId = l3.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 16) };
            var h8 = new History() { VisitorId = v3.Id, BookItemId = bi39.Id, LibraryId = l6.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 1) };
            var h8 = new History() { VisitorId = v3.Id, BookItemId = bi39.Id, LibraryId = l6.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 15) };
            var h8 = new History() { VisitorId = v3.Id, BookItemId = bi43.Id, LibraryId = l6.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 15) };
            var h8 = new History() { VisitorId = v3.Id, BookItemId = bi43.Id, LibraryId = l6.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 30) };
            var h8 = new History() { VisitorId = v3.Id, BookItemId = bi42.Id, LibraryId = l6.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v5.Id, BookItemId = bi25.Id, LibraryId = l3.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 2) };
            var h8 = new History() { VisitorId = v5.Id, BookItemId = bi25.Id, LibraryId = l3.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 10) };
            var h8 = new History() { VisitorId = v5.Id, BookItemId = bi26.Id, LibraryId = l3.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 10) };
            var h8 = new History() { VisitorId = v5.Id, BookItemId = bi26.Id, LibraryId = l3.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 20) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi11.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi12.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi13.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi11.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi12.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi13.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi23.Id, LibraryId = l2.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v6.Id, BookItemId = bi23.Id, LibraryId = l2.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 25) };
            var h8 = new History() { VisitorId = v7.Id, BookItemId = bi7.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 3) };
            var h8 = new History() { VisitorId = v7.Id, BookItemId = bi7.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 13) };
            var h8 = new History() { VisitorId = v7.Id, BookItemId = bi14.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v7.Id, BookItemId = bi14.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 20) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi1.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 7) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 7) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi1.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 27) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi10.Id, LibraryId = l1.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 27) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi21.Id, LibraryId = l2.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi21.Id, LibraryId = l2.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 10) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi38.Id, LibraryId = l5.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 15) };
            var h8 = new History() { VisitorId = v8.Id, BookItemId = bi38.Id, LibraryId = l5.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 25) };
            var h8 = new History() { VisitorId = v9.Id, BookItemId = bi33.Id, LibraryId = l4.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 2) };
            var h8 = new History() { VisitorId = v9.Id, BookItemId = bi33.Id, LibraryId = l4.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 12) };
            var h8 = new History() { VisitorId = v9.Id, BookItemId = bi29.Id, LibraryId = l4.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 1) };
            var h8 = new History() { VisitorId = v9.Id, BookItemId = bi29.Id, LibraryId = l4.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 10) };
            var h8 = new History() { VisitorId = v10.Id, BookItemId = bi34.Id, LibraryId = l5.Id, VisitorAction = "take", Date = new DateTime(2019, 8, 10) };
            var h8 = new History() { VisitorId = v10.Id, BookItemId = bi34.Id, LibraryId = l5.Id, VisitorAction = "put", Date = new DateTime(2019, 8, 20) };
            var h8 = new History() { VisitorId = v10.Id, BookItemId = bi37.Id, LibraryId = l5.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 2) };
            var h8 = new History() { VisitorId = v10.Id, BookItemId = bi37.Id, LibraryId = l5.Id, VisitorAction = "put", Date = new DateTime(2019, 9, 12) };
            var h8 = new History() { VisitorId = v10.Id, BookItemId = bi38.Id, LibraryId = l5.Id, VisitorAction = "take", Date = new DateTime(2019, 9, 26) };

            // all library visitors 
            Console.WriteLine("Show all library visitors\n");
            var libVisitors = from l in libraries
                              join lv in libraryVisitors on l.Id equals lv.LibraryId
                              join v in visitors on lv.VisitorId equals v.Id
                              select new { Library = l, Visitor = v };

            foreach (var lv in libVisitors)
            {
                Console.WriteLine($"{lv.Library.Name} {lv.Visitor.Name} {lv.Visitor.LastName}");
            }

            Console.ReadKey();
        }
    }
}
