using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OperationsManagementSystem.Models
{
    public class Part
    {
        public enum PartStatusList
        {
            unembodied,
            identified,
            transiting,
            stored,
            assigned,
            qualified,
            nonconform
        }

        [Key]
        public string Id { get; set; } //[primary key, increment, not null]
        public string Name { get; set; }//[not null]
        public string? Text { get; set; }
        public PartStatusList? Status { get; set; } //[not null]
        [ForeignKey("InternalLocation")]
        public string Location { get; set; }
        [ForeignKey("Organization")]
        public string? Supplier { get; set; }
        public string? SupplierRef { get; set; }
        public int? LotUnit { get; set; }
        [ForeignKey("Assembly")]
        public string Group { get; set; }


        public Part()
        {

        }
    }


}
