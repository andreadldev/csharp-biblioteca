using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
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
            Console.WriteLine("Libri | DVD | indietro");
            while (search == true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "libri":
                        Console.WriteLine("Lista libri: ");
                        break;
                    case "dvd":
                        Console.WriteLine("Lista DVD: ");
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
