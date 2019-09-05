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


            // all library visitors 
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
