using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_assignment
{
    public class ERPShift_assignment : ERPNextObjectBase
    {
        public ERPShift_assignment() : this(new ERPObject(DocType.Shift_assignment)) { }
        public ERPShift_assignment(ERPObject obj) : base(obj) { }

        public static ERPShift_assignment Create(string employeename, string employee, string shifttype, string company)

        {
            ERPShift_assignment obj = new ERPShift_assignment();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.shift_type = shifttype;
            obj.company = company;
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

        public string shift_type
        {
            get { return data.shift_type; }
            set { data.shift_type = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string shift_request
        {
            get { return data.shift_request; }
            set { data.shift_request = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}