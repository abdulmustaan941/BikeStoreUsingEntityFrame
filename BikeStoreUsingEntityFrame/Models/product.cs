namespace BikeStoreUsingEntityFrame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            order_items = new HashSet<order_items>();
            stocks = new HashSet<stock>();
        }

        [Key]
        public int product_id { get; set; }

        [Required]
        [StringLength(100)]
        public string product_name { get; set; }

        public int brand_id { get; set; }

        public int category_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? model_year { get; set; }

        [Column(TypeName = "numeric")]
        public decimal list_price { get; set; }

        public virtual brand brand { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_items> order_items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stock> stocks { get; set; }
    }
}
