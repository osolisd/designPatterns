using NUnit.Framework;
using State_Pattern_Kata_App.Context;
using State_Pattern_Kata_App.States;

namespace StatePatternKataAppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TankState_InitialValesOk()
        {
            Tank tank = new Tank();

            Assert.AreEqual(5, tank.Damage);
            Assert.IsTrue(tank.CanMove);
        }

        [Test]
        public void SiegeState_ValesOk()
        {
            Tank tank = new Tank();
            tank.SetState(new SiegeState(tank));
            tank.NoMove();
            

            Assert.AreEqual(20, tank.Damage);
            Assert.IsFalse(tank.CanMove);
        }

        [Test]
        public void TankState_ValesOk()
        {
            Tank tank = new Tank();
            tank.SetState(new SiegeState(tank));
            tank.NoMove();

            tank.SetState(new TankState(tank));
            tank.Move();

            Assert.AreEqual(5, tank.Damage);
            Assert.IsTrue(tank.CanMove);
        }
    }
}