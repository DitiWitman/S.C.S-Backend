﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DataObject
{
    public class Rentals
    {
        public int Id { get; set; }
        public int CarId {  get; set; }
        public int UserId { get; set; } 
        public CarStatus CarStatus { get; set; }
        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; } 

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
