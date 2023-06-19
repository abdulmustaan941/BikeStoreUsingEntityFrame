namespace BikeStoreUsingEntityFrame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public store()
        {
            orders = new HashSet<order>();
            staffs = new HashSet<staff>();
            stocks = new HashSet<stock>();
        }

        [Key]
        public int store_id { get; set; }

        [Required]
        [StringLength(200)]
        public string store_name { get; set; }

        [StringLength(13)]
        public string phone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(300)]
        public string street { get; set; }

        [StringLength(300)]
        public string city { get; set; }

        [StringLength(300)]
        public string state { get; set; }

        [StringLength(6)]
        public string zip_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staff> staffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stock> stocks { get; set; }
    }
}
