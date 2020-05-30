using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_type
{
    public class ERPBank_account_type : ERPNextObjectBase
    {
        public ERPBank_account_type() : this(new ERPObject(DocType.Bank_account_type)) { }
        public ERPBank_account_type(ERPObject obj) : base(obj) { }

        public static ERPBank_account_type Create()

        {
            ERPBank_account_type obj = new ERPBank_account_type();
            return obj;
        }

        public string account_type
        {
            get { return data.account_type; }
            set
            {
                data.account_type = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}