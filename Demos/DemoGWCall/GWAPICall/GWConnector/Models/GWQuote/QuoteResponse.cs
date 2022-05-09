namespace GWAPICall.GWConnector.Models.GWQuote
{
    public class QuoteResponse
    {
        public Data data { get; set; }
    }
    public class Data
    {
        public Attributes attributes { get; set; }
        public string checksum { get; set; }
        public Links links { get; set; }
    }

    public class Attributes
    {
        public Account account { get; set; }
        public Basestate baseState { get; set; }
        public DateTime createdDate { get; set; }
        public bool editLocked { get; set; }
        public string id { get; set; }
        public DateTime jobEffectiveDate { get; set; }
        public string jobNumber { get; set; }
        public Jobstatus jobStatus { get; set; }
        public Jobtype jobType { get; set; }
        public Organization organization { get; set; }
        public DateTime periodEnd { get; set; }
        public DateTime periodStart { get; set; }
        public Preferredcoveragecurrency preferredCoverageCurrency { get; set; }
        public Primaryinsured primaryInsured { get; set; }
        public Primarylocation primaryLocation { get; set; }
        public Producercode producerCode { get; set; }
        public Product product { get; set; }
        public Quotetype quoteType { get; set; }
        public Taxesandsurcharges taxesAndSurcharges { get; set; }
        public Termtype termType { get; set; }
        public Totalcost totalCost { get; set; }
        public Totalpremium totalPremium { get; set; }
        public Uwcompany uwCompany { get; set; }
    }

    public class Account
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Basestate
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Jobstatus
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Jobtype
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Organization
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Preferredcoveragecurrency
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Primaryinsured
    {
        public string displayName { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
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

    public class Product
    {
        public string displayName { get; set; }
        public string id { get; set; }
    }

    public class Quotetype
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Taxesandsurcharges
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Termtype
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Totalcost
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Totalpremium
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Uwcompany
    {
        public Code code { get; set; }
        public string displayName { get; set; }
        public string id { get; set; }
    }

    public class Code
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Links
    {
        public Activities activities { get; set; }
        public ActivityAssignees activityassignees { get; set; }
        public ActivityPatterns activitypatterns { get; set; }
        public BindAndIssue bindandissue { get; set; }
        public BindOnly bindonly { get; set; }
        public ChangeVersion changeversion { get; set; }
        public Contacts contacts { get; set; }
        public Contingencies contingencies { get; set; }
        public CopySubmission copysubmission { get; set; }
        public Costs costs { get; set; }
        public Decline decline { get; set; }
        public Documents documents { get; set; }
        public Lines lines { get; set; }
        public Locations locations { get; set; }
        public MakeDraft makedraft { get; set; }
        public NotTake nottake { get; set; }
        public Notes notes { get; set; }
        public OosConflicts oosconflicts { get; set; }
        public OverrideRating overriderating { get; set; }
        public PaymentInfo paymentinfo { get; set; }
        public PaymentPlans paymentplans { get; set; }
        public Questions questions { get; set; }
        public ReleaseEditLock releaseeditlock { get; set; }
        public RequestApproval requestapproval { get; set; }
        public Self self { get; set; }
        public UserRoles userroles { get; set; }
        public UwIssues uwissues { get; set; }
        public Versions versions { get; set; }
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

    public class BindAndIssue
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class BindOnly
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class ChangeVersion
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Contacts
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Contingencies
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class CopySubmission
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Costs
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Decline
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Documents
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Lines
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Locations
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class MakeDraft
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class NotTake
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Notes
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class OosConflicts
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class OverrideRating
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class PaymentInfo
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class PaymentPlans
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Questions
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class ReleaseEditLock
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class RequestApproval
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class UserRoles
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class UwIssues
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Versions
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }

    public class Withdraw
    {
        public string href { get; set; }
        public string[] methods { get; set; }
    }
}
