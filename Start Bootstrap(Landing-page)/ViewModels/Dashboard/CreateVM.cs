using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Start_Bootstrap_Landing_page_.ViewModels.Dashboard
{
    public class CreateVM
    {
        public int Id { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        [Required, MaxLength(50)]
        public string Head { get; set; }
        [Required, MaxLength(50)]
        public string Content { get; set; }
    }
}
