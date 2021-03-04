using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    public class Square : Shape
    {
        #region Constructor

        //Square
        public Square(double _sideA) : base(_sideA)
        {
            SideA = _sideA;
        }
        #endregion

        #region Method
        public override double CalculatePerimeter()
        {
            //Formula for perimeter: O = 4 *a
            return (4 * SideA);
        }

        public override double CalculateArea()
        {
            //Formula for Area: A = a * aæ
            return (SideA * SideA);
        }
        #endregion
    }
}
