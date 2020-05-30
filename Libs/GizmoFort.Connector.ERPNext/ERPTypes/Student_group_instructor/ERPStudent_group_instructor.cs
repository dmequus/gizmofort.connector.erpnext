using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_instructor
{
    public class ERPStudent_group_instructor : ERPNextObjectBase
    {
        public ERPStudent_group_instructor() : this(new ERPObject(DocType.Student_group_instructor)) { }
        public ERPStudent_group_instructor(ERPObject obj) : base(obj) { }

        public static ERPStudent_group_instructor Create(string instructor, string instructorname)

        {
            ERPStudent_group_instructor obj = new ERPStudent_group_instructor();
            obj.instructor = instructor;
            obj.instructor_name = instructorname;
            return obj;
        }

        public string instructor
        {
            get { return data.instructor; }
            set
            {
                data.instructor = value;
                data.name = value;
            }

        }

        public string instructor_name
        {
            get { return data.instructor_name; }
            set { data.instructor_name = value; }
        }


    }

    //Enums go here

}