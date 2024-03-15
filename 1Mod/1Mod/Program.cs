//v2
using System;

public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class CalendarEvent
{
    public string EventName { get; set; }
    public DaysOfWeek EventDay { get; set; }

    public CalendarEvent(string eventName, DaysOfWeek eventDay)
    {
        EventName = eventName;
        EventDay = eventDay;
    }

    public void PrintEventDetails()
    {
        Console.WriteLine($"Подія {EventName} відбудеться в день {EventDay}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalendarEvent myEvent = new CalendarEvent("Концерт", DaysOfWeek.Saturday);
        myEvent.PrintEventDetails();
    }
}
