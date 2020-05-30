using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_webhook_detail
{
    public class ERPShopify_webhook_detail : ERPNextObjectBase
    {
        public ERPShopify_webhook_detail() : this(new ERPObject(DocType.Shopify_webhook_detail)) { }
        public ERPShopify_webhook_detail(ERPObject obj) : base(obj) { }

        public static ERPShopify_webhook_detail Create(string webhookid, string method)

        {
            ERPShopify_webhook_detail obj = new ERPShopify_webhook_detail();
            obj.webhook_id = webhookid;
            obj.method = method;
            return obj;
        }

        public string webhook_id
        {
            get { return data.webhook_id; }
            set
            {
                data.webhook_id = value;
                data.name = value;
            }

        }

        public string method
        {
            get { return data.method; }
            set { data.method = value; }
        }


    }

    //Enums go here

}