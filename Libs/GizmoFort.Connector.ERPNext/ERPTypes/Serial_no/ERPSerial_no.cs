using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Serial_no
{
    public class ERPSerial_no : ERPNextObjectBase
    {
        public ERPSerial_no() : this(new ERPObject(DocType.Serial_no)) { }
        public ERPSerial_no(ERPObject obj) : base(obj) { }

        public static ERPSerial_no Create(string serialno, string itemcode, string company)

        {
            ERPSerial_no obj = new ERPSerial_no();
            obj.serial_no = serialno;
            obj.item_code = itemcode;
            obj.company = company;
            return obj;
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set
            {
                data.serial_no = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string purchase_document_type
        {
            get { return data.purchase_document_type; }
            set { data.purchase_document_type = value; }
        }

        public string purchase_document_no
        {
            get { return data.purchase_document_no; }
            set { data.purchase_document_no = value; }
        }

        public string purchase_date
        {
            get { return data.purchase_date; }
            set { data.purchase_date = value; }
        }

        public string purchase_time
        {
            get { return data.purchase_time; }
            set { data.purchase_time = value; }
        }

        private double _purchase_rate = 0.0;
        public double purchase_rate
        {
            get { return data._purchase_rate; }
            set { data._purchase_rate = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        public string asset
        {
            get { return data.asset; }
            set { data.asset = value; }
        }

        public Assetstatus asset_status
        {
            get { return parseEnum<Assetstatus>(data.asset_status); }
            set { data.asset_status = value.ToString(); }
        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string delivery_document_type
        {
            get { return data.delivery_document_type; }
            set { data.delivery_document_type = value; }
        }

        public string delivery_document_no
        {
            get { return data.delivery_document_no; }
            set { data.delivery_document_no = value; }
        }

        public string delivery_date
        {
            get { return data.delivery_date; }
            set { data.delivery_date = value; }
        }

        public string delivery_time
        {
            get { return data.delivery_time; }
            set { data.delivery_time = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        public Maintenancestatus maintenance_status
        {
            get { return parseEnum<Maintenancestatus>(data.maintenance_status); }
            set { data.maintenance_status = value.ToString(); }
        }

        private int _warranty_period = 0;
        public int warranty_period
        {
            get { return data._warranty_period; }
            set { data._warranty_period = value; }
        }

        public string warranty_expiry_date
        {
            get { return data.warranty_expiry_date; }
            set { data.warranty_expiry_date = value; }
        }

        public string amc_expiry_date
        {
            get { return data.amc_expiry_date; }
            set { data.amc_expiry_date = value; }
        }

        public string serial_no_details
        {
            get { return data.serial_no_details; }
            set { data.serial_no_details = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }


    }

    //Enums go here
    public enum Assetstatus
    {
        [Description("Issue")]
        Issue,
        [Description("Receipt")]
        Receipt,
        [Description("Transfer")]
        Transfer,
    }

    public enum Maintenancestatus
    {
        [Description("Under Warranty")]
        UnderWarranty,
        [Description("Out of Warranty")]
        OutofWarranty,
        [Description("Under AMC")]
        UnderAMC,
        [Description("Out of AMC")]
        OutofAMC,
    }

    public enum Status
    {
        [Description("Active")]
        Active,
        [Description("Inactive")]
        Inactive,
        [Description("Delivered")]
        Delivered,
        [Description("Expired")]
        Expired,
    }


}