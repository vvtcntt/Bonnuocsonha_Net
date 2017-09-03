using System;
using System.Collections.Generic;

namespace Bonnuocsonha.Models
{
    public partial class tblCommentNew
    {
        public int id { get; set; }
        public Nullable<int> idNew { get; set; }
        public string NameNew { get; set; }
        public string Name { get; set; }
        public Nullable<int> Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
    }
}
