using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_student
{
    public class ERPStudent_group_student : ERPNextObjectBase
    {
        public ERPStudent_group_student() : this(new ERPObject(DocType.Student_group_student)) { }
        public ERPStudent_group_student(ERPObject obj) : base(obj) { }

        public static ERPStudent_group_student Create(string student, string studentname, int grouprollnumber, int active)

        {
            ERPStudent_group_student obj = new ERPStudent_group_student();
            obj.student = student;
            obj.student_name = studentname;
            obj.group_roll_number = grouprollnumber;
            obj.active = active;
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

        private int _group_roll_number = 0;
        public int group_roll_number
        {
            get { return data._group_roll_number; }
            set { data._group_roll_number = value; }
        }

        private int _active = 0;
        public int active
        {
            get { return data._active; }
            set { data._active = value; }
        }


    }

    //Enums go here

}