﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}
