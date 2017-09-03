using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblHoiDap
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tieude { get; set; }
        public string Noidung { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> State { get; set; }
    }
}
