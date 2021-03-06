using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Material_request_item
{
    public class ERPMaterial_request_item : ERPNextObjectBase
    {
        public ERPMaterial_request_item() : this(new ERPObject(DocType.Material_request_item)) { }
        public ERPMaterial_request_item(ERPObject obj) : base(obj) { }

        public static ERPMaterial_request_item Create(string itemcode, string description, double qty, string uom, double conversionfactor, string stockuom, string scheduledate)

        {
            ERPMaterial_request_item obj = new ERPMaterial_request_item();
            obj.item_code = itemcode;
            obj.description = description;
            obj.qty = qty;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            obj.stock_uom = stockuom;
            obj.schedule_date = scheduledate;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
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

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
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

        public string lead_time_date
        {
            get { return data.lead_time_date; }
            set { data.lead_time_date = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string sales_order_item
        {
            get { return data.sales_order_item; }
            set { data.sales_order_item = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string production_plan
        {
            get { return data.production_plan; }
            set { data.production_plan = value; }
        }

        public string material_request_plan_item
        {
            get { return data.material_request_plan_item; }
            set { data.material_request_plan_item = value; }
        }

        public double min_order_qty
        {
            get { return data.min_order_qty; }
            set { data.min_order_qty = value; }
        }

        public double projected_qty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public double ordered_qty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
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

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public double received_qty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        public string manufacturer
        {
            get { return data.manufacturer; }
            set { data.manufacturer = value; }
        }

        public string manufacturer_part_no
        {
            get { return data.manufacturer_part_no; }
            set { data.manufacturer_part_no = value; }
        }

        public string from_warehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }


    }

    //Enums go here

}