using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblPage
    {
        public int id { get; set; }
        public Nullable<int> idRight { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
