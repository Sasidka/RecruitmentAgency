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
    
    public partial class Passport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passport()
        {
            this.User = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public int Seria { get; set; }
        public int Number { get; set; }
        public int DepartmentCode { get; set; }
        public System.DateTime DateOfIssue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}