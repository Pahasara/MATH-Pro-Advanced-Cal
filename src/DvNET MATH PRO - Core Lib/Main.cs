/*
 *
 * Copyright(c) 2019, 2023, M.P.Dewnith Fernando and/or its affiliates.All rights reserved.
 * M.P.Dewnith Fernando PROPRIETARY/CONFIDENTIAL.Use is subject to license terms.
 * 
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvNET.MATH.Core
{
    public class Main
    {
        public string GetVersion()
        {
            return "v1.5";
        }

        public string GetYear()
        {
            return "2023";
        }

        public string GetBuild()
        {
            return "2301";
        }

        public string InputTextError()
        {
            string error = "Enter valid values!";
            return error;
        }
        public string InputSubmitError()
        {
            string error = "Invalid calculation!";
            return error;
        }
    }
}
