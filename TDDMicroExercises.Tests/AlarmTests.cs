using Moq;
using NUnit.Framework;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercises.Tests
{
    [TestFixture]
    public class AlarmTests
    {
        private Mock<ISensor> sensor;
        private Alarm alarm;

        [SetUp]
        public void SetUp()
        {
            sensor = new Mock<ISensor>();
            alarm = new Alarm(sensor.Object);
        }

        [Test]
        [TestCase(16.0, true)]
        [TestCase(17, false)]
        [TestCase(22.1, true)]
        public void CheckPressure_GivenValues_AlarmResult(double value, bool expected)
        {
            // arrange
            sensor
                .Setup(s => s.PopNextPressurePsiValue())
                .Returns(value);

            // act
            alarm.Check();

            var result = alarm.AlarmOn;

            // assert
            Assert.AreEqual(alarm.AlarmOn, expected);
        }
    }
}
