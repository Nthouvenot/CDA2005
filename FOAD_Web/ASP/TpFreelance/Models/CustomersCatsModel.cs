using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    [Table("customers_cats")]
    public class CustomerCatsModel
    {
        [Key]
        [Column("cats_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatId { get; set; }

        [Column("cat_name")]
        [Required]
        [MaxLength(50)]
        public string CatName { get; set; }

        [Column("cat_description")]
        [DataType(DataType.MultilineText)]
        public string CatDescription {get; set; }

        public ICollection<CustomerCatsModel> Customers { get; set; }
    }
}
