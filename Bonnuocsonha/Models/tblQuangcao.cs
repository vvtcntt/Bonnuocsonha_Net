using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblQuangcao
    {
        public int id { get; set; }
        public Nullable<int> idMenu { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string ImageLink { get; set; }
        public string ImageLinkRoot { get; set; }
        public string Url { get; set; }
        public Nullable<int> State { get; set; }
    }
}
