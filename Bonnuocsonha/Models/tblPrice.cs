using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblPrice
    {
        public int id { get; set; }
        public Nullable<int> idDMNPP { get; set; }
        public Nullable<int> idProduct { get; set; }
        public Nullable<double> Price { get; set; }
    }
}
