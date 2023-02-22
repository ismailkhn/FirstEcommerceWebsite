﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Collection
    {
        public int Id { get; set; }
        
        
        [MaxLength(400)]
        public string Name { get; set; }

        [MaxLength(400)]
        public string PhotoUrl { get; set; }

        public bool IsFeatured { get; set; }


    }
}
