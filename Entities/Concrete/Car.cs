﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }  //marka
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DaliyPrice { get; set; }  //günlük fiyat
        public string Description { get; set; } //tanım
    }
}
