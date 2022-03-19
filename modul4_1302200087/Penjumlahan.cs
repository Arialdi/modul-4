using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200087
{
    internal class Penjumlahan<T>
    {
        T data;
        public static int JumlahTigaAngka(T an1, T an2, T an3)
        {
            int AN1 = Convert.ToInt32(an1);
            int AN2 = Convert.ToInt32(an2);
            int AN3 = Convert.ToInt32(an3);

            int jumlah = AN1 + AN2 + AN3;

            return jumlah;
        }
    }
}
