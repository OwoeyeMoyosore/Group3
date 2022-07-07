﻿using System.ComponentModel.DataAnnotations;

namespace TourMaxAPI.DataModel
{
    public class TourImage
    {
        [Key]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string? Name { get; set; }
        public string? description { get; set; }
    }
}
