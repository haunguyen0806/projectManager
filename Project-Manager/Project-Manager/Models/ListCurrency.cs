using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListCurrency
    {
        public string Curr { get; set; }
        public string CurrName { get; set; }
        public bool? Enabled { get; set; }
    }
}
