namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commune")]
    public partial class Commune
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? communeId { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public virtual Address Address { get; set; }
    }
}
