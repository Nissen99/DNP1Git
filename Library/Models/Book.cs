using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public int  TotalPages { get; set; }
        public DateTime PublishDate { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}