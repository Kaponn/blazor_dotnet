using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeInterpreterWA.Models
{
    public class ToDoItemModel
    {
        [StringLength(20, ErrorMessage = "Title is too long. Max 20 characters")]

        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
