using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblMenuPD
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> State { get; set; }
    }
}
