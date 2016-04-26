using System;
using FluentAssertions;
using NUnit.Framework;
using Open_Closed_Principle.Shared;

namespace Open_Closed_Principle.Tests
{
    [TestFixture]
    public class TemperatureTest
    {
        private readonly Temperature _oneDegreeCelsius = new Temperature(1, TemperatureUnit.Celsius);
        private readonly Temperature _twoDegreeCelsius = new Temperature(2, TemperatureUnit.Celsius);
        private readonly Temperature _oneDegreeFahrenheit = new Temperature(1, TemperatureUnit.Fahrenheit);

        [Test]
        public void AddCelsiusReturnsSum()
        {
            var sumOf1And1Celsius = _oneDegreeCelsius + _oneDegreeCelsius;

            sumOf1And1Celsius.Should().Be(_twoDegreeCelsius);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SumDifferentUnitRaisesException()
        {
            var differentUnits = _oneDegreeCelsius + _oneDegreeFahrenheit;
        }
    }
}
