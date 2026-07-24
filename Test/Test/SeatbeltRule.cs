using Test.Interfaces.RulesInterfaces;

namespace Test;

public class SeatbeltRule : IRule
{
    private readonly decimal _fine;

    public SeatbeltRule( decimal fine)
    {
        _fine = fine;
    }
    public Violation? Check(Observation observation)
    {
       

        if (observation.IsSeatbeltFastened)
            return null;

        return new Violation(
            $"Seatbelt not fastned",  _fine);
    }    
}