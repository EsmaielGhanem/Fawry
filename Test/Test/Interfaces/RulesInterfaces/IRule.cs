namespace Test.Interfaces.RulesInterfaces;

public interface IRule
{
    Violation? Check(Observation observation);

}