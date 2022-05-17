using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverterCZ.model
{
    class ModelFile
    {
        public ModelFile(string product, string image, string position)
        {
            this.product = product;
            this.image = image;
            this.position = position;
        }

        public string product { get; set; }
        public string image { get; set; }
        public string position { get; set; }


    }
}
