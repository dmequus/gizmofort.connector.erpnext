using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Batch
{
    public class ERPBatch : ERPNextObjectBase
    {
        public ERPBatch() : this(new ERPObject(DocType.Batch)) { }
        public ERPBatch(ERPObject obj) : base(obj) { }

        public static ERPBatch Create(string batchid, string item)

        {
            ERPBatch obj = new ERPBatch();
            obj.batch_id = batchid;
            obj.item = item;
            return obj;
        }

        public string batch_id
        {
            get { return data.batch_id; }
            set
            {
                data.batch_id = value;
                data.name = value;
            }

        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string parent_batch
        {
            get { return data.parent_batch; }
            set { data.parent_batch = value; }
        }

        public string manufacturing_date
        {
            get { return data.manufacturing_date; }
            set { data.manufacturing_date = value; }
        }

        public string expiry_date
        {
            get { return data.expiry_date; }
            set { data.expiry_date = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public double batch_qty
        {
            get { return data.batch_qty; }
            set { data.batch_qty = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }


    }

    //Enums go here

}