public class AnimalShelter
{
    public AnimalShelter(string name, string kind, int age)
    {
        this.name = name;
        this.kind = kind;
        this.age = age;
    }

    private string name;
    private string kind;
    private int age;
    

    public String GetName()
    {
        return name;
    }

    public String GetKind()
    {
        return kind;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetName(string newName)
    {
        this.name = name;
    }

    public void SetKind(string newKind)
    {
        this.kind = kind;
    }

    public void SetAge(string newAge)
    {
        this.age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine(this.name+" "+this.kind+" "+this.age);
    }

    
    
}