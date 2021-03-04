using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    class Rectangel : Shape
    {

        #region Constructor
        public Rectangel(double _sideA, double _sideB) : base(_sideA, _sideB)
        {
        }
        #endregion

        #region Methodes

        public override double CalculateArea()
        {
            return SideA * SideB;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (SideA + SideB);
        }
        #endregion
    }
}
