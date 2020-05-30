using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_subtype
{
    public class ERPBank_account_subtype : ERPNextObjectBase
    {
        public ERPBank_account_subtype() : this(new ERPObject(DocType.Bank_account_subtype)) { }
        public ERPBank_account_subtype(ERPObject obj) : base(obj) { }

        public static ERPBank_account_subtype Create(string accountsubtype)

        {
            ERPBank_account_subtype obj = new ERPBank_account_subtype();
            obj.account_subtype = accountsubtype;
            return obj;
        }

        public string account_subtype
        {
            get { return data.account_subtype; }
            set
            {
                data.account_subtype = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}