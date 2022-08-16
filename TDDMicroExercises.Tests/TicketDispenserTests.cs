using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.TurnTicketDispenser;

namespace TDDMicroExercises.Tests
{
    [TestFixture]
    class TicketDispenserTests
    {
        [Test]
        public void TicketDispenser_GetOneTicket_ReturnNextNumber()
        {
            // arrange
            var ticket = new TicketDispenser();

            // act
            var number = ticket.GetTurnTicket();
            var result = number.TurnNumber;

            // assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void TicketDispenser_GetTwoTickets_ReturnAGreaterNumber()
        {
            // arrange
            var ticket = new TicketDispenser();

            // act
            var fisrt_number = ticket.GetTurnTicket();
            var first_result = fisrt_number.TurnNumber;
            var second_number = ticket.GetTurnTicket();
            var second_result = second_number.TurnNumber;

            // assert
            Assert.Greater(second_result, first_result);
        }
    }
}
