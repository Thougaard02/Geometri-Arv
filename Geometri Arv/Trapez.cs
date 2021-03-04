using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    class Trapez : Shape
    {
        #region Properties
        private double sideC;

        protected double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        private double sideD;

        protected double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }
        #endregion

        #region Constructor
        //Inheritance sideA from square
        public Trapez(double _sideA, double _sideB, double _sideC, double _sideD) : base(_sideA, _sideB)
        {
            SideC = _sideC;
            SideD = _sideD;
        }
        #endregion

        #region Methods
        public double GetHeight()
        {
            //Calculate s
            //Formula for s: s = (a + b - c + d) / 2
            double s = (SideA + SideB - SideC + SideD) / 2;
            //Returns the height of the trapez
            //Formula for height: h = (2 / (a - c)) * Sqrt(s * (s - a + c) * (s - b) * (s - d)))
            return (2 / (SideA - SideC)) * (Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD)));
        }

        public override double CalculateArea()
        {
            //Formula for area: A = 0.5 * (a + c) * h
            return 0.5 * (SideA + SideC) * GetHeight();
        }
        public override double CalculatePerimeter()
        {
            //Formula for perimeter: O = a + b + c + d
            return SideA + SideB + sideC + sideD;
        }
        #endregion
    }
}
