using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    public class QuotesModel
    {
        [Key]
        [Column("quote_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuoteId { get; set; }

        [Column("quote_state")]
        [Required]
        [StringLength(10)]
        public string QuoteState { get; set; }

        [Column("quote_date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        [Column("quote_amount")]
        [Required]
        public int QuoteAmount { get; set; }

        [Column("quote_final_date")]
        [DataType(DataType.Date)]
        public DateTime QuoteFinalDate { get; set; }

        [Column("quote_final_amount")]
        public int QuoteFinalAmount { get; set; }

        [ForeignKey("job_id")]
        [Column("job_id")]
        [Required]
        public int Jobid { get; set; }
        public JobsModel JobsModel { get; set; }
    }
}
