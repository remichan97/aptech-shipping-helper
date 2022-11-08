﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class Cities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Users> Users { get; set; } = new List<Users>();
    }
}
