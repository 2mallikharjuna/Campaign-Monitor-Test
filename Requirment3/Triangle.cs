using System;

namespace CampaignMonitorTest
{
    public class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new InvalidTriangleException($"Invalid inputs ; {side1} : {side2} : {side3} ");
            }

            // Length of sides must be positive and sum of any two sides
            // must be smaller than third side.
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new InvalidTriangleException("Any two sides needs to be grater than the other side");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        /// <summary>
        /// Calculate Area of triangle
        /// </summary>
        /// <returns></returns>
        public double getArea()
        {
            double p = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;
        }
    }
}
