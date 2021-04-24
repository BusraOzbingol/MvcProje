using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content : IEntity
    {
        [Key]
        public int ContentId { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public int HeadingId { get; set; } //1.ForeignKey
        public virtual Heading Heading { get; set; }

        public int? WriterId { get; set; } //2.ForeignKey (int? : bos bırakılabilir yapıyoruz)
        public virtual Writer Writer { get; set; }

    }
}
