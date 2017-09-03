using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblMenuNew
    {
        public int idMenu { get; set; }
        public Nullable<int> idParent { get; set; }
        public string MenuName { get; set; }
        public string MenuNameURL { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string ImageLink { get; set; }
        public string ImageLinkRoot { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> UserID { get; set; }
    }
}
