//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RenatoSfera.DOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Show
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Show()
        {
            this.Mensagem = new HashSet<Mensagem>();
        }
    
        public int Id { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public System.DateTime horario { get; set; }
        public string local { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensagem> Mensagem { get; set; }
    }
}
