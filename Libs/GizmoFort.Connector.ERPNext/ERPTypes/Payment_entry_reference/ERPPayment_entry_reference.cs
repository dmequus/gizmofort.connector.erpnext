using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_reference
{
    public class ERPPayment_entry_reference : ERPNextObjectBase
    {
        public ERPPayment_entry_reference() : this(new ERPObject(DocType.Payment_entry_reference)) { }
        public ERPPayment_entry_reference(ERPObject obj) : base(obj) { }

        public static ERPPayment_entry_reference Create(string referencedoctype, string referencename)

        {
            ERPPayment_entry_reference obj = new ERPPayment_entry_reference();
            obj.reference_doctype = referencedoctype;
            obj.reference_name = referencename;
            return obj;
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set
            {
                data.reference_doctype = value;
                data.name = value;
            }

        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string bill_no
        {
            get { return data.bill_no; }
            set { data.bill_no = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        private double _outstanding_amount = 0.0;
        public double outstanding_amount
        {
            get { return data._outstanding_amount; }
            set { data._outstanding_amount = value; }
        }

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        private double _exchange_rate = 0.0;
        public double exchange_rate
        {
            get { return data._exchange_rate; }
            set { data._exchange_rate = value; }
        }

        public string payment_term
        {
            get { return data.payment_term; }
            set { data.payment_term = value; }
        }


    }

    //Enums go here

}