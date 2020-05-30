using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing_payments
{
    public class ERPCashier_closing_payments : ERPNextObjectBase
    {
        public ERPCashier_closing_payments() : this(new ERPObject(DocType.Cashier_closing_payments)) { }
        public ERPCashier_closing_payments(ERPObject obj) : base(obj) { }

        public static ERPCashier_closing_payments Create(string modeofpayment, double amount)

        {
            ERPCashier_closing_payments obj = new ERPCashier_closing_payments();
            obj.mode_of_payment = modeofpayment;
            obj.amount = amount;
            return obj;
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set
            {
                data.mode_of_payment = value;
                data.name = value;
            }

        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}