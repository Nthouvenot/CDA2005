using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    [Table("customers_cats")]
    public class CustomersCats
    {
        [Key]
        [Column("cats_id")]
        public int CatId { get; set; }

        [Column("cat_name")]
        [Required]
        [MaxLength(50)]
        public string CatName { get; set; }

        [Column("cat_description")]
        [DataType(DataType.MultilineText)]
        public string CatDescription { get; set; }
    }
}
