using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblAd
    {
        public int idAds { get; set; }
        public string HeadShort { get; set; }
        public string ImageName { get; set; }
        public string ImageLink { get; set; }
        public string ImageLinkRoot { get; set; }
        public string Url { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> idUser { get; set; }
    }
}
