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

    // CCN reduced by delegating each check
    public static VitalStatus CheckVitals(Vitals vitals)
    {
        if (IsTemperatureCritical(vitals))
            return VitalStatus.TemperatureCritical;

        if (IsPulseOutOfRange(vitals))
            return VitalStatus.PulseOutOfRange;

        if (IsSpO2Low(vitals))
            return VitalStatus.SpO2Low;

        return VitalStatus.Normal;
    }

    private static bool IsTemperatureCritical(Vitals v) =>
        v.Temperature > 102 || v.Temperature < 95;

    private static bool IsPulseOutOfRange(Vitals v) =>
        v.PulseRate < 60 || v.PulseRate > 100;

    private static bool IsSpO2Low(Vitals v) =>
        v.SpO2 < 90;
}
