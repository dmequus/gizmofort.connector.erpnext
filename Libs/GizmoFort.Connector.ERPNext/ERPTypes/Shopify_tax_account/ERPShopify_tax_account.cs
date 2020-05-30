using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_tax_account
{
    public class ERPShopify_tax_account : ERPNextObjectBase
    {
        public ERPShopify_tax_account() : this(new ERPObject(DocType.Shopify_tax_account)) { }
        public ERPShopify_tax_account(ERPObject obj) : base(obj) { }

        public static ERPShopify_tax_account Create(string shopifytax, string taxaccount)

        {
            ERPShopify_tax_account obj = new ERPShopify_tax_account();
            obj.shopify_tax = shopifytax;
            obj.tax_account = taxaccount;
            return obj;
        }

        public string shopify_tax
        {
            get { return data.shopify_tax; }
            set
            {
                data.shopify_tax = value;
                data.name = value;
            }

        }

        public string tax_account
        {
            get { return data.tax_account; }
            set { data.tax_account = value; }
        }


    }

    //Enums go here

}