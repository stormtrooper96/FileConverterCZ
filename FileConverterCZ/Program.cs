﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverterCZ
{
    class Program
    {
        static void Main(string[] args)
        {
            model.LoadFile l = new model.LoadFile();
            model.ReadFile r=  new model.ReadFile();
            model.ProccessFile p = new model.ProccessFile();
            p.processFileOutput(r.TransformFile(l.transformfiletoReadable()));


        }
    }
}
