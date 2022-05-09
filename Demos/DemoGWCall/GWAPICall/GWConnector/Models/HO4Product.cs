namespace GWAPICall.GWConnector.Models
{
    public class HO4Product
    {
        public class AvailableTermType
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class DefaultTermType
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class ProductAccountType
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class ProductType
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Attributes
        {
            public string abbreviation { get; set; }
            public List<AvailableTermType> availableTermTypes { get; set; }
            public DefaultTermType defaultTermType { get; set; }
            public string description { get; set; }
            public string descriptionKey { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string nameKey { get; set; }
            public int priority { get; set; }
            public ProductAccountType productAccountType { get; set; }
            public ProductType productType { get; set; }
            public bool visualized { get; set; }
        }

        public class Lines
        {
            public string href { get; set; }
            public List<string> methods { get; set; }
        }

        public class Questions
        {
            public string href { get; set; }
            public List<string> methods { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
            public List<string> methods { get; set; }
        }

        public class Links
        {
            public Lines lines { get; set; }
            public Questions questions { get; set; }
            public Self self { get; set; }
        }

        public class Data
        {
            public Attributes attributes { get; set; }
            public Links links { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
        }
    }
}
