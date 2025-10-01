using System;
using System.Collections;
using WaitingList;

public class QueueSupermarket
{
    
    static void Main(String[] args)
    {
        Queue<Customer> customerQueue = new Queue<Customer>();
        
        bool go = true;
        
        while (go){
        Console.WriteLine("1. een nieuwe klant toevogen.");
        Console.WriteLine("2. de volgende klant helpen. ");
        Console.WriteLine("3. de wachtrij tonen.");
        Console.WriteLine("4. stop het programma." );
        
        
        Console.WriteLine("kies een optie: ");
        int input= Convert.ToInt32(Console.ReadLine());




        switch (input)
        {
            case 1:
                Console.Write("Naam van de klant: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Naam mag niet leeg zijn!");
                    break;
                }

                customerQueue.Enqueue(new Customer(name));
                Console.WriteLine(name+" is toegevoegd aan de wachtrij.");
                break;

            case 2:
                if (customerQueue.Count > 0)
                {
                    Customer gettingHelp = customerQueue.Dequeue();
                    Console.WriteLine(gettingHelp.GetName()+" wordt geholpen!");
                }
                else
                {
                    Console.WriteLine("Er zijn geen klanten in de wachtrij.");
                }

                break;

            case 3:
                if (customerQueue.Count > 0)
                {
                    Console.WriteLine("Wachtrij:");
                    foreach (Customer customers in customerQueue)
                    {
                        Console.WriteLine("- " + customers.GetName);
                    }
                }
                else
                {
                    Console.WriteLine("De wachtrij is leeg.");
                }

                break;

            case 4:
                go = false;
                Console.WriteLine("Programma wordt afgesloten...");
                break;

            default:
                Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                break;
        }
        }
    }
}