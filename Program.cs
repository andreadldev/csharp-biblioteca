using csharp_biblioteca;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Gestionale biblioteca");
bool registered = false;

while (true)
{
    Console.WriteLine("registrati | esci");
    var input = Console.ReadLine();

    switch (input)
    {
        case "registrati":
            if (registered == true)
            {
                Console.WriteLine("Sei già registrato.");
                break;
            }
            Register();
            break;
        case "esci" or "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Input non valido");
            break;
    }
}

void Register()
{
    Console.WriteLine("\nInserisci il nome");
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
    registered = true;
}
