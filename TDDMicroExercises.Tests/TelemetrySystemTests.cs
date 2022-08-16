using NUnit.Framework;
using TDDMicroExercises.TelemetrySystem;

namespace TDDMicroExercises.Tests
{
    [TestFixture]
    public class TelemetrySystemTests
    {
        private TelemetryClient telemetry;

        [SetUp]
        public void SetUp()
        {
            telemetry = new TelemetryClient();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TelemetrySystem_Connect_ConnectionStringIsNullOrEmpty(string msg)
        {
            // act, assert
            Assert.That(() => telemetry.Connect(msg), Throws.ArgumentNullException);
        }

        [Test]
        public void TelemetrySystem_Connect_IsTrueOrFalse()
        {
            // act
            telemetry.Connect("connection string");
            var result = telemetry.OnlineStatus;

            // assert
            Assert.IsInstanceOf<bool>(result);
        }

        [Test]
        public void TelemetrySystem_Disconnect_ExpectedResult()
        {
            // act
            telemetry.Disconnect();
            var result = telemetry.OnlineStatus;

            // assert
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TelemetrySystem_SendMessage_IsNullOrEmpty(string msg)
        {
            // act, assert
            Assert.That(() => telemetry.Send(msg), Throws.ArgumentNullException);
        }

        [Test]
        public void TelemetrySystem_SendMessage_IsTrueOrFalse()
        {
            // act
            var result = telemetry.Send("message");

            // assert
            Assert.IsInstanceOf<bool>(result);
        }

        [Test]
        public void TelemetrySystem_Receive_IsNotNull()
        {
            // act
            var result = telemetry.Receive();

            // assert
            Assert.IsInstanceOf<string>(result);
            Assert.IsNotEmpty(result);
        }
    }
}
