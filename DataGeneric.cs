using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpltpmod4_1302204056
{
    internal class DataGeneric<T>
    {
        private T ehe ;

        public DataGeneric(T ehe) 
        {

            this.ehe = ehe ;

        }

        public void DataPrint()
        {

            Console.WriteLine("\n The kept data is : " + this.ehe) ;

        }
    }
}