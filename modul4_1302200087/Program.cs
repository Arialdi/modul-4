using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.AddNewData(13);
            db.AddNewData(02);
            db.AddNewData(20);
            db.PrintAllData();
        }
    }
}
