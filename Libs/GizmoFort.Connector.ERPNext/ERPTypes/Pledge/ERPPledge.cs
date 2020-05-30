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

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public double loan_security_price
        {
            get { return data.loan_security_price; }
            set { data.loan_security_price = value; }
        }

        public double haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double post_haircut_amount
        {
            get { return data.post_haircut_amount; }
            set { data.post_haircut_amount = value; }
        }


    }

    //Enums go here

}