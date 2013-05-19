﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
