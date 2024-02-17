using System;

class Program
{
    static void Main(string [] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "USA");
        Address address2 = new Address("456 Elm St", "Townsville", "Canada");
        Address address3 = new Address("789 Oak St", "Villageville", "USA");

        Lecture lectureEvent = new Lecture("Lecture Title", "Interesting lecture topic", new DateTime(2024, 2, 20), new TimeSpan(14, 0, 0), address1, "John Doe", 50);
        Reception receptionEvent = new Reception("Reception Title", "Join us for a fun evening", new DateTime(2024, 3, 15), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering Title", "Enjoy the outdoors with us", new DateTime(2024, 4, 10), new TimeSpan(12, 0, 0), address3, "Sunny skies");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        
        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
