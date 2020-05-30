using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_sibling
{
    public class ERPStudent_sibling : ERPNextObjectBase
    {
        public ERPStudent_sibling() : this(new ERPObject(DocType.Student_sibling)) { }
        public ERPStudent_sibling(ERPObject obj) : base(obj) { }

        public static ERPStudent_sibling Create(Studyinginsameinstitute studyinginsameinstitute, string fullname, Gender gender, string student, string institution, string program, string dateofbirth)

        {
            ERPStudent_sibling obj = new ERPStudent_sibling();
            obj.studying_in_same_institute = studyinginsameinstitute;
            obj.full_name = fullname;
            obj.gender = gender;
            obj.student = student;
            obj.institution = institution;
            obj.program = program;
            obj.date_of_birth = dateofbirth;
            return obj;
        }

        public Studyinginsameinstitute studying_in_same_institute
        {
            get { return parseEnum<Studyinginsameinstitute>(data.studying_in_same_institute); }
            set { data.studying_in_same_institute = value.ToString(); }
        }

        public string full_name
        {
            get { return data.full_name; }
            set { data.full_name = value; }
        }

        public Gender gender
        {
            get { return parseEnum<Gender>(data.gender); }
            set { data.gender = value.ToString(); }
        }

        public string student
        {
            get { return data.student; }
            set { data.student = value; }
        }

        public string institution
        {
            get { return data.institution; }
            set { data.institution = value; }
        }

        public string program
        {
            get { return data.program; }
            set { data.program = value; }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }


    }

    //Enums go here
    public enum Studyinginsameinstitute
    {
        [Description("NO")]
        NO,
        [Description("YES")]
        YES,
    }

    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
    }


}