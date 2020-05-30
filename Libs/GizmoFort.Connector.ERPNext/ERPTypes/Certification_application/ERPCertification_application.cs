using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Certification_application
{
    public class ERPCertification_application : ERPNextObjectBase
    {
        public ERPCertification_application() : this(new ERPObject(DocType.Certification_application)) { }
        public ERPCertification_application(ERPObject obj) : base(obj) { }

        public static ERPCertification_application Create(string nameofapplicant, string email, Certificationstatus certificationstatus, long paid, Currency currency, double amount)

        {
            ERPCertification_application obj = new ERPCertification_application();
            obj.name_of_applicant = nameofapplicant;
            obj.email = email;
            obj.certification_status = certificationstatus;
            obj.paid = paid;
            obj.currency = currency;
            obj.amount = amount;
            return obj;
        }

        public string name_of_applicant
        {
            get { return data.name_of_applicant; }
            set
            {
                data.name_of_applicant = value;
                data.name = value;
            }

        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public Certificationstatus certification_status
        {
            get { return parseEnum<Certificationstatus>(data.certification_status); }
            set { data.certification_status = value.ToString(); }
        }

        public long paid
        {
            get { return data.paid; }
            set { data.paid = value; }
        }

        public Currency currency
        {
            get { return parseEnum<Currency>(data.currency); }
            set { data.currency = value.ToString(); }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here
    public enum Certificationstatus
    {
        [Description("Yet to appear")]
        Yettoappear,
        [Description("Certified")]
        Certified,
        [Description("Not Certified")]
        NotCertified,
    }

    public enum Currency
    {
        [Description("USD")]
        USD,
        [Description("INR")]
        INR,
    }


}