using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class FrontWheelDrive : IDrive
    {
        private TwoWheelAxle _frontAxle;

        public FrontWheelDrive(TwoWheelAxle frontAxle)
        {
            _frontAxle = frontAxle;
        }

        public void Accelerate(int kmsPerHour)
        {
            _frontAxle.Accelerate(kmsPerHour);
            
        }
    }
}
