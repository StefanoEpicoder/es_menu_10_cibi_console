using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace es_menù_10_cibi_console_app_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definizione dei nomi e prezzi dei cibi nel menu
            string[] menuItems = new string[]
            {
                "Coca Cola 150 ml (euro 2.50)",
                "Insalata di pollo (euro 5.20)",
                "Pizza Margherita (euro 10.00)",
                "Pizza 4 Formaggi (euro 12.50)",
                "Pz patatine fritte (euro 3.50)",
                "Insalata di riso (euro 8.00)",
                "Frutta di stagione (euro 5.00)",
                "Pizza fritta (euro 5.00)",
                "Piadina vegetariana (euro 6.00)",
                "Panino Hamburger (euro 7.90)"
            };

            // Definizione dei prezzi corrispondenti ai cibi
            double[] menuPrices = new double[]
            {
                2.50, 5.20, 10.00, 12.50, 3.50,
                8.00, 5.00, 5.00, 6.00, 7.90
            };

            // Inizializzazione del costo totale
            double totalCost = 0.00;



            // Visualizzazione del menu
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============MENU==============");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }
            Console.WriteLine($"11: Stampa conto finale e conferma (euro 3.00)");
            Console.WriteLine("==============MENU==============");



            // Ciclo di selezione dei cibi
            while (true)
            {
                Console.Write("Seleziona un cibo (da 1 a 10), premi 11 per il conto finale. ");
                if (int.TryParse(Console.ReadLine(), out int choice))//Qui prendo l'input dell’utente dalla console.
                                                                     //int.TryParse tenta di convertire l’input in un numero
                                                                     //intero e lo assegna alla variabile choice.

                {
                    if (choice >= 1 && choice <= 10)//Se choice è compreso tra 1 e 10,
                                                    //viene aggiunto il prezzo del cibo selezionato (menuPrices[choice - 1])
                                                    //al costo totale (totalCost).
                    {
                        // Aggiunta del prezzo del cibo selezionato al costo totale
                        totalCost += menuPrices[choice - 1];
                    }
                    else if (choice == 11)
                    {
                        // Aggiungo il costo del servizio al tavolo
                        // Se choice è 11, viene aggiunto il costo del servizio al tavolo(3,00 euro) al costo totale.
                        // Vengono quindi visualizzate alcune informazioni sul costo e il programma esce dal ciclo con break.
                        totalCost += 3.00;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Costo cibi: euro {totalCost - 3.00}");
                        Console.WriteLine($"Servizio al tavolo: euro 3.00");
                        Console.WriteLine($"Costo totale: euro {totalCost}");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Scelta non valida. Riprova.");
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci un numero valido.");
                }
            }
        }
    }
}
