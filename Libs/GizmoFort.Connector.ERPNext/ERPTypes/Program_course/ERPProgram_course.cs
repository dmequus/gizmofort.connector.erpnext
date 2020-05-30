using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Program_course
{
    public class ERPProgram_course : ERPNextObjectBase
    {
        public ERPProgram_course() : this(new ERPObject(DocType.Program_course)) { }
        public ERPProgram_course(ERPObject obj) : base(obj) { }

        public static ERPProgram_course Create(string course)

        {
            ERPProgram_course obj = new ERPProgram_course();
            obj.course = course;
            return obj;
        }

        public string course
        {
            get { return data.course; }
            set
            {
                data.course = value;
                data.name = value;
            }

        }

        public string course_name
        {
            get { return data.course_name; }
            set { data.course_name = value; }
        }

        private int _required = 0;
        public int required
        {
            get { return data._required; }
            set { data._required = value; }
        }


    }

    //Enums go here

}