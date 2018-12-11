namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(30)]
        public string password { get; set; }

        public int? roleId { get; set; }

        public int? addressId { get; set; }

        public int? genderId { get; set; }

        public DateTime? birthday { get; set; }

        public int? statusId { get; set; }

        public virtual Address Address { get; set; }

        public virtual GenderCustomer GenderCustomer { get; set; }

        public virtual Role Role { get; set; }

        public virtual StatusCustomer StatusCustomer { get; set; }
    }
}
