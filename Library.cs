using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        readonly static List<Document> _documents = new();
        public void AddDocument(Document document) => _documents.Add(document);

        public static void SearchByTitle(string title)
        {
            for (int i = 0; i < _documents.Count; i++)
            {
                if (_documents[i].title == title)
                {
                    Console.WriteLine(_documents[i].title);
                    Console.WriteLine(_documents[i].author);
                    Console.WriteLine(_documents[i].year);
                    Console.WriteLine(_documents[i].category);
                }
            }
        }

        public static void ListBooks()
        {
            for (int i = 0; i < _documents.Count; i++)
            {
                if (_documents[i].GetType().Name == "Book")
                {
                    Console.WriteLine(_documents[i].title);
                }
            }
        }

        public static void ListDvds()
        {
            for (int i = 0; i < _documents.Count; i++)
            {
                if (_documents[i].GetType().Name == "Dvd")
                {
                    Console.WriteLine(_documents[i].title);
                }
            }
        }

        public void userRegister()
        {
            Console.WriteLine("Inserisci il nome");
            var first_name = Console.ReadLine();

            Console.WriteLine("\nInserisci il cognome");
            var last_name = Console.ReadLine();

            Console.WriteLine("\nInserisci l'email");
            var email = Console.ReadLine();

            Console.WriteLine("\nInserisci la password");
            var password = Console.ReadLine();

            Console.WriteLine("\nInserisci il numero");
            var number = Console.ReadLine();

            var user = new User(first_name, last_name, email, password, number);
            Console.WriteLine($"\nNuovo utente registrato: " +
                $"\n{user.first_name} {user.last_name}" +
                $"\n{user.email}" +
                $"\n{user.number}");
        }

        public void search()
        {
            bool search = true;
            while (search == true)
            {
                Console.WriteLine("Libri | DVD | Ricerca avanzata | indietro");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "libri":
                        Console.WriteLine($"Lista libri:");
                        ListBooks();
                        break;
                    case "dvd":
                        Console.WriteLine("Lista DVD: ");
                        ListDvds();
                        break;
                    case "ricerca avanzata":
                        advancedSearch();
                        break;
                    case "indietro":
                        search = false;
                        break;
                    case "esci" or "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input non valido");
                        break;
                }
            }
        }

        public void advancedSearch()
        {
            bool search = true;
            while (search == true)
            {
                Console.WriteLine("Per titolo | Indietro");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "per titolo":
                        Console.WriteLine("Scrivi il titolo del documento");
                        string query = Console.ReadLine();
                        SearchByTitle(query);
                        break;
                    case "indietro":
                        search = false;
                        break;
                    case "esci" or "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input non valido");
                        break;
                }
            }
        }
    }
}