using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_item
{
    public class ERPClinical_procedure_item : ERPNextObjectBase
    {
        public ERPClinical_procedure_item() : this(new ERPObject(DocType.Clinical_procedure_item)) { }
        public ERPClinical_procedure_item(ERPObject obj) : base(obj) { }

        public static ERPClinical_procedure_item Create(string itemcode, double qty, string uom, string stockuom)

        {
            ERPClinical_procedure_item obj = new ERPClinical_procedure_item();
            obj.item_code = itemcode;
            obj.qty = qty;
            obj.uom = uom;
            obj.stock_uom = stockuom;
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

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public long invoice_separately_as_consumables
        {
            get { return data.invoice_separately_as_consumables; }
            set { data.invoice_separately_as_consumables = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public double transfer_qty
        {
            get { return data.transfer_qty; }
            set { data.transfer_qty = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }


    }

    //Enums go here

}