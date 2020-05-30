using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application
{
    public class ERPEmployee_benefit_application : ERPNextObjectBase
    {
        public ERPEmployee_benefit_application() : this(new ERPObject(DocType.Employee_benefit_application)) { }
        public ERPEmployee_benefit_application(ERPObject obj) : base(obj) { }

        public static ERPEmployee_benefit_application Create(string employeename, string employee, double maxbenefits, double remainingbenefit, string date, string payrollperiod, string department, string amendedfrom, string employeebenefits, double totalamount, double proratadispensedamount)

        {
            ERPEmployee_benefit_application obj = new ERPEmployee_benefit_application();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.max_benefits = maxbenefits;
            obj.remaining_benefit = remainingbenefit;
            obj.date = date;
            obj.payroll_period = payrollperiod;
            obj.department = department;
            obj.amended_from = amendedfrom;
            obj.employee_benefits = employeebenefits;
            obj.total_amount = totalamount;
            obj.pro_rata_dispensed_amount = proratadispensedamount;
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

        private double _max_benefits = 0.0;
        public double max_benefits
        {
            get { return data._max_benefits; }
            set { data._max_benefits = value; }
        }

        private double _remaining_benefit = 0.0;
        public double remaining_benefit
        {
            get { return data._remaining_benefit; }
            set { data._remaining_benefit = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string payroll_period
        {
            get { return data.payroll_period; }
            set { data.payroll_period = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string employee_benefits
        {
            get { return data.employee_benefits; }
            set { data.employee_benefits = value; }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        private double _pro_rata_dispensed_amount = 0.0;
        public double pro_rata_dispensed_amount
        {
            get { return data._pro_rata_dispensed_amount; }
            set { data._pro_rata_dispensed_amount = value; }
        }


    }

    //Enums go here

}