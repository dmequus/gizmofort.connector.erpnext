using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopping_cart_settings
{
    public class ERPShopping_cart_settings : ERPNextObjectBase
    {
        public ERPShopping_cart_settings() : this(new ERPObject(DocType.Shopping_cart_settings)) { }
        public ERPShopping_cart_settings(ERPObject obj) : base(obj) { }

        public static ERPShopping_cart_settings Create(long enabled, long showattachments, long showprice, long showstockavailability, long showconfigurebutton, long showcontactusbutton, long showquantityinwebsite, long showapplycouponcodeinwebsite, long allowitemsnotinstock, string company, string pricelist, string defaultcustomergroup, string quotationseries, long enablecheckout, Paymentsuccessurl paymentsuccessurl, string paymentgatewayaccount)

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

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        public long show_attachments
        {
            get { return data.show_attachments; }
            set { data.show_attachments = value; }
        }

        public long show_price
        {
            get { return data.show_price; }
            set { data.show_price = value; }
        }

        public long show_stock_availability
        {
            get { return data.show_stock_availability; }
            set { data.show_stock_availability = value; }
        }

        public long show_configure_button
        {
            get { return data.show_configure_button; }
            set { data.show_configure_button = value; }
        }

        public long show_contact_us_button
        {
            get { return data.show_contact_us_button; }
            set { data.show_contact_us_button = value; }
        }

        public long show_quantity_in_website
        {
            get { return data.show_quantity_in_website; }
            set { data.show_quantity_in_website = value; }
        }

        public long show_apply_coupon_code_in_website
        {
            get { return data.show_apply_coupon_code_in_website; }
            set { data.show_apply_coupon_code_in_website = value; }
        }

        public long allow_items_not_in_stock
        {
            get { return data.allow_items_not_in_stock; }
            set { data.allow_items_not_in_stock = value; }
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

        public long enable_checkout
        {
            get { return data.enable_checkout; }
            set { data.enable_checkout = value; }
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