using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_language
{
    public class ERPStudent_language : ERPNextObjectBase
    {
        public ERPStudent_language() : this(new ERPObject(DocType.Student_language)) { }
        public ERPStudent_language(ERPObject obj) : base(obj) { }

        public static ERPStudent_language Create(string languagename)

        {
            ERPStudent_language obj = new ERPStudent_language();
            obj.language_name = languagename;
            return obj;
        }

        public string language_name
        {
            get { return data.language_name; }
            set
            {
                data.language_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}