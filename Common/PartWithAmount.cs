﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarsztatAPI.Entities;

namespace WarsztatAPI.Common
{
    public class PartWithAmount
    {
        public Meal Part { get; set; }
        public int Amount { get; set; }
    }
}
