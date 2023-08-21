﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjOniqueWebsite.Models.EFModels
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public int Citys { get; set; }
        public int Areas { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Position { get; set; }
        public string VerificationCode { get; set; }
        public bool? Verification { get; set; }
        public string PhotoPath { get; set; }
        public DateTime RegisterDate { get; set; }

        public virtual Areas AreasNavigation { get; set; }
        public virtual Citys CitysNavigation { get; set; }
        public virtual EmployeeLevel PositionNavigation { get; set; }
    }
}