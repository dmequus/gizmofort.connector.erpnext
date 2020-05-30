using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_student_group
{
    public class ERPFee_schedule_student_group : ERPNextObjectBase
    {
        public ERPFee_schedule_student_group() : this(new ERPObject(DocType.Fee_schedule_student_group)) { }
        public ERPFee_schedule_student_group(ERPObject obj) : base(obj) { }

        public static ERPFee_schedule_student_group Create(string studentgroup, string totalstudents)

        {
            ERPFee_schedule_student_group obj = new ERPFee_schedule_student_group();
            obj.student_group = studentgroup;
            obj.total_students = totalstudents;
            return obj;
        }

        public string student_group
        {
            get { return data.student_group; }
            set
            {
                data.student_group = value;
                data.name = value;
            }

        }

        public string total_students
        {
            get { return data.total_students; }
            set { data.total_students = value; }
        }


    }

    //Enums go here

}