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

        public double credit_limit
        {
            get { return data.credit_limit; }
            set { data.credit_limit = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long bypass_credit_limit_check
        {
            get { return data.bypass_credit_limit_check; }
            set { data.bypass_credit_limit_check = value; }
        }


    }

    //Enums go here

}