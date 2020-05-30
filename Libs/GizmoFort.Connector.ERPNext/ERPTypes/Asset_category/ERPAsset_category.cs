using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_category
{
    public class ERPAsset_category : ERPNextObjectBase
    {
        public ERPAsset_category() : this(new ERPObject(DocType.Asset_category)) { }
        public ERPAsset_category(ERPObject obj) : base(obj) { }

        public static ERPAsset_category Create(string assetcategoryname, string accounts)

        {
            ERPAsset_category obj = new ERPAsset_category();
            obj.asset_category_name = assetcategoryname;
            obj.accounts = accounts;
            return obj;
        }

        public string asset_category_name
        {
            get { return data.asset_category_name; }
            set
            {
                data.asset_category_name = value;
                data.name = value;
            }

        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string finance_books
        {
            get { return data.finance_books; }
            set { data.finance_books = value; }
        }

        private int _enable_cwip_accounting = 0;
        public int enable_cwip_accounting
        {
            get { return data._enable_cwip_accounting; }
            set { data._enable_cwip_accounting = value; }
        }


    }

    //Enums go here

}