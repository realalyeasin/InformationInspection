﻿using System.ComponentModel.DataAnnotations;

namespace InformationInspection
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusOption { get; set; }
    }
}
