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
    
    public partial class donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public donhang()
        {
            this.ctdonhangs = new HashSet<ctdonhang>();
        }
    
        public int ID { get; set; }
        public string MaKH { get; set; }
        public System.DateTime NgayDat { get; set; }
        public int TinhTrang { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ctdonhang> ctdonhangs { get; set; }
        public virtual taikhoan taikhoan { get; set; }
        public virtual hoadon hoadon { get; set; }
    }
}
