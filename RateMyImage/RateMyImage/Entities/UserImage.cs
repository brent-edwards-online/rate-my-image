namespace CareerHub.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserImage")]
    public class UserImage
    {
        [Required]
        [Key]
        public int UserImageId { get; set; }

        [Required]
        [MaxLength]
        public string UserId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string ImageUrls { get; set; }

        [Required]
        [MaxLength(1500)]
        public string ImageUser { get; set; }

        [Required]
        public bool IsLiked { get; set; }
    }
}
