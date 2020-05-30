using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_transfer
{
    public class ERPShare_transfer : ERPNextObjectBase
    {
        public ERPShare_transfer() : this(new ERPObject(DocType.Share_transfer)) { }
        public ERPShare_transfer(ERPObject obj) : base(obj) { }

        public static ERPShare_transfer Create(Transfertype transfertype, string date, string equityorliabilityaccount, string sharetype, int fromno, double rate, int noofshares, int tono, string company)

        {
            ERPShare_transfer obj = new ERPShare_transfer();
            obj.transfer_type = transfertype;
            obj.date = date;
            obj.equity_or_liability_account = equityorliabilityaccount;
            obj.share_type = sharetype;
            obj.from_no = fromno;
            obj.rate = rate;
            obj.no_of_shares = noofshares;
            obj.to_no = tono;
            obj.company = company;
            return obj;
        }

        public Transfertype transfer_type
        {
            get { return parseEnum<Transfertype>(data.transfer_type); }
            set { data.transfer_type = value.ToString(); }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string equity_or_liability_account
        {
            get { return data.equity_or_liability_account; }
            set { data.equity_or_liability_account = value; }
        }

        public string share_type
        {
            get { return data.share_type; }
            set { data.share_type = value; }
        }

        private int _from_no = 0;
        public int from_no
        {
            get { return data._from_no; }
            set { data._from_no = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private int _no_of_shares = 0;
        public int no_of_shares
        {
            get { return data._no_of_shares; }
            set { data._no_of_shares = value; }
        }

        private int _to_no = 0;
        public int to_no
        {
            get { return data._to_no; }
            set { data._to_no = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string from_shareholder
        {
            get { return data.from_shareholder; }
            set { data.from_shareholder = value; }
        }

        public string from_folio_no
        {
            get { return data.from_folio_no; }
            set { data.from_folio_no = value; }
        }

        public string asset_account
        {
            get { return data.asset_account; }
            set { data.asset_account = value; }
        }

        public string to_shareholder
        {
            get { return data.to_shareholder; }
            set { data.to_shareholder = value; }
        }

        public string to_folio_no
        {
            get { return data.to_folio_no; }
            set { data.to_folio_no = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Transfertype
    {
        [Description("Issue")]
        Issue,
        [Description("Purchase")]
        Purchase,
        [Description("Transfer")]
        Transfer,
    }


}