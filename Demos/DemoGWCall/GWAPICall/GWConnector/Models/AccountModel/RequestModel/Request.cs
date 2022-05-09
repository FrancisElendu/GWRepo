namespace GWAPICall.GWConnector.Models.AccountModel.RequestModel
{
    public class Request
    {
        public Data data { get; set; }
        public Included included { get; set; }
    }


    //public class Rootobject
    //{
    //    public Data data { get; set; }
    //    public Included included { get; set; }
    //}

    public class Data
    {
        public Attributes attributes { get; set; }
    }

    public class Attributes
    {
        public Accountholder accountHolder { get; set; }
        public Preferredcoveragecurrency preferredCoverageCurrency { get; set; }
        public Preferredsettlementcurrency preferredSettlementCurrency { get; set; }
        public Primarylanguage primaryLanguage { get; set; }
        public Primarylocale primaryLocale { get; set; }
        public Primarylocation primaryLocation { get; set; }
        public string businessOperationsDescription { get; set; }
        public string nickname { get; set; }
        public Producercode[] producerCodes { get; set; }
    }

    public class Accountholder
    {
        public string refid { get; set; }
    }

    public class Preferredcoveragecurrency
    {
        public string code { get; set; }
    }

    public class Preferredsettlementcurrency
    {
        public string code { get; set; }
    }

    public class Primarylanguage
    {
        public string code { get; set; }
    }

    public class Primarylocale
    {
        public string code { get; set; }
    }

    public class Primarylocation
    {
        public string refid { get; set; }
    }

    public class Producercode
    {
        public string id { get; set; }
    }

    public class Included
    {
        public Accountcontact[] AccountContact { get; set; }
        public Accountlocation[] AccountLocation { get; set; }
    }

    public class Accountcontact
    {
        public Attributes1 attributes { get; set; }
        public string method { get; set; }
        public string refid { get; set; }
        public string uri { get; set; }
    }

    public class Attributes1
    {
        public string contactSubtype { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Homephone homePhone { get; set; }
        public Workphone workPhone { get; set; }
        public Cellphone cellPhone { get; set; }
        public Primaryphonetype primaryPhoneType { get; set; }
        public string emailAddress1 { get; set; }
        public string emailAddress2 { get; set; }
        public string dateOfBirth { get; set; }
        public Primaryaddress primaryAddress { get; set; }
        public string taxId { get; set; }
    }

    public class Homephone
    {
        public Countrycode countryCode { get; set; }
        public string number { get; set; }
    }

    public class Countrycode
    {
        public string code { get; set; }
    }

    public class Workphone
    {
        public Countrycode1 countryCode { get; set; }
        public string number { get; set; }
    }

    public class Countrycode1
    {
        public string code { get; set; }
    }

    public class Cellphone
    {
        public Countrycode2 countryCode { get; set; }
        public string number { get; set; }
    }

    public class Countrycode2
    {
        public string code { get; set; }
    }

    public class Primaryphonetype
    {
        public string code { get; set; }
    }

    public class Primaryaddress
    {
        public string country { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string addressLine3 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public State state { get; set; }
        public string postalCode { get; set; }
    }

    public class State
    {
        public string code { get; set; }
    }

    public class Accountlocation
    {
        public Attributes2 attributes { get; set; }
        public string method { get; set; }
        public string refid { get; set; }
        public string uri { get; set; }
    }

    public class Attributes2
    {
        public bool nonSpecific { get; set; }
        public string country { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string addressLine3 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public State1 state { get; set; }
        public string postalCode { get; set; }
        public Addresstype addressType { get; set; }
    }

    public class State1
    {
        public string code { get; set; }
    }

    public class Addresstype
    {
        public string code { get; set; }
    }




    //public class Data
    //{
    //    public Attributes attributes { get; set; }
    //}

    //public class Attributes
    //{
    //    public Accountholder accountHolder { get; set; }
    //    public Preferredcoveragecurrency preferredCoverageCurrency { get; set; }
    //    public Preferredsettlementcurrency preferredSettlementCurrency { get; set; }
    //    public Primarylanguage primaryLanguage { get; set; }
    //    public Primarylocale primaryLocale { get; set; }
    //    public Primarylocation primaryLocation { get; set; }
    //    public string businessOperationsDescription { get; set; }
    //    public string nickname { get; set; }
    //    public Producercode[] producerCodes { get; set; }
    //}

    //public class Accountholder
    //{
    //    public string refid { get; set; }
    //}

    //public class Preferredcoveragecurrency
    //{
    //    public string code { get; set; }
    //}

    //public class Preferredsettlementcurrency
    //{
    //    public string code { get; set; }
    //}

    //public class Primarylanguage
    //{
    //    public string code { get; set; }
    //}

    //public class Primarylocale
    //{
    //    public string code { get; set; }
    //}

    //public class Primarylocation
    //{
    //    public string refid { get; set; }
    //}

    //public class Producercode
    //{
    //    public string id { get; set; }
    //}

    //public class Included
    //{
    //    public Accountcontact[] AccountContact { get; set; }
    //    public Accountlocation[] AccountLocation { get; set; }
    //}

    //public class Accountcontact
    //{
    //    public Attributes1 attributes { get; set; }
    //    public string method { get; set; }
    //    public string refid { get; set; }
    //    public string uri { get; set; }
    //}

    //public class Attributes1
    //{
    //    public string contactSubtype { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public Homephone homePhone { get; set; }
    //    public Workphone workPhone { get; set; }
    //    public Cellphone cellPhone { get; set; }
    //    public Primaryphonetype primaryPhoneType { get; set; }
    //    public string emailAddress1 { get; set; }
    //    public string emailAddress2 { get; set; }
    //    public string dateOfBirth { get; set; }
    //    public Primaryaddress primaryAddress { get; set; }
    //    public string taxId { get; set; }
    //}

    //public class Homephone
    //{
    //    public Countrycode countryCode { get; set; }
    //    public string number { get; set; }
    //}

    //public class Countrycode
    //{
    //    public string code { get; set; }
    //}

    //public class Workphone
    //{
    //    public Countrycode1 countryCode { get; set; }
    //    public string number { get; set; }
    //}

    //public class Countrycode1
    //{
    //    public string code { get; set; }
    //}

    //public class Cellphone
    //{
    //    public Countrycode2 countryCode { get; set; }
    //    public string number { get; set; }
    //}

    //public class Countrycode2
    //{
    //    public string code { get; set; }
    //}

    //public class Primaryphonetype
    //{
    //    public string code { get; set; }
    //}

    //public class Primaryaddress
    //{
    //    public string country { get; set; }
    //    public string addressLine1 { get; set; }
    //    public string addressLine2 { get; set; }
    //    public string addressLine3 { get; set; }
    //    public string city { get; set; }
    //    public string county { get; set; }
    //    public State state { get; set; }
    //    public string postalCode { get; set; }
    //}

    //public class State
    //{
    //    public string code { get; set; }
    //}

    //public class Accountlocation
    //{
    //    public Attributes2 attributes { get; set; }
    //    public string method { get; set; }
    //    public string refid { get; set; }
    //    public string uri { get; set; }
    //}

    //public class Attributes2
    //{
    //    public bool nonSpecific { get; set; }
    //    public string country { get; set; }
    //    public string addressLine1 { get; set; }
    //    public string addressLine2 { get; set; }
    //    public string addressLine3 { get; set; }
    //    public string city { get; set; }
    //    public string county { get; set; }
    //    public State1 state { get; set; }
    //    public string postalCode { get; set; }
    //    public Addresstype addressType { get; set; }
    //}

    //public class State1
    //{
    //    public string code { get; set; }
    //}

    //public class Addresstype
    //{
    //    public string code { get; set; }
    //}
}
