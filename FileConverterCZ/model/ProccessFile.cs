using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileConverterCZ.model
{
    class ProccessFile
    {
        public bool processFileOutput(List<ModelFile> modelFiles)
        {
            bool proccesFile = false;
            var file = @"C:\Cizaro Work\loadfilesImages\output\output.csv";

            if (File.Exists(file)) File.Delete(file);

            using (var stream = File.CreateText(file))
            {
                for (int i = 0; i < modelFiles.Count(); i++)
                {
                    ModelFile model = modelFiles[i];
                    string product = model.product;
                    string image = model.image;
                    string position = model.position;
                    string csvRow = string.Format("{0},{1},{2}", product, image, position);

                    stream.WriteLine(csvRow);
                }
                proccesFile = true;
            }
            return proccesFile;
        }
    }
}
