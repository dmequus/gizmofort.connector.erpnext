using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_advance
{
    public class ERPExpense_claim_advance : ERPNextObjectBase
    {
        public ERPExpense_claim_advance() : this(new ERPObject(DocType.Expense_claim_advance)) { }
        public ERPExpense_claim_advance(ERPObject obj) : base(obj) { }

        public static ERPExpense_claim_advance Create(string employeeadvance, double unclaimedamount)

        {
            ERPExpense_claim_advance obj = new ERPExpense_claim_advance();
            obj.employee_advance = employeeadvance;
            obj.unclaimed_amount = unclaimedamount;
            return obj;
        }

        public string employee_advance
        {
            get { return data.employee_advance; }
            set
            {
                data.employee_advance = value;
                data.name = value;
            }

        }

        private double _unclaimed_amount = 0.0;
        public double unclaimed_amount
        {
            get { return data._unclaimed_amount; }
            set { data._unclaimed_amount = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        private double _advance_paid = 0.0;
        public double advance_paid
        {
            get { return data._advance_paid; }
            set { data._advance_paid = value; }
        }

        private double _allocated_amount = 0.0;
        public double allocated_amount
        {
            get { return data._allocated_amount; }
            set { data._allocated_amount = value; }
        }

        public string advance_account
        {
            get { return data.advance_account; }
            set { data.advance_account = value; }
        }


    }

    //Enums go here

}