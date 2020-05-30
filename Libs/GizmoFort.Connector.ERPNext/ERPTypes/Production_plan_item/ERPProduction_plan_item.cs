using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_item
{
    public class ERPProduction_plan_item : ERPNextObjectBase
    {
        public ERPProduction_plan_item() : this(new ERPObject(DocType.Production_plan_item)) { }
        public ERPProduction_plan_item(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan_item Create(long includeexplodeditems, string itemcode, string bomno, double plannedqty, long makeworkorderforsubassemblyitems, string warehouse, string plannedstartdate, double pendingqty, double orderedqty, double producedqty, string description, string stockuom, string salesorder, string salesorderitem, string materialrequest, string materialrequestitem, string productbundleitem)

        {
            ERPProduction_plan_item obj = new ERPProduction_plan_item();
            obj.include_exploded_items = includeexplodeditems;
            obj.item_code = itemcode;
            obj.bom_no = bomno;
            obj.planned_qty = plannedqty;
            obj.make_work_order_for_sub_assembly_items = makeworkorderforsubassemblyitems;
            obj.warehouse = warehouse;
            obj.planned_start_date = plannedstartdate;
            obj.pending_qty = pendingqty;
            obj.ordered_qty = orderedqty;
            obj.produced_qty = producedqty;
            obj.description = description;
            obj.stock_uom = stockuom;
            obj.sales_order = salesorder;
            obj.sales_order_item = salesorderitem;
            obj.material_request = materialrequest;
            obj.material_request_item = materialrequestitem;
            obj.product_bundle_item = productbundleitem;
            return obj;
        }

        public long include_exploded_items
        {
            get { return data.include_exploded_items; }
            set { data.include_exploded_items = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public double planned_qty
        {
            get { return data.planned_qty; }
            set { data.planned_qty = value; }
        }

        public long make_work_order_for_sub_assembly_items
        {
            get { return data.make_work_order_for_sub_assembly_items; }
            set { data.make_work_order_for_sub_assembly_items = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string planned_start_date
        {
            get { return data.planned_start_date; }
            set { data.planned_start_date = value; }
        }

        public double pending_qty
        {
            get { return data.pending_qty; }
            set { data.pending_qty = value; }
        }

        public double ordered_qty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        public double produced_qty
        {
            get { return data.produced_qty; }
            set { data.produced_qty = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
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

        public string product_bundle_item
        {
            get { return data.product_bundle_item; }
            set { data.product_bundle_item = value; }
        }


    }

    //Enums go here

}