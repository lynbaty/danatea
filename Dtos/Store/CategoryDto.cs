using System.ComponentModel.DataAnnotations;

namespace Dtos.Store
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="required")]
        public string Name { get; set; }
        public int? ParentId { set; get; }
        public int SortOrder { set; get; }
        public bool IsHome { set; get; }
    }
}