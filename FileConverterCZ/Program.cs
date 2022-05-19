using System;

namespace FileConverterCZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start processes to read file");
            model.LoadFile l = new model.LoadFile();
            model.ReadFile r = new model.ReadFile();
            model.ProccessFile p = new model.ProccessFile();
            Console.WriteLine("Start processes to write file with images");
            p.processFileOutput(  l.processDuplicate(l.transformfiletoReadable()));
            Console.WriteLine("Start processes to write file only products");
            p.processFileOutput(r.TransformFile(l.transformfiletoReadable()));
            Console.ReadKey();

        }
    }
}
