using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Netflix_codes
{
    public class Code
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Number { get; set; }
    }
}
