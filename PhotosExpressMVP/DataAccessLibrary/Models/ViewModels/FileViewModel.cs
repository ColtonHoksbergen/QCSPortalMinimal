namespace DataAccessLibrary.Models.ViewModels
{
    public class FileViewModel
    {
        public string? FileIndex { get; set; }
        public string? Base64Data { get; set; }
        public string? FullSizeBase64Data { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public byte[] Stream { get; set; }
        public string ClaimNumber { get; set; }
        public string Guid { get; set; }
    }
}
