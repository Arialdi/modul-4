using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200087
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            foreach (var x in storedData.Zip(inputDates, Tuple.Create))
            {
                Console.WriteLine(x.Item1 + " ");
                Console.WriteLine(x.Item2);
            }
        }
    }
}
