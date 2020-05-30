using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian_student
{
    public class ERPGuardian_student : ERPNextObjectBase
    {
        public ERPGuardian_student() : this(new ERPObject(DocType.Guardian_student)) { }
        public ERPGuardian_student(ERPObject obj) : base(obj) { }

        public static ERPGuardian_student Create(string student, string studentname)

        {
            ERPGuardian_student obj = new ERPGuardian_student();
            obj.student = student;
            obj.student_name = studentname;
            return obj;
        }

        public string student
        {
            get { return data.student; }
            set
            {
                data.student = value;
                data.name = value;
            }

        }

        public string student_name
        {
            get { return data.student_name; }
            set { data.student_name = value; }
        }


    }

    //Enums go here

}