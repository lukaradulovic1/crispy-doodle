﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voltron_assemble_interface
{
    public class VoltronLeftArm : IVoltronPart
    {
        public double Attack()
        {
            return 2;
        }

        public double Move()
        {
            return 0;
        }
    }
}
