using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_interest_accrual
{
    public class ERPProcess_loan_interest_accrual : ERPNextObjectBase
    {
        public ERPProcess_loan_interest_accrual() : this(new ERPObject(DocType.Process_loan_interest_accrual)) { }
        public ERPProcess_loan_interest_accrual(ERPObject obj) : base(obj) { }

        public static ERPProcess_loan_interest_accrual Create(string postingdate)

        {
            ERPProcess_loan_interest_accrual obj = new ERPProcess_loan_interest_accrual();
            obj.posting_date = postingdate;
            return obj;
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set
            {
                data.posting_date = value;
                data.name = value;
            }

        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string loan_type
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        public string loan
        {
            get { return data.loan; }
            set { data.loan = value; }
        }

        public string process_type
        {
            get { return data.process_type; }
            set { data.process_type = value; }
        }


    }

    //Enums go here

}