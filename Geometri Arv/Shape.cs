using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    public abstract class Shape
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
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
        #endregion
    }
}
