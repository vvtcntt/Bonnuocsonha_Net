using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class Support
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Yahoo { get; set; }
        public string Skyper { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
    }
}
