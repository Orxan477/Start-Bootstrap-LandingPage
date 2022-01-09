using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Start_Bootstrap_Landing_page_.Models
{
    public class Information
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
