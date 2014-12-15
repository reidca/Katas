using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class FrontWheelSteering : ISteering
    {
        private readonly TwoWheelAxle _axel;
      
        public FrontWheelSteering(TwoWheelAxle axel)
        {
            _axel = axel;
        }

        public void TurnLeft(int degrees)
        {
           _axel.TurnLeft(degrees);
           
        }

        public void TurnRight(int degrees)
        {
            _axel.TurnRight(degrees);
        }
    }
}
