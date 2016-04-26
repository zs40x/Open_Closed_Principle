using Open_Closed_Principle.Shared;

namespace Open_Closed_Principle.Valid
{
    public class OutdoorTemperatureSensor : AbstractTemperatureSensor
    {
        public OutdoorTemperatureSensor(Temperature temperature) 
            : base(temperature) { }
    }
}
