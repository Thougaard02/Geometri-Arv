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
        //CalculateArea
        public RightAngelTriangle(double _sideA, double _sideB) : base(_sideA, _sideB)
        {
            SideB = _sideB;
        }
        //CalculatePerimeter
        public RightAngelTriangle(double _sideA, double _sideB, double _sideC) : base(_sideA, _sideB)
        {
            SideC = _sideC;
        }
        #endregion

        #region Methods

        public double GetHypotenuse()
        {
            return Math.Sqrt((SideA * SideA) + (SideB * SideB));
        }

        public override double CalculatePerimeter()
        {
            //Formula for perimeter of right angel triangel: O = a + b + c
            return SideA + SideB + sideC;
        }

        public override double CalculateArea()
        {
            //Formula for area of right angel triangel: A = 0.5 * a * b
            return 0.5 * (SideA * SideB);
        }
        #endregion

    }
}
