using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HomeSlider
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string? Title { get; set; }

        [MaxLength(400)]
        public string? Description { get; set; }

        [MaxLength(600)]
        public string? URL { get; set; }

        [MaxLength(600)]
        public string? PhotoUrl { get; set; }
        public bool IsDeleted { get; set; }

        [MaxLength(200)]
        public string? TextPosition { get; set; }

	}
}
