using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblMenuNPP
    {
        public int idDMNPP { get; set; }
        public string Name { get; set; }
        public string NameURL { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> idUser { get; set; }
    }
}
