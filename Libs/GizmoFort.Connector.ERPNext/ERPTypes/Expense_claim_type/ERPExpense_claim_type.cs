using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_type
{
    public class ERPExpense_claim_type : ERPNextObjectBase
    {
        public ERPExpense_claim_type() : this(new ERPObject(DocType.Expense_claim_type)) { }
        public ERPExpense_claim_type(ERPObject obj) : base(obj) { }

        public static ERPExpense_claim_type Create(string expensetype)

        {
            ERPExpense_claim_type obj = new ERPExpense_claim_type();
            obj.expense_type = expensetype;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public long deferred_expense_account
        {
            get { return data.deferred_expense_account; }
            set { data.deferred_expense_account = value; }
        }


    }

    //Enums go here

}