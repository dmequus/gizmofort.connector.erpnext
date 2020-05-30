using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_account
{
    public class ERPExpense_claim_account : ERPNextObjectBase
    {
        public ERPExpense_claim_account() : this(new ERPObject(DocType.Expense_claim_account)) { }
        public ERPExpense_claim_account(ERPObject obj) : base(obj) { }

        public static ERPExpense_claim_account Create(string company, string defaultaccount)

        {
            ERPExpense_claim_account obj = new ERPExpense_claim_account();
            obj.company = company;
            obj.default_account = defaultaccount;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string default_account
        {
            get { return data.default_account; }
            set { data.default_account = value; }
        }


    }

    //Enums go here

}