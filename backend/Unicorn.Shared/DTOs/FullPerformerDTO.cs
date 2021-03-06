﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.Shared.DTOs
{
    public class FullPerformerDTO
    {
        public long Id { get; set; }

        public double Rating { get; set; }

        public int ReviewsCount { get; set; }

        public string Name { get; set; }

        public string Avatar { get; set; }

        public string PerformerType { get; set; } //vendor or company

        public string Link { get; set; }

        public LocationDTO Location { get; set; }

        public double Distance { get; set; }

        public string Description { get; set; }
    }
}
