using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template_detail
{
    public class ERPPayment_terms_template_detail : ERPNextObjectBase
    {
        public ERPPayment_terms_template_detail() : this(new ERPObject(DocType.Payment_terms_template_detail)) { }
        public ERPPayment_terms_template_detail(ERPObject obj) : base(obj) { }

        public static ERPPayment_terms_template_detail Create(string paymentterm, string description, double invoiceportion, Duedatebasedon duedatebasedon, int creditdays, int creditmonths, string modeofpayment)

        {
            ERPPayment_terms_template_detail obj = new ERPPayment_terms_template_detail();
            obj.payment_term = paymentterm;
            obj.description = description;
            obj.invoice_portion = invoiceportion;
            obj.due_date_based_on = duedatebasedon;
            obj.credit_days = creditdays;
            obj.credit_months = creditmonths;
            obj.mode_of_payment = modeofpayment;
            return obj;
        }

        public string payment_term
        {
            get { return data.payment_term; }
            set
            {
                data.payment_term = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double invoice_portion
        {
            get { return data.invoice_portion; }
            set { data.invoice_portion = value; }
        }

        public Duedatebasedon due_date_based_on
        {
            get { return parseEnum<Duedatebasedon>(data.due_date_based_on); }
            set { data.due_date_based_on = value.ToString(); }
        }

        public int credit_days
        {
            get { return data.credit_days; }
            set { data.credit_days = value; }
        }

        public int credit_months
        {
            get { return data.credit_months; }
            set { data.credit_months = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
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