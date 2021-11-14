using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        public string Bio { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}