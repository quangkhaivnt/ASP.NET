namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipment")]
    public partial class Shipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string sender { get; set; }

        public int? shipperId { get; set; }

        public DateTime? dateTranfer { get; set; }

        public DateTime? completeDate { get; set; }

        public int? statusShipmentId { get; set; }

        public virtual Shipper Shipper { get; set; }

        public virtual StatusShipment StatusShipment { get; set; }
    }
}
