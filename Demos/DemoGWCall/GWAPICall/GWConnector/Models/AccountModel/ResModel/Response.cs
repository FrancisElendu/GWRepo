namespace GWAPICall.GWConnector.Models.AccountModel.ResModel
{
    public class Response
    {
        public Data data { get; set; }
    }

    //public class Rootobject
    //{
    //    public Data data { get; set; }
    //}

    public class Data
    {
        public Attributes attributes { get; set; }
        public string checksum { get; set; }
        public Links links { get; set; }
    }

    public class Attributes
    {
        public Accountholder accountHolder { get; set; }
        public string accountNumber { get; set; }
        public Accountstatus accountStatus { get; set; }
        public string businessOperationsDescription { get; set; }
        public DateTime createdDate { get; set; }
        public bool frozen { get; set; }
        public string id { get; set; }
        public string nickname { get; set; }
        public string numberOfContacts { get; set; }
        public Preferredcoveragecurrency preferredCoverageCurrency { get; set; }
        public Preferredsettlementcurrency preferredSettlementCurrency { get; set; }
        public Primarylanguage primaryLanguage { get; set; }
        public Primarylocale primaryLocale { get; set; }
        public Primarylocation primaryLocation { get; set; }
        public Producercode[] producerCodes { get; set; }
    }

    public class Accountholder
    {
        public string displayName { get; set; }
        public string id { get; set; }
    }

    public class Accountstatus
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Preferredcoveragecurrency
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Preferredsettlementcurrency
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Primarylanguage
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Primarylocale
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Primarylocation
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Producercode
    {
        public string displayName { get; set; }
        public string id { get; set; }
    }

    public class Links
    {
        public Activities activities { get; set; }
        public ActivityAssignees activityassignees { get; set; }
        public ActivityPatterns activitypatterns { get; set; }
        public Contacts contacts { get; set; }
        public Documents documents { get; set; }
        public Freeze freeze { get; set; }
        public Jobs jobs { get; set; }
        public Locations locations { get; set; }
        public MovePolicies movepolicies { get; set; }
        public Notes notes { get; set; }
        public Policies policies { get; set; }
        public Self self { get; set; }
        public Withdraw withdraw { get; set; }
    }

    public class Activities
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class ActivityAssignees
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class ActivityPatterns
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Contacts
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Documents
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Freeze
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Jobs
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Locations
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class MovePolicies
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Notes
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Policies
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Withdraw
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }



    //public class Data
    //{
    //    public Attributes attributes { get; set; }
    //    public string checksum { get; set; }
    //    public Links links { get; set; }
    //}

    //public class Attributes
    //{
    //    public Accountholder accountHolder { get; set; }
    //    public string accountNumber { get; set; }
    //    public Accountstatus accountStatus { get; set; }
    //    public string businessOperationsDescription { get; set; }
    //    public DateTime createdDate { get; set; }
    //    public bool frozen { get; set; }
    //    public string id { get; set; }
    //    public string nickname { get; set; }
    //    public string numberOfContacts { get; set; }
    //    public Preferredcoveragecurrency preferredCoverageCurrency { get; set; }
    //    public Preferredsettlementcurrency preferredSettlementCurrency { get; set; }
    //    public Primarylanguage primaryLanguage { get; set; }
    //    public Primarylocale primaryLocale { get; set; }
    //    public Primarylocation primaryLocation { get; set; }
    //    public Producercode[] producerCodes { get; set; }
    //}

    //public class Accountholder
    //{
    //    public string displayName { get; set; }
    //    public string id { get; set; }
    //}

    //public class Accountstatus
    //{
    //    public string code { get; set; }
    //    public string name { get; set; }
    //}

    //public class Preferredcoveragecurrency
    //{
    //    public string code { get; set; }
    //    public string name { get; set; }
    //}

    //public class Preferredsettlementcurrency
    //{
    //    public string code { get; set; }
    //    public string name { get; set; }
    //}

    //public class Primarylanguage
    //{
    //    public string code { get; set; }
    //    public string name { get; set; }
    //}

    //public class Primarylocale
    //{
    //    public string code { get; set; }
    //    public string name { get; set; }
    //}

    //public class Primarylocation
    //{
    //    public string displayName { get; set; }
    //    public string id { get; set; }
    //    public string type { get; set; }
    //    public string uri { get; set; }
    //}

    //public class Producercode
    //{
    //    public string displayName { get; set; }
    //    public string id { get; set; }
    //}

    //public class Links
    //{
    //    public Activities activities { get; set; }
    //    public ActivityAssignees activityassignees { get; set; }
    //    public ActivityPatterns activitypatterns { get; set; }
    //    public Contacts contacts { get; set; }
    //    public Documents documents { get; set; }
    //    public Freeze freeze { get; set; }
    //    public Jobs jobs { get; set; }
    //    public Locations locations { get; set; }
    //    public MovePolicies movepolicies { get; set; }
    //    public Notes notes { get; set; }
    //    public Policies policies { get; set; }
    //    public Self self { get; set; }
    //    public Withdraw withdraw { get; set; }
    //}

    //public class Activities
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class ActivityAssignees
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class ActivityPatterns
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Contacts
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Documents
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Freeze
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Jobs
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Locations
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class MovePolicies
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Notes
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Policies
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Self
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

    //public class Withdraw
    //{
    //    public string href { get; set; }
    //    public string[] methods { get; set; }
    //}

}
