using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class SoftwareadviceModel
    {
            public List<SoftwareadviceProduct> products { get; set; }
    }

    public class SoftwareadviceProduct
    {
        public List<string> categories { get; set; }
        public string twitter { get; set; }
        public string title { get; set; }
    }

    public class SoftwareadviceResponseModel
    {
        public string twitter { get; set; }
        public string categories { get; set; }
        public string name { get; set; }
    }
}
