using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pledge
{
    public class ERPPledge : ERPNextObjectBase
    {
        public ERPPledge() : this(new ERPObject(DocType.Pledge)) { }
        public ERPPledge(ERPObject obj) : base(obj) { }

        public static ERPPledge Create(string loansecurity)

        {
            ERPPledge obj = new ERPPledge();
            obj.loan_security = loansecurity;
            return obj;
        }

        public string loan_security
        {
            get { return data.loan_security; }
            set
            {
                data.loan_security = value;
                data.name = value;
            }

        }

        public string loan_security_type
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }

        public string loan_security_code
        {
            get { return data.loan_security_code; }
            set { data.loan_security_code = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private double _loan_security_price = 0.0;
        public double loan_security_price
        {
            get { return data._loan_security_price; }
            set { data._loan_security_price = value; }
        }

        private double _haircut = 0.0;
        public double haircut
        {
            get { return data._haircut; }
            set { data._haircut = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
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