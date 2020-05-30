using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_purchase_receipt
{
    public class ERPLanded_cost_purchase_receipt : ERPNextObjectBase
    {
        public ERPLanded_cost_purchase_receipt() : this(new ERPObject(DocType.Landed_cost_purchase_receipt)) { }
        public ERPLanded_cost_purchase_receipt(ERPObject obj) : base(obj) { }

        public static ERPLanded_cost_purchase_receipt Create(Receiptdocumenttype receiptdocumenttype, string receiptdocument, string supplier, string postingdate, double grandtotal)

        {
            ERPLanded_cost_purchase_receipt obj = new ERPLanded_cost_purchase_receipt();
            obj.receipt_document_type = receiptdocumenttype;
            obj.receipt_document = receiptdocument;
            obj.supplier = supplier;
            obj.posting_date = postingdate;
            obj.grand_total = grandtotal;
            return obj;
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

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
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