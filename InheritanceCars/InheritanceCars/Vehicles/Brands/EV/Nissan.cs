using InheritanceCars.Vehicles.Components.EV;

namespace InheritanceCars.Vehicles.Brands.EV;
public class Nissan : Cars, ITechEV
{
    private string? _name;
    public string? Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}