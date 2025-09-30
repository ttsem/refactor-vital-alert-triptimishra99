using System;
using System.Threading;

class VitalsAlert
{
    // Handles alerts with blinking effect
    public static void ShowAlert(string message, int blinks = 6)
    {
        Console.WriteLine(message);
        for (int i = 0; i < blinks; i++)
        {
            Console.Write("\r* ");
            Thread.Sleep(1000);
            Console.Write("\r *");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public static void ReportVitals(VitalsChecker.Vitals vitals)
    {
        Console.WriteLine("Vitals within normal range:");
        Console.WriteLine($"Temperature: {vitals.Temperature} | Pulse: {vitals.PulseRate} | SpO2: {vitals.SpO2}");
    }
}
