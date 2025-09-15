namespace Oefeningen25_26;

public class AnimalDoable
{
    public static void Main()
    {
        AnimalDoable printMethod = new AnimalDoable();

    List<AnimalShelter> myList = new List<AnimalShelter>();
    AnimalShelter aSchnawg = new AnimalShelter("piepo", "dog", 6);
    AnimalShelter aFish= new AnimalShelter("mykolenko", "fish", 88);
    AnimalShelter aCat= new AnimalShelter("Pieter-jan van oostendestad", "cat", 6954);
    AnimalShelter aSnake = new AnimalShelter("piam", "Snake", 1);
    AnimalShelter aPerson= new  AnimalShelter("alexander", "person", 44);
    myList.Add(aSchnawg);
    myList.Add(aFish);
    myList.Add(aCat);
    myList.Add(aSnake);
    myList.Add(aPerson);
    foreach (AnimalShelter a in myList)
    {
        if (a.GetAge() > 3)
        {
            a.PrintInfo();
            Console.WriteLine();
            
        }
    }
    Queue<Adoptant> myQueue = new Queue<Adoptant>();
    Adoptant myAdoptant1 = new Adoptant("Jozef", "Jozef.Berge@gmail.com", 0496588852);
    Adoptant myAdoptant2 = new Adoptant("piet", "piet.hokie@skynet.com", 0455986778);
    Adoptant myAdoptant3 = new Adoptant("Bert", "Bert.Berty@gmail.com", 0455669988);
    Adoptant myAdoptant4 = new Adoptant("Klu", "Klu.GG@Gmail.A", 0499887326);
    myQueue.Enqueue(myAdoptant1);
    myQueue.Enqueue(myAdoptant2);
    myQueue.Enqueue(myAdoptant3);
    myQueue.Enqueue(myAdoptant4);
        
    Adoptant first = myQueue.Dequeue();
    Console.WriteLine(first.GetName()+" heeft een dier geadopteerd.");
    Console.WriteLine();


    Stack<string> stackenStackenVoorEenPanamera = new Stack<string>();
    stackenStackenVoorEenPanamera.Push("Panamera");
    stackenStackenVoorEenPanamera.Push("pantalon");
    stackenStackenVoorEenPanamera.Push("key key do you love me");
    foreach (string s in stackenStackenVoorEenPanamera)
    {
        Console.WriteLine(s);
    }
    




    }

}