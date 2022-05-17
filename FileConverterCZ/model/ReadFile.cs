using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverterCZ.model
{
    class ReadFile
    {

       
        public List<ModelFile> TransformFile(String file)
        {

           // System.IO.StreamReader archivo = new System.IO.StreamReader(file);
            string[] lines = System.IO.File.ReadAllLines(@file,Encoding.UTF8);
            IEnumerable<string> strs = lines;
            var columnQuery =
                  from line in strs
                  let elements = line.Split('|')
                  select elements[0];
            var columnQuery2 =
      from line in strs
      let elements = line.Split('|')
      select elements[24];
            var columnQuery3 =
from line in strs
let elements = line.Split('|')
select elements[25];

            List<ModelFile> fileOut = new List<ModelFile>();
            List<string> nameList = columnQuery.ToList();
            List<string> imageList = columnQuery2.ToList();
            List<string> position  = columnQuery3.ToList();

            for (int i = 0; i < nameList.Count; i++)
            {
                ModelFile fileRow = new ModelFile(nameList[i], imageList[i], position[i]);
                fileOut.Add(fileRow);
            }
            Console.WriteLine(fileOut[1]);
            return fileOut;




        }
    }
}