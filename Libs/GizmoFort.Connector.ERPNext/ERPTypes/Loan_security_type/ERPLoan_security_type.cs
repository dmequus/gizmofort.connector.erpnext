using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_type
{
    public class ERPLoan_security_type : ERPNextObjectBase
    {
        public ERPLoan_security_type() : this(new ERPObject(DocType.Loan_security_type)) { }
        public ERPLoan_security_type(ERPObject obj) : base(obj) { }

        public static ERPLoan_security_type Create(string loansecuritytype, string unitofmeasure)

        {
            ERPLoan_security_type obj = new ERPLoan_security_type();
            obj.loan_security_type = loansecuritytype;
            obj.unit_of_measure = unitofmeasure;
            return obj;
        }

        public string loan_security_type
        {
            get { return data.loan_security_type; }
            set
            {
                data.loan_security_type = value;
                data.name = value;
            }

        }

        public string unit_of_measure
        {
            get { return data.unit_of_measure; }
            set { data.unit_of_measure = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        private double _haircut = 0.0;
        public double haircut
        {
            get { return data._haircut; }
            set { data._haircut = value; }
        }

        private double _loan_to_value_ratio = 0.0;
        public double loan_to_value_ratio
        {
            get { return data._loan_to_value_ratio; }
            set { data._loan_to_value_ratio = value; }
        }


    }

    //Enums go here

}