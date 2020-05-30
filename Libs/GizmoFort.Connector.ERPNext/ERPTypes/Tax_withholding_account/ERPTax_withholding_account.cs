using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_account
{
    public class ERPTax_withholding_account : ERPNextObjectBase
    {
        public ERPTax_withholding_account() : this(new ERPObject(DocType.Tax_withholding_account)) { }
        public ERPTax_withholding_account(ERPObject obj) : base(obj) { }

        public static ERPTax_withholding_account Create(string company, string account)

        {
            ERPTax_withholding_account obj = new ERPTax_withholding_account();
            obj.company = company;
            obj.account = account;
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

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }


    }

    //Enums go here

}