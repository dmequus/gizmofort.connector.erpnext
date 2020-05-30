using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer_credit_limit
{
    public class ERPCustomer_credit_limit : ERPNextObjectBase
    {
        public ERPCustomer_credit_limit() : this(new ERPObject(DocType.Customer_credit_limit)) { }
        public ERPCustomer_credit_limit(ERPObject obj) : base(obj) { }

        public static ERPCustomer_credit_limit Create()

        {
            ERPCustomer_credit_limit obj = new ERPCustomer_credit_limit();
            return obj;
        }

        private double _credit_limit = 0.0;
        public double credit_limit
        {
            get { return data._credit_limit; }
            set { data._credit_limit = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private int _bypass_credit_limit_check = 0;
        public int bypass_credit_limit_check
        {
            get { return data._bypass_credit_limit_check; }
            set { data._bypass_credit_limit_check = value; }
        }


    }

    //Enums go here

}