using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class OrderDetail
    {
        public int id { get; set; }
        public Nullable<int> idOrder { get; set; }
        public Nullable<int> idProduct { get; set; }
        public string NameProduct { get; set; }
        public Nullable<int> Quantily { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> State { get; set; }
    }
}
