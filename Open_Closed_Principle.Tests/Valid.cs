using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Open_Closed_Principle.Shared;
using Open_Closed_Principle.Valid;

namespace Open_Closed_Principle.Tests
{
    [TestFixture]
    public class Valid
    {
        AvgTemperatureReader _avgTempReader;

        [SetUp]
        public void InitializeTest()
        {
            _avgTempReader = new AvgTemperatureReader();
        }

        [Test]
        public void EmptyListReturnsNull()
        {
            var sensors = new List<ITemperatureSensor>();
            
            _avgTempReader.GetAverageTemperature(sensors).Should().Be(0);
        }

        [Test]
        public void OneSensorValueIsReturned()
        {
            var sensors = new List<ITemperatureSensor>
            {
                new IndoorTemperatureSensor(new Temperature(1.0, TemperatureUnit.Celsius))
            };

            _avgTempReader.GetAverageTemperature(sensors).Should().Be(1);
        }

        [Test]
        public void TwoSensorValueIsReturned()
        {
            var sensors = new List<ITemperatureSensor>
            {
                new IndoorTemperatureSensor(new Temperature(1.0, TemperatureUnit.Celsius)),
                new OutdoorTemperatureSensor(new Temperature(2.0, TemperatureUnit.Celsius))
            };

            _avgTempReader.GetAverageTemperature(sensors).Should().Be(1.5);
        }
    }
}
