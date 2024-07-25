using System;

class Program
{
    static void Main(string[] args)
    {
        // Create events
        Lecture lecture = new Lecture("Lecture on programming", "A must have 21st century knowledge", new DateTime(2024, 8, 17, 18, 0, 0), new Address("123 Main St", "Holy Wood", "CA", "12345"), "John Taylor", 100);
        Reception reception = new Reception("Warn Exotic Reception", "Join us for an excting reception", new DateTime(2024, 7, 14, 15, 30, 0), new Address("456 Car Rd", "Ikoyi", "LAG", "54321"), "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Woods", "Have fun and relax", new DateTime(2024, 7, 30, 12, 0, 0), new Address("789 Elm St", "Houston", "TX", "67890"), "Sunny with a high of 80F");


        // Output event details
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n" + reception.GetStandardDetails());
        Console.WriteLine("\n" + outdoorGathering.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n" + reception.GetFullDetails());
        Console.WriteLine("\n" + outdoorGathering.GetFullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}