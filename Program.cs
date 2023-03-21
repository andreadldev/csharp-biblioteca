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
            Console.WriteLine("...");
            break;
        case "esci" or "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Input non valido");
            break;
    }
}

//Si vuole progettare un sistema per la gestione di una biblioteca.
//Gli utenti si possono registrare al sistema, fornendo:
//-cognome
//- nome
//- email
//- password
//- recapito telefonico

//Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//-un codice identificativo di tipo stringa
//- titolo
//- anno
//- settore (storia, matematica, economia, …)
//-uno scaffale in cui è posizionato
//- un autore (Nome, Cognome)
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
//Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
//Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.
