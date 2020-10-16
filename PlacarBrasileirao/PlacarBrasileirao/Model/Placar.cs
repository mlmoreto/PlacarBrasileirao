using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PlacarBrasileirao.Model
{
    public class Placar
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String NroRodada { get; set; }
        public String Time1 { get; set; }
        public String GolTime1 { get; set; }
        public String Time2 { get; set; }
        public String GolTime2 { get; set; }
    }
}
