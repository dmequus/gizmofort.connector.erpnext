using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_balance
{
    public class ERPShare_balance : ERPNextObjectBase
    {
        public ERPShare_balance() : this(new ERPObject(DocType.Share_balance)) { }
        public ERPShare_balance(ERPObject obj) : base(obj) { }

        public static ERPShare_balance Create(string sharetype, int fromno, int rate, int noofshares, int tono, int amount, long iscompany, Currentstate currentstate)

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

        public int from_no
        {
            get { return data.from_no; }
            set { data.from_no = value; }
        }

        public int rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public int no_of_shares
        {
            get { return data.no_of_shares; }
            set { data.no_of_shares = value; }
        }

        public int to_no
        {
            get { return data.to_no; }
            set { data.to_no = value; }
        }

        public int amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public long is_company
        {
            get { return data.is_company; }
            set { data.is_company = value; }
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