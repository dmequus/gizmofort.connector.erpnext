using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_term
{
    public class ERPPayment_term : ERPNextObjectBase
    {
        public ERPPayment_term() : this(new ERPObject(DocType.Payment_term)) { }
        public ERPPayment_term(ERPObject obj) : base(obj) { }

        public static ERPPayment_term Create(string paymenttermname, double invoiceportion, string modeofpayment, Duedatebasedon duedatebasedon, int creditdays, int creditmonths, string description)

        {
            ERPPayment_term obj = new ERPPayment_term();
            obj.payment_term_name = paymenttermname;
            obj.invoice_portion = invoiceportion;
            obj.mode_of_payment = modeofpayment;
            obj.due_date_based_on = duedatebasedon;
            obj.credit_days = creditdays;
            obj.credit_months = creditmonths;
            obj.description = description;
            return obj;
        }

        public string payment_term_name
        {
            get { return data.payment_term_name; }
            set
            {
                data.payment_term_name = value;
                data.name = value;
            }

        }

        private double _invoice_portion = 0.0;
        public double invoice_portion
        {
            get { return data._invoice_portion; }
            set { data._invoice_portion = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public Duedatebasedon due_date_based_on
        {
            get { return parseEnum<Duedatebasedon>(data.due_date_based_on); }
            set { data.due_date_based_on = value.ToString(); }
        }

        private int _credit_days = 0;
        public int credit_days
        {
            get { return data._credit_days; }
            set { data._credit_days = value; }
        }

        private int _credit_months = 0;
        public int credit_months
        {
            get { return data._credit_months; }
            set { data._credit_months = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here
    public enum Duedatebasedon
    {
        [Description("Day(s) after invoice date")]
        Daysafterinvoicedate,
        [Description("Day(s) after the end of the invoice month")]
        Daysaftertheendoftheinvoicemonth,
        [Description("Month(s) after the end of the invoice month")]
        Monthsaftertheendoftheinvoicemonth,
    }


}