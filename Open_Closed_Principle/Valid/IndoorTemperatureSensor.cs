using System;
using Open_Closed_Principle.Shared;

namespace Open_Closed_Principle.Valid
{
    public class IndoorTemperatureSensor : AbstractTemperatureSensor
    {
        public IndoorTemperatureSensor(Temperature temperature) 
            : base(temperature) { }
    }
}
