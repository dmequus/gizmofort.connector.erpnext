using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_taxes
{
    public class ERPPos_closing_voucher_taxes : ERPNextObjectBase
    {
        public ERPPos_closing_voucher_taxes() : this(new ERPObject(DocType.Pos_closing_voucher_taxes)) { }
        public ERPPos_closing_voucher_taxes(ERPObject obj) : base(obj) { }

        public static ERPPos_closing_voucher_taxes Create(double rate, double amount)

        {
            ERPPos_closing_voucher_taxes obj = new ERPPos_closing_voucher_taxes();
            obj.rate = rate;
            obj.amount = amount;
            return obj;
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}