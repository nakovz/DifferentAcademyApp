//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleGame
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agreement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agreement()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int AgreementId { get; set; }
        public int OfferId { get; set; }
        public Nullable<int> AgreementNumber { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Offer Offer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}