namespace Test;

public class Observation
{
    public string PlateNumber { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public CarType CarType { get; set; }

    public double Speed { get; set; }

    public bool IsSeatbeltFastened { get; set; }
}