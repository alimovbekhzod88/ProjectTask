using System;
using CsvHelper.Configuration.Attributes;

namespace ProjectTest.Models
{
	public class Employee
	{
        [Index(0)]
        public string Payroll_Number { get; set; } = "";
        [Index(1)]
        public string Forenames { get; set; } = "";
        [Index(2)]
        public string Surname { get; set; } = "";
        [Index(3)]
        public string Date_Of_Birth { get; set; } = "";
        [Index(4)]
        public string Telephone { get; set; } = "";
        [Index(5)]
        public string Mobile { get; set; } = "";
        [Index(6)]
        public string Address_Name { get; set; } = "";
        [Index(7)]
        public string Address_2 { get; set; } = "";
        [Index(8)]
        public string Postcode { get; set; } = "";
        [Index(9)]
        public string Email_Home { get; set; } = "";
        [Index(10)]
        public string Start_Date { get; set; } = "";
    }
}

