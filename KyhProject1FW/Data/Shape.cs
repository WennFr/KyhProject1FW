﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyhProject1FW.Interfaces;

namespace KyhProject1FW.Data
{
    public class Shape : IShape
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TypeOfShape { get; set; }
        public DateTime CreatedDate { get; set; }

        public enum shape
        {
            Rectangle,
            Paralellogram,
            Triangle,
            Rhombus
        }


    }
}
