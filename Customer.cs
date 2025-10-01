namespace WaitingList;

public class Customer
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
    
}