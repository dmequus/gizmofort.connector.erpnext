using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_attendance_tool
{
    public class ERPEmployee_attendance_tool : ERPNextObjectBase
    {
        public ERPEmployee_attendance_tool() : this(new ERPObject(DocType.Employee_attendance_tool)) { }
        public ERPEmployee_attendance_tool(ERPObject obj) : base(obj) { }

        public static ERPEmployee_attendance_tool Create(string date, string department, string branch, string company, string employeeshtml, string markedattendancehtml)

        {
            ERPEmployee_attendance_tool obj = new ERPEmployee_attendance_tool();
            obj.date = date;
            obj.department = department;
            obj.branch = branch;
            obj.company = company;
            obj.employees_html = employeeshtml;
            obj.marked_attendance_html = markedattendancehtml;
            return obj;
        }

        public string date
        {
            get { return data.date; }
            set
            {
                data.date = value;
                data.name = value;
            }

        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string employees_html
        {
            get { return data.employees_html; }
            set { data.employees_html = value; }
        }

        public string marked_attendance_html
        {
            get { return data.marked_attendance_html; }
            set { data.marked_attendance_html = value; }
        }


    }

    //Enums go here

}