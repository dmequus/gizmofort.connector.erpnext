using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry
{
    public class ERPStock_entry : ERPNextObjectBase
    {
        public ERPStock_entry() : this(new ERPObject(DocType.Stock_entry)) { }
        public ERPStock_entry(ERPObject obj) : base(obj) { }

        public static ERPStock_entry Create(string title, string namingseries, string stockentrytype, string company, string items)

        {
            ERPStock_entry obj = new ERPStock_entry();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.stock_entry_type = stockentrytype;
            obj.company = company;
            obj.items = items;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string stock_entry_type
        {
            get { return data.stock_entry_type; }
            set { data.stock_entry_type = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string outgoing_stock_entry
        {
            get { return data.outgoing_stock_entry; }
            set { data.outgoing_stock_entry = value; }
        }

        public Purpose purpose
        {
            get { return parseEnum<Purpose>(data.purpose); }
            set { data.purpose = value.ToString(); }
        }

        public string work_order
        {
            get { return data.work_order; }
            set { data.work_order = value; }
        }

        public string purchase_order
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
        }

        public string delivery_note_no
        {
            get { return data.delivery_note_no; }
            set { data.delivery_note_no = value; }
        }

        public string sales_invoice_no
        {
            get { return data.sales_invoice_no; }
            set { data.sales_invoice_no = value; }
        }

        public string purchase_receipt_no
        {
            get { return data.purchase_receipt_no; }
            set { data.purchase_receipt_no = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        private int _seta_posting_time = 0;
        public int seta_posting_time
        {
            get { return data._seta_posting_time; }
            set { data._seta_posting_time = value; }
        }

        private int _inspection_required = 0;
        public int inspection_required
        {
            get { return data._inspection_required; }
            set { data._inspection_required = value; }
        }

        private int _from_bom = 0;
        public int from_bom
        {
            get { return data._from_bom; }
            set { data._from_bom = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        private double _fg_completed_qty = 0.0;
        public double fg_completed_qty
        {
            get { return data._fg_completed_qty; }
            set { data._fg_completed_qty = value; }
        }

        private int _use_multi_level_bom = 0;
        public int use_multi_level_bom
        {
            get { return data._use_multi_level_bom; }
            set { data._use_multi_level_bom = value; }
        }

        public string from_warehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }

        public string source_warehouse_address
        {
            get { return data.source_warehouse_address; }
            set { data.source_warehouse_address = value; }
        }

        public string source_address_display
        {
            get { return data.source_address_display; }
            set { data.source_address_display = value; }
        }

        public string to_warehouse
        {
            get { return data.to_warehouse; }
            set { data.to_warehouse = value; }
        }

        public string target_warehouse_address
        {
            get { return data.target_warehouse_address; }
            set { data.target_warehouse_address = value; }
        }

        public string target_address_display
        {
            get { return data.target_address_display; }
            set { data.target_address_display = value; }
        }

        public string scan_barcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        private double _total_incoming_value = 0.0;
        public double total_incoming_value
        {
            get { return data._total_incoming_value; }
            set { data._total_incoming_value = value; }
        }

        private double _total_outgoing_value = 0.0;
        public double total_outgoing_value
        {
            get { return data._total_outgoing_value; }
            set { data._total_outgoing_value = value; }
        }

        private double _value_difference = 0.0;
        public double value_difference
        {
            get { return data._value_difference; }
            set { data._value_difference = value; }
        }

        public string additional_costs
        {
            get { return data.additional_costs; }
            set { data.additional_costs = value; }
        }

        private double _total_additional_costs = 0.0;
        public double total_additional_costs
        {
            get { return data._total_additional_costs; }
            set { data._total_additional_costs = value; }
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

        public string supplier_address
        {
            get { return data.supplier_address; }
            set { data.supplier_address = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
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

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public Isopening is_opening
        {
            get { return parseEnum<Isopening>(data.is_opening); }
            set { data.is_opening = value.ToString(); }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        private double _per_transferred = 0.0;
        public double per_transferred
        {
            get { return data._per_transferred; }
            set { data._per_transferred = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        public string job_card
        {
            get { return data.job_card; }
            set { data.job_card = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string credit_note
        {
            get { return data.credit_note; }
            set { data.credit_note = value; }
        }

        public string pick_list
        {
            get { return data.pick_list; }
            set { data.pick_list = value; }
        }


    }

    //Enums go here
    public enum Purpose
    {
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Material Receipt")]
        MaterialReceipt,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Material Transfer for Manufacture")]
        MaterialTransferforManufacture,
        [Description("Material Consumption for Manufacture")]
        MaterialConsumptionforManufacture,
        [Description("Manufacture")]
        Manufacture,
        [Description("Repack")]
        Repack,
        [Description("Send to Subcontractor")]
        SendtoSubcontractor,
        [Description("Send to Warehouse")]
        SendtoWarehouse,
        [Description("Receive at Warehouse")]
        ReceiveatWarehouse,
    }

    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}