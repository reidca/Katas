using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class TwoWheelAxle:ISteering, IDrive
    {
        private Wheel _Left;
        private Wheel _Right;

        public TwoWheelAxle(string leftWheelName, string rightWheelName)
        {
            _Left = new Wheel(leftWheelName);
            _Right = new Wheel(rightWheelName);
        }


        public void TurnLeft(int degrees)
        {
           _Left.turnLeft(degrees);
            _Right.turnLeft(degrees);
        }

        public void TurnRight(int degrees)
        {
            _Left.turnRight(degrees);
            _Right.turnRight(degrees);
        }

        public void Accelerate(int kmsPerHour)
        {
           _Left.rotate(kmsPerHour);
            _Right.rotate(kmsPerHour);
        }
    }
}
