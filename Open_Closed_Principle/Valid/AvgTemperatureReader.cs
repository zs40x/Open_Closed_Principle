using System.Collections.Generic;
using System.Linq;

namespace Open_Closed_Principle.Valid
{
    public class AvgTemperatureReader
    {
        public double GetAverageTemperature(List<ITemperatureSensor> sensors)
        {
            return sensors.Count == 0 ? 0 : sensors.Average(s => s.CurrentTemperature.Value);
        }
    }
}
