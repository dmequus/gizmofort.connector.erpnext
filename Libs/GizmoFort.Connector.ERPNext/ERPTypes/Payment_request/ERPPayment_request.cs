using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_request
{
    public class ERPPayment_request : ERPNextObjectBase
    {
        public ERPPayment_request() : this(new ERPObject(DocType.Payment_request)) { }
        public ERPPayment_request(ERPObject obj) : base(obj) { }

        public static ERPPayment_request Create(Paymentrequesttype paymentrequesttype, string namingseries)

        {
            ERPPayment_request obj = new ERPPayment_request();
            obj.payment_request_type = paymentrequesttype;
            obj.naming_series = namingseries;
            return obj;
        }

        public Paymentrequesttype payment_request_type
        {
            get { return parseEnum<Paymentrequesttype>(data.payment_request_type); }
            set { data.payment_request_type = value.ToString(); }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string party_type
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        public string party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        private int _is_a_subscription = 0;
        public int is_a_subscription
        {
            get { return data._is_a_subscription; }
            set { data._is_a_subscription = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string subscription_plans
        {
            get { return data.subscription_plans; }
            set { data.subscription_plans = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public string bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        public string bank_account_no
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string iban
        {
            get { return data.iban; }
            set { data.iban = value; }
        }

        public string branch_code
        {
            get { return data.branch_code; }
            set { data.branch_code = value; }
        }

        public string swift_number
        {
            get { return data.swift_number; }
            set { data.swift_number = value; }
        }

        public string print_format
        {
            get { return data.print_format; }
            set { data.print_format = value; }
        }

        public string email_to
        {
            get { return data.email_to; }
            set { data.email_to = value; }
        }

        public string subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        public string payment_gateway_account
        {
            get { return data.payment_gateway_account; }
            set { data.payment_gateway_account = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        private int _make_sales_invoice = 0;
        public int make_sales_invoice
        {
            get { return data._make_sales_invoice; }
            set { data._make_sales_invoice = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        public string message_examples
        {
            get { return data.message_examples; }
            set { data.message_examples = value; }
        }

        private int _mute_email = 0;
        public int mute_email
        {
            get { return data._mute_email; }
            set { data._mute_email = value; }
        }

        public string payment_url
        {
            get { return data.payment_url; }
            set { data.payment_url = value; }
        }

        public string payment_gateway
        {
            get { return data.payment_gateway; }
            set { data.payment_gateway = value; }
        }

        public string payment_account
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
        }

        public string payment_order
        {
            get { return data.payment_order; }
            set { data.payment_order = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Paymentrequesttype
    {
        [Description("Outward")]
        Outward,
        [Description("Inward")]
        Inward,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Requested")]
        Requested,
        [Description("Initiated")]
        Initiated,
        [Description("Partially Paid")]
        PartiallyPaid,
        [Description("Payment Ordered")]
        PaymentOrdered,
        [Description("Paid")]
        Paid,
        [Description("Failed")]
        Failed,
        [Description("Cancelled")]
        Cancelled,
    }


}