﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Bio { get; set; }
        public DateTime DOB { get; set; }
    }
}