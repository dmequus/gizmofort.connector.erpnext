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

        private double _loan_amount = 0.0;
        public double loan_amount
        {
            get { return data._loan_amount; }
            set { data._loan_amount = value; }
        }

        private double _security_value = 0.0;
        public double security_value
        {
            get { return data._security_value; }
            set { data._security_value = value; }
        }

        private double _shortfall_amount = 0.0;
        public double shortfall_amount
        {
            get { return data._shortfall_amount; }
            set { data._shortfall_amount = value; }
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