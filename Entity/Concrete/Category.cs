﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public Int16 CategoryId { get; set; }//birincil anahtar
        public string CategoryName { get; set; }
        
    }
}
