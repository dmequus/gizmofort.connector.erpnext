using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_claim
{
    public class ERPEmployee_benefit_claim : ERPNextObjectBase
    {
        public ERPEmployee_benefit_claim() : this(new ERPObject(DocType.Employee_benefit_claim)) { }
        public ERPEmployee_benefit_claim(ERPObject obj) : base(obj) { }

        public static ERPEmployee_benefit_claim Create(string employeename, string employee, string department, string claimdate, string earningcomponent, double maxamounteligible, long payagainstbenefitclaim, double claimedamount, string salaryslip, string amendedfrom, string attachments)

        {
            ERPEmployee_benefit_claim obj = new ERPEmployee_benefit_claim();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.department = department;
            obj.claim_date = claimdate;
            obj.earning_component = earningcomponent;
            obj.max_amount_eligible = maxamounteligible;
            obj.pay_against_benefit_claim = payagainstbenefitclaim;
            obj.claimed_amount = claimedamount;
            obj.salary_slip = salaryslip;
            obj.amended_from = amendedfrom;
            obj.attachments = attachments;
            return obj;
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set
            {
                data.employee_name = value;
                data.name = value;
            }

        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string claim_date
        {
            get { return data.claim_date; }
            set { data.claim_date = value; }
        }

        public string earning_component
        {
            get { return data.earning_component; }
            set { data.earning_component = value; }
        }

        public double max_amount_eligible
        {
            get { return data.max_amount_eligible; }
            set { data.max_amount_eligible = value; }
        }

        public long pay_against_benefit_claim
        {
            get { return data.pay_against_benefit_claim; }
            set { data.pay_against_benefit_claim = value; }
        }

        public double claimed_amount
        {
            get { return data.claimed_amount; }
            set { data.claimed_amount = value; }
        }

        public string salary_slip
        {
            get { return data.salary_slip; }
            set { data.salary_slip = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string attachments
        {
            get { return data.attachments; }
            set { data.attachments = value; }
        }


    }

    //Enums go here

}