using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    [Table("customers")]
    public class CustomersModel
    {
        [Key]
        [Column("customer_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Column("customer_name")]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Column("customer_email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(255)]
        public string CustomerEmail { get; set; }

        [ForeignKey("FK_customers_cats")]
        [Column("cat_id")]
        [Required]
        public int CatId { get; set; }
        public CustomerCatsModel CustomersCats { get; set; }

        public ICollection<JobsModel> JobsModels { get; set; }
    }
}