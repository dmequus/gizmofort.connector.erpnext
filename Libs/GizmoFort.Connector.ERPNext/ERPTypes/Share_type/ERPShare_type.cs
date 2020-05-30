using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_type
{
    public class ERPShare_type : ERPNextObjectBase
    {
        public ERPShare_type() : this(new ERPObject(DocType.Share_type)) { }
        public ERPShare_type(ERPObject obj) : base(obj) { }

        public static ERPShare_type Create(string title, string description)

        {
            ERPShare_type obj = new ERPShare_type();
            obj.title = title;
            obj.description = description;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}