namespace Test;

public class Violation
{
    public String Message { get; }
    public decimal Fee { get; }

    public Violation(String message, decimal fee)
    {
        Message = message;
        Fee = fee; 
    }
   
}