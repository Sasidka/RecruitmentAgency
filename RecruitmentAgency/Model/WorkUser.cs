//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecruitmentAgency.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkUser
    {
        public int ID { get; set; }
        public Nullable<int> WorkCode { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> TimeOfReceipt { get; set; }
    
        public virtual User User { get; set; }
        public virtual Work Work { get; set; }
    }
}
