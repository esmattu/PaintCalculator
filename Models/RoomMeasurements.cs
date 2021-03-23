using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaintCalculator.Models
{
    public class RoomMeasurements
    {
        [Display(Name = "Wall One")]
        [Range(1,100)]
        [Required]
        public int wallOne { get; set; }
        [Display(Name = "Wall Two")]
        [Range(1, 100)]
        [Required]
        public int wallTwo { get; set; }
        [Display(Name = "Wall Three")]
        [Range(1, 100)]
        [Required]
        public int wallThree { get; set; }
        [Display(Name = "Wall Four")]
        [Range(1, 100)]
        [Required]
        public int wallFour { get; set; }
        [Display(Name = "Room Height")]
        [Range(1, 100)]
        [Required]
        public int roomHeight { get; set; }
    }
}
