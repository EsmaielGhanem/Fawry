namespace Test;

public class Fine
{
    public string PlateNumber { get; }

    public IReadOnlyList<Violation> Violations { get; }

    public decimal TotalAmount =>
        Violations.Sum(v => v.Fee);

    public Fine(string plateNumber, List<Violation> violations)
    {
        PlateNumber = plateNumber;
        Violations = violations;
    }

    public void FineReport()
    {
        Console.WriteLine($"Traffic fine for car {PlateNumber}"); 
        Console.WriteLine($"Total amount : {TotalAmount}"); 
        Console.WriteLine("Violatoins:");
        foreach (var violation in Violations)
        {
            Console.WriteLine($"- {violation.Message} : {violation.Fee} EGP");
        }
    }
    
    
}