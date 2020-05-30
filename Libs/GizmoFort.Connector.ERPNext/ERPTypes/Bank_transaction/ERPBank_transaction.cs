using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction
{
    public class ERPBank_transaction : ERPNextObjectBase
    {
        public ERPBank_transaction() : this(new ERPObject(DocType.Bank_transaction)) { }
        public ERPBank_transaction(ERPObject obj) : base(obj) { }

        public static ERPBank_transaction Create(string bankaccount, string namingseries, string date, Status status, string company, double debit, double credit, string currency, string description, string referencenumber, string transactionid, string paymententries, double allocatedamount, string amendedfrom, double unallocatedamount)

        {
            ERPBank_transaction obj = new ERPBank_transaction();
            obj.bank_account = bankaccount;
            obj.naming_series = namingseries;
            obj.date = date;
            obj.status = status;
            obj.company = company;
            obj.debit = debit;
            obj.credit = credit;
            obj.currency = currency;
            obj.description = description;
            obj.reference_number = referencenumber;
            obj.transaction_id = transactionid;
            obj.payment_entries = paymententries;
            obj.allocated_amount = allocatedamount;
            obj.amended_from = amendedfrom;
            obj.unallocated_amount = unallocatedamount;
            return obj;
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set
            {
                data.bank_account = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private double _debit = 0.0;
        public double debit
        {
            get { return data._debit; }
            set { data._debit = value; }
        }

        private double _credit = 0.0;
        public double credit
        {
            get { return data._credit; }
            set { data._credit = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string reference_number
        {
            get { return data.reference_number; }
            set { data.reference_number = value; }
        }

        public string transaction_id
        {
            get { return data.transaction_id; }
            set { data.transaction_id = value; }
        }

        public string payment_entries
        {
            get { return data.payment_entries; }
            set { data.payment_entries = value; }
        }

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        private double _unallocated_amount = 0.0;
        public double unallocated_amount
        {
            get { return data._unallocated_amount; }
            set { data._unallocated_amount = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Pending")]
        Pending,
        [Description("Settled")]
        Settled,
        [Description("Unreconciled")]
        Unreconciled,
        [Description("Reconciled")]
        Reconciled,
    }


}