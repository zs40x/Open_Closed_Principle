using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Closed_Principle.Violation
{
    public class AvgTemperatureReader
    {
        public double GetAverageTemperature(List<object> temperatureSensors)
        {
            double total = 0;
            int count = 0;
            
            foreach (var temperatureSensor in temperatureSensors.OfType<IndoorTemperatureSensor>())
            {
                total += (temperatureSensor).CurrentTemperature.Value;
                count ++;
            }

            foreach (var temperatureSensor in temperatureSensors.OfType<OutdoorTemperatureSensor>())
            {
                total += (temperatureSensor).CurrentTemperature.Value;
                count++;
            }

            if (count == 0)
            {
                return 0;
            }

            return total / count;
        }
        
    }
}
