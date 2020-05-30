using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission
{
    public class ERPEmployee_tax_exemption_proof_submission : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_proof_submission() : this(new ERPObject(DocType.Employee_tax_exemption_proof_submission)) { }
        public ERPEmployee_tax_exemption_proof_submission(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_proof_submission Create(string employee, string submissiondate, string payrollperiod, string company)

        {
            ERPEmployee_tax_exemption_proof_submission obj = new ERPEmployee_tax_exemption_proof_submission();
            obj.employee = employee;
            obj.submission_date = submissiondate;
            obj.payroll_period = payrollperiod;
            obj.company = company;
            return obj;
        }

        public string employee
        {
            get { return data.employee; }
            set
            {
                data.employee = value;
                data.name = value;
            }

        }

        public string submission_date
        {
            get { return data.submission_date; }
            set { data.submission_date = value; }
        }

        public string payroll_period
        {
            get { return data.payroll_period; }
            set { data.payroll_period = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string tax_exemption_proofs
        {
            get { return data.tax_exemption_proofs; }
            set { data.tax_exemption_proofs = value; }
        }

        public double total_actual_amount
        {
            get { return data.total_actual_amount; }
            set { data.total_actual_amount = value; }
        }

        public double exemption_amount
        {
            get { return data.exemption_amount; }
            set { data.exemption_amount = value; }
        }

        public string attachments
        {
            get { return data.attachments; }
            set { data.attachments = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}