//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONGBAO
    {
        public string MaTB { get; set; }
        public string Mota { get; set; }
        public Nullable<System.DateTime> NgayNhan { get; set; }
        public string MaKH { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
