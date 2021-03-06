﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Genre
    {
        public byte Id{ get; set; }

        [Required, StringLength(50)]
        public string Libelle { get; set; }

        public static readonly byte Unknown = 0;
    }
}