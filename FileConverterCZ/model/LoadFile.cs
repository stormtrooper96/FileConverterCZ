using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace FileConverterCZ.model
{


    class LoadFile
    {
        public string FILEPATHMOVED = "";

        public string transformfiletoReadable()
        {

            {
                string path = moveFile();
                var parser = new TextFieldParser(new StringReader(File.ReadAllText(path)))
                {
                    HasFieldsEnclosedInQuotes = true,
                    Delimiters = new string[] { "," },
                    TrimWhiteSpace = true
                };

                var csvSplitList = new List<string>();

                // Reads all fields on the current line of the CSV file and returns as a string array
                // Joins each field together with new delimiter "|"
                while (!parser.EndOfData)
                {
                    csvSplitList.Add(String.Join("|", parser.ReadFields()));
                }

                // Newline characters added to each line and flattens List<string> into single string
                var formattedCsvToSave = String.Join(Environment.NewLine, csvSplitList.Select(x => x));
                path = path.Replace(".csv", "_01.csv");
                // Write single string to file
                File.WriteAllText(@path, formattedCsvToSave,System.Text.Encoding.UTF8);
                parser.Close();
                return path;
            }
        }
        public List<string> processDuplicate(string file) {
            var dictionary = new List<string>();
            var dictionary2 = new List<string>();
            var dictionary3 = new List<string>();

         

            using (var rd2 = new StreamReader(file))
            {
                while (!rd2.EndOfStream)
                {
      
                   dictionary2.Add(rd2.ReadLine());

                }
            }
            for (int i = 0; i < dictionary2.Count; i++)
            {
              string value = dictionary2[i];

                dictionary3.Add(value);


            }
                  int c = dictionary3.Count;
            return dictionary3;

        }



        public string moveFile()
        {
            var dt = DateTime.Now;
            string initialPath = "C:\\Cizaro Work\\loadfilesImages\\src\\gvtocsv.csv";
            Console.WriteLine("Cargando desde " + initialPath);
            string formattedDate = dt.ToString("ddMMyyyyhhmmss");
            Console.WriteLine(formattedDate);
            string finalPath = initialPath.Replace("gvtocsv", "gvtocsv" + formattedDate);
            finalPath = finalPath.Replace("src", "input");

            File.Delete(finalPath); // Delete the existing file if exists
            File.Copy(initialPath, finalPath); // Rename the oldFileName into newFileName
            Console.WriteLine("creado archivo   " + finalPath);
            FILEPATHMOVED = finalPath;
            return finalPath;
        }


    }
}
