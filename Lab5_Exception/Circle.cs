using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Exception
{
    internal class Circle
    {
        private double radius;

        public void SetRadius(double radius)
        {

            if (radius > 0)
            {
                this.radius = radius;
                throw new InvalidRadiusException();
            }
            else { throw new InvalidRadiusException(radius.ToString()); }

        }
        public Circle(double radius)
        {
            SetRadius(radius);
        }

        public override string ToString()
        {
            return radius.ToString();
        }
    }
}
