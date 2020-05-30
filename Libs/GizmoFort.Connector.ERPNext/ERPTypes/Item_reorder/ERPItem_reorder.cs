using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_reorder
{
    public class ERPItem_reorder : ERPNextObjectBase
    {
        public ERPItem_reorder() : this(new ERPObject(DocType.Item_reorder)) { }
        public ERPItem_reorder(ERPObject obj) : base(obj) { }

        public static ERPItem_reorder Create(string warehousegroup, string warehouse, double warehousereorderlevel, double warehousereorderqty, Materialrequesttype materialrequesttype)

        {
            ERPItem_reorder obj = new ERPItem_reorder();
            obj.warehouse_group = warehousegroup;
            obj.warehouse = warehouse;
            obj.warehouse_reorder_level = warehousereorderlevel;
            obj.warehouse_reorder_qty = warehousereorderqty;
            obj.material_request_type = materialrequesttype;
            return obj;
        }

        public string warehouse_group
        {
            get { return data.warehouse_group; }
            set
            {
                data.warehouse_group = value;
                data.name = value;
            }

        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        private double _warehouse_reorder_level = 0.0;
        public double warehouse_reorder_level
        {
            get { return data._warehouse_reorder_level; }
            set { data._warehouse_reorder_level = value; }
        }

        private double _warehouse_reorder_qty = 0.0;
        public double warehouse_reorder_qty
        {
            get { return data._warehouse_reorder_qty; }
            set { data._warehouse_reorder_qty = value; }
        }

        public Materialrequesttype material_request_type
        {
            get { return parseEnum<Materialrequesttype>(data.material_request_type); }
            set { data.material_request_type = value.ToString(); }
        }


    }

    //Enums go here
    public enum Materialrequesttype
    {
        [Description("Purchase")]
        Purchase,
        [Description("Transfer")]
        Transfer,
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Manufacture")]
        Manufacture,
    }


}