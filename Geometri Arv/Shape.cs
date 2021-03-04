using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    public class Shape
    {
        #region Properties

        private double sideA;

        protected double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        private double sideB;

        protected double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        #endregion

        #region Constructor
        //Used to square
        public Shape(double _sideA)
        {
            SideA = _sideA;
        }

        //Used to Parallelogram, Trapez, and Right angel triangel
        public Shape(double _sideA, double _sideB)
        {
            SideA = _sideA;
            SideB = _sideB;
        }
        #endregion

        #region Method
        public virtual double CalculatePerimeter()
        {
            //Formula for perimeter: O = 4 *a
            return (4 * SideA);
        }

        public virtual double CalculateArea()
        {
            //Formula for Area: A = a * a
            return (SideA * SideA);
        }
        #endregion
    }
}
