using Open_Closed_Principle.Shared;

namespace Open_Closed_Principle.Violation
{
    public class IndoorTemperatureSensor
    {
        public IndoorTemperatureSensor(Temperature temperature)
        {
            CurrentTemperature = temperature;
        }

        public Temperature CurrentTemperature { get; }
    }
}
