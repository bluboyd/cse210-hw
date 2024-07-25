using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
            {
                new Running(new DateTime(2024, 07, 25), 30, 3.0),
                new Cycling(new DateTime(2024, 07, 25), 30, 9.7),
                new Swimming(new DateTime(2024, 07, 25), 30, 60)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}