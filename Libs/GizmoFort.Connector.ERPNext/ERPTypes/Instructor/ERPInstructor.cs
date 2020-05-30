using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Instructor
{
    public class ERPInstructor : ERPNextObjectBase
    {
        public ERPInstructor() : this(new ERPObject(DocType.Instructor)) { }
        public ERPInstructor(ERPObject obj) : base(obj) { }

        public static ERPInstructor Create(string instructorname, string employee, string namingseries, string department, string image, string instructorlog)

        {
            ERPInstructor obj = new ERPInstructor();
            obj.instructor_name = instructorname;
            obj.employee = employee;
            obj.naming_series = namingseries;
            obj.department = department;
            obj.image = image;
            obj.instructor_log = instructorlog;
            return obj;
        }

        public string instructor_name
        {
            get { return data.instructor_name; }
            set
            {
                data.instructor_name = value;
                data.name = value;
            }

        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string instructor_log
        {
            get { return data.instructor_log; }
            set { data.instructor_log = value; }
        }


    }

    //Enums go here

}