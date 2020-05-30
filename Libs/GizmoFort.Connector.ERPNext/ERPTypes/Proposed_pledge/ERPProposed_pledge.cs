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

        private double _loan_security_price = 0.0;
        public double loan_security_price
        {
            get { return data._loan_security_price; }
            set { data._loan_security_price = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private double _haircut = 0.0;
        public double haircut
        {
            get { return data._haircut; }
            set { data._haircut = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string loan_security
        {
            get { return data.loan_security; }
            set { data.loan_security = value; }
        }

        private double _post_haircut_amount = 0.0;
        public double post_haircut_amount
        {
            get { return data._post_haircut_amount; }
            set { data._post_haircut_amount = value; }
        }


    }

    //Enums go here

}