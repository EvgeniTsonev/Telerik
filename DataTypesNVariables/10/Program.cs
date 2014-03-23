
//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics
//– first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information
//for a single employee using appropriate data types and descriptive names.


using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string familyName = "Ivanov";
        byte age = 18;
        char gender = 'm';
        string idNumber = "87087987";              //stringove syshto mogat da se sravnqvat
        string uniqueEmploeeNumber = "435324534 ";
        Console.WriteLine("{0} {1} {2} {3} {4} {5} ", firstName, familyName, age, gender, idNumber, uniqueEmploeeNumber);
        Console.WriteLine();
    }
}

