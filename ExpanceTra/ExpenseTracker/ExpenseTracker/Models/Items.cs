using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Items
    {
        [Key]
        public string ItemNO { get; set; }
        [Required]
        public string IfsCode { get; set; }
        [Required]
        public string GWTPC { get; set; }

        [Required]
        public string Group { get; set; }
        [Required]
        public string HsCode { get; set; }
        [Required]
        public string LengthCtn { get; set; }
        [Required]
        public string SbGroup { get; set; }
        [Required]
        public string PackSUdom { get; set; }
        [Required]
        public string WeightCtn { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string ifscode { get; set; }
        [Required]
        public string PackS { get; set; }
        [Required]
        public string HeightCtn { get; set; }
        [Required]
        public string Uom { get; set; }
        [Required]
        public string PcsPerCtn { get; set; }
    }
}
