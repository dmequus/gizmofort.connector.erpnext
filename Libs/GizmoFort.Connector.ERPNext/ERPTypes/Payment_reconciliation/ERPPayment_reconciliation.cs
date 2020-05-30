using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation
{
    public class ERPPayment_reconciliation : ERPNextObjectBase
    {
        public ERPPayment_reconciliation() : this(new ERPObject(DocType.Payment_reconciliation)) { }
        public ERPPayment_reconciliation(ERPObject obj) : base(obj) { }

        public static ERPPayment_reconciliation Create(string company, string partytype, string party, string receivablepayableaccount, string bankcashaccount, string fromdate, string todate, double minimumamount, double maximumamount, int limit, string payments, string invoices)

        {
            ERPPayment_reconciliation obj = new ERPPayment_reconciliation();
            obj.company = company;
            obj.party_type = partytype;
            obj.party = party;
            obj.receivable_payable_account = receivablepayableaccount;
            obj.bank_cash_account = bankcashaccount;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.minimum_amount = minimumamount;
            obj.maximum_amount = maximumamount;
            obj.limit = limit;
            obj.payments = payments;
            obj.invoices = invoices;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

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

        public string receivable_payable_account
        {
            get { return data.receivable_payable_account; }
            set { data.receivable_payable_account = value; }
        }

        public string bank_cash_account
        {
            get { return data.bank_cash_account; }
            set { data.bank_cash_account = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        private double _minimum_amount = 0.0;
        public double minimum_amount
        {
            get { return data._minimum_amount; }
            set { data._minimum_amount = value; }
        }

        private double _maximum_amount = 0.0;
        public double maximum_amount
        {
            get { return data._maximum_amount; }
            set { data._maximum_amount = value; }
        }

        private int _limit = 0;
        public int limit
        {
            get { return data._limit; }
            set { data._limit = value; }
        }

        public string payments
        {
            get { return data.payments; }
            set { data.payments = value; }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
        }


    }

    //Enums go here

}