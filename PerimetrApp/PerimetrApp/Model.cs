﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    class Model : IModel
    {
        public int GetP(int a, int b) => (a + b) * 2;
    }
}
