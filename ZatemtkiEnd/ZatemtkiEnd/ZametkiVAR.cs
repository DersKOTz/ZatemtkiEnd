using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZatemtkiEnd
{
    [Table("Zametki")]
    public class ZametkiVAR
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Nazv { get; set; }
        public string Opis { get; set; }
        public DateTime Nach { get; set; }
        public string Sroc { get; set; }
        public bool Swi { get; set; }

    }
}


