using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadicalGamingForum.Models
{
    public class Questions
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUser")]
        public IdentityUser User { get; set; }

        public List<Answers>? Answers { get; set; }
    }
}
