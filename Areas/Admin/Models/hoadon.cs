//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1460650_.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hoadon
    {
        public int MaDH { get; set; }
        public int TongTien { get; set; }
        public System.DateTime NgayGiao { get; set; }
    
        public virtual donhang donhang { get; set; }
    }
}