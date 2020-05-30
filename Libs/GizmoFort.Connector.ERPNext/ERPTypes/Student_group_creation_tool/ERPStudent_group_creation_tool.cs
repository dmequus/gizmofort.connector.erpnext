using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool
{
    public class ERPStudent_group_creation_tool : ERPNextObjectBase
    {
        public ERPStudent_group_creation_tool() : this(new ERPObject(DocType.Student_group_creation_tool)) { }
        public ERPStudent_group_creation_tool(ERPObject obj) : base(obj) { }

        public static ERPStudent_group_creation_tool Create(string academicyear, string academicterm, string program, int separategroups, string courses)

        {
            ERPStudent_group_creation_tool obj = new ERPStudent_group_creation_tool();
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.program = program;
            obj.separate_groups = separategroups;
            obj.courses = courses;
            return obj;
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set
            {
                data.academic_year = value;
                data.name = value;
            }

        }

        public string academic_term
        {
            get { return data.academic_term; }
            set { data.academic_term = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        private int _separate_groups = 0;
        public int separate_groups
        {
            get { return data._separate_groups; }
            set { data._separate_groups = value; }
        }

        public string courses
        {
            get { return data.courses; }
            set { data.courses = value; }
        }


    }

    //Enums go here

}