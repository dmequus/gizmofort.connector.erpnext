using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_result_employee
{
    public class ERPTraining_result_employee : ERPNextObjectBase
    {
        public ERPTraining_result_employee() : this(new ERPObject(DocType.Training_result_employee)) { }
        public ERPTraining_result_employee(ERPObject obj) : base(obj) { }

        public static ERPTraining_result_employee Create(string employee, string employeename, string department, double hours, string grade, string comments)

        {
            ERPTraining_result_employee obj = new ERPTraining_result_employee();
            obj.employee = employee;
            obj.employee_name = employeename;
            obj.department = department;
            obj.hours = hours;
            obj.grade = grade;
            obj.comments = comments;
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

        public double hours
        {
            get { return data.hours; }
            set { data.hours = value; }
        }

        public string grade
        {
            get { return data.grade; }
            set { data.grade = value; }
        }

        public string comments
        {
            get { return data.comments; }
            set { data.comments = value; }
        }


    }

    //Enums go here

}