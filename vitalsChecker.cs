using System;

class VitalsChecker
{
    public struct Vitals
    {
        public float Temperature;
        public int PulseRate;
        public int SpO2;
    }

    public enum VitalStatus
    {
        Normal,
        TemperatureCritical,
        PulseOutOfRange,
        SpO2Low
    }

    // Pure function: returns the status without any I/O
    public static VitalStatus CheckVitals(Vitals vitals)
    {
        if (vitals.Temperature > 102 || vitals.Temperature < 95)
            return VitalStatus.TemperatureCritical;

        if (vitals.PulseRate < 60 || vitals.PulseRate > 100)
            return VitalStatus.PulseOutOfRange;

        if (vitals.SpO2 < 90)
            return VitalStatus.SpO2Low;

        return VitalStatus.Normal;
    }
}
