using System;

namespace kpltpmod4_1302204056
{
    class Program
    {

        static void Main(string[] args)
        {
            HaloGeneric<string> hello = new HaloGeneric<string>() ;

            String XXX = "Ore wa Koi Desu" ;

            hello.HelloUser(XXX) ;

            DataGeneric<String> data = new DataGeneric<string>("1302204056") ;

            data.DataPrint() ;

        }
    }


}