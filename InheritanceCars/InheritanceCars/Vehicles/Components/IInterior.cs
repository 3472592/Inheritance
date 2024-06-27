using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCars.Vehicles.Components
{
    public interface IInterior
    {
        public string? InteriorMaterial { get; set; }
        public int? NumberOfSeats { get; set; }
        public string? SteeringWheel { get; set; }
    }
}
