using System.ComponentModel.DataAnnotations;

namespace InformationInspection
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}
