using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D3.OOP_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine(
                               "----------------\n" +
                               " BANCA D'ITALIA \n" +
                               "----------------\n" +
                               "\n" +
                               "Vuoi registrarti? y/n"
                               );
            string registrazione = Console.ReadLine();
            if (registrazione != "y") Environment.Exit(0);
            ContoCorrente NuovoConto = new ContoCorrente();
            Console.WriteLine($"Benvenuto, come ti chiami?");
            persona.Nome = Console.ReadLine();
            while (persona.Nome == "")
            {
                Console.WriteLine("Si prega di riempire il campo, Qual'è il tuo nome?");
                persona.Nome = Console.ReadLine();
            }
            Console.WriteLine($"Ciao {persona.Nome}, Qual'è il tuo cognome?");
            persona.Cognome = Console.ReadLine();
            while (persona.Cognome == "")
            {
                Console.WriteLine("Si prega di riempire il campo, Qual'è il tuo cognome?");
                persona.Cognome = Console.ReadLine();
            }
            Console.WriteLine($"CONTO di {persona.Nome} {persona.Cognome} creato con successo!");
            string unAltraOperazione;
            do
            {
                Console.WriteLine(
                      "\n" +
                      "0. Esci\n" +
                      "1. Saldo\n" +
                      "2. Prelievo\n" +
                      "3. Versamento\n" +
                      "\n"
                      );

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"Il tuo saldo attuale è di: {NuovoConto.Saldo}");
                        break;
                    case "2":
                        {
                            Console.WriteLine("Quanto vuoi prelevare?");
                            string quantita = Console.ReadLine();
                            if (NuovoConto.Saldo < 0 || NuovoConto.Saldo < double.Parse(quantita)) {
                                Console.WriteLine("Non puoi prelevare, non hai credito sufficiente.");
                            } else
                            {
                                NuovoConto.Prelievo(double.Parse(quantita));
                            }
                        } 
                        break;
                    case "3":
                        {
                            Console.WriteLine("Quanto vuoi versare?");
                            string quantita = Console.ReadLine();
                            NuovoConto.Versamento(double.Parse(quantita));
                        }
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\nVuoi fare altre operazioni? y/n");
                unAltraOperazione = Console.ReadLine();
            } while (unAltraOperazione == "y");
            Console.ReadLine();
        }
    }
}
