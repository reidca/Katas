using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarPlant
{
	[TestClass]
	public class SandBuggyTest
	{
		private Car buggy;

		[TestInitialize]
		public void Init()
		{
			CarPlant.LOG = "";
			buggy = CarPlant.makeSandBuggy();
		}

		[TestMethod]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Sand Buggy", buggy.Name());
		}

		[TestMethod]
		public void TurningLeftTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n"
			             + "rear left turning left " + degrees + " degrees\n"
			             + "rear right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[TestMethod]
		public void TurningRightTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n"
			             + "rear left turning right " + degrees + " degrees\n"
			             + "rear right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[TestMethod]
		public void AcceleratingTurnsAllWheels()
		{
			int speed = TestHelpers.randomSpeed();
			buggy.Accelerate(speed);
			Assert.AreEqual("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

