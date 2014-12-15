using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPlant
{
    public interface ISteering
    {
        void TurnLeft(int degrees);
        void TurnRight(int degrees);
    }
}
