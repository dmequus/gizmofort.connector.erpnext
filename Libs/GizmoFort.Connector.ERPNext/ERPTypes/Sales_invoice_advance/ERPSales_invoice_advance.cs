using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_advance
{
    public class ERPSales_invoice_advance : ERPNextObjectBase
    {
        public ERPSales_invoice_advance() : this(new ERPObject(DocType.Sales_invoice_advance)) { }
        public ERPSales_invoice_advance(ERPObject obj) : base(obj) { }

        public static ERPSales_invoice_advance Create(string referencetype, string referencename, string remarks, string referencerow, double advanceamount, double allocatedamount)

        {
            ERPSales_invoice_advance obj = new ERPSales_invoice_advance();
            obj.reference_type = referencetype;
            obj.reference_name = referencename;
            obj.remarks = remarks;
            obj.reference_row = referencerow;
            obj.advance_amount = advanceamount;
            obj.allocated_amount = allocatedamount;
            return obj;
        }

        public string reference_type
        {
            get { return data.reference_type; }
            set
            {
                data.reference_type = value;
                data.name = value;
            }

        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string reference_row
        {
            get { return data.reference_row; }
            set { data.reference_row = value; }
        }

        public double advance_amount
        {
            get { return data.advance_amount; }
            set { data.advance_amount = value; }
        }

        public double allocated_amount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }


    }

    //Enums go here

}