using csharp_biblioteca;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Gestionale biblioteca");

var Library = new Library();
bool isUserRegistered = false;

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

            Console.WriteLine("bravo il coglione");
            break;
        case "esci" or "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Input non valido");
            break;
    }
}