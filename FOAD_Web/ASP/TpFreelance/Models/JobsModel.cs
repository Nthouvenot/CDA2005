using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    [Table("jobs")]
    public class JobsModel
    {
        [Key]
        [Column("job_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        [Column("job_state")]
        [Required]
        [StringLength(10)]
        public string JobState { get; set; }

        [Column("job_title")]
        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Column("job_start")]
        [DataType(DataType.DateTime)]
        public DateTime JobStart { get; set; } 

        [Column("job_end")]
        [DataType(DataType.DateTime)]
        public DateTime JobEnd { get; set; }

        [Column("job_description")]
        [DataType(DataType.MultilineText)]
        public string JobDescription { get; set; }

        [ForeignKey("FK_customers")]
        [Column("customer_id")]
        [Required]
        public int CustomerId { get; set; }
        public CustomersModel CustomersModel { get; set; }

        public ICollection<QuotesModel> QuotesModels;
    }
}
