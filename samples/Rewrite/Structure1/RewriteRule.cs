﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rewrite
{
    public abstract class RewriteRule : Rule
    {
        public bool StopApplyingRulesOnSuccess { get; set; }

    }
}