using Test.Interfaces.RulesInterfaces;

namespace Test;

class Program
{
    private const double MAX_TRUCK_SPEED = 60 ; 
    private const double MAX_PRIVATE_SPEED = 100 ; 
    private const double MAX_BUS_SPEED = 80 ;
    private const decimal TRUCK_FEE_SPEED = 300;
    private const decimal PRIVATE_FEE_SPEED = 120;
    private const decimal BUS_FEE_SPEED = 200; 
    
    private const decimal SEATBELT_FEE = 80 ;
    public static void Main(string[] args)
    {
        List<IRule> rules = new()
        {
            new SpeedRule(CarType.Truck,MAX_TRUCK_SPEED,TRUCK_FEE_SPEED),
            new SpeedRule(CarType.Private,MAX_PRIVATE_SPEED,PRIVATE_FEE_SPEED),
            new SpeedRule(CarType.Bus,MAX_BUS_SPEED,BUS_FEE_SPEED),
            new SeatbeltRule(SEATBELT_FEE) 
        };

        Radar radar = new Radar(rules);

        Observation observation = new Observation
        {
            PlateNumber = "ABC1234",
            Date = DateTime.Now,
            CarType = CarType.Private,
            Speed = 150,
            IsSeatbeltFastened = false
        };

        Fine? fine = radar.MakeObservation(observation);
        
        
        if(fine != null)
        fine.FineReport();
        
    }
}
