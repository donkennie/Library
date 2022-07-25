using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
    public class Book : LibraryAsset
    {
        [Required]
        public string ISBN { get; set; }

        public string Author { get; set; }

        public string DeweyIndex { get; set; }
    }
}
