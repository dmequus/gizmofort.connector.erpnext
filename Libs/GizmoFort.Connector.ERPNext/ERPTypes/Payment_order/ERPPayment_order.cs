using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_order
{
    public class ERPPayment_order : ERPNextObjectBase
    {
        public ERPPayment_order() : this(new ERPObject(DocType.Payment_order)) { }
        public ERPPayment_order(ERPObject obj) : base(obj) { }

        public static ERPPayment_order Create(string namingseries, string company, string references, Paymentordertype paymentordertype, string companybankaccount)

        {
            ERPPayment_order obj = new ERPPayment_order();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.references = references;
            obj.payment_order_type = paymentordertype;
            obj.company_bank_account = companybankaccount;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string references
        {
            get { return data.references; }
            set { data.references = value; }
        }

        public Paymentordertype payment_order_type
        {
            get { return parseEnum<Paymentordertype>(data.payment_order_type); }
            set { data.payment_order_type = value.ToString(); }
        }

        public string company_bank_account
        {
            get { return data.company_bank_account; }
            set { data.company_bank_account = value; }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string company_bank
        {
            get { return data.company_bank; }
            set { data.company_bank = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }


    }

    //Enums go here
    public enum Paymentordertype
    {
        [Description("Payment Request")]
        PaymentRequest,
        [Description("Payment Entry")]
        PaymentEntry,
    }


}