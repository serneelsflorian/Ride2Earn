﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Ride2Earn.Klassen
{
    public class Rit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Start { get; set; }
        public string Einde { get; set; }
        public double Gereden { get; set; }

        public override string ToString()
        {
            return $"{Gereden}";
        }
    }

}