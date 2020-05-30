using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_settings
{
    public class ERPGocardless_settings : ERPNextObjectBase
    {
        public ERPGocardless_settings() : this(new ERPObject(DocType.Gocardless_settings)) { }
        public ERPGocardless_settings(ERPObject obj) : base(obj) { }

        public static ERPGocardless_settings Create(string gatewayname, string accesstoken, string webhookssecret, long usesandbox)

        {
            ERPGocardless_settings obj = new ERPGocardless_settings();
            obj.gateway_name = gatewayname;
            obj.access_token = accesstoken;
            obj.webhooks_secret = webhookssecret;
            obj.use_sandbox = usesandbox;
            return obj;
        }

        public string gateway_name
        {
            get { return data.gateway_name; }
            set
            {
                data.gateway_name = value;
                data.name = value;
            }

        }

        public string access_token
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        public string webhooks_secret
        {
            get { return data.webhooks_secret; }
            set { data.webhooks_secret = value; }
        }

        public long use_sandbox
        {
            get { return data.use_sandbox; }
            set { data.use_sandbox = value; }
        }


    }

    //Enums go here

}