using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Material_request_plan_item
{
    public class ERPMaterial_request_plan_item : ERPNextObjectBase
    {
        public ERPMaterial_request_plan_item() : this(new ERPObject(DocType.Material_request_plan_item)) { }
        public ERPMaterial_request_plan_item(ERPObject obj) : base(obj) { }

        public static ERPMaterial_request_plan_item Create(string itemcode, string warehouse, double quantity)

        {
            ERPMaterial_request_plan_item obj = new ERPMaterial_request_plan_item();
            obj.item_code = itemcode;
            obj.warehouse = warehouse;
            obj.quantity = quantity;
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public double quantity
        {
            get { return data.quantity; }
            set { data.quantity = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public Materialrequesttype material_request_type
        {
            get { return parseEnum<Materialrequesttype>(data.material_request_type); }
            set { data.material_request_type = value.ToString(); }
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

        public double min_order_qty
        {
            get { return data.min_order_qty; }
            set { data.min_order_qty = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public double requested_qty
        {
            get { return data.requested_qty; }
            set { data.requested_qty = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string from_warehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }


    }

    //Enums go here
    public enum Materialrequesttype
    {
        [Description("Purchase")]
        Purchase,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Manufacture")]
        Manufacture,
        [Description("Customer Provided")]
        CustomerProvided,
    }


}