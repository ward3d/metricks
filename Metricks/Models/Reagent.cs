﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Metricks.Models
{
    public class Reagent
    {
        [Display(Name = "Reagent name")]
        public string Name { get; set; }

        [Display(Name = "Reagent mass")]
        public double Mass { get; set; }

        [Display(Name = "Reactant")]
        public bool IsReactant { get; set; }

        [Display(Name = "Benign")]
        public bool IsBenign { get; set; }
    }
}