using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Holds
    {

        public int Id { get; set; }

        public virtual LibraryAsset LibraryAsset { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }

        public DateTime HoldPlace { get; set; }
    }
}
