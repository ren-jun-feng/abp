﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Identity
{
    public class ChangePasswordInput
    {
        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
