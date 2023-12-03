namespace Ecommerce.Models.ViewModel
{
    public class AccounInfoModel
    {
        public int? SSN { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsModerator { get; set; }
        public bool IsAdmin { get; set; }
    }
}
