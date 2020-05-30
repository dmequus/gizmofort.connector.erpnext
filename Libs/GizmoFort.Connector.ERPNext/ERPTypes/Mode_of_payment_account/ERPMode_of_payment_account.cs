using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment_account
{
    public class ERPMode_of_payment_account : ERPNextObjectBase
    {
        public ERPMode_of_payment_account() : this(new ERPObject(DocType.Mode_of_payment_account)) { }
        public ERPMode_of_payment_account(ERPObject obj) : base(obj) { }

        public static ERPMode_of_payment_account Create(string company, string defaultaccount)

        {
            ERPMode_of_payment_account obj = new ERPMode_of_payment_account();
            obj.company = company;
            obj.default_account = defaultaccount;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string default_account
        {
            get { return data.default_account; }
            set { data.default_account = value; }
        }


    }

    //Enums go here

}