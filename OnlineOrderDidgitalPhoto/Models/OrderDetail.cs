namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? orderId { get; set; }

        public int? productId { get; set; }

        public int? amount { get; set; }

        public int? payment_method_id { get; set; }

        public int? shipperId { get; set; }

        public DateTime? createdAt { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Shipper Shipper { get; set; }
    }
}
