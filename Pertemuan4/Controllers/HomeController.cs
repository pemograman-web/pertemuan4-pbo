using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pertemuan4.Models;

namespace Pertemuan4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BookViews model = new BookViews();
            model.books = GetBook();
            model.users = GetUser();
            model.loans = GetLoans();
            return View(model);

        }

        private List<Book_Model> GetBook()
        {
            List<Book_Model> Books = new List<Book_Model>();

            Books.Add(new Book_Model() { 
                Id = 1, 
                Judul = "In Search of Lost Time by Marcel Proust", 
                Sinopsis = "Swann's Way, the first part of A la recherche de temps perdu, Marcel Proust's seven-part cycle, was published in 1913. In it, Proust introduces the themes that run through the entire work. The narr..." 
            });
            Books.Add(new Book_Model() { 
                Id = 2, 
                Judul = "Ulysses by James Joyce", 
                Sinopsis = "Ulysses chronicles the passage of Leopold Bloom through Dublin during an ordinary day, June 16, 1904. The title parallels and alludes to Odysseus (Latinised into Ulysses), the hero of Homer's Odyss..." 
            });
            Books.Add(new Book_Model() { 
                Id = 3, 
                Judul = "Don Quixote by Miguel de Cervantes", 
                Sinopsis = "Alonso Quixano, a retired country gentleman in his fifties, lives in an unnamed section of La Mancha with his niece and a housekeeper. He has become obsessed with books of chivalry, and believes th..." 
            });
            Books.Add(new Book_Model() { 
                Id = 4, 
                Judul = "One Hundred Years of Solitude by Gabriel Garcia Marquez", 
                Sinopsis = "One of the 20th century's enduring works, One Hundred Years of Solitude is a widely beloved and acclaimed novel known throughout the world, and the ultimate achievement in a Nobel Prize–winning car..."
            }); 
            Books.Add(new Book_Model() { 
                Id = 5, 
                Judul = "The Great Gatsby by F. Scott Fitzgerald", 
                Sinopsis = "The novel chronicles an era that Fitzgerald himself dubbed the 'Jazz Age'. Following the shock and chaos of World War I, American society enjoyed unprecedented levels of prosperity during the roar..."
            });

            return Books;
        }

        private List<User_Model> GetUser()
        {
            List<User_Model> Users = new List<User_Model>();

            Users.Add(new User_Model() { npm = 1821332, nama = "Oliver"});
            Users.Add(new User_Model() { npm = 1924882, nama = "Harry" });
            Users.Add(new User_Model() { npm = 2038744, nama = "Ella" });

            return Users;
        }

        public List<BookLoans> GetLoans()
        {
            List<BookLoans> Loans = new List<BookLoans>();
            List<Book_Model> Books = new List<Book_Model>();
            List<Book_Model> Books1 = new List<Book_Model>();
            List<Book_Model> Books2 = new List<Book_Model>();
            Books.Add(new Book_Model()
            {
                Id = 1,
                Judul = "In Search of Lost Time by Marcel Proust",
                Sinopsis = "Swann's Way, the first part of A la recherche de temps perdu, Marcel Proust's seven-part cycle, was published in 1913. In it, Proust introduces the themes that run through the entire work. The narr...",
                Price = 1000
            });
            Books.Add(new Book_Model()
            {
                Id = 2,
                Judul = "Ulysses by James Joyce",
                Sinopsis = "Ulysses chronicles the passage of Leopold Bloom through Dublin during an ordinary day, June 16, 1904. The title parallels and alludes to Odysseus (Latinised into Ulysses), the hero of Homer's Odyss...",
                Price = 1000
            });

            Books1.Add(new Book_Model()
            {
                Id = 4,
                Judul = "One Hundred Years of Solitude by Gabriel Garcia Marquez",
                Sinopsis = "One of the 20th century's enduring works, One Hundred Years of Solitude is a widely beloved and acclaimed novel known throughout the world, and the ultimate achievement in a Nobel Prize–winning car...",
                Price = 1000
            });

            Books1.Add(new Book_Model()
            {
                Id = 3,
                Judul = "Don Quixote by Miguel de Cervantes",
                Sinopsis = "Alonso Quixano, a retired country gentleman in his fifties, lives in an unnamed section of La Mancha with his niece and a housekeeper. He has become obsessed with books of chivalry, and believes th...",
                Price = 1000
            });

            Books2.Add(new Book_Model()
            {
                Id = 5,
                Judul = "The Great Gatsby by F. Scott Fitzgerald",
                Sinopsis = "The novel chronicles an era that Fitzgerald himself dubbed the 'Jazz Age'. Following the shock and chaos of World War I, American society enjoyed unprecedented levels of prosperity during the roar...",
                Price = 1000
            });

            Loans.Add(new BookLoans()
            {
                IdLoan = 1,
                npm = 1821332,
                nama = "Oliver",
                books = Books
            });

            Loans.Add(new BookLoans()
            {
                IdLoan = 2,
                npm = 1931887,
                nama = "Mary",
                books = Books1
            });

            Loans.Add(new BookLoans()
            {
                IdLoan = 2,
                npm = 1942987,
                nama = "Mary",
                books = Books2
            });

            return Loans;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}