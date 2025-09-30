using Xunit;

public class CheckerTests
{
    [Fact]
    public void CheckVitals_ReturnsExpectedStatus(
        float temperature, int pulseRate, int spo2, VitalsChecker.VitalStatus expectedStatus)
    {
        var vitals = new VitalsChecker.Vitals
        {
            Temperature = temperature,
            PulseRate = pulseRate,
            SpO2 = spo2
        };

        var status = VitalsChecker.CheckVitals(vitals);

        Assert.Equal(expectedStatus, status);
    }
}