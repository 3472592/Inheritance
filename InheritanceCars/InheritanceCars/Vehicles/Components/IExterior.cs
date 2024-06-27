using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCars.Vehicles.Components
{
    public interface IExterior
    {
        public string? ExteriorMaterial { get; set; }
        public string? Tires { get; set; }
        public string? Rims { get; set; }
        public string? LogNuts { get; set; }
        public string? Lights { get; set; }
    }
}
