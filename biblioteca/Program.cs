using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Utente u = new Utente();
            Documento d = new Documento();
            Autore a = new Autore();
            DVD dvd = new DVD();
            Libro l = new Libro();
            Prestito prestito = new Prestito();
            Console.WriteLine("inserisci il tuo nome");
            p.nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome");
            p.cognome = Console.ReadLine();
            Console.WriteLine("inserisci il numero di telefono");
            u.telefono = Console.ReadLine();
            Console.WriteLine("inserisci la email");
            u.email = Console.ReadLine();   
            Console.WriteLine("inserisci la password");
            u.password = Console.ReadLine();
            Console.WriteLine("inserisci il codice");
            d.codice = Console.ReadLine();
            Console.WriteLine("inserisci il titolo");
            d.titolo = Console.ReadLine();
            Console.WriteLine("inserisci l'anno di produzione");
            d.anno=int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il settore");
            d.settore = Console.ReadLine();
            Console.WriteLine("inserisci il nome dell'autore");
            a.nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome dell'autore");
            a.cognome = Console.ReadLine();
            Console.WriteLine("inserisci il tipo di documento");
            int tipo = int.Parse(Console.ReadLine());
            if(tipo==1)
            {
                dvd.durata=int.Parse(Console.ReadLine());
                Console.WriteLine("il dvd '{0}' prodotto da {1} {2} nel {3} si trova nel settore {4}",d.titolo,a.nome,a.cognome,d.anno,d.settore);
                Console.WriteLine("inserire il numero del documento");
                prestito.numero=Console.ReadLine();
                Console.WriteLine("inserire il periodo");
                prestito.dal=DateTime.Parse(Console.ReadLine());    
                prestito.al=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("operazione eseguita con successo");

            }
            else if(tipo==2)
            {
                l.pagine=int.Parse(Console.ReadLine());
                Console.WriteLine("il libro '{0}' scritto da {1} {2} nel {3} si trova nel settore {4}", d.titolo, a.nome, a.cognome, d.anno, d.settore);
                Console.WriteLine("inserire il numero del documento");
                prestito.numero = Console.ReadLine();
                Console.WriteLine("inserire il periodo");
                prestito.dal = DateTime.Parse(Console.ReadLine());
                prestito.al = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("operazione eseguita con successo");
            }
            else
            {
                Console.WriteLine("tipo errato");
            }
            Console.ReadLine();

        }
    }
    enum Stato { disponibile, prestito}
}
