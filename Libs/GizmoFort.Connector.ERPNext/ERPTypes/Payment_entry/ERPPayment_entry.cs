using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry
{
    public class ERPPayment_entry : ERPNextObjectBase
    {
        public ERPPayment_entry() : this(new ERPObject(DocType.Payment_entry)) { }
        public ERPPayment_entry(ERPObject obj) : base(obj) { }

        public static ERPPayment_entry Create(string title, string namingseries, Paymenttype paymenttype, string postingdate, string company, string paidfrom, string paidfromaccountcurrency, string paidto, string paidtoaccountcurrency, double paidamount, double sourceexchangerate, double basepaidamount, double receivedamount, double targetexchangerate, double basereceivedamount)

        {
            ERPPayment_entry obj = new ERPPayment_entry();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.payment_type = paymenttype;
            obj.posting_date = postingdate;
            obj.company = company;
            obj.paid_from = paidfrom;
            obj.paid_from_account_currency = paidfromaccountcurrency;
            obj.paid_to = paidto;
            obj.paid_to_account_currency = paidtoaccountcurrency;
            obj.paid_amount = paidamount;
            obj.source_exchange_rate = sourceexchangerate;
            obj.base_paid_amount = basepaidamount;
            obj.received_amount = receivedamount;
            obj.target_exchange_rate = targetexchangerate;
            obj.base_received_amount = basereceivedamount;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Paymenttype payment_type
        {
            get { return parseEnum<Paymenttype>(data.payment_type); }
            set { data.payment_type = value.ToString(); }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string paid_from
        {
            get { return data.paid_from; }
            set { data.paid_from = value; }
        }

        public string paid_from_account_currency
        {
            get { return data.paid_from_account_currency; }
            set { data.paid_from_account_currency = value; }
        }

        public string paid_to
        {
            get { return data.paid_to; }
            set { data.paid_to = value; }
        }

        public string paid_to_account_currency
        {
            get { return data.paid_to_account_currency; }
            set { data.paid_to_account_currency = value; }
        }

        private double _paid_amount = 0.0;
        public double paid_amount
        {
            get { return data._paid_amount; }
            set { data._paid_amount = value; }
        }

        private double _source_exchange_rate = 0.0;
        public double source_exchange_rate
        {
            get { return data._source_exchange_rate; }
            set { data._source_exchange_rate = value; }
        }

        private double _base_paid_amount = 0.0;
        public double base_paid_amount
        {
            get { return data._base_paid_amount; }
            set { data._base_paid_amount = value; }
        }

        private double _received_amount = 0.0;
        public double received_amount
        {
            get { return data._received_amount; }
            set { data._received_amount = value; }
        }

        private double _target_exchange_rate = 0.0;
        public double target_exchange_rate
        {
            get { return data._target_exchange_rate; }
            set { data._target_exchange_rate = value; }
        }

        private double _base_received_amount = 0.0;
        public double base_received_amount
        {
            get { return data._base_received_amount; }
            set { data._base_received_amount = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
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

        public string party_name
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string contact_email
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        private double _party_balance = 0.0;
        public double party_balance
        {
            get { return data._party_balance; }
            set { data._party_balance = value; }
        }

        private double _paid_from_account_balance = 0.0;
        public double paid_from_account_balance
        {
            get { return data._paid_from_account_balance; }
            set { data._paid_from_account_balance = value; }
        }

        private double _paid_to_account_balance = 0.0;
        public double paid_to_account_balance
        {
            get { return data._paid_to_account_balance; }
            set { data._paid_to_account_balance = value; }
        }

        public string references
        {
            get { return data.references; }
            set { data.references = value; }
        }

        private double _total_allocated_amount = 0.0;
        public double total_allocated_amount
        {
            get { return data._total_allocated_amount; }
            set { data._total_allocated_amount = value; }
        }

        private double _base_total_allocated_amount = 0.0;
        public double base_total_allocated_amount
        {
            get { return data._base_total_allocated_amount; }
            set { data._base_total_allocated_amount = value; }
        }

        private double _unallocated_amount = 0.0;
        public double unallocated_amount
        {
            get { return data._unallocated_amount; }
            set { data._unallocated_amount = value; }
        }

        private double _difference_amount = 0.0;
        public double difference_amount
        {
            get { return data._difference_amount; }
            set { data._difference_amount = value; }
        }

        public string deductions
        {
            get { return data.deductions; }
            set { data.deductions = value; }
        }

        public string reference_no
        {
            get { return data.reference_no; }
            set { data.reference_no = value; }
        }

        public string reference_date
        {
            get { return data.reference_date; }
            set { data.reference_date = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string print_heading
        {
            get { return data.print_heading; }
            set { data.print_heading = value; }
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

        public string payment_order
        {
            get { return data.payment_order; }
            set { data.payment_order = value; }
        }

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public string party_bank_account
        {
            get { return data.party_bank_account; }
            set { data.party_bank_account = value; }
        }

        public Paymentorderstatus payment_order_status
        {
            get { return parseEnum<Paymentorderstatus>(data.payment_order_status); }
            set { data.payment_order_status = value.ToString(); }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }


    }

    //Enums go here
    public enum Paymenttype
    {
        [Description("Receive")]
        Receive,
        [Description("Pay")]
        Pay,
        [Description("Internal Transfer")]
        InternalTransfer,
    }

    public enum Paymentorderstatus
    {
        [Description("Initiated")]
        Initiated,
        [Description("Payment Ordered")]
        PaymentOrdered,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
    }


}