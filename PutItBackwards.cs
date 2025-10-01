using System;
using System.Collections;

public class WordsBackwards
{
    static void Main(){
        
        Console.WriteLine("Geef een woord in : ");
        string input = Console.ReadLine();
        
        Stack<char> backwards = new Stack<char>();

        foreach (char c in input)
        {
            backwards.Push(c);
        }

        string turnAround = null;
        while (backwards.Count > 0)
        {
            turnAround += backwards.Pop();
        }
        Console.WriteLine("Het omgekeerde woord is: "+turnAround);

    }
}