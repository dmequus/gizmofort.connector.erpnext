using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip_item
{
    public class ERPPacking_slip_item : ERPNextObjectBase
    {
        public ERPPacking_slip_item() : this(new ERPObject(DocType.Packing_slip_item)) { }
        public ERPPacking_slip_item(ERPObject obj) : base(obj) { }

        public static ERPPacking_slip_item Create(string itemcode, string itemname, string batchno, string description, double qty, double netweight, string stockuom, string weightuom, long pagebreak, string dndetail)

        {
            ERPPacking_slip_item obj = new ERPPacking_slip_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.batch_no = batchno;
            obj.description = description;
            obj.qty = qty;
            obj.net_weight = netweight;
            obj.stock_uom = stockuom;
            obj.weight_uom = weightuom;
            obj.page_break = pagebreak;
            obj.dn_detail = dndetail;
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

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
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

        public double net_weight
        {
            get { return data.net_weight; }
            set { data.net_weight = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string weight_uom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public string dn_detail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = value; }
        }


    }

    //Enums go here

}