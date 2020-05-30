using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Plaid_settings
{
    public class ERPPlaid_settings : ERPNextObjectBase
    {
        public ERPPlaid_settings() : this(new ERPObject(DocType.Plaid_settings)) { }
        public ERPPlaid_settings(ERPObject obj) : base(obj) { }

        public static ERPPlaid_settings Create()

        {
            ERPPlaid_settings obj = new ERPPlaid_settings();
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        private int _automatic_sync = 0;
        public int automatic_sync
        {
            get { return data._automatic_sync; }
            set { data._automatic_sync = value; }
        }

        public string plaid_client_id
        {
            get { return data.plaid_client_id; }
            set { data.plaid_client_id = value; }
        }

        public string plaid_secret
        {
            get { return data.plaid_secret; }
            set { data.plaid_secret = value; }
        }

        public string plaid_public_key
        {
            get { return data.plaid_public_key; }
            set { data.plaid_public_key = value; }
        }

        public Plaidenv plaid_env
        {
            get { return parseEnum<Plaidenv>(data.plaid_env); }
            set { data.plaid_env = value.ToString(); }
        }


    }

    //Enums go here
    public enum Plaidenv
    {
        [Description("sandbox")]
        sandbox,
        [Description("development")]
        development,
        [Description("production")]
        production,
    }


}