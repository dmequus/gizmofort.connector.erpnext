using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopping_cart_settings
{
    public class ERPShopping_cart_settings : ERPNextObjectBase
    {
        public ERPShopping_cart_settings() : this(new ERPObject(DocType.Shopping_cart_settings)) { }
        public ERPShopping_cart_settings(ERPObject obj) : base(obj) { }

        public static ERPShopping_cart_settings Create(int enabled, int showattachments, int showprice, int showstockavailability, int showconfigurebutton, int showcontactusbutton, int showquantityinwebsite, int showapplycouponcodeinwebsite, int allowitemsnotinstock, string company, string pricelist, string defaultcustomergroup, string quotationseries, int enablecheckout, Paymentsuccessurl paymentsuccessurl, string paymentgatewayaccount)

        {
            ERPShopping_cart_settings obj = new ERPShopping_cart_settings();
            obj.enabled = enabled;
            obj.show_attachments = showattachments;
            obj.show_price = showprice;
            obj.show_stock_availability = showstockavailability;
            obj.show_configure_button = showconfigurebutton;
            obj.show_contact_us_button = showcontactusbutton;
            obj.show_quantity_in_website = showquantityinwebsite;
            obj.show_apply_coupon_code_in_website = showapplycouponcodeinwebsite;
            obj.allow_items_not_in_stock = allowitemsnotinstock;
            obj.company = company;
            obj.price_list = pricelist;
            obj.default_customer_group = defaultcustomergroup;
            obj.quotation_series = quotationseries;
            obj.enable_checkout = enablecheckout;
            obj.payment_success_url = paymentsuccessurl;
            obj.payment_gateway_account = paymentgatewayaccount;
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        private int _show_attachments = 0;
        public int show_attachments
        {
            get { return data._show_attachments; }
            set { data._show_attachments = value; }
        }

        private int _show_price = 0;
        public int show_price
        {
            get { return data._show_price; }
            set { data._show_price = value; }
        }

        private int _show_stock_availability = 0;
        public int show_stock_availability
        {
            get { return data._show_stock_availability; }
            set { data._show_stock_availability = value; }
        }

        private int _show_configure_button = 0;
        public int show_configure_button
        {
            get { return data._show_configure_button; }
            set { data._show_configure_button = value; }
        }

        private int _show_contact_us_button = 0;
        public int show_contact_us_button
        {
            get { return data._show_contact_us_button; }
            set { data._show_contact_us_button = value; }
        }

        private int _show_quantity_in_website = 0;
        public int show_quantity_in_website
        {
            get { return data._show_quantity_in_website; }
            set { data._show_quantity_in_website = value; }
        }

        private int _show_apply_coupon_code_in_website = 0;
        public int show_apply_coupon_code_in_website
        {
            get { return data._show_apply_coupon_code_in_website; }
            set { data._show_apply_coupon_code_in_website = value; }
        }

        private int _allow_items_not_in_stock = 0;
        public int allow_items_not_in_stock
        {
            get { return data._allow_items_not_in_stock; }
            set { data._allow_items_not_in_stock = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        public string default_customer_group
        {
            get { return data.default_customer_group; }
            set { data.default_customer_group = value; }
        }

        public string quotation_series
        {
            get { return data.quotation_series; }
            set { data.quotation_series = value; }
        }

        private int _enable_checkout = 0;
        public int enable_checkout
        {
            get { return data._enable_checkout; }
            set { data._enable_checkout = value; }
        }

        public Paymentsuccessurl payment_success_url
        {
            get { return parseEnum<Paymentsuccessurl>(data.payment_success_url); }
            set { data.payment_success_url = value.ToString(); }
        }

        public string payment_gateway_account
        {
            get { return data.payment_gateway_account; }
            set { data.payment_gateway_account = value; }
        }


    }

    //Enums go here
    public enum Paymentsuccessurl
    {
        [Description("Orders")]
        Orders,
        [Description("Invoices")]
        Invoices,
        [Description("My Account")]
        MyAccount,
    }


}