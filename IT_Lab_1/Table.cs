﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Lab_1
{
    class Table
    {
        public string tName;
        public List<Column> tColumnsList;
        public List<Row> tRowsList;

        public Table(string tname)
        {
            tName = tname;
            tColumnsList = new List<Column>();
            tRowsList = new List<Row>();
        }
    }
}
