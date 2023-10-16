namespace MySoft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategoria")]
    public partial class Kategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdKategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string TitulliKategoris { get; set; }
    }
}
