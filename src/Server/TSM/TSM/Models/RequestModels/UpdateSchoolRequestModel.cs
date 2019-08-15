﻿using System;
using System.ComponentModel.DataAnnotations;
using TSM.Common.Enums;

namespace TSM.Models.RequestModels
{
    public class UpdateSchoolRequestModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public string Website { get; set; }

        public string CoverUrl { get; set; }

        public int StudentCount { get; set; }

        public long TuiTion { get; set; }

        public string Description { get; set; }

        public SchoolType SchoolType { get; set; }

        public LocationRequestModel Location { get; set; }
    }
}
