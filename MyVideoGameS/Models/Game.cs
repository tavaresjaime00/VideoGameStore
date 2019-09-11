﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVideoGameS.Models
{
    public class Game
    {
        public virtual int Id { get; set; }
        public virtual int VideoGameNumber { get; set; }

        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String MinimumRequirements { get; set; }
        public virtual Decimal Price { get; set; }
        public virtual String Developer { get; set; }
    }
}
