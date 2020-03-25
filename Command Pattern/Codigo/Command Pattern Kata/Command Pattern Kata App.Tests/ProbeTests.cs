using Command_Pattern_Kata_App.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Command_Pattern_Kata_App.Tests
{
    [TestClass]
    public class ProbeTests
    {
        [TestMethod]
        public void _0_MoveCommand_Should_Move_Unit()
        {
            var unit = new Probe();
            var moveCommand = new MoveCommand(unit, 7, 9);

            moveCommand.Execute();

            var expected = new Point { X = 7, Y = 9 };

            Assert.AreEqual(expected.X, unit.Position.X);
            Assert.AreEqual(expected.Y, unit.Position.Y);
        }

        [TestMethod]
        public void _1_GatherCommand_Should_Gather_Resources()
        {
            var unit = new Probe();
            var gatherCommand = new GatherCommand(unit);

            gatherCommand.Execute();

            Assert.AreEqual(5, unit.Minerals);
        }
    }
}
