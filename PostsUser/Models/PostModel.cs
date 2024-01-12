using PostsUser.Enums;

namespace PostsUser.Models
{
    public class PostModel : Model
    {
        public string? Content { get; set; }
        public DateTime Publication { get; set; }
        public DateTime Edited { get; set; }
        public PrivacyEnum Privacy { get; set; }
    }
}
