using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_balance
{
    public class ERPShare_balance : ERPNextObjectBase
    {
        public ERPShare_balance() : this(new ERPObject(DocType.Share_balance)) { }
        public ERPShare_balance(ERPObject obj) : base(obj) { }

        public static ERPShare_balance Create(string sharetype, int fromno, int rate, int noofshares, int tono, int amount, int iscompany, Currentstate currentstate)

        {
            ERPShare_balance obj = new ERPShare_balance();
            obj.share_type = sharetype;
            obj.from_no = fromno;
            obj.rate = rate;
            obj.no_of_shares = noofshares;
            obj.to_no = tono;
            obj.amount = amount;
            obj.is_company = iscompany;
            obj.current_state = currentstate;
            return obj;
        }

        public string share_type
        {
            get { return data.share_type; }
            set
            {
                data.share_type = value;
                data.name = value;
            }

        }

        private int _from_no = 0;
        public int from_no
        {
            get { return data._from_no; }
            set { data._from_no = value; }
        }

        private int _rate = 0;
        public int rate
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

        private int _amount = 0;
        public int amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private int _is_company = 0;
        public int is_company
        {
            get { return data._is_company; }
            set { data._is_company = value; }
        }

        public Currentstate current_state
        {
            get { return parseEnum<Currentstate>(data.current_state); }
            set { data.current_state = value.ToString(); }
        }


    }

    //Enums go here
    public enum Currentstate
    {
        [Description("Issued")]
        Issued,
        [Description("Purchased")]
        Purchased,
    }


}