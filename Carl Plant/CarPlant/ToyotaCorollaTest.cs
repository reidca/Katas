using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarPlant
{
	[TestClass]
	public class ToyotaCorollaTest
	{

		private Car corolla;

		[TestInitialize]
		public void Init()
		{
			CarPlant.LOG = "";
			corolla = CarPlant.makeToyotaCorolla();
		}

		[TestMethod]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Toyota Corolla", corolla.Name());
		}

		[TestMethod]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			              + "front right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[TestMethod]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			              + "front right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[TestMethod]
		public void AcceleratingOnlyTurnsTheFrontWheels()
		{
			int speed = TestHelpers.randomSpeed();
			corolla.Accelerate(speed);
			Assert.AreEqual("front left accelerating " + speed + " kph\n"
			              + "front right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}

}
