//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam_Ermoshin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zayavka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zayavka()
        {
            this.UserZayavka = new HashSet<UserZayavka>();
            this.ZayavkaRabotniki = new HashSet<ZayavkaRabotniki>();
            this.ZayavkaRashodniki = new HashSet<ZayavkaRashodniki>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateViezda { get; set; }
        public int ZakazkhikId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserZayavka> UserZayavka { get; set; }
        public virtual Zakazkhik Zakazkhik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZayavkaRabotniki> ZayavkaRabotniki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZayavkaRashodniki> ZayavkaRashodniki { get; set; }
    }
}
