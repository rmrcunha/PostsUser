using PostsUser.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostsUser.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Content cannot be void")]
        [MinLength(1)]
        [MaxLength(500)]
        [DisplayName("Content")]
        public string Content { get; set; }
        
        [Display(Name = "Publication date")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Publication date is required")]
        [DisplayFormat(DataFormatString ="{0: dd/mm/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Publication { get; set; }

        [Display(Name = "Edition date")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Edition date is required")]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Edited { get; set; }

        [Required(ErrorMessage = "The privacy set is required")]
        [Range(0,3)]
        public PrivacyEnum Privacy { get; set; }
    }
}
