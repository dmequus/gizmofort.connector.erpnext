using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_item
{
    public class ERPLanded_cost_item : ERPNextObjectBase
    {
        public ERPLanded_cost_item() : this(new ERPObject(DocType.Landed_cost_item)) { }
        public ERPLanded_cost_item(ERPObject obj) : base(obj) { }

        public static ERPLanded_cost_item Create(string itemcode, string description, double amount)

        {
            ERPLanded_cost_item obj = new ERPLanded_cost_item();
            obj.item_code = itemcode;
            obj.description = description;
            obj.amount = amount;
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

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public Receiptdocumenttype receipt_document_type
        {
            get { return parseEnum<Receiptdocumenttype>(data.receipt_document_type); }
            set { data.receipt_document_type = value.ToString(); }
        }

        public string receipt_document
        {
            get { return data.receipt_document; }
            set { data.receipt_document = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _applicable_charges = 0.0;
        public double applicable_charges
        {
            get { return data._applicable_charges; }
            set { data._applicable_charges = value; }
        }

        public string purchase_receipt_item
        {
            get { return data.purchase_receipt_item; }
            set { data.purchase_receipt_item = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private int _is_fixed_asset = 0;
        public int is_fixed_asset
        {
            get { return data._is_fixed_asset; }
            set { data._is_fixed_asset = value; }
        }


    }

    //Enums go here
    public enum Receiptdocumenttype
    {
        [Description("Purchase Invoice")]
        PurchaseInvoice,
        [Description("Purchase Receipt")]
        PurchaseReceipt,
    }


}