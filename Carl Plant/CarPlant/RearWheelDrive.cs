using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public class RearWheelDrive : IDrive
    {
        private TwoWheelAxle _rearAxel;

        public RearWheelDrive(TwoWheelAxle rearAxel)
        {
            this._rearAxel = rearAxel;
        }

        public void Accelerate(int kmsPerHour)
        {
            _rearAxel.Accelerate(kmsPerHour);

        }
    }
}
