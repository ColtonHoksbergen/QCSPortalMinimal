//using DataAccessLibrary.Models.CustomModels;
//using DataAccessLibrary.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models.ViewModels
{
    public class PhotosExpressDetailViewModel
    {
        // Photos Express Section
        public int PhotosExpressId { get; set; }
        public Guid PhotosExpressGUID { get; set; }
        public string ClaimNumber { get; set; }
        public int PolicyNumber { get; set; }
        public string ProgramCode { get; set; }
        public int OwnerId { get; set; }
        public int VehicleId { get; set; }
        public int AssignedAdjusterId { get; set; }
        public int? SupplementId { get; set; }
        public int? TotalLossId { get; set; }
        public string LossType { get; set; }
        public DateTime DateOfLoss { get; set; }
        public int DeductibleAmount { get; set; }
        public double EstimateAmount { get; set; }
        public string PointOfImpact { get; set; }
        public string FactsOfLoss { get; set; }
        public int PhotosExpressStatusEnum { get; set; }
        public string PhotosExpressStatus { get; set; }
        public bool SMSSent { get; set; }
        public bool EmailSent { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCompleted { get; set; }
        //public List<AdjusterModel>? AdjusterModels { get; set; }
        //public List<NotesDetailsModel>? Notes { get; set; }
        public string? CancellationReason { get; set; }
        public bool IsInternalAudit { get; set; }
        public bool IsActive { get; set; }

        // Vehicle Section
        public string VehicleVin { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModelAndTrim { get; set; }

        // Owner Section
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }

        [Required]
        [EmailAddress]
        public string OwnerEmailAddress { get; set; }

        [Required]
        public string OwnerCellPhone { get; set; }

        public string OwnerZipCode { get; set; }
        public string OwnerState { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerAddress { get; set; }
        public string? OwnerOtherPhone { get; set; }

        // TODO : I feel like PersonStatus is probably actually more closely related to the PhotosExpress
        //          than to the owner model, despite the name.
        public string OwnerStatus { get; set; }
    }
}
