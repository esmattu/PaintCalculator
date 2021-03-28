using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * This class will store the wall height and width
 */

namespace PaintCalculator.Models
{
    public class WallMeasurement
    {
        [Display(Name = "Wall Height")]
        [Range(1,100)]
        [Required]
        public int WallHeight { get; set; }
        [Display(Name = "Wall Width")]
        [Range(1, 100)]
        [Required]
        public int WallWidth { get; set; }

    }
}
