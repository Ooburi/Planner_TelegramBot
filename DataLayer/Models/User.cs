using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public long TelegramUserId { get; set; }

    }
}
