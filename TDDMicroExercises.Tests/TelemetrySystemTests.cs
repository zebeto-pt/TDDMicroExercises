using NUnit.Framework;
using TDDMicroExercises.TelemetrySystem;

namespace TDDMicroExercises.Tests
{
    [TestFixture]
    public class TelemetrySystemTests
    {
        [Test]
        public void TelemetrySystem_Scenario_ExpectedResult()
        {
            // arrange


            // act


            // assert

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TelemetrySystem_Connect_ConnectionStringIsNullOrEmpty(string msg)
        {
            // arrange
            var telemetry = new TelemetryClient();

            // act, assert
            Assert.That(() => telemetry.Connect(msg), Throws.ArgumentNullException);
        }

        [Test]
        public void TelemetrySystem_Connect_IsTrueOrFalse()
        {
            // arrange
            var telemetry = new TelemetryClient();

            // act
            telemetry.Connect("connection string");
            var result = telemetry.OnlineStatus;

            // assert
            Assert.IsInstanceOf<bool>(result);
        }

        [Test]
        public void TelemetrySystem_Disconnect_ExpectedResult()
        {
            // arrange
            var telemetry = new TelemetryClient();

            // act
            telemetry.Disconnect();
            var result = telemetry.OnlineStatus;

            // assert
            Assert.IsFalse(result);
        }
    }
}
