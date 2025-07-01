using System.ComponentModel.DataAnnotations;

namespace TaskApi.DTOs
{
    public class CreateTaskDto
    {
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Title can't exceed 100 characters.")]
        public string Title { get; set; }
    }
}
