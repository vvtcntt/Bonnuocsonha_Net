using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblNPP
    {
        public int idNPP { get; set; }
        public Nullable<int> idDMNPP { get; set; }
        public string Name { get; set; }
        public string NameURL { get; set; }
        public string HeadShort { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string People { get; set; }
        public string Email { get; set; }
        public string Tags { get; set; }
        public Nullable<int> State { get; set; }
    }
}
