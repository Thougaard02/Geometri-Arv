using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    class Parallelogram : Shape
    {
        #region Properties
        private double angel;
        protected double Angel
        {
            get { return angel; }
            set { angel = value; }
        }
        #endregion

        #region Constructor
        //Inheritance sideA from square
        public Parallelogram(double _sideA, double _sideB, double _angel) : base(_sideA, _sideB)
        {
            Angel = _angel;
        }
        #endregion

        #region Methods
        //Overides method in sqaure. Using proptery from square (SideA)
        public override double CalculateArea()
        {
            //Fomula for area of parallelogram 𝐴 = 𝑎 × 𝑏 × 𝑠in(𝜃)
            return SideA * SideB * Math.Sin(angel * Math.PI / 180);
        }

        //If you want to calculate perimeter add formula to the methods
        public override double CalculatePerimeter()
        {
            return SideB;
        }
        #endregion
    }
}
