using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_payment
{
    public class ERPSales_invoice_payment : ERPNextObjectBase
    {
        public ERPSales_invoice_payment() : this(new ERPObject(DocType.Sales_invoice_payment)) { }
        public ERPSales_invoice_payment(ERPObject obj) : base(obj) { }

        public static ERPSales_invoice_payment Create(int keyDELdefault, string modeofpayment, double amount, string account, string type, double baseamount, string clearancedate)

        {
            ERPSales_invoice_payment obj = new ERPSales_invoice_payment();
            obj.keyDELdefault = keyDELdefault;
            obj.mode_of_payment = modeofpayment;
            obj.amount = amount;
            obj.account = account;
            obj.type = type;
            obj.base_amount = baseamount;
            obj.clearance_date = clearancedate;
            return obj;
        }

        private int _keyDELdefault = 0;
        public int keyDELdefault
        {
            get { return data._keyDELdefault; }
            set { data._keyDELdefault = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        public string type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        private double _base_amount = 0.0;
        public double base_amount
        {
            get { return data._base_amount; }
            set { data._base_amount = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }


    }

    //Enums go here

}