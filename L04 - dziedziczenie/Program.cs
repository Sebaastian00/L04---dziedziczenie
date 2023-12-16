using System;

class Employer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    private double salary;

    public Employer(string firstName, string lastName, string position)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        salary = 0;
    }

    public string GetInfo()
    {
        return $"{FirstName} {LastName} - {Position}";
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
            Console.WriteLine($"New salary set for {FirstName} {LastName}: {salary}");
        }
        else
        {
            Console.WriteLine("Salary cannot be negative.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Tworzenie instancji pracowników
        Employer director = new Employer("John", "Doe", "Director");
        Employer accountant = new Employer("Alice", "Smith", "Accountant");
        Employer technician = new Employer("Bob", "Johnson", "Technician");

        // Wyświetlenie informacji o pracownikach
        Console.WriteLine(director.GetInfo());
        Console.WriteLine(accountant.GetInfo());
        Console.WriteLine(technician.GetInfo());

        // Ustawianie pensji dla pracowników
        director.SetSalary(10000);
        accountant.SetSalary(5000);
        technician.SetSalary(7000);

        // Wyświetlenie pensji pracowników
        Console.WriteLine($"Director's salary: {director.GetSalary()}");
        Console.WriteLine($"Accountant's salary: {accountant.GetSalary()}");
        Console.WriteLine($"Technician's salary: {technician.GetSalary()}");
    }
}
