using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_detail
{
    public class ERPExpense_claim_detail : ERPNextObjectBase
    {
        public ERPExpense_claim_detail() : this(new ERPObject(DocType.Expense_claim_detail)) { }
        public ERPExpense_claim_detail(ERPObject obj) : base(obj) { }

        public static ERPExpense_claim_detail Create(string expensetype, double amount)

        {
            ERPExpense_claim_detail obj = new ERPExpense_claim_detail();
            obj.expense_type = expensetype;
            obj.amount = amount;
            return obj;
        }

        public string expense_type
        {
            get { return data.expense_type; }
            set
            {
                data.expense_type = value;
                data.name = value;
            }

        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string expense_date
        {
            get { return data.expense_date; }
            set { data.expense_date = value; }
        }

        public string default_account
        {
            get { return data.default_account; }
            set { data.default_account = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double sanctioned_amount
        {
            get { return data.sanctioned_amount; }
            set { data.sanctioned_amount = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }


    }

    //Enums go here

}