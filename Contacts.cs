using System.Collections.Generic;

Dictionary<string, string> Contacts = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("[1]Add Contact");
    Console.WriteLine("[2]Delete Contact");
    Console.WriteLine("[3]List all Contacts");
    Console.WriteLine("[4]Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Number: ");
            string number = Console.ReadLine();
            Contacts.Add(name, number);
            break;
        case "2":
            Console.WriteLine("Enter Name: ");
            string nameToDelete = Console.ReadLine();
            Contacts.Remove(nameToDelete);
            break;
        case "3":
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Number: {contact.Value}");
            }
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }   

}   
