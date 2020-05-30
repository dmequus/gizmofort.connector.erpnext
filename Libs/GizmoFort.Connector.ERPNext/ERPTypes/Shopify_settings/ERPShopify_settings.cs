using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_settings
{
    public class ERPShopify_settings : ERPNextObjectBase
    {
        public ERPShopify_settings() : this(new ERPObject(DocType.Shopify_settings)) { }
        public ERPShopify_settings(ERPObject obj) : base(obj) { }

        public static ERPShopify_settings Create(string apptype, string shopifyurl)

        {
            ERPShopify_settings obj = new ERPShopify_settings();
            obj.app_type = apptype;
            obj.shopify_url = shopifyurl;
            return obj;
        }

        public string app_type
        {
            get { return data.app_type; }
            set
            {
                data.app_type = value;
                data.name = value;
            }

        }

        public string shopify_url
        {
            get { return data.shopify_url; }
            set { data.shopify_url = value; }
        }

        public string status_html
        {
            get { return data.status_html; }
            set { data.status_html = value; }
        }

        private int _enable_shopify = 0;
        public int enable_shopify
        {
            get { return data._enable_shopify; }
            set { data._enable_shopify = value; }
        }

        public string last_sync_datetime
        {
            get { return data.last_sync_datetime; }
            set { data.last_sync_datetime = value; }
        }

        public string api_key
        {
            get { return data.api_key; }
            set { data.api_key = value; }
        }

        public string password
        {
            get { return data.password; }
            set { data.password = value; }
        }

        public string shared_secret
        {
            get { return data.shared_secret; }
            set { data.shared_secret = value; }
        }

        public string access_token
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        public string webhooks
        {
            get { return data.webhooks; }
            set { data.webhooks = value; }
        }

        public string default_customer
        {
            get { return data.default_customer; }
            set { data.default_customer = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string cash_bank_account
        {
            get { return data.cash_bank_account; }
            set { data.cash_bank_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        private int _update_price_in_erpnext_price_list = 0;
        public int update_price_in_erpnext_price_list
        {
            get { return data._update_price_in_erpnext_price_list; }
            set { data._update_price_in_erpnext_price_list = value; }
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

        private int _sync_delivery_note = 0;
        public int sync_delivery_note
        {
            get { return data._sync_delivery_note; }
            set { data._sync_delivery_note = value; }
        }

        public string delivery_note_series
        {
            get { return data.delivery_note_series; }
            set { data.delivery_note_series = value; }
        }

        private int _sync_sales_invoice = 0;
        public int sync_sales_invoice
        {
            get { return data._sync_sales_invoice; }
            set { data._sync_sales_invoice = value; }
        }

        public string sales_invoice_series
        {
            get { return data.sales_invoice_series; }
            set { data.sales_invoice_series = value; }
        }

        public string html_16
        {
            get { return data.html_16; }
            set { data.html_16 = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }


    }

    //Enums go here

}