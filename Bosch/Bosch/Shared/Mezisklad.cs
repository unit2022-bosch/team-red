﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    class Mezisklad
    {
        public int Id { get; set; }
        public List<Vlacek> seznamVlacku { get; set; }
        public JizdniRad jizdniRad { get; set; } //prijezdy vlaku
    }
}
