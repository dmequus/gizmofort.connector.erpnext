using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Budget_account
{
    public class ERPBudget_account : ERPNextObjectBase
    {
        public ERPBudget_account() : this(new ERPObject(DocType.Budget_account)) { }
        public ERPBudget_account(ERPObject obj) : base(obj) { }

        public static ERPBudget_account Create(string account, double budgetamount)

        {
            ERPBudget_account obj = new ERPBudget_account();
            obj.account = account;
            obj.budget_amount = budgetamount;
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

        private double _budget_amount = 0.0;
        public double budget_amount
        {
            get { return data._budget_amount; }
            set { data._budget_amount = value; }
        }


    }

    //Enums go here

}