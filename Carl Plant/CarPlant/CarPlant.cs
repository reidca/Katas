namespace CarPlant {
	public class CarPlant
	{
		public static string LOG;

		public static Car makeToyotaCorolla()
		{
            TwoWheelAxle frontWheels = new TwoWheelAxle("front left", "front right");
            ISteering steering = new FrontWheelSteering(frontWheels);
            IDrive drive = new FrontWheelDrive(frontWheels);
            Car car = new Car("Toyota Corolla", steering, drive);

            return car;
		}

		public static Car makeToyotaCorollaSports()
		{
            TwoWheelAxle frontWheels = new TwoWheelAxle("front left","front right");
            TwoWheelAxle rearWheels = new TwoWheelAxle("rear left", "rear right");
		    ISteering steering = new FrontWheelSteering(frontWheels);
            IDrive drive = new RearWheelDrive(rearWheels);
            Car car = new Car("Toyota Corolla sports",steering, drive);

		    return car;
		}

		public static Car makeMitsubishiTriton()
		{
            TwoWheelAxle frontWheels = new TwoWheelAxle("front left", "front right");
            TwoWheelAxle rearWheels = new TwoWheelAxle("rear left", "rear right");
            ISteering steering = new FrontWheelSteering(frontWheels);
            IDrive drive = new FourWheelDrive(frontWheels, rearWheels);
            Car car = new Car("Mitsubishi Triton", steering, drive);
            return car;
		}

		public static Car makeSandBuggy()
		{
            TwoWheelAxle frontAxel = new TwoWheelAxle("front left", "front right");
            TwoWheelAxle rearAxel = new TwoWheelAxle("rear left", "rear right");
            ISteering steering = new FourWheelSteering(frontAxel, rearAxel);
            IDrive drive = new FourWheelDrive(frontAxel,rearAxel);
            Car car = new Car("Sand Buggy", steering, drive);

            return car;
		}

		public static Car makeSandBuggyLite()
		{
		    TwoWheelAxle frontAxel = new TwoWheelAxle("front left","front right");
            TwoWheelAxle rearAxel = new TwoWheelAxle("rear left","rear right");
		    ISteering steering = new FourWheelSteering(frontAxel, rearAxel);
		    IDrive drive = new RearWheelDrive(rearAxel);
		    Car car = new Car("Sand Buggy Lite",steering, drive);

		    return car;
		}
	}

    



    
}