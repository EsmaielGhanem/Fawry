using Test.Interfaces.RulesInterfaces;

namespace Test;

public class Radar
{
    private readonly IEnumerable<IRule> _rules;

    public Radar(IEnumerable<IRule> rules)
    {
        _rules = rules.ToList();
    }

    public Fine? MakeObservation(Observation observation)
    {
        List<Violation> violations = new();
        foreach (var rule in _rules)
        {
            var violation = rule.Check(observation);
            if (violation != null) violations.Add(violation);
        }

        if (!violations.Any()) return null;
        return new Fine(observation.PlateNumber, violations); 
    }
    
}