using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GasolinerasShell.Models
{
    [Table("Shell")]
    public class ShellModel
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
            
        public string Brand { get; set; }
        
        public string Name { get; set; }

        public string Picture { get; set; }

        public double PriceMagna { get; set; }

        public double PricePremium { get; set; }

        public double PriceDiesel { get; set; }

        public double Lattitude { get; set;  }

        public double Longitude { get; set; }
    }
}
