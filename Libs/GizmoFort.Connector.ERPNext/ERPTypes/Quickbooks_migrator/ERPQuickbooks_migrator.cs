using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quickbooks_migrator
{
    public class ERPQuickbooks_migrator : ERPNextObjectBase
    {
        public ERPQuickbooks_migrator() : this(new ERPObject(DocType.Quickbooks_migrator)) { }
        public ERPQuickbooks_migrator(ERPObject obj) : base(obj) { }

        public static ERPQuickbooks_migrator Create(string clientid, string redirecturl, string tokenendpoint, string clientsecret, string scope, string apiendpoint, string authorizationendpoint, string authorizationurl)

        {
            ERPQuickbooks_migrator obj = new ERPQuickbooks_migrator();
            obj.client_id = clientid;
            obj.redirect_url = redirecturl;
            obj.token_endpoint = tokenendpoint;
            obj.client_secret = clientsecret;
            obj.scope = scope;
            obj.api_endpoint = apiendpoint;
            obj.authorization_endpoint = authorizationendpoint;
            obj.authorization_url = authorizationurl;
            return obj;
        }

        public string client_id
        {
            get { return data.client_id; }
            set
            {
                data.client_id = value;
                data.name = value;
            }

        }

        public string redirect_url
        {
            get { return data.redirect_url; }
            set { data.redirect_url = value; }
        }

        public string token_endpoint
        {
            get { return data.token_endpoint; }
            set { data.token_endpoint = value; }
        }

        public string client_secret
        {
            get { return data.client_secret; }
            set { data.client_secret = value; }
        }

        public string scope
        {
            get { return data.scope; }
            set { data.scope = value; }
        }

        public string api_endpoint
        {
            get { return data.api_endpoint; }
            set { data.api_endpoint = value; }
        }

        public string authorization_endpoint
        {
            get { return data.authorization_endpoint; }
            set { data.authorization_endpoint = value; }
        }

        public string authorization_url
        {
            get { return data.authorization_url; }
            set { data.authorization_url = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string refresh_token
        {
            get { return data.refresh_token; }
            set { data.refresh_token = value; }
        }

        public string code
        {
            get { return data.code; }
            set { data.code = value; }
        }

        public string access_token
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        public string quickbooks_company_id
        {
            get { return data.quickbooks_company_id; }
            set { data.quickbooks_company_id = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string default_shipping_account
        {
            get { return data.default_shipping_account; }
            set { data.default_shipping_account = value; }
        }

        public string default_warehouse
        {
            get { return data.default_warehouse; }
            set { data.default_warehouse = value; }
        }

        public string default_cost_center
        {
            get { return data.default_cost_center; }
            set { data.default_cost_center = value; }
        }

        public string undeposited_funds_account
        {
            get { return data.undeposited_funds_account; }
            set { data.undeposited_funds_account = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Connecting to QuickBooks")]
        ConnectingtoQuickBooks,
        [Description("Connected to QuickBooks")]
        ConnectedtoQuickBooks,
        [Description("In Progress")]
        InProgress,
        [Description("Complete")]
        Complete,
        [Description("Failed")]
        Failed,
    }


}