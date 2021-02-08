using System;

public class Example
{
    public static void Main()
    {
        bool flag = true;
        try
        {
            IConvertible conv = flag;
            Char ch = conv.ToChar(null);
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Cannot convert a Boolean to a Char.");
        }

        try
        {
            Char ch = Convert.ToChar(flag);
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Cannot convert a Boolean to a Char.");
        }
        {
            decimal price = 169.32m;
            Console.WriteLine("The cost is {0:Q2}.", price);
        }
        String _name;

   public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

public class PersonWithId : Person
{
    String _id;

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
}

public class Example
{
    public static void Main()
    {
        Person p = new Person();
        p.Name = "John";
        try
        {
            PersonWithId pid = (PersonWithId)p;
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Conversion failed.");
        }

        PersonWithId pid1 = new PersonWithId();
        pid1.Name = "John";
        pid1.Id = "246";
        Person p1 = pid1;
        try
        {
            PersonWithId pid1a = (PersonWithId)p1;
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Conversion failed.");
        }

        Person p2 = null;
        try
        {
            PersonWithId pid2 = (PersonWithId)p2;
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Conversion failed.");
        }
        public static void Main(string[] args)
        {
            int value = Int32.Parse(args[0]);
            List<String> names;
            if (value > 0)
                names = new List<String>();

            names.Add("Major Major Major");
        }
    }
}

}