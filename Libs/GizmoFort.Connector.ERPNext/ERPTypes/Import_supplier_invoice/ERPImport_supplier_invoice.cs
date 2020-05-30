using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Import_supplier_invoice
{
    public class ERPImport_supplier_invoice : ERPNextObjectBase
    {
        public ERPImport_supplier_invoice() : this(new ERPObject(DocType.Import_supplier_invoice)) { }
        public ERPImport_supplier_invoice(ERPObject obj) : base(obj) { }

        public static ERPImport_supplier_invoice Create(string company, string itemcode, string suppliergroup, string taxaccount, string invoiceseries, string defaultbuyingpricelist)

        {
            ERPImport_supplier_invoice obj = new ERPImport_supplier_invoice();
            obj.company = company;
            obj.item_code = itemcode;
            obj.supplier_group = suppliergroup;
            obj.tax_account = taxaccount;
            obj.invoice_series = invoiceseries;
            obj.default_buying_price_list = defaultbuyingpricelist;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string supplier_group
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        public string tax_account
        {
            get { return data.tax_account; }
            set { data.tax_account = value; }
        }

        public string invoice_series
        {
            get { return data.invoice_series; }
            set { data.invoice_series = value; }
        }

        public string default_buying_price_list
        {
            get { return data.default_buying_price_list; }
            set { data.default_buying_price_list = value; }
        }

        public string zip_file
        {
            get { return data.zip_file; }
            set { data.zip_file = value; }
        }

        public string status
        {
            get { return data.status; }
            set { data.status = value; }
        }


    }

    //Enums go here

}