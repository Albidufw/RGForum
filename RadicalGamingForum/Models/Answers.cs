using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadicalGamingForum.Models
{
    public class Answers
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]

        public IdentityUser? User { get; set; }

        public int QuestionsId { get; set; }
        [ForeignKey("QuestionsId")]
        public Questions Questions { get; set; }
    }
}
