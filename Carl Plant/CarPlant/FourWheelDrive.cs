using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class FourWheelDrive : IDrive
    {

        private TwoWheelAxle _frontAxel;
        private TwoWheelAxle _rearAxel;
        public FourWheelDrive(TwoWheelAxle frontAxel, TwoWheelAxle rearAxel)
        {
            _frontAxel = frontAxel;
            _rearAxel = rearAxel;
        }

        public void Accelerate(int kmsPerHour)
        {
            _frontAxel.Accelerate(kmsPerHour);

            _rearAxel.Accelerate(kmsPerHour);


        }
    }
}
