﻿using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class ConsoleData : IWriteReadable
    {
        public object Read()
        {
            object InputData = Console.ReadLine();
            return InputData;
        }
        
        public void Write(object OutputData)
        {
            Console.WriteLine(OutputData);
        }
    }
}
