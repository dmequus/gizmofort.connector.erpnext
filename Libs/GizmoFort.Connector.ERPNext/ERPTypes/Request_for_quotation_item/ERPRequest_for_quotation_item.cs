using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_item
{
    public class ERPRequest_for_quotation_item : ERPNextObjectBase
    {
        public ERPRequest_for_quotation_item() : this(new ERPObject(DocType.Request_for_quotation_item)) { }
        public ERPRequest_for_quotation_item(ERPObject obj) : base(obj) { }

        public static ERPRequest_for_quotation_item Create(string itemcode, string description, double qty, string scheduledate, string uom)

        {
            ERPRequest_for_quotation_item obj = new ERPRequest_for_quotation_item();
            obj.item_code = itemcode;
            obj.description = description;
            obj.qty = qty;
            obj.schedule_date = scheduledate;
            obj.uom = uom;
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

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string supplier_part_no
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = value; }
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

        public string image_view
        {
            get { return data.image_view; }
            set { data.image_view = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string project_name
        {
            get { return data.project_name; }
            set { data.project_name = value; }
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

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }


    }

    //Enums go here

}