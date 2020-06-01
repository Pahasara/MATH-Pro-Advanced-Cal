/*
 *
 * Copyright(c) 2019, 2020, M.P.Dewnith Fernando and/or its affiliates.All rights reserved.
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
            return "v1.3";
        }

        public string GetYear()
        {
            return "2020";
        }

        public string GetBuild()
        {
            return "2005";
        }

        public string InputTextError()
        {
            string error = "Error : Please enter only the valid values!";
            return error;
        }
        public string InputSubmitError()
        {
            string error = "Error : Please enter the valid values, before calculation....";
            return error;
        }
    }
}
