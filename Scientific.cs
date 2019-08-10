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
    public class Scientific
    {
        public Double Speed(double Distance, double Time)
        {
            return Distance / Time;
        }
        public Double Velocity(double Extended, double Time)
        {
            return Extended / Time;
        }
        public Double Acceleration(double Velocity, double Time)
        {
            return Velocity / Time;
        }
        public Double Power(double Energy, double Time)
        {
            return Energy / Time;
        }
        public Double Mass(double Force, double Gravity)
        {
            return Force / Gravity;
        }
        public Double Distance(double Speed, double Time)
        {
            return Speed * Time;
        }

        public Double Energy(double Mass, double Velocity)
        {
            return 0.5 * Mass * Velocity * Velocity;
        }
        public Double Force(double Mass, double Gravity)
        {
            return Mass * Gravity;
        }

    }
}
