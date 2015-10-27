﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoContest.Web.Models.BindingModel
{
    public class ImageBindingModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Base64Data { get; set; }

        [Required]
        public int ContestId { get; set; }
    }
}