﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLQBFanSite.Models
{
    public class Review
    {
        public string ReviewText { get; set; }
        public User Reviewer { get; set; }
    }
}
