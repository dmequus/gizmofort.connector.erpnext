using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan
{
    public class ERPProduction_plan : ERPNextObjectBase
    {
        public ERPProduction_plan() : this(new ERPObject(DocType.Production_plan)) { }
        public ERPProduction_plan(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan Create(string namingseries, string company, string postingdate, string poitems)

        {
            ERPProduction_plan obj = new ERPProduction_plan();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.posting_date = postingdate;
            obj.po_items = poitems;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string po_items
        {
            get { return data.po_items; }
            set { data.po_items = value; }
        }

        public Getitemsfrom get_items_from
        {
            get { return parseEnum<Getitemsfrom>(data.get_items_from); }
            set { data.get_items_from = value.ToString(); }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string sales_orders
        {
            get { return data.sales_orders; }
            set { data.sales_orders = value; }
        }

        public string material_requests
        {
            get { return data.material_requests; }
            set { data.material_requests = value; }
        }

        public long include_non_stock_items
        {
            get { return data.include_non_stock_items; }
            set { data.include_non_stock_items = value; }
        }

        public long include_subcontracted_items
        {
            get { return data.include_subcontracted_items; }
            set { data.include_subcontracted_items = value; }
        }

        public long ignore_existing_ordered_qty
        {
            get { return data.ignore_existing_ordered_qty; }
            set { data.ignore_existing_ordered_qty = value; }
        }

        public string mr_items
        {
            get { return data.mr_items; }
            set { data.mr_items = value; }
        }

        public double total_planned_qty
        {
            get { return data.total_planned_qty; }
            set { data.total_planned_qty = value; }
        }

        public double total_produced_qty
        {
            get { return data.total_produced_qty; }
            set { data.total_produced_qty = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string for_warehouse
        {
            get { return data.for_warehouse; }
            set { data.for_warehouse = value; }
        }

        public string warehouses
        {
            get { return data.warehouses; }
            set { data.warehouses = value; }
        }


    }

    //Enums go here
    public enum Getitemsfrom
    {
        [Description("Sales Order")]
        SalesOrder,
        [Description("Material Request")]
        MaterialRequest,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Not Started")]
        NotStarted,
        [Description("In Process")]
        InProcess,
        [Description("Completed")]
        Completed,
        [Description("Stopped")]
        Stopped,
        [Description("Cancelled")]
        Cancelled,
        [Description("Material Requested")]
        MaterialRequested,
    }


}