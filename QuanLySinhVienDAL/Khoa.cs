//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVienWCF
{
    namespace QuanLySinhVienDAL
    {
        using System;
        using System.Collections.Generic;

        public partial class Khoa
        {
            public Khoa()
            {
                this.Sinhviens = new HashSet<Sinhvien>();
            }

            public string Makhoa { get; set; }
            public string Tenkhoa { get; set; }

            public virtual ICollection<Sinhvien> Sinhviens { get; set; }
        }
    }
}
