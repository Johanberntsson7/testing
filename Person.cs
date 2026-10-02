namespace testing;

public class Person
{
    public string Name;
    public string Adress;
    public int Phonenumber;

    public void UserInfo()
    {
        Console.WriteLine("Write your name:");
        Name = Console.ReadLine()!;

        Console.WriteLine("Write your Adress:");
        Adress = Console.ReadLine()!;

        Console.WriteLine("Write your phonenumber:");
        Phonenumber = int.Parse(Console.ReadLine()!);
    }

        public void WriteOutUserInfo()
    {
        Console.WriteLine($"Your name is {Name}, and your adress is {Adress}, and your phonenumber is {Phonenumber}");
    }
    
}