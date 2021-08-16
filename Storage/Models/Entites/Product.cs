﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models.Entites
{
    public class Product
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Shelf { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
