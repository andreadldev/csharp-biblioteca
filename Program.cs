using csharp_biblioteca;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Gestionale biblioteca");

var Library = new Library();
bool isUserRegistered = false;
Library.AddDocument(new Book("libro1", "autore1", "anno1", "categoria1"));
Library.AddDocument(new Book("libro2", "autore2", "anno2", "categoria2"));

Library.AddDocument(new Dvd("dvd1", "autore1", "anno1", "categoria1"));
Library.AddDocument(new Dvd("dvd2", "autore2", "anno2", "categoria2"));

while (true)
{
    Console.WriteLine("registrati | ricerca | esci");
    var input = Console.ReadLine();

    switch (input)
    {
        case "registrati":
            if (isUserRegistered == true)
            {
                Console.WriteLine("Sei già registrato.");
                break;
            }
            Library.userRegister();
            isUserRegistered = true;
            break;
        case "ricerca":
            Library.search();
            break;
        case "esci" or "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Input non valido");
            break;
    }
}
