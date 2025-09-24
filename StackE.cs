using System.Collections;

namespace ThuisOefeningen;

public class StackE

{

    static void Main(String[] args)
    {
        Stack myStack = new Stack();
        myStack.Push("Fiona's plate");
        myStack.Push("George's plate");
        myStack.Push("Pierre's plate");
        myStack.Push("Kevin's plate");
        myStack.Push("Solomons plate");

        
            Console.WriteLine("Amount of plates in the stack : " + myStack.Count);
            Console.WriteLine("The plate on top is : " + myStack.Peek());
            Console.WriteLine("The plate on top get's taken off : " + myStack.Pop());
            Console.WriteLine("The plate on top is : " + myStack.Peek());
            Console.WriteLine("Amount of plates in the stack : " + myStack.Count);
            Console.WriteLine("Pierre's plate is still in the stack : " + myStack.Contains("Pierre's plate"));
            Console.WriteLine();
            
            foreach (var StackItem in myStack)
            {
                Console.WriteLine(StackItem);
            }


    }
}