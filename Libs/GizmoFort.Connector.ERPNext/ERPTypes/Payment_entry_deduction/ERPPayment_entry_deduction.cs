using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_deduction
{
    public class ERPPayment_entry_deduction : ERPNextObjectBase
    {
        public ERPPayment_entry_deduction() : this(new ERPObject(DocType.Payment_entry_deduction)) { }
        public ERPPayment_entry_deduction(ERPObject obj) : base(obj) { }

        public static ERPPayment_entry_deduction Create(string account, string costcenter, double amount)

        {
            ERPPayment_entry_deduction obj = new ERPPayment_entry_deduction();
            obj.account = account;
            obj.cost_center = costcenter;
            obj.amount = amount;
            return obj;
        }

        public string account
        {
            get { return data.account; }
            set
            {
                data.account = value;
                data.name = value;
            }

        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
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