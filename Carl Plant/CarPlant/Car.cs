using System;
using System.Runtime.InteropServices;

namespace CarPlant
{
	public  class Car
	{
	    protected ISteering _steering;
	    protected IDrive _drive;
	    private string _name;

	    public string Name()
	    {
	        return _name;
	    }

	    public virtual void Accelerate(int kmsPerHour)
	    {
            _drive.Accelerate(kmsPerHour);
	    }

	    public Car(string name, ISteering steering, IDrive drive)
		{
            _name = name;
		    _steering = steering;
            _drive = drive;
		}

		public virtual void TurnLeft(int degrees)
		{
			_steering.TurnLeft(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			_steering.TurnRight(degrees);
		}
	}
}