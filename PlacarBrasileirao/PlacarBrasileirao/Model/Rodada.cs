using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PlacarBrasileirao.Model
{
    class Rodada
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String NroRodada { get; set; }
    }
}
