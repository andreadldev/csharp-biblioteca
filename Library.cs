using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public void Register()
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
    }
}
