using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class FourWheelSteering : ISteering
    {
        private TwoWheelAxle _frontAxel;
        private TwoWheelAxle _rearAxel;

        public FourWheelSteering(TwoWheelAxle frontAxel, TwoWheelAxle rearAxel)
        {
            _frontAxel = frontAxel;
            _rearAxel = rearAxel;

        }

        public void TurnLeft(int degrees)
        {
            _frontAxel.TurnLeft(degrees);
            _rearAxel.TurnLeft(degrees);

        }

        public void TurnRight(int degrees)
        {
            _frontAxel.TurnRight(degrees);
            _rearAxel.TurnRight(degrees);
        }
    }
}
