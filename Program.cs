using System;

class Program
{
    static void Main()
    {
        var vitals = new VitalsChecker.Vitals
        {
            Temperature = 101,
            PulseRate = 110,
            SpO2 = 95
        };

        var status = VitalsChecker.CheckVitals(vitals);

        switch (status)
        {
            case VitalsChecker.VitalStatus.Normal:
                VitalsAlert.ReportVitals(vitals);
                break;
            case VitalsChecker.VitalStatus.TemperatureCritical:
                VitalsAlert.ShowAlert("Temperature critical!");
                break;
            case VitalsChecker.VitalStatus.PulseOutOfRange:
                VitalsAlert.ShowAlert("Pulse rate out of range!");
                break;
            case VitalsChecker.VitalStatus.SpO2Low:
                VitalsAlert.ShowAlert("Oxygen saturation low!");
                break;
        }
    }
}
