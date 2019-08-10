/*
 *
 * Copyright(c) 2019, M.P.Dewnith Fernando and/or its affiliates.All rights reserved.
 * M.P.Dewnith Fernando PROPRIETARY/CONFIDENTIAL.Use is subject to license terms.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvNET.MATH.Core
{
    public class Area
    {
        double pi = 22 / 7;
        /// /////////////////////////////////////////////// ///
        ///             Core.AREA.Basic-Shapes           
        public Double Square(double Length)
        {
            return Length * Length;
        }

        public Double Rectangle(double Length, double Width)
        {
            return Length * Width;
        }

        public Double Triangle(double height, double aid)
        {
            return height * aid * 0.5;
        }

        public Double Trapezoid(double a1, double a2, double height)
        {
            return (a1 + a2) / 2 * height;
        }

        public Double Circle(double radius)
        {
            return radius * radius * 22 / 7;
        }

        public Double Ellipse(double a1, double b1)
        {
            return a1 * b1 * 22 / 7;
        }

        /// /////////////////////////////////////////////// ///

        
        /// /////////////////////////////////////////////// ///
        ///           Core.AREA.Advanced-Shapes           
        public Double Cube(double Length)
        {
            return Length * Length * 6;
        }

        public Double RectangleCube(double Length, double Width, double Height)
        {
            return Length * Width * 2 + Height * Width * 2 + Height * Length * 2;
        }

        public Double Pythagorean(double Aid, double Height)
        {
            double LL = Aid*Aid + Height*Height;
            return Math.Sqrt(LL);
        }

        public Double CircularCone(double radius, double Height)
        {
            double l = Pythagorean(radius,Height);
            double Pirl = radius * l * 22 / 7;
            double Pi2R = pi * radius * radius;
            return Pirl + Pi2R;
        }

        public Double Cylinder(double Radius, double Height)
        {
            double Pi2R = 2 * (pi * Radius * Radius);
            double R2PiH = 2 * pi * Radius * Height;
            return Pi2R + R2PiH;
        }

        /// /////////////////////////////////////////////// ///
    }
}
