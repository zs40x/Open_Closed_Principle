using System.Collections.Generic;

namespace Open_Closed_Principle.Valid
{
    public class AvgTemperatureReader
    {
        public double GetAverageTemperature(List<ITemperatureSensor> sensors)
        {
            double total = 0;
            int counter = 0;

            sensors.ForEach(sensor =>
            {
                total += sensor.CurrentTemperature.Value;
                counter++;
            });

            if (counter == 0)
                return 0;

            return total / counter;
        }
    }
}
