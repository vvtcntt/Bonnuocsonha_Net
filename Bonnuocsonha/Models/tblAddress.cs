using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblAddress
    {
        public int id { get; set; }
        public Nullable<int> idProduct { get; set; }
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
    }
}
