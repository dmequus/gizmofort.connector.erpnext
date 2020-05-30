using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier
{
    public class ERPSupplier : ERPNextObjectBase
    {
        public ERPSupplier() : this(new ERPObject(DocType.Supplier)) { }
        public ERPSupplier(ERPObject obj) : base(obj) { }

        public static ERPSupplier Create(string suppliername, string suppliergroup, Suppliertype suppliertype)

        {
            ERPSupplier obj = new ERPSupplier();
            obj.supplier_name = suppliername;
            obj.supplier_group = suppliergroup;
            obj.supplier_type = suppliertype;
            return obj;
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set
            {
                data.supplier_name = value;
                data.name = value;
            }

        }

        public string supplier_group
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        public Suppliertype supplier_type
        {
            get { return parseEnum<Suppliertype>(data.supplier_type); }
            set { data.supplier_type = value.ToString(); }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string default_bank_account
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string tax_withholding_category
        {
            get { return data.tax_withholding_category; }
            set { data.tax_withholding_category = value; }
        }

        private int _is_transporter = 0;
        public int is_transporter
        {
            get { return data._is_transporter; }
            set { data._is_transporter = value; }
        }

        private int _is_internal_supplier = 0;
        public int is_internal_supplier
        {
            get { return data._is_internal_supplier; }
            set { data._is_internal_supplier = value; }
        }

        public string represents_company
        {
            get { return data.represents_company; }
            set { data.represents_company = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string pan
        {
            get { return data.pan; }
            set { data.pan = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        private int _warn_rfqs = 0;
        public int warn_rfqs
        {
            get { return data._warn_rfqs; }
            set { data._warn_rfqs = value; }
        }

        private int _warn_pos = 0;
        public int warn_pos
        {
            get { return data._warn_pos; }
            set { data._warn_pos = value; }
        }

        private int _prevent_rfqs = 0;
        public int prevent_rfqs
        {
            get { return data._prevent_rfqs; }
            set { data._prevent_rfqs = value; }
        }

        private int _prevent_pos = 0;
        public int prevent_pos
        {
            get { return data._prevent_pos; }
            set { data._prevent_pos = value; }
        }

        public string companies
        {
            get { return data.companies; }
            set { data.companies = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        private int _on_hold = 0;
        public int on_hold
        {
            get { return data._on_hold; }
            set { data._on_hold = value; }
        }

        public Holdtype hold_type
        {
            get { return parseEnum<Holdtype>(data.hold_type); }
            set { data.hold_type = value.ToString(); }
        }

        public string release_date
        {
            get { return data.release_date; }
            set { data.release_date = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string supplier_details
        {
            get { return data.supplier_details; }
            set { data.supplier_details = value; }
        }

        private int _is_frozen = 0;
        public int is_frozen
        {
            get { return data._is_frozen; }
            set { data._is_frozen = value; }
        }

        private int _allow_purchase_invoice_creation_without_purchase_order = 0;
        public int allow_purchase_invoice_creation_without_purchase_order
        {
            get { return data._allow_purchase_invoice_creation_without_purchase_order; }
            set { data._allow_purchase_invoice_creation_without_purchase_order = value; }
        }

        private int _allow_purchase_invoice_creation_without_purchase_receipt = 0;
        public int allow_purchase_invoice_creation_without_purchase_receipt
        {
            get { return data._allow_purchase_invoice_creation_without_purchase_receipt; }
            set { data._allow_purchase_invoice_creation_without_purchase_receipt = value; }
        }


    }

    //Enums go here
    public enum Suppliertype
    {
        [Description("Company")]
        Company,
        [Description("Individual")]
        Individual,
    }

    public enum Holdtype
    {
        [Description("All")]
        All,
        [Description("Invoices")]
        Invoices,
        [Description("Payments")]
        Payments,
    }


}