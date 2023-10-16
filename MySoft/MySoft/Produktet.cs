namespace MySoft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produktet")]
    public partial class Produktet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Emri { get; set; }

        public double CmimiMeTVSH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataEProdhimit { get; set; }

        [StringLength(50)]
        public string Pershkrimi { get; set; }

        public int KategoriaId { get; set; }

        public int? Vendor { get; set; }

        public int? JoVendor { get; set; }
    }
}
