﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class webbandienthoaiEntities2 : DbContext
    {
        public webbandienthoaiEntities2()
            : base("name=webbandienthoaiEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ctdonhang> ctdonhangs { get; set; }
        public virtual DbSet<donhang> donhangs { get; set; }
        public virtual DbSet<giohang> giohangs { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<loaisp> loaisps { get; set; }
        public virtual DbSet<nhasx> nhasxes { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<taikhoan> taikhoans { get; set; }
    }
}
