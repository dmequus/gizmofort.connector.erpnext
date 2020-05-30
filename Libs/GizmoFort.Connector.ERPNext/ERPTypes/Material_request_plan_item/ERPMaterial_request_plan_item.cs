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

        private double _quantity = 0.0;
        public double quantity
        {
            get { return data._quantity; }
            set { data._quantity = value; }
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

        private double _projected_qty = 0.0;
        public double projected_qty
        {
            get { return data._projected_qty; }
            set { data._projected_qty = value; }
        }

        private double _actual_qty = 0.0;
        public double actual_qty
        {
            get { return data._actual_qty; }
            set { data._actual_qty = value; }
        }

        private double _min_order_qty = 0.0;
        public double min_order_qty
        {
            get { return data._min_order_qty; }
            set { data._min_order_qty = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        private double _requested_qty = 0.0;
        public double requested_qty
        {
            get { return data._requested_qty; }
            set { data._requested_qty = value; }
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