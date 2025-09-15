using System.Runtime.InteropServices;

namespace Oefeningen25_26;

public class Adoptant
{
    private String name;
    private String email;
    private int phonenumber;

    public Adoptant(String name, String email, int phonenumber)
    {
        this.name = name;
        this.email = email;
        this.phonenumber = phonenumber;
    }

    public String GetName()
    {
        return name;
    }

    public String GetEmail()
    {
        return email;
    }

    public int GetPhonenumber()
    {
        return phonenumber;
    }

    public void SetName(String newName)
    {
        this.name = name;
    }

    public void SetEmail(String newEmail)
    {
        this.email = email;
    }

    public void SetPhonenumber(int newPhonenumber)
    {
        this.phonenumber = phonenumber;
    }
    

    
    
}