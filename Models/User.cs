using System.ComponentModel.DataAnnotations;

namespace CP2_CSHARP.Models
{
    public class User {

        [Key]
        public int id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;

    }
}
