//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SADIC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parents()
        {
            this.Child = new HashSet<Child>();
        }
    
        public int ID_Parent { get; set; }
        public string FIOMA { get; set; }
        public string TelMA { get; set; }
        public string FIOFAT { get; set; }
        public string TelFAT { get; set; }
        public string OtherTel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child> Child { get; set; }
    }
}
