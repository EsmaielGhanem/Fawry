using Test.Interfaces;
using Test.Interfaces.RulesInterfaces;

namespace Test;

public class SpeedRule : IRule
{
    private readonly CarType _carType;
    private readonly double _maxSpeed;
    private readonly decimal _fine;

    public SpeedRule(CarType carType, double maxSpeed, decimal fine)
    {
        _carType = carType;
        _maxSpeed = maxSpeed;
        _fine = fine;
    }
    public Violation? Check(Observation observation)
    {
        if (observation.CarType != _carType)
            return null;

        if (observation.Speed <= _maxSpeed)
            return null;

        return new Violation(
            $"speed of {observation.Speed} exceeded max allowed {_maxSpeed}",
            _fine);
    }    

}