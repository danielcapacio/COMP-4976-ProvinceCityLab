using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP4976ProvinceCityLab.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }
    }
}