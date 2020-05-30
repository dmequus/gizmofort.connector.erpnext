using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_education
{
    public class ERPEmployee_education : ERPNextObjectBase
    {
        public ERPEmployee_education() : this(new ERPObject(DocType.Employee_education)) { }
        public ERPEmployee_education(ERPObject obj) : base(obj) { }

        public static ERPEmployee_education Create(string schooluniv, string qualification, Level level, int yearofpassing, string classper, string majoptsubj)

        {
            ERPEmployee_education obj = new ERPEmployee_education();
            obj.school_univ = schooluniv;
            obj.qualification = qualification;
            obj.level = level;
            obj.year_of_passing = yearofpassing;
            obj.class_per = classper;
            obj.maj_opt_subj = majoptsubj;
            return obj;
        }

        public string school_univ
        {
            get { return data.school_univ; }
            set
            {
                data.school_univ = value;
                data.name = value;
            }

        }

        public string qualification
        {
            get { return data.qualification; }
            set { data.qualification = value; }
        }

        public Level level
        {
            get { return parseEnum<Level>(data.level); }
            set { data.level = value.ToString(); }
        }

        private int _year_of_passing = 0;
        public int year_of_passing
        {
            get { return data._year_of_passing; }
            set { data._year_of_passing = value; }
        }

        public string class_per
        {
            get { return data.class_per; }
            set { data.class_per = value; }
        }

        public string maj_opt_subj
        {
            get { return data.maj_opt_subj; }
            set { data.maj_opt_subj = value; }
        }


    }

    //Enums go here
    public enum Level
    {
        [Description("Graduate")]
        Graduate,
        [Description("Post Graduate")]
        PostGraduate,
        [Description("Under Graduate")]
        UnderGraduate,
    }


}