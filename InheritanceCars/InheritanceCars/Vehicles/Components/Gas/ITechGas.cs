using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCars.Vehicles.Components.Gas
{
    public interface ITechGas
    {
        public string? Engine { get; set; }
        public string? EngineName { get; set; }
        public string? EngineVersion { get; set; }

        public string? FuelTank { get; set; }

        public string? Exhaust { get; set; }
        public string? Muffler { get; set; }
        public string? Catalytic { get; set; }

        public string? Battery { get; set; }

        public string? Trans { get; set; }
        public string? TransName { get; set; }
        public string? TransVersion { get; set; }

        public string? Tires { get; set; }
        public string? Rims { get; set; }
        public string? LogNuts { get; set; }
        public string? Axle { get; set; }
        public string? Shock { get; set; }
        public string? Brake { get; set; }
    }
}
