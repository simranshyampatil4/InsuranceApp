namespace InsuranceApp.DTO
{
    public class DocumentDto
    {
        public int DocumentId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string DocumentFile { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
    }
}
