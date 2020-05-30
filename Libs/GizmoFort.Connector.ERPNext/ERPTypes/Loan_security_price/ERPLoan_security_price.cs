using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_price
{
    public class ERPLoan_security_price : ERPNextObjectBase
    {
        public ERPLoan_security_price() : this(new ERPObject(DocType.Loan_security_price)) { }
        public ERPLoan_security_price(ERPObject obj) : base(obj) { }

        public static ERPLoan_security_price Create(string loansecurity, double loansecurityprice, string validfrom, string validupto)

        {
            ERPLoan_security_price obj = new ERPLoan_security_price();
            obj.loan_security = loansecurity;
            obj.loan_security_price = loansecurityprice;
            obj.valid_from = validfrom;
            obj.valid_upto = validupto;
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

        private double _loan_security_price = 0.0;
        public double loan_security_price
        {
            get { return data._loan_security_price; }
            set { data._loan_security_price = value; }
        }

        public string valid_from
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        public string valid_upto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string loan_security_type
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }


    }

    //Enums go here

}