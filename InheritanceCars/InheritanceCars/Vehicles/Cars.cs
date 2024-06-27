using InheritanceCars.Vehicles.Components;


namespace InheritanceCars.Vehicles;

    public class Cars : ITechAll, IInterior, IExterior
    {
    public int? NumberOfWheels { get; set; }
    public string? Engine { get; set; }
    public string? EngineName { get; set; }
    public string? EngineVersion { get; set; }
    public string? EngineSound { get; set; }
    public string? ChassisType { get; set; }
    public string? SuspensionType { get; set; }
    public string? Trans { get; set; }
    public string? TransName { get; set; }
    public string? TransVersion { get; set; }

    public string? ExteriorMaterial { get; set; }
    public string? Tires { get; set; }
    public string? Rims { get; set; }
    public string? LogNuts { get; set; }
    public string? Axles { get; set; }
    public string? Shocks { get; set; }
    public string? Brakes { get; set; }
    public string? Lights { get; set; }

    public short? Speed { get; set; }

    public string? InteriorMaterial { get; set; }
    public int? NumberOfSeats { get; set; }
    public string? SteeringWheel { get; set; }

    public string CarCreds(int numOfWheels, string engine)
    {
        NumberOfWheels = numOfWheels;
        Engine = engine;

        return "Total of wheels is " + numOfWheels.ToString() + "\n" +
            "Engine Name is" + engine.ToString();
    }
}