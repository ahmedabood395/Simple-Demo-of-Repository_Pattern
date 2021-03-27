namespace Repository_Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? Age { get; set; }

        public int? Salary { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
    }
}
