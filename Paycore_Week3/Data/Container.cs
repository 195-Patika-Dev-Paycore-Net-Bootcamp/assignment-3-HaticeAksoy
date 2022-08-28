﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycore_Week3
{
    public class Container
    {
        public virtual long Id { get; set; }
        public virtual string ContainerName { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude{ get; set; }
        public virtual long VehicleId { get; set; }
    }
}
