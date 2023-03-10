﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolWebApp.Data.Models;

namespace SchoolWebApp.Data.interfaces
{
    interface IClass
    {
        IEnumerable<Class> AllClasses { get; }
        Class getObjectClass(int ClassId);

    }
}
