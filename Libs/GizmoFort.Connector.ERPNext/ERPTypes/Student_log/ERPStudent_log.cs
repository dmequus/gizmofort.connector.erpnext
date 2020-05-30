using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_log
{
    public class ERPStudent_log : ERPNextObjectBase
    {
        public ERPStudent_log() : this(new ERPObject(DocType.Student_log)) { }
        public ERPStudent_log(ERPObject obj) : base(obj) { }

        public static ERPStudent_log Create(string studentname, string student, Type type, string date, string academicyear, string academicterm, string program, string studentbatch, string log)

        {
            ERPStudent_log obj = new ERPStudent_log();
            obj.student_name = studentname;
            obj.student = student;
            obj.type = type;
            obj.date = date;
            obj.academic_year = academicyear;
            obj.academic_term = academicterm;
            obj.program = program;
            obj.student_batch = studentbatch;
            obj.log = log;
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

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string academic_year
        {
            get { return data.academic_year; }
            set { data.academic_year = value; }
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

        public string student_batch
        {
            get { return data.student_batch; }
            set { data.student_batch = value; }
        }

        public string log
        {
            get { return data.log; }
            set { data.log = value; }
        }


    }

    //Enums go here
    public enum Type
    {
        [Description("General")]
        General,
        [Description("Academic")]
        Academic,
        [Description("Medical")]
        Medical,
        [Description("Achievement")]
        Achievement,
    }


}