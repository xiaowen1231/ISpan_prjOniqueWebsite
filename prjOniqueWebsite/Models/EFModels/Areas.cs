﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjOniqueWebsite.Models.EFModels
{
    public partial class Areas
    {
        public Areas()
        {
            Employees = new HashSet<Employees>();
            Members = new HashSet<Members>();
        }

        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int CityId { get; set; }

        public virtual Citys City { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Members> Members { get; set; }
    }
}