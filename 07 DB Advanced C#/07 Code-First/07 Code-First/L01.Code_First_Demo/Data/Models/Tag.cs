﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Code_First_Demo.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
