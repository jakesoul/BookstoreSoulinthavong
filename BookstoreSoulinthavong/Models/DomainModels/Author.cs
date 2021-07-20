﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [MaxLength(200)]
        [Remote("CheckAuthor", "Validation", "Admin", AdditionalFields = "FirstName, Operation")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
