using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_shortfall
{
    public class ERPLoan_security_shortfall : ERPNextObjectBase
    {
        public ERPLoan_security_shortfall() : this(new ERPObject(DocType.Loan_security_shortfall)) { }
        public ERPLoan_security_shortfall(ERPObject obj) : base(obj) { }

        public static ERPLoan_security_shortfall Create()

        {
            ERPLoan_security_shortfall obj = new ERPLoan_security_shortfall();
            return obj;
        }

        public string loan
        {
            get { return data.loan; }
            set
            {
                data.loan = value;
                data.name = value;
            }

        }

        public double loan_amount
        {
            get { return data.loan_amount; }
            set { data.loan_amount = value; }
        }

        public double security_value
        {
            get { return data.security_value; }
            set { data.security_value = value; }
        }

        public double shortfall_amount
        {
            get { return data.shortfall_amount; }
            set { data.shortfall_amount = value; }
        }

        public string shortfall_time
        {
            get { return data.shortfall_time; }
            set { data.shortfall_time = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string process_loan_security_shortfall
        {
            get { return data.process_loan_security_shortfall; }
            set { data.process_loan_security_shortfall = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Pending")]
        Pending,
        [Description("Completed")]
        Completed,
    }


}