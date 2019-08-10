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
    public class Volume
    {
        double half13 = 0.3333333333333333;

        /// /////////////////////////////////////////////// ///
        ///             Core.VOLUME.Base ---Shapes           
        public Double Cube(double Length)
        {
            return Length * Length * Length;
        }

        public Double RectangleCube(double Length, double Width,double Height)
        {
            return Length * Width * Height;
        }

        public Double Cylinder(double radius, double height)
        {
            return 2 * radius * radius * height * 22 / 7;
        }

        public Double Sphere(double radius)
        {
            return 4/3 * (radius * radius * radius * 22 / 7);
        }

        public Double CircularCone(double radius, double height)
        {
            return half13 * (radius * radius * height * 22 / 7);
        }
        
        public Double Pyramid(double Length,double Width,double Height)
        {
            double recVol = Length * Width * Height;
            return  half13 * recVol;
        }
        /// /////////////////////////////////////////////// ///

    }
}
