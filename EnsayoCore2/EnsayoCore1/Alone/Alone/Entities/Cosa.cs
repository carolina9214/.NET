﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alone.Entities
{
    public class Cosa
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }

        public List<CosaACosaB> CosaACosaB { get; set; }
    }
}
