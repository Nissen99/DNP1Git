using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Library.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [MaxLength(30)]
        public string GenreName { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}