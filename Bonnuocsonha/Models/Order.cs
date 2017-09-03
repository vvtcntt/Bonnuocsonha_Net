using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class Order
    {
        public int idOrder { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public Nullable<int> Tolar { get; set; }
        public Nullable<System.DateTime> DateByy { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> State { get; set; }
    }
}
