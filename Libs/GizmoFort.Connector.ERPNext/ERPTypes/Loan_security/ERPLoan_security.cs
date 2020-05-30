using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security
{
    public class ERPLoan_security : ERPNextObjectBase
    {
        public ERPLoan_security() : this(new ERPObject(DocType.Loan_security)) { }
        public ERPLoan_security(ERPObject obj) : base(obj) { }

        public static ERPLoan_security Create(string loansecurityname, string loansecuritytype, string unitofmeasure)

        {
            ERPLoan_security obj = new ERPLoan_security();
            obj.loan_security_name = loansecurityname;
            obj.loan_security_type = loansecuritytype;
            obj.unit_of_measure = unitofmeasure;
            return obj;
        }

        public string loan_security_name
        {
            get { return data.loan_security_name; }
            set
            {
                data.loan_security_name = value;
                data.name = value;
            }

        }

        public string loan_security_type
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }

        public string unit_of_measure
        {
            get { return data.unit_of_measure; }
            set { data.unit_of_measure = value; }
        }

        public double haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        public string loan_security_code
        {
            get { return data.loan_security_code; }
            set { data.loan_security_code = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }


    }

    //Enums go here

}