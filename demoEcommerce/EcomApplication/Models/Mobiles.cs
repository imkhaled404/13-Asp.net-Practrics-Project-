﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EcomApplication.Models
{
    public class Mobiles
    {
        public int SLNo
        {
            get;
            set;
        }
        [DisplayName("Mobile Name")]
        public string MobileName
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        [DisplayName("Upload File")]
        public string PicURL
        {
            get;
            set;
        }
        [DisplayName("Mobile Model")]
        public string Model
        {
            get;
            set;
        }
        public string Features
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        [DisplayName("Sim Type")]
        public string SimType
        {
            get;
            set;
        }

        public IFormFile ImageFile { get; set; }

        public string ErrorMessage { get; set; }
    }
}
