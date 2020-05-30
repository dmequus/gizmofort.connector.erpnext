using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_category
{
    public class ERPTax_withholding_category : ERPNextObjectBase
    {
        public ERPTax_withholding_category() : this(new ERPObject(DocType.Tax_withholding_category)) { }
        public ERPTax_withholding_category(ERPObject obj) : base(obj) { }

        public static ERPTax_withholding_category Create(string categoryname, string rates, string accounts)

        {
            ERPTax_withholding_category obj = new ERPTax_withholding_category();
            obj.category_name = categoryname;
            obj.rates = rates;
            obj.accounts = accounts;
            return obj;
        }

        public string category_name
        {
            get { return data.category_name; }
            set
            {
                data.category_name = value;
                data.name = value;
            }

        }

        public string rates
        {
            get { return data.rates; }
            set { data.rates = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }


    }

    //Enums go here

}