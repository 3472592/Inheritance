using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceCars.Vehicles.Components;
    public interface ITechAll
    {
    public int? NumberOfWheels { get; set; }
    public string? Engine { get; set; }
    public string? EngineName { get; set; }
    public string? EngineVersion { get; set; }
    public string? EngineSound { get; set; }
    public string? ChassisType { get; set; }
    public string? Trans { get; set; }
    public string? TransName { get; set; }
    public string? TransVersion { get; set; }
    public string? SuspensionType { get; set; }

    public string? Axles { get; set; }
    public string? Shocks { get; set; }
    public string? Brakes { get; set; }
    
    public short? Speed { get; set; }
}