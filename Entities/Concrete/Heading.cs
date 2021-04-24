using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading : IEntity
    {
        [Key]
        public int HeadingId { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }

        public int CategoryId { get; set; } //İlişkili tablonun anahtar sütunu ile ayni isimde olacak!!! (İlişkili sınıf Category tablosu, en çok hata alınabilen alan)

        public virtual Category Category { get; set; } //Bir sınıftan değer alacak

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; } //Başlık alanı (Heading) da içerik alanı (content) ile ilişkili

    }
}
