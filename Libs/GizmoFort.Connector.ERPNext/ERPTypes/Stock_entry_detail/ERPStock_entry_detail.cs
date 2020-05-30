using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_detail
{
    public class ERPStock_entry_detail : ERPNextObjectBase
    {
        public ERPStock_entry_detail() : this(new ERPObject(DocType.Stock_entry_detail)) { }
        public ERPStock_entry_detail(ERPObject obj) : base(obj) { }

        public static ERPStock_entry_detail Create(string itemcode, double qty, string uom, double conversionfactor, string stockuom, double transferqty)

        {
            ERPStock_entry_detail obj = new ERPStock_entry_detail();
            obj.item_code = itemcode;
            obj.qty = qty;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            obj.stock_uom = stockuom;
            obj.transfer_qty = transferqty;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public double transfer_qty
        {
            get { return data.transfer_qty; }
            set { data.transfer_qty = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string s_warehouse
        {
            get { return data.s_warehouse; }
            set { data.s_warehouse = value; }
        }

        public string t_warehouse
        {
            get { return data.t_warehouse; }
            set { data.t_warehouse = value; }
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

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string image_view
        {
            get { return data.image_view; }
            set { data.image_view = value; }
        }

        public double basic_rate
        {
            get { return data.basic_rate; }
            set { data.basic_rate = value; }
        }

        public double basic_amount
        {
            get { return data.basic_amount; }
            set { data.basic_amount = value; }
        }

        public double additional_cost
        {
            get { return data.additional_cost; }
            set { data.additional_cost = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public long retain_sample
        {
            get { return data.retain_sample; }
            set { data.retain_sample = value; }
        }

        public int sample_quantity
        {
            get { return data.sample_quantity; }
            set { data.sample_quantity = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string quality_inspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public long allow_zero_valuation_rate
        {
            get { return data.allow_zero_valuation_rate; }
            set { data.allow_zero_valuation_rate = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public long allow_alternative_item
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        public string material_request_item
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        public string original_item
        {
            get { return data.original_item; }
            set { data.original_item = value; }
        }

        public string subcontracted_item
        {
            get { return data.subcontracted_item; }
            set { data.subcontracted_item = value; }
        }

        public string against_stock_entry
        {
            get { return data.against_stock_entry; }
            set { data.against_stock_entry = value; }
        }

        public string ste_detail
        {
            get { return data.ste_detail; }
            set { data.ste_detail = value; }
        }

        public double transferred_qty
        {
            get { return data.transferred_qty; }
            set { data.transferred_qty = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string reference_purchase_receipt
        {
            get { return data.reference_purchase_receipt; }
            set { data.reference_purchase_receipt = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string po_detail
        {
            get { return data.po_detail; }
            set { data.po_detail = value; }
        }


    }

    //Enums go here

}