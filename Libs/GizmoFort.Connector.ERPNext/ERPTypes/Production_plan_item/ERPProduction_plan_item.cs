using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_item
{
    public class ERPProduction_plan_item : ERPNextObjectBase
    {
        public ERPProduction_plan_item() : this(new ERPObject(DocType.Production_plan_item)) { }
        public ERPProduction_plan_item(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan_item Create(int includeexplodeditems, string itemcode, string bomno, double plannedqty, int makeworkorderforsubassemblyitems, string warehouse, string plannedstartdate, double pendingqty, double orderedqty, double producedqty, string description, string stockuom, string salesorder, string salesorderitem, string materialrequest, string materialrequestitem, string productbundleitem)

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

        private int _include_exploded_items = 0;
        public int include_exploded_items
        {
            get { return data._include_exploded_items; }
            set { data._include_exploded_items = value; }
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

        private double _planned_qty = 0.0;
        public double planned_qty
        {
            get { return data._planned_qty; }
            set { data._planned_qty = value; }
        }

        private int _make_work_order_for_sub_assembly_items = 0;
        public int make_work_order_for_sub_assembly_items
        {
            get { return data._make_work_order_for_sub_assembly_items; }
            set { data._make_work_order_for_sub_assembly_items = value; }
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

        private double _pending_qty = 0.0;
        public double pending_qty
        {
            get { return data._pending_qty; }
            set { data._pending_qty = value; }
        }

        private double _ordered_qty = 0.0;
        public double ordered_qty
        {
            get { return data._ordered_qty; }
            set { data._ordered_qty = value; }
        }

        private double _produced_qty = 0.0;
        public double produced_qty
        {
            get { return data._produced_qty; }
            set { data._produced_qty = value; }
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