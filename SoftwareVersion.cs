using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoadTime
{


    public class SoftwareVersion
    {
        public string Version { get; set; }
        
        public SoftwareVersion()
        {
            Version = "6.12";
        }
        //version 6 add a delay between char send()
        //6.1 fix bug sending a zero before sending main string
        //6.2 display char send data with delay
        //6.3 set default delay to 1 ms
        //6.4 removed space between last char and the CR
        //6.5 fix software lockup when dis-connecting from a virtual com port
        //6.6 set TX char delay to a seperate timer3
        //6.7 add dst/cst select
        //6.8 add pause rx button
        //6.9 disable setting delay to 0
        //6.10 remove pause rx button
        //6.11 remove delay
        //6.12 fix RX data window not getting serial read

    }

    
}
