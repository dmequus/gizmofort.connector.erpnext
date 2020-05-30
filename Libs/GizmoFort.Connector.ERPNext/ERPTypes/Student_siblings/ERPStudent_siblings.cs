using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_siblings
{
    public class ERPStudent_siblings : ERPNextObjectBase
    {
        public ERPStudent_siblings() : this(new ERPObject(DocType.Student_siblings)) { }
        public ERPStudent_siblings(ERPObject obj) : base(obj) { }

        public static ERPStudent_siblings Create(string name1, Gender gender, string dateofbirth)

        {
            ERPStudent_siblings obj = new ERPStudent_siblings();
            obj.name1 = name1;
            obj.gender = gender;
            obj.date_of_birth = dateofbirth;
            return obj;
        }

        public string name1
        {
            get { return data.name1; }
            set
            {
                data.name1 = value;
                data.name = value;
            }

        }

        public Gender gender
        {
            get { return parseEnum<Gender>(data.gender); }
            set { data.gender = value.ToString(); }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }


    }

    //Enums go here
    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
    }


}