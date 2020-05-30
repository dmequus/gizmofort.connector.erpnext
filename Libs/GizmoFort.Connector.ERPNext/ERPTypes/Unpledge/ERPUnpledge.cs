using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Unpledge
{
    public class ERPUnpledge : ERPNextObjectBase
    {
        public ERPUnpledge() : this(new ERPObject(DocType.Unpledge)) { }
        public ERPUnpledge(ERPObject obj) : base(obj) { }

        public static ERPUnpledge Create(string loansecurity, double qty)

        {
            ERPUnpledge obj = new ERPUnpledge();
            obj.loan_security = loansecurity;
            obj.qty = qty;
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

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
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

        public double haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }


    }

    //Enums go here

}