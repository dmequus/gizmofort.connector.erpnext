using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_taxes_and_charges
{
    public class ERPLanded_cost_taxes_and_charges : ERPNextObjectBase
    {
        public ERPLanded_cost_taxes_and_charges() : this(new ERPObject(DocType.Landed_cost_taxes_and_charges)) { }
        public ERPLanded_cost_taxes_and_charges(ERPObject obj) : base(obj) { }

        public static ERPLanded_cost_taxes_and_charges Create(string description, double amount, string expenseaccount)

        {
            ERPLanded_cost_taxes_and_charges obj = new ERPLanded_cost_taxes_and_charges();
            obj.description = description;
            obj.amount = amount;
            obj.expense_account = expenseaccount;
            return obj;
        }

        public string description
        {
            get { return data.description; }
            set
            {
                data.description = value;
                data.name = value;
            }

        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }


    }

    //Enums go here

}