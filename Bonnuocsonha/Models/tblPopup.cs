using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblPopup
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string HeadShort { get; set; }
        public string ImageName { get; set; }
        public string Imagelink { get; set; }
        public string ImageLinkRoot { get; set; }
        public string Url { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> State { get; set; }
    }
}
