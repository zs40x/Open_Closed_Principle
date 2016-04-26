using Open_Closed_Principle.Shared;

namespace Open_Closed_Principle.Valid
{
    public abstract class AbstractTemperatureSensor : ITemperatureSensor
    {
        public Temperature CurrentTemperature { get; private set; }

        protected AbstractTemperatureSensor(Temperature currentTemperature)
        {
            CurrentTemperature = currentTemperature;
        }

        protected void NewTemperatureReceived(Temperature newTemperature)
        {
            CurrentTemperature = newTemperature;
        }
    }
}
