using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Woocommerce_settings
{
    public class ERPWoocommerce_settings : ERPNextObjectBase
    {
        public ERPWoocommerce_settings() : this(new ERPObject(DocType.Woocommerce_settings)) { }
        public ERPWoocommerce_settings(ERPObject obj) : base(obj) { }

        public static ERPWoocommerce_settings Create(string taxaccount, string fnfaccount, string creationuser, string company)

        {
            ERPWoocommerce_settings obj = new ERPWoocommerce_settings();
            obj.tax_account = taxaccount;
            obj.f_n_f_account = fnfaccount;
            obj.creation_user = creationuser;
            obj.company = company;
            return obj;
        }

        public string tax_account
        {
            get { return data.tax_account; }
            set
            {
                data.tax_account = value;
                data.name = value;
            }

        }

        public string f_n_f_account
        {
            get { return data.f_n_f_account; }
            set { data.f_n_f_account = value; }
        }

        public string creation_user
        {
            get { return data.creation_user; }
            set { data.creation_user = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long enable_sync
        {
            get { return data.enable_sync; }
            set { data.enable_sync = value; }
        }

        public string woocommerce_server_url
        {
            get { return data.woocommerce_server_url; }
            set { data.woocommerce_server_url = value; }
        }

        public string secret
        {
            get { return data.secret; }
            set { data.secret = value; }
        }

        public string api_consumer_key
        {
            get { return data.api_consumer_key; }
            set { data.api_consumer_key = value; }
        }

        public string api_consumer_secret
        {
            get { return data.api_consumer_secret; }
            set { data.api_consumer_secret = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string sales_order_series
        {
            get { return data.sales_order_series; }
            set { data.sales_order_series = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string endpoint
        {
            get { return data.endpoint; }
            set { data.endpoint = value; }
        }

        public int delivery_after_days
        {
            get { return data.delivery_after_days; }
            set { data.delivery_after_days = value; }
        }


    }

    //Enums go here

}