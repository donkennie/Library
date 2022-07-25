using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        public LibraryAsset LibraryAsset { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public DateTime CheckedOut { get; set; }

        public DateTime? CheckedIn { get; set; }
    }
}
