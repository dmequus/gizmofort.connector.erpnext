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

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
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

        private int _invoice_separately_as_consumables = 0;
        public int invoice_separately_as_consumables
        {
            get { return data._invoice_separately_as_consumables; }
            set { data._invoice_separately_as_consumables = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
        }

        private double _transfer_qty = 0.0;
        public double transfer_qty
        {
            get { return data._transfer_qty; }
            set { data._transfer_qty = value; }
        }

        private double _actual_qty = 0.0;
        public double actual_qty
        {
            get { return data._actual_qty; }
            set { data._actual_qty = value; }
        }


    }

    //Enums go here

}