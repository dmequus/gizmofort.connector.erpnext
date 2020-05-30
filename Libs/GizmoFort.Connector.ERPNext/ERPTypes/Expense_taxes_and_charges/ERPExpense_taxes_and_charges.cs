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

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double tax_amount
        {
            get { return data.tax_amount; }
            set { data.tax_amount = value; }
        }

        public double total
        {
            get { return data.total; }
            set { data.total = value; }
        }


    }

    //Enums go here

}