using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_category
{
    public class ERPStudent_category : ERPNextObjectBase
    {
        public ERPStudent_category() : this(new ERPObject(DocType.Student_category)) { }
        public ERPStudent_category(ERPObject obj) : base(obj) { }

        public static ERPStudent_category Create(string category)

        {
            ERPStudent_category obj = new ERPStudent_category();
            obj.category = category;
            return obj;
        }

        public string category
        {
            get { return data.category; }
            set
            {
                data.category = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}