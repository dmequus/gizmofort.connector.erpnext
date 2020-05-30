using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Retention_bonus
{
    public class ERPRetention_bonus : ERPNextObjectBase
    {
        public ERPRetention_bonus() : this(new ERPObject(DocType.Retention_bonus)) { }
        public ERPRetention_bonus(ERPObject obj) : base(obj) { }

        public static ERPRetention_bonus Create(string company, string employee, string bonuspaymentdate, double bonusamount, string salarycomponent)

        {
            ERPRetention_bonus obj = new ERPRetention_bonus();
            obj.company = company;
            obj.employee = employee;
            obj.bonus_payment_date = bonuspaymentdate;
            obj.bonus_amount = bonusamount;
            obj.salary_component = salarycomponent;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string bonus_payment_date
        {
            get { return data.bonus_payment_date; }
            set { data.bonus_payment_date = value; }
        }

        private double _bonus_amount = 0.0;
        public double bonus_amount
        {
            get { return data._bonus_amount; }
            set { data._bonus_amount = value; }
        }

        public string salary_component
        {
            get { return data.salary_component; }
            set { data.salary_component = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

        public string date_of_joining
        {
            get { return data.date_of_joining; }
            set { data.date_of_joining = value; }
        }

        public string additional_salary
        {
            get { return data.additional_salary; }
            set { data.additional_salary = value; }
        }


    }

    //Enums go here

}