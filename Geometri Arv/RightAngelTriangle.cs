using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    public class RightAngelTriangle : Shape
    {
        #region Propterties
        private double sideC;

        protected double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        #endregion

        #region Constructor
        public RightAngelTriangle(double _sideA, double _sideB) : base(_sideA, _sideB)
        {
            //Calculate hypotenuse
            SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }
        #endregion

        #region Methods
        public override double CalculatePerimeter()
        {
            //Formula for perimeter of right angel triangel: O = a + b + c
            return SideA + SideB + SideC;
        }

        public override double CalculateArea()
        {
            //Formula for area of right angel triangel: A = 0.5 * a * b
            return 0.5 * (SideA * SideB);
        }
        #endregion

    }
}
