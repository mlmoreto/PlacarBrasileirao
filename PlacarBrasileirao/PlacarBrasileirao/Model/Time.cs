using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PlacarBrasileirao.Model
{
    class Time
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String Nome { get; set; }
    }
}
