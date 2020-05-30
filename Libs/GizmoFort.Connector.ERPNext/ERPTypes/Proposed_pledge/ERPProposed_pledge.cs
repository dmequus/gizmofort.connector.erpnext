using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Proposed_pledge
{
    public class ERPProposed_pledge : ERPNextObjectBase
    {
        public ERPProposed_pledge() : this(new ERPObject(DocType.Proposed_pledge)) { }
        public ERPProposed_pledge(ERPObject obj) : base(obj) { }

        public static ERPProposed_pledge Create()

        {
            ERPProposed_pledge obj = new ERPProposed_pledge();
            return obj;
        }

        public double loan_security_price
        {
            get { return data.loan_security_price; }
            set { data.loan_security_price = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string loan_security
        {
            get { return data.loan_security; }
            set { data.loan_security = value; }
        }

        public double post_haircut_amount
        {
            get { return data.post_haircut_amount; }
            set { data.post_haircut_amount = value; }
        }


    }

    //Enums go here

}