﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empare.Contracts;

namespace Empare.Models
{
    class Resourse : IResourse
    {
        public int Quantity { get; set; }
        public string Type { get; set; }
    }
}
