using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_guardian
{
    public class ERPStudent_guardian : ERPNextObjectBase
    {
        public ERPStudent_guardian() : this(new ERPObject(DocType.Student_guardian)) { }
        public ERPStudent_guardian(ERPObject obj) : base(obj) { }

        public static ERPStudent_guardian Create(string guardian, string guardianname, Relation relation)

        {
            ERPStudent_guardian obj = new ERPStudent_guardian();
            obj.guardian = guardian;
            obj.guardian_name = guardianname;
            obj.relation = relation;
            return obj;
        }

        public string guardian
        {
            get { return data.guardian; }
            set
            {
                data.guardian = value;
                data.name = value;
            }

        }

        public string guardian_name
        {
            get { return data.guardian_name; }
            set { data.guardian_name = value; }
        }

        public Relation relation
        {
            get { return parseEnum<Relation>(data.relation); }
            set { data.relation = value.ToString(); }
        }


    }

    //Enums go here
    public enum Relation
    {
        [Description("Mother")]
        Mother,
        [Description("Father")]
        Father,
        [Description("Others")]
        Others,
    }


}