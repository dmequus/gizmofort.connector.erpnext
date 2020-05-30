using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_taxes_and_charges
{
    public class ERPExpense_taxes_and_charges : ERPNextObjectBase
    {
        public ERPExpense_taxes_and_charges() : this(new ERPObject(DocType.Expense_taxes_and_charges)) { }
        public ERPExpense_taxes_and_charges(ERPObject obj) : base(obj) { }

        public static ERPExpense_taxes_and_charges Create(string accounthead, string description)

        {
            ERPExpense_taxes_and_charges obj = new ERPExpense_taxes_and_charges();
            obj.account_head = accounthead;
            obj.description = description;
            return obj;
        }

        public string account_head
        {
            get { return data.account_head; }
            set
            {
                data.account_head = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _tax_amount = 0.0;
        public double tax_amount
        {
            get { return data._tax_amount; }
            set { data._tax_amount = value; }
        }

        private double _total = 0.0;
        public double total
        {
            get { return data._total; }
            set { data._total = value; }
        }


    }

    //Enums go here

}