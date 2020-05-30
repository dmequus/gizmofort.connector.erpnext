using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_order_reference
{
    public class ERPPayment_order_reference : ERPNextObjectBase
    {
        public ERPPayment_order_reference() : this(new ERPObject(DocType.Payment_order_reference)) { }
        public ERPPayment_order_reference(ERPObject obj) : base(obj) { }

        public static ERPPayment_order_reference Create(string referencedoctype, string referencename, double amount, string bankaccount)

        {
            ERPPayment_order_reference obj = new ERPPayment_order_reference();
            obj.reference_doctype = referencedoctype;
            obj.reference_name = referencename;
            obj.amount = amount;
            obj.bank_account = bankaccount;
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

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string payment_request
        {
            get { return data.payment_request; }
            set { data.payment_request = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string payment_reference
        {
            get { return data.payment_reference; }
            set { data.payment_reference = value; }
        }

        public string payment_entry
        {
            get { return data.payment_entry; }
            set { data.payment_entry = value; }
        }


    }

    //Enums go here

}