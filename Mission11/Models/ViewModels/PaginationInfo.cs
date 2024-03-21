namespace Mission11.Models.ViewModels
{
    public class PaginationInfo
    {
        //Created Pagination!
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int)(Math.Ceiling((decimal)TotalItems / ItemsPerPage));
    }
}
