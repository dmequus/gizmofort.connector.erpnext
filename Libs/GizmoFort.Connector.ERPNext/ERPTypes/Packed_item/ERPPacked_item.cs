using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Packed_item
{
    public class ERPPacked_item : ERPNextObjectBase
    {
        public ERPPacked_item() : this(new ERPObject(DocType.Packed_item)) { }
        public ERPPacked_item(ERPObject obj) : base(obj) { }

        public static ERPPacked_item Create()

        {
            ERPPacked_item obj = new ERPPacked_item();
            return obj;
        }

        public string parent_item
        {
            get { return data.parent_item; }
            set
            {
                data.parent_item = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
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

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string target_warehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
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

        private double _actual_qty = 0.0;
        public double actual_qty
        {
            get { return data._actual_qty; }
            set { data._actual_qty = value; }
        }

        private double _projected_qty = 0.0;
        public double projected_qty
        {
            get { return data._projected_qty; }
            set { data._projected_qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private int _page_break = 0;
        public int page_break
        {
            get { return data._page_break; }
            set { data._page_break = value; }
        }

        public string prevdoc_doctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = value; }
        }

        public string parent_detail_docname
        {
            get { return data.parent_detail_docname; }
            set { data.parent_detail_docname = value; }
        }

        private double _actual_batch_qty = 0.0;
        public double actual_batch_qty
        {
            get { return data._actual_batch_qty; }
            set { data._actual_batch_qty = value; }
        }


    }

    //Enums go here

}