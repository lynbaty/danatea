namespace API.Dtos.Store
{
    public class CategoryDto
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int? ParentId {set; get;}
        public int SortOrder {set; get;}
        public bool IsHome {set; get;}
    }
}