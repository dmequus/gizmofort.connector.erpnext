using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_leave_application
{
    public class ERPStudent_leave_application : ERPNextObjectBase
    {
        public ERPStudent_leave_application() : this(new ERPObject(DocType.Student_leave_application)) { }
        public ERPStudent_leave_application(ERPObject obj) : base(obj) { }

        public static ERPStudent_leave_application Create(string studentname, string student, string fromdate, string todate, long markaspresent, string reason, string amendedfrom)

        {
            ERPStudent_leave_application obj = new ERPStudent_leave_application();
            obj.student_name = studentname;
            obj.student = student;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.mark_as_present = markaspresent;
            obj.reason = reason;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string student_name
        {
            get { return data.student_name; }
            set
            {
                data.student_name = value;
                data.name = value;
            }

        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public long mark_as_present
        {
            get { return data.mark_as_present; }
            set { data.mark_as_present = value; }
        }

        public string reason
        {
            get { return data.reason; }
            set { data.reason = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}