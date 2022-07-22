/*
 *
 * Copyright(c) 2019, 2020, M.P.Dewnith Fernando and/or its affiliates.All rights reserved.
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
        double Pi = 22 / 7;

        public Double Speed(double Distance, double Time)
        {
            return Distance / Time;
        }
        public Double Velocity(double Extended, double Time)
        {
            return Extended / Time;
        }
        public Double Acceleration(double U,double V, double Time)
        {
            return (V-U) / Time;
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

        public Double Energy(double Force, double Distance)
        {
            return Force * Distance;
        }
        public Double Force(double Mass, double Gravity)
        {
            return Mass * Gravity;
        }

        public Double RForce(double P, double Q, double T)
        {
            T = T * Pi / 180;
            double R = Math.Sqrt((P * P) + (Q * Q) + (2 * P * Q * Math.Cos(T)));
            return R;
        }

        public Double LinearKineticEnergy(double Mass,double Velocity)
        {
            double Energy = 0.5 * Mass * Velocity * Velocity;
            return Energy;
        }

        public Double GravPotentialEnergy(double Mass, double Gravity, double Height)
        {
            double Energy = Mass * Gravity * Height;
            return Energy;
        }

        public Double AngularV(double Frequency)
        {
            return 2 * Pi * Frequency;
        }

        public Double Frequency(double Rounds, double Time)
        {
            return Rounds / Time;
        }
    }
}
