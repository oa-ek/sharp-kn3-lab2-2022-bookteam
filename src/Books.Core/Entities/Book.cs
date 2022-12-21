﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Entities
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public virtual ICollection<Author>? Authors { get; set; } = new List<Author>();
        public Publisher? Publishers { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Genre>? Genres { get; set; } = new List<Genre>();
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public string? IconPath { get; set; } // Шлях до іконки
        public float? Rating { get; set; }
        public override string ToString()
        {
            return $"{Title}";
        }

    }
}
